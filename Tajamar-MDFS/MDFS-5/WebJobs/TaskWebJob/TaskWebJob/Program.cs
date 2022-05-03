using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using TaskWebJob.Data;
using TaskWebJob.Repositories;

namespace TaskWebJob
{
    class Program
    {
        static void Main(string[] args)
        {
            String cnn =
                "Server=tcp:sqlserverdbtajamarrcdlt.database.windows.net" +
                ",1433;Initial Catalog=tajamar_db;Persist Security" +
                " Info=False;User ID=YourName;Password=PasswordPassword;" +
                "MultipleActiveResultSets=False;Encrypt=True;" +
                "TrustServerCertificate=False;" +
                "Connection Timeout=30;";
            var provider = new ServiceCollection()
                .AddTransient<RepositoryWebJobs>()
                .AddDbContext<WebJobContext>(options =>
                options.UseSqlServer(cnn)).BuildServiceProvider();

            RepositoryWebJobs repo = provider.GetService<RepositoryWebJobs>();
            //Console.WriteLine("Pulse una tecla para iniciar");
            //Console.ReadLine();
            repo.PopulateDataWebJob();
            //Console.WriteLine("Proceso terminado. Pulse ENTER para terminar");
            //Console.Read();
        }
    }
}
