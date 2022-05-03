using RetoMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetoMVC.Repositories
{
    interface IRepositoryPlantilla
    {
        List<Empleado> GetEmpleados() ;
    }
}
