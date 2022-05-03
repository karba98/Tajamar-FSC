using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MVCEntityFramework.Data;
using MVCEntityFramework.Models;
using MVCEntityFramework.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCEntityFramework
{
    public class Startup
    {
        IConfiguration configuration { get; set; }
        public Startup(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {

            //COMPARTIT INSTANCIA 
            //services.AddTransient<Coche>();
            //INSTANICA UNICA (SE GUARDA EN LA PROPIA APP)

            //string cadena = configuration.GetConnectionString("CasaMySqlHospital");
            //services.AddSingleton<IDepartamentosContext>(new DepartamentosContextMySQL(cadena));

            string cadena = configuration.GetConnectionString("CasaSqlHospital");

            services.AddTransient<RepositoryEmpleados>();
            services.AddTransient<RepositoryPlantilla>();
            services.AddTransient<RepositoryHospital>();
            services.AddTransient<RepositoryEnfermos>();
            services.AddTransient<RepositoryDoctores>();
            services.AddTransient<RepositoryEmpleadosHospital>();

            services.AddDbContext<HospitalContext>(options=>
            options.UseSqlServer(cadena));
            services.AddDbContext<EmpleadosContext>(options =>
            options.UseSqlServer(cadena));
            services.AddDbContext<EnfermosContext>(options=>
            options.UseSqlServer(cadena));


            //DEPARTAMENTOS ES UN CASO DE INYECCION SENCILLA A PARTE
            services.AddSingleton<IDepartamentosContext>(new DepartamentosContextSQL(cadena));



            services.AddSingleton<ICoche>(coche => new CocheDeportivo("Audi","R8","audi.jpg",350));
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
                    name:"default",
                    pattern:"{controller=Home}/{action=Index}/{id?}"
                    );
            });
        }
    }
}
