using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ControlCOchesCosmosSql.Models
{
    [Table("COCHESCOSMOS")]
    public class Coche
    {
        [Key]
        [Column("ID")]
        public String Id { get; set; }
        [Column("MARCA")]
        public String Marca { get; set; }
        [Column("MODELO")]
        public String Modelo { get; set; }
        [Column("ESTADO")]
        public String Estado { get; set; }
        [Column("VELOCIDAD")]
        public int Velocidad { get; set; }
        [Column("")]
        public DateTime Fecha { get; set; }
    }
}
