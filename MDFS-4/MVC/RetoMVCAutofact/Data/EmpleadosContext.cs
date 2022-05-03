using RetoMVCAutofac.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RetoMVCAutofac.Data
{
    public class EmpleadosContext : DbContext
    {
        public EmpleadosContext() : base("name=connectionstringSqlServerCasa")
        { }

        public DbSet<Empleado> Empleados { get; set; }
    }
}