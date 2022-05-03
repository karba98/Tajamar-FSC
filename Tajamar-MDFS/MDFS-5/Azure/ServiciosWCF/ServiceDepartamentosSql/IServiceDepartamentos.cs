﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServiceDepartamentosSql
{
    [ServiceContract]
    public interface IServiceDepartamentos
    {
        [OperationContract]
        List<Departamento> GetDepartamentos();
        [OperationContract]
        Departamento BuscarDepartamento(int id);
    }
}
