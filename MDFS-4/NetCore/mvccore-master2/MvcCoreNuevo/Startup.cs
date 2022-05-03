using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MvcCoreNuevo.Data;
using MvcCoreNuevo.Repositories;

namespace MvcCoreNuevo
{
    public class Startup
    {
        IConfiguration conf;
        public Startup(IConfiguration conf)
        {
            this.conf = conf;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            string cadenaSqlClase = conf.GetConnectionString("SqlSerevrClase");
            string cadenaSqlCasa = conf.GetConnectionString("SqlSerevrCasa");
            services.AddControllersWithViews();
            services.AddSession(options=>options.IdleTimeout = TimeSpan.FromMinutes(2));
            services.AddDbContext<HospitalContext>(options =>
                options.UseSqlServer(cadenaSqlCasa));

            services.AddTransient<IRepositoryHospital,RepositoryHospital>();
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
            app.UseSession();
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
