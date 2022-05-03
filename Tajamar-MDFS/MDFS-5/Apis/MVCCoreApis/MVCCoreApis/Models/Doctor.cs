using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCoreApis.Models
{
    public class Doctor
    {
        public int hospitalCod { get; set; }
        public String apellido { get; set; }
        public int doctorNo { get; set; }
        public String especialidad { get; set; }
        public int salario { get; set; }
    }
}
