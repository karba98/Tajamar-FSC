using RetoMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetoMVC.Data
{
    public interface IContextPlantilla
    {
        DbSet<Empleado> Empleados { get; set; }
    }
}
