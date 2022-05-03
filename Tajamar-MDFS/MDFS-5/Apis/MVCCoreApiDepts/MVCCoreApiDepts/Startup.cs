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
using MVCCoreApiDepts.Services;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace MVCCoreLimpio
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
            String cadenaDepts =
                this.Configuration.GetConnectionString("serviceDeptsAzure");
            String cadenaDoctores =
                this.Configuration.GetConnectionString("serviceDoctoresAzure");
            String cadenaOAuthEmpleados =
                this.Configuration.GetConnectionString("serviceOAuthEmpleados");

            //services.AddDbContext<Context>
            //    (options => options.UseSqlServer(cadenasql));

            services.AddTransient(x=>new ServiceDepartamentos(cadenaDepts));
            services.AddTransient(x=>new ServiceOAuthEmpleados(cadenaOAuthEmpleados));
            services.AddTransient(x=>new ServiceDoctores(cadenaDoctores));

            //SESSION AND SECURITY
            services.AddDistributedMemoryCache();
            services.AddSession(options=> {
                options.IdleTimeout = TimeSpan.FromMinutes(10);
                options.Cookie.IsEssential = true;
            });
            services.AddAuthentication(options => {
                options.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            }).AddCookie();

            
            services.AddControllersWithViews(options =>
            {
                options.EnableEndpointRouting = false;
            });
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

            app.UseAuthorization();
            app.UseAuthentication();
            app.UseSession();


            app.UseMvc(options =>
            {
                options.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}"
                );
            });
        }
    }
}
