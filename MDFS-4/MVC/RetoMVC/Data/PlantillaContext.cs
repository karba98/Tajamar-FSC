
using RetoMVC.Models;

using System.Collections.Generic;
using System.Data.Entity;

namespace RetoMVC.Data
{
    public class PlantillaContext :DbContext, IContextPlantilla
    {
        public PlantillaContext():base("name=connectionstringSqlServerCasa")
        {}
        
        public DbSet<Empleado> Empleados { get; set ; }
    }
}