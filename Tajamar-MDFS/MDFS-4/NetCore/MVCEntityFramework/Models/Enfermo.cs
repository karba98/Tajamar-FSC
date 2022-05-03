using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVCEntityFramework.Models
{
    [Table("ENFERMO")]
    public class Enfermo
    {
        [Key]
        [Column("INSCRIPCION")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public String Inscripcion { get; set; }
        [Column("APELLIDO")]
        public String Apellido  { get; set; }
        [Column("DIRECCION")]
        public String Direccion  { get; set; }
        [Column("FECHA_NAC")]
        public DateTime Fecha_Nac { get; set; }
        [Column("S")]
        public String S { get; set; }
        [Column("NSS")]
        public String NSS { get; set; }
    }
}
