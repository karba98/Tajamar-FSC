using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreNuevo.Models
{
    [Table("TRABAJADORES")]
    public class Trabajador
    {
        //MIO
        //[Key]
        //[Column("APELLIDO")]
        //public String Apellido { get; set; }
        //[Column("SALARIO")]
        //public int Salario{ get; set; }
        //[Column("OFICIO")]
        //public String Oficio { get; set; }

        [Key]
        [Column("IDEMPLEADO")]
        public int IdTrabajador { get; set; }
        [Column("APELLIDO")]
        public String Apellido { get; set; }
        [Column("SALARIO")]
        public int Salario { get; set; }
        [Column("TRABAJO")]
        public String Oficio { get; set; }
    }
}
