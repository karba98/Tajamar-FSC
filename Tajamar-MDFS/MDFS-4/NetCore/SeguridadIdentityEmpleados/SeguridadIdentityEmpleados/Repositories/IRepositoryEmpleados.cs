using SeguridadIdentityEmpleados.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeguridadIdentityEmpleados.Repositories
{
    public interface IRepositoryEmpleados
    {
        public List<Empleado> GetEmpleados();
        public Empleado GetEmpleado(String apellido, int idempleado);
        public Empleado BuscarObjetoEmpleado(int idempleado);
        public List<Empleado> GetSubordinados(int idempleado);
    }
}
