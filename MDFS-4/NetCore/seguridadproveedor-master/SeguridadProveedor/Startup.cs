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
using SeguridadProveedor.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authentication.Cookies;


namespace MvcCore
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
            //MICROSOFT

            //AZURE-REGISTROS DE APLICACIONES
            //  AGREGAR UNA (TODAS LAS CUENTAS)
            //  COPIA ID Y CLIENT ID
            services.AddControllersWithViews(options => options.EnableEndpointRouting = false);
            String cadenasql =
                this.Configuration.GetConnectionString("cadenaaspnetdb");
            services.AddDbContext<ApplicationDbContext>
                (options => options.UseSqlServer(cadenasql));
            //DEBEMOS INDICAR QUE UTILIZAREMOS SERVICIOS
            //DE TERCEROS PARA LA AUTENTICACION
            //services.AddDefaultIdentity
            services.AddDefaultIdentity<IdentityUser>()
                .AddEntityFrameworkStores<ApplicationDbContext>();
            //INDICAMOS QUE UTILIZAREMOS LA AUTENTICACION
            //DEL PROVEEDOR MICROSOFT
            //services.AddAuthenticacion().AddProvider
            //EN EL MOMENTO DE INDICAR EL PROVEEDOR, NOS
            //PIDE LAS CLAVES


            services.AddAuthentication()
            .AddMicrosoftAccount
            (microsoftOptions =>
            {
                microsoftOptions.ClientId = "01c96793-7a7e-4008-8e28-e28b2f5aa12d";
                microsoftOptions.ClientSecret = "Ok3R2IB_TJrg5N~0n621.Im.dVr5WMm0Mo";
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
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseHttpsRedirection();

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapControllerRoute(
            //        name: "default",
            //        pattern: "{controller=Home}/{action=Index}/{id?}"
            //    );
            //});

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
