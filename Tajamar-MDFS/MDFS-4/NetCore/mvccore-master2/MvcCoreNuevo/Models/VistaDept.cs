using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreNuevo.Models
{
    [Table("VISTADEPTPAGED")]
    public class VistaDept
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("POSICION")]
        public long Posicion { get; set; }
        [Key]
        [Column("DEPT_NO")]
        public int Numero { get; set; }
        [Column("DNOMBRE")]
        public String Nombre { get; set; }
        [Column("LOC")]
        public String Imagen { get; set; }
    }
}
