using RetoMVCAutofac.Data;
using RetoMVCAutofac.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RetoMVCAutofac.Repositories
{
    public class RepositoryEmpleados
    {
        private EmpleadosContext context;
        public RepositoryEmpleados(EmpleadosContext context)
        {
            this.context = context;
        }

        public List<Empleado> GetEmpleados()
        {
            var consulta = from datos in context.Empleados
                           select datos;
            return consulta.ToList();
        }
    }

}