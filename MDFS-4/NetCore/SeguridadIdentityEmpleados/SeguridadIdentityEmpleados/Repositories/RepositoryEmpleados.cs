
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using SeguridadIdentityEmpleados.Data;
using SeguridadIdentityEmpleados.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SeguridadIdentityEmpleados.Repositories
{
    public class RepositoryEmpleados : IRepositoryEmpleados
    {
       EmpleadosContext context;
        public RepositoryEmpleados(EmpleadosContext context)
        {
            this.context = context;
        }

        public Empleado BuscarObjetoEmpleado(int idempleado)
        {
            return context.Empleados.Where(x=>x.IdEmpleado == idempleado).SingleOrDefault();
        }

        public Empleado GetEmpleado(string apellido, int idempleado)
        {
            return context.Empleados.Where(x => x.Apellido == apellido && x.IdEmpleado == idempleado).SingleOrDefault();
        }

        public List<Empleado> GetEmpleados()
        {
            return context.Empleados.ToList();
        }
        public List<Empleado> GetSubordinados(int idempleado)
        {
            var consulta = from datos in context.Empleados
                           where datos.Director == idempleado
                           select datos;
            return consulta.ToList();
        }
    }
}
