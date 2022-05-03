using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using ServiceWIlsonInformer.Data;
using ServiceWIlsonInformer.Helpers;
using ServiceWIlsonInformer.repositories;
using ServiceWIlsonInformer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceWIlsonInformer
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            HelperToken helper = new HelperToken(this.Configuration);
            services.AddTransient<IRepositoryPartes,RepositoryPartes>();
            services.AddTransient<IRepositoryUsuarios,RepositoryUsuarios>();
            services.AddDbContext<PartesContext>(options=>
                options.UseSqlServer(Configuration.GetConnectionString("StringSQLServerAzureTajamar")));
            services.AddSwaggerGen(
               options =>
               {
                   options.SwaggerDoc(name: "v1", new OpenApiInfo
                   {
                       Title = "Api Partes",
                       Version = "v1",
                       Description = "Api Partes Raul Castro"
                   });
               });

            services.AddTransient(x => helper);
            services.AddAuthentication(helper.GetAuthOptions())
                .AddJwtBearer(helper.GetJwtOptions());
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseSwagger();
            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint(
                    url: "/swagger/v1/swagger.json",
                    name: "Api v1"
                    );
                options.RoutePrefix = "";
            }
            );

            app.UseHttpsRedirection();

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}