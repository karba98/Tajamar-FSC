using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RetoMVC.Models
{
    
    [Table("EMP")]
    public class Empleado
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("EMP_NO")]
        public int EMP_NO { get; set; }
        [Column("APELLIDO")]
        public String Apellido { get; set; }
        [Column("OFICIO")]
        public String Oficio { get; set; }
        [Column("DEPT_NO")]
        public int Departamento { get; set; }
        [Column("DIR")]
        public int DIR { get; set; }
        [Column("SALARIO")]
        public int Salario { get; set; }
        [Column("COMISION")]
        public int Comision { get; set; }

    }
    
}