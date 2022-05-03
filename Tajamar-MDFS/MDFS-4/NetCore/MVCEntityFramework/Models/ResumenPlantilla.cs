using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCEntityFramework.Models
{
    public class ResumenPlantilla
    {
        public List<Plantilla> Empleados { get; set; }
        public int Maximo { get; set; }
        public int Minimo { get; set; }
        public int NumEmpleados { get; set; }
    }
}
