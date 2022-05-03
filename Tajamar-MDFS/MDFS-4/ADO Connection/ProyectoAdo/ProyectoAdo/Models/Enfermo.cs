using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAdo.Models
{
    public class Enfermo
    {
        public Enfermo(int inscripcion, string apellido, string direccion, string fechaNacimiento, string sex, int nss)
        {
            Inscripcion = inscripcion;
            Apellido = apellido;
            Direccion = direccion;
            FechaNacimiento = fechaNacimiento;
            Sex = sex;
            Nss = nss;
        }

        public int Inscripcion { get; set; }
        public String Apellido { get; set; }
        public String Direccion { get; set; }
        public String FechaNacimiento { get; set; }
        public String Sex { get; set; }
        public int Nss { get; set; }

    }
}
