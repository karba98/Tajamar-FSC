using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MvcCore.Data;
using MvcCore.Helpers;
using MvcCore.Repositories;
using MvcCore.Repositories._4_USUARIOS;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using System;

namespace MvcCore
{
    public class Startup
    {
        IConfiguration configuration;
        public Startup(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            string cadenaSQL = configuration.GetConnectionString("SqlServerCasa");
            string cadenaSQLClase = configuration.GetConnectionString("SqlServerClase");
            string cadenaOracle = configuration.GetConnectionString("OracleServer");
            string cadenaMySql = configuration.GetConnectionString("MySqlCasa");

          

            //SESSIONS
            services.AddDistributedMemoryCache();
            services.AddSession(options=> {
                //COMO LOS BANCOS, A LOS 10 MIN SIN ACTIVIDAD SE CIERRAN TODOS LOS DATOS
                
                //EJEMPLOSESSIONS SENCILLO
                options.IdleTimeout = TimeSpan.FromMinutes(15);

                //options.IdleTimeout = TimeSpan.FromMinutes(10);
            });
            //FOR MAIL SERVICE
            services.AddSingleton<IConfiguration>(configuration);

            //CACHE DISTRIBUIDA
            services.AddResponseCaching();

            //CACHE PERSONALIZADA
            services.AddMemoryCache();


            services.AddTransient<PathProvider>();
            services.AddTransient<MailService>();
            services.AddTransient<FileService>();
            services.AddTransient<RepositoryJoyerias>();
            services.AddTransient<RepositoryAlumnos>();
            services.AddTransient<RepositoryUsuarios>();
            //XML
            //services.AddTransient<IRepositoryDepartamentos,RepositoryDepartamentosXML>();

            //SQLSERVER 
            //services.AddTransient<IRepositoryDepartamentos, RepositoryDepartamentosSqlServer>();
            //services.AddDbContext<HospitalContext>(options => options.UseSqlServer(cadenaSQLClase));
            //-----------------------------------------------------------
            //SQLSERVER CON REPOSITORYHOSPITAL E IREPOSITORYHOSPITAL (MODIFICAR EN CONTROLLER)
            services.AddTransient<IRepositoryHospital, RepositoryHospitalSqlServer>();
            services.AddDbContext<HospitalContext>(options => options.UseSqlServer(cadenaSQLClase));

            //MYSQL
            //services.AddTransient<IRepositoryDepartamentos, RepositoryDepartamentosMySql>();
            //services.AddDbContextPool<HospitalContext>(
            //    options => options
            //    .UseMySql(
            //        cadenaMySql, 
            //        ServerVersion.AutoDetect(cadenaMySql))
            //);

            //ORACLE
            //services.AddTransient<IRepositoryDepartamentos>(x =>
            //    new RepositoryDepartamentosOracle(cadenaOracle));

            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(
            IApplicationBuilder app,
            IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                
            }
           
            app.UseRouting();
            app.UseStaticFiles();

            //Caché DISTRIBUIDO
            app.UseResponseCaching();

            //SESSIONS
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