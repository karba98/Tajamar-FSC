using ServiceClientesDataContract.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServiceClientesDataContract
{
    [ServiceContract]
    public interface IServiceClienteContract
    {
        [OperationContract]
        List<Cliente> GetClientes();
        [OperationContract]
        Cliente BuscarCliente(int id);
    }
}
