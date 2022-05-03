using RetoMVC.Data;
using System;

using System.Linq;
using System.Web;

using System.Data.Entity;
using System.Collections.Generic;
using RetoMVC.Models;

namespace RetoMVC.Repositories
{
    public class RepositoryPlantilla:IRepositoryPlantilla
    {
        private IContextPlantilla context;

        public RepositoryPlantilla(IContextPlantilla dbContext)
        {
            context = dbContext;
        }

        public List<Empleado> GetEmpleados()
        {
            return this.context.Empleados.ToList();
        }
    }
}