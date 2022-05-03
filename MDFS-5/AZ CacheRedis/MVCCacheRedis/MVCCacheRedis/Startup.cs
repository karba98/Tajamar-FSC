using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using MVCCacheRedis.Repositories;
using MVCCacheRedis.Helpers;
using MVCCacheRedis.Services;

namespace MVCCacheRedis
{
    public class Startup
    {
        IConfiguration Configuration;
        public Startup(IConfiguration configuration)
        {
            this.Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            //String cadenasql =
            //    this.Configuration.GetConnectionString("");

            //services.AddDbContext<Context>
            //    (options => options.UseSqlServer(cadenasql));


            services.AddTransient<PathProvider>();
            services.AddTransient<RepositoryProductos>();
            services.AddTransient<ServiceCacheRedis>();

            services.AddStackExchangeRedisCache(options =>
            options.Configuration = Configuration["cacheRedis"]);

            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseStaticFiles();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}"
                );
            });
        }
    }
}
