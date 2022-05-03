using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ServiceClientesNameSpace;
namespace ClienteWCFCore.Services
{
    public class WCFServiceClientes
    {
        ServiceClienteContractClient client;
        public WCFServiceClientes()
        {
            this.client = new ServiceClienteContractClient();
        }
        public async Task<List<Cliente>> GetClientes()
        {
            Cliente [] clientes = await client.GetClientesAsync();
            return clientes.ToList();
        }
        public async Task<Cliente> BuscarCliente(int id)
        {
            return await this.client.BuscarClienteAsync(id);
        }
    }
}
