using ServiceDoctoresSql.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServiceDoctoresSql
{
    //referencias
    //system runtime servialization
    //system.services.models
    [ServiceContract]
    public interface IServiceDoctores
    {
        [OperationContract]
        List<Doctor> GetDoctores();
        [OperationContract]
        Doctor BuscarDoctor(int Id);
    }
}
