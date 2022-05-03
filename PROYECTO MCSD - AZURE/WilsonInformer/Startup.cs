using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using WilsonInformer.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Authentication.Cookies;
using WilsonInformer.Services;

namespace WilsonInformer
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        IConfiguration conf;
        public Startup(IConfiguration configuration)
        {
            this.conf = configuration;
        }


        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            String service = conf.GetConnectionString("ApiWilson");
            services.AddAntiforgery();
            services.AddSession();

            services.AddSingleton<ITempDataProvider, CookieTempDataProvider>();

            services.AddSingleton<IConfiguration>(conf);

            services.AddHttpContextAccessor();

            services.AddTransient(x=>new ServicePartes(service));
            services.AddTransient(x=>new ServiceUsers(service));
            services.AddTransient<PathProvider>();
            //services.AddControllersWithViews();

            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultSignOutScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            }).AddCookie();

            //VIEWS, CONTROLLERS Y TEMPDATA
            services.AddControllersWithViews(options => options.EnableEndpointRouting = false)
                .AddSessionStateTempDataProvider();

            services.AddMemoryCache();
            services.AddDistributedMemoryCache();
            services.AddHttpContextAccessor();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddApplicationInsightsTelemetry(conf.GetConnectionString("ConnectionString"));

            //services.AddSession(options => {

            //    options.IdleTimeout = TimeSpan.FromMinutes(5);

            //});

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            //app.UseStaticFiles(new StaticFileOptions
            //{
            //    FileProvider = new PhysicalFileProvider(
            //        Path.Combine(Directory.GetCurrentDirectory(), "MyStaticFiles")),
            //        RequestPath = "/StaticFiles"
            //});
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseSession();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                  name: "default",
                  template: "{controller=Partes}/{action=Index}/{id?}"
                  );
            });

        }
    }
}
