using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ServiceDoctores;
namespace ClienteWCFCore
{
    public class WCF_Azure_ServiceDoctores
    {
        ServiceDoctoresClient client;
        public WCF_Azure_ServiceDoctores()
        {
            this.client = new ServiceDoctoresClient();
        }
        public async Task<List<Doctor>> GetDoctores()
        {
            Doctor[] doctors = await client.GetDoctoresAsync();
            return doctors.ToList();
        }

    }
}
