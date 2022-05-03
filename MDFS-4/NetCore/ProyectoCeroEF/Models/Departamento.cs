using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoCeroEF.Models
{
    [Table("DEPT")]
    public class Departamento
    {
        [Key]
        [Column("DEPT_NO")]
        public int Dept_NO { get; set; }
        [Column("DNOMBRE")]
        public String DNombre { get; set; }
        [Column("LOC")]
        public String Loc { get; set; }
    }
}
