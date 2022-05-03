using Microsoft.Azure.Cosmos.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTokenTableAlumnos.Services
{
    public class ServiceTableAlumnos
    {
        private CloudTable tablaalumnos;
        public ServiceTableAlumnos(String keys)
        {
            CloudStorageAccount account = CloudStorageAccount.Parse(keys);
            CloudTableClient client = account.CreateCloudTableClient();
            this.tablaalumnos = client.GetTableReference("tablaalumnos");
        }
        public String GetKeySas(String curso)
        {
            SharedAccessTablePolicy policy = new SharedAccessTablePolicy
            {
                SharedAccessExpiryTime = DateTime.UtcNow.AddMinutes(30),
                Permissions = 
                  SharedAccessTablePermissions.Query
                | SharedAccessTablePermissions.Delete
            };
            String token = tablaalumnos.GetSharedAccessSignature(
                    policy,null
                    ,curso,null,curso,null
                );
            return token;
        }
    }
}
