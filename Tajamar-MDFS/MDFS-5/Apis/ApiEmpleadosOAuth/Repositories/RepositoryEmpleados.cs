using ApiEmpleadosOAuth.Data;
using ApiEmpleadosOAuth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiEmpleadosOAuth.Repositories
{
    public class RepositoryEmpleados
    {
        public EmpleadosContext context;
        public RepositoryEmpleados(EmpleadosContext context)
        {
            this.context = context;
        }
        public List<Empleado> GetEmpleados()
        {
            return context.Empleados.ToList();
        }
        public Empleado GetEmpleado(int id)
        {
            return context.Empleados.SingleOrDefault(x => x.IdEmpleado == id);
        }
        public Empleado ExisteEmpleado(String apellido, int idEmpleado)
        {
            return context.Empleados.SingleOrDefault(x => x.IdEmpleado == idEmpleado && x.Apellido == apellido);
        }
        public List<Empleado> GetSubordinados(int idEmpleado)
        {
            return context.Empleados.Where(x => x.Dir == idEmpleado).ToList();
        }
    }
}
