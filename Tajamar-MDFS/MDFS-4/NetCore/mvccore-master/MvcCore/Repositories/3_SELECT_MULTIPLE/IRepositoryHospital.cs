using MvcCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCore.Repositories
{
    public interface IRepositoryHospital : IRepositoryDepartamentos
    {
        public List<Empleado> GetEmpleados();
        public List<Empleado> GetEmpleadosSession(List<int> idsempleados);

        public List<Empleado> GetEmpleadosDept(List<int> id);

    }
}
