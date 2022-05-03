using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVCEntityFramework.Models
{
    [Table("TOTALEMPLEADOS")]
    public class EmpleadoGenerico
    {
        [Key]
        [Column("IdEmpleado")]
        public int IdEmpleado { get; set; }
        [Column("Apellido")]
        public String Apellido { get; set; }
        [Column("Funcion")]
        public String Funcion { get; set; }
        [Column("Salario")]
        public int Salario { get; set; }
        [Column("NOMBRE")]
        public String NombreDestino { get; set; }
        [Column("Code")]
        public int Code { get; set; }
    }
}
