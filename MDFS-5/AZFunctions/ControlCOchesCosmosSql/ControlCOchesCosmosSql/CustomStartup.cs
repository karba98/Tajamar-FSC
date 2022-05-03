using ControlCOchesCosmosSql.Data;
using ControlCOchesCosmosSql.Repositories;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

[assembly:FunctionsStartup(typeof(ControlCOchesCosmosSql.CustomStartup))]
namespace ControlCOchesCosmosSql
{
    public class CustomStartup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {

            String cadena = Environment.GetEnvironmentVariable("cadenaAzureSql");
            builder.Services.AddTransient<RepositoryCoches>();
            builder.Services.AddDbContext<CochesContext>(options=>
                options.UseSqlServer(cadena));
        }
    }
}
