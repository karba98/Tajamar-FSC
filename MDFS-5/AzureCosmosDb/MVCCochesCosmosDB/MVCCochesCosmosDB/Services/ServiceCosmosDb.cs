using Microsoft.Azure.Documents;
using Microsoft.Azure.Documents.Client;
using Microsoft.Extensions.Configuration;
using MVCCochesCosmosDB.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCochesCosmosDB.Services
{
    public class ServiceCosmosDb
    {
        DocumentClient client;
        String database;
        String collection;
        public ServiceCosmosDb(IConfiguration config)
        {
            String endpoint = config["CosmosDb:Endpoint"];
            String key = config["CosmosDb:PrimaryKey"];
            this.database = "vehiculos BBDD";
            this.collection = "VehiculosCollection";
            this.client =
                new DocumentClient(new Uri(endpoint), key);

        }
        public async Task CrearBBDDVehiculosAsync()
        {
            Database db = new Database() { Id = this.database };
            await this.client.CreateDatabaseAsync(db);
        }
        public async Task CrearColeccionVehiculosAsync()
        {
            DocumentCollection collection = new DocumentCollection()
            {
                Id = this.collection
            };
            await this.client.CreateDocumentCollectionAsync(
                UriFactory.CreateDatabaseUri(this.database),collection);
        }
        public async Task InsertarVehiculoAsync(Vehiculo vehiculo)
        {
            Uri uri = UriFactory.CreateDocumentCollectionUri(this.database, collection);
            await this.client.CreateDocumentAsync(uri, vehiculo);
        }
        public List<Vehiculo> GetVehiculos()
        {
            FeedOptions options = new FeedOptions() {
                MaxItemCount = -1
            };
            //siempre c por defecto
            String sql = "SELECT * FROM c";
            Uri uri = UriFactory.CreateDocumentCollectionUri(this.database, this.collection);
            IQueryable<Vehiculo> consulta = client.CreateDocumentQuery<Vehiculo>(uri, sql, options);
            return consulta.ToList();
        }
        public async Task<Vehiculo> FindVehiculo(String id)
        {
            Uri uri = UriFactory.CreateDocumentUri(this.database, this.collection, id);
            Document doc = await client.ReadDocumentAsync(uri);
            MemoryStream ms = new MemoryStream();
            using (var stream = new StreamReader(ms))
            {
                doc.SaveTo(ms);
                ms.Position = 0;
                Vehiculo car = JsonConvert.DeserializeObject<Vehiculo>(await stream.ReadToEndAsync());
                return car;
            }
        }
        public async Task ModificarVehiculo(Vehiculo car)
        {
            Uri uri = UriFactory.CreateDocumentUri(this.database, this.collection, car.Id);
            await this.client.ReplaceDocumentAsync(uri, car);
        }
        public async Task EliminarVehiculo(String id)
        {
            Uri uri = UriFactory.CreateDocumentUri(this.database, this.collection, id);
            await this.client.DeleteDocumentAsync(uri);
        }
        public List<Vehiculo> BuscarPorMarca(String Marca)
        {
            FeedOptions options = new FeedOptions()
            {
                MaxItemCount = -1
            };
            //siempre c por defecto
            String sql = "SELECT * FROM c";
            Uri uri = UriFactory.CreateDocumentCollectionUri(this.database, this.collection);
            IQueryable<Vehiculo> consulta = client.CreateDocumentQuery<Vehiculo>(uri, sql, options)
                .Where(x=>x.Marca.ToLower() == Marca.ToLower());
            return consulta.ToList();
        }
        public List<Vehiculo> CrearCoches()
        {
            List<Vehiculo> coches = new List<Vehiculo>()
            {
                new Vehiculo(){Id="1",Marca="Audi",Modelo="R8",
                Motor = new Motor(){ Caballos=100,Potencia=5000,Tipo="Bestia"} },
                new Vehiculo(){Id="2",Marca="Audi",Modelo="A9",
                Motor = new Motor(){ Caballos=150,Potencia=9000,Tipo="Bestia Parda"} }
                ,new Vehiculo(){Id="3",Marca="Seat",Modelo="Ibiza",
                Motor = new Motor(){ Caballos=1,Potencia=1,Tipo="Chafado"} },
                new Vehiculo(){Id="4",Marca="BW",Modelo="SerieS",
                Motor = new Motor(){ Caballos=100,Potencia=7000,Tipo="Ta bien"} },
                new Vehiculo(){Id="5",Marca="Citroen",Modelo="C4 Picasso",
                Motor = new Motor(){ Caballos=60,Potencia=500,Tipo="Mola Mogollon"} },

            };
            return coches;
        }
    }
}
