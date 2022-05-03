using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SeguridadIdentityEmpleados.Models
{
    [Table("EMP")]
    public class Empleado
    {
        [Key]
        [Column("EMP_NO")]
        public int IdEmpleado { get; set; }

        [Column("APELLIDO")]
        public String Apellido { get; set; }

        [Column("OFICIO")]
        public String Oficio { get; set; }

        [Column("SALARIO")]
        public int Salario { get; set; }
        [Column("DIR")]
        public int Director { get; set; }
    }
}