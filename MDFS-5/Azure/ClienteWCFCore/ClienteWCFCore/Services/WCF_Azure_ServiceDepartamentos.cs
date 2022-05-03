using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ServiceDepartamentos;
namespace ClienteWCFCore.Services
{
    public class WCF_Azure_ServiceDepartamentos
    {
        ServiceDepartamentosClient client;
        public WCF_Azure_ServiceDepartamentos()
        {
            client = new ServiceDepartamentosClient();
        }
        public async Task<List<Departamento>> GetDepartamentos()
        {
            Departamento [] departamentos =  await client.GetDepartamentosAsync();
            return departamentos.ToList();
        }
        public async Task<Departamento> BuscarDept(int id)
        {
            Departamento d = await client.BuscarDepartamentoAsync(id);
            return d;
        }
    }
}
