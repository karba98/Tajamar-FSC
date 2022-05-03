using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using Amazon.DynamoDBv2.DocumentModel;
using MVCCoreDynamoDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCoreDynamoDB.Services
{
    public class ServiceAWSDynamoDB
    {
        private DynamoDBContext context;
        public ServiceAWSDynamoDB()
        {
            AmazonDynamoDBClient client = new AmazonDynamoDBClient();
            this.context = new DynamoDBContext(client);
        }
        public async Task CreateCoche(Coche car)
        {
            await this.context.SaveAsync(car);
        }
        public async Task<List<Coche>> GetCoches()
        {
            //BUSQUEDA POR DOCUMENT
            var tabla = context.GetTargetTable<Coche>();
            var scanoptions = new ScanOperationConfig();
            var resultados = tabla.Scan(scanoptions);
            List<Document> data = await resultados.GetNextSetAsync();
            IEnumerable<Coche> cars = context.FromDocuments<Coche>(data);
            return cars.ToList();

        }
        public async Task<Coche> GetCoche(int idcoche)
        {
            //BUSQUEDA POR MODLE
            return await context.LoadAsync<Coche>(idcoche);
        }
        public async Task Delete(int idcoche)
        {
            await context.DeleteAsync<Coche>(idcoche);
        }
        public async Task<List<Coche>> SearchMarca(String marca)
        {
            var tabla = context.GetTargetTable<Coche>();
            ScanFilter scanFilter = new ScanFilter();
            scanFilter.AddCondition("marca", ScanOperator.Contains, marca);

            ScanOperationConfig config = new ScanOperationConfig()
            {
                Filter = scanFilter
            };

            var resultados = tabla.Scan(config);
            List<Document> data = await resultados.GetNextSetAsync();
            IEnumerable<Coche> cars = context.FromDocuments<Coche>(data);
            return cars.ToList();
        }
    }
}
