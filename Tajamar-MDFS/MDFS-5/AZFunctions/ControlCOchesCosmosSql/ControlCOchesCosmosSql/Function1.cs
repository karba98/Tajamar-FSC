using System;
using System.Collections.Generic;
using ControlCOchesCosmosSql.Models;
using ControlCOchesCosmosSql.Repositories;
using Microsoft.Azure.Documents;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace ControlCOchesCosmosSql
{
    public class Function1
    {
        RepositoryCoches repo;
        public Function1(RepositoryCoches repo)
        {
            this.repo = repo;
        }
        [FunctionName("FunctionCosmos")]
        public void Run([CosmosDBTrigger(
            //databaseName: "vehiculos BBDD",
            databaseName: "coches",
            collectionName: "micoleccion",
            ConnectionStringSetting = "cadenaCosmosDb",
            CreateLeaseCollectionIfNotExists = true)
            ]IReadOnlyList<Document> input, ILogger log)
        {
            if (input != null && input.Count > 0)
            {
                var data = JsonConvert.SerializeObject(input);
                log.LogInformation("Coche cosmos: "+data);
                List<Coche> coches = 
                    JsonConvert.DeserializeObject<List<Coche>>(data);
                Coche car = coches[0];
                if (this.repo.BuscarCoche(car.Id) == null)
                {
                    this.repo.InsertCoche(car.Id, car.Marca, car.Modelo, car.Velocidad);
                }
                else
                {
                    this.repo.Modificar(car.Id, car.Marca, car.Modelo, car.Velocidad);
                }

                log.LogInformation("Datos guardados en Sql.");
                log.LogInformation("Nuevo Coche Sql: " +coches[0].Id);
            }
        }
    }
}
