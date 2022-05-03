using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;
using MVCCoreStorageFile.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCoreStorageFile.Services
{
    public class ServiceStorageTable
    {
        private CloudTable table;
        public ServiceStorageTable(String keys)
        {
            CloudStorageAccount account = CloudStorageAccount.Parse(keys);
            CloudTableClient client = account.CreateCloudTableClient();
            this.table = client.GetTableReference("clientes");
            this.table.CreateIfNotExistsAsync();
        }
        public async Task CreateClientAsync(String Id,String Nombre,String edad,String Empresa)
        {
            Cliente client = new Cliente(Id, Empresa);
            client.Nombre = Nombre;
            client.Edad = edad;
            TableOperation insert = TableOperation.Insert(client);
            await this.table.ExecuteAsync(insert);
        }
        public async Task<List<Cliente>> GetClientesAsync()
        {
            TableQuery<Cliente> query = new TableQuery<Cliente>();
            TableQuerySegment<Cliente> segment = await table.ExecuteQuerySegmentedAsync(query, null);
            return segment.Results;
        }
        public async Task<List<String>> GetEmpresasAsync()
        {
            TableQuery<Cliente> query = new TableQuery<Cliente>();
            TableQuerySegment<Cliente> segment = await table.ExecuteQuerySegmentedAsync(query, null);
            return segment.Select(x=>x.Empresa).Distinct().ToList();
        }
        public async Task<List<Cliente>>GetClientesEmpresa(String empresa)
        {
            TableQuery<Cliente> query = new TableQuery<Cliente>();
            TableQuerySegment<Cliente> segment = await table.ExecuteQuerySegmentedAsync(query, null);
            return segment.Where(x => x.Empresa == empresa).ToList();
            
        }
    }
}
