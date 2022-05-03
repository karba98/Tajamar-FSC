using ServiceClientesDataContract.Models;
using ServiceClientesDataContract.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceClientesDataContract
{
    public class ServiceClientesClass : IServiceClienteContract
    {
        RepositoryClientes repo;
        public ServiceClientesClass()
        {
            this.repo = new RepositoryClientes();
        }
        public Cliente BuscarCliente(int id)
        {
            return repo.BuscarCliente(id);
        }

        public List<Cliente> GetClientes()
        {
            return repo.GetClientes();
        }
    }
}
