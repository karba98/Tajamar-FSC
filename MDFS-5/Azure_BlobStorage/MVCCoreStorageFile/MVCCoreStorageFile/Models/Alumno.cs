using Microsoft.Azure.Cosmos.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCoreStorageFile.Models
{
    public class Alumno :TableEntity
    {
        public String IdAlumno { get; set; }
        public String Nombre { get; set; }
        public String Apellidos { get; set; }
        public String Curso { get; set; }
        public String Nota { get; set; }
    }
}
