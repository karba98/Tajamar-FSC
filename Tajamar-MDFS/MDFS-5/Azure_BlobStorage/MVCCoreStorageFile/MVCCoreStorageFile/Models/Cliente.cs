using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCoreStorageFile.Models
{
    public class Cliente:TableEntity
    {
        public Cliente() { }
        public Cliente(String Id,String empresa) 
        {
            this.Id = Id;
            this.Empresa = empresa;
            this.RowKey = Id;
            this.PartitionKey = empresa;
        }
        public String Id { get; set; }
        public String Nombre { get; set; }
        public String Empresa { get; set; }
        public String Edad { get; set; }
    }
}
