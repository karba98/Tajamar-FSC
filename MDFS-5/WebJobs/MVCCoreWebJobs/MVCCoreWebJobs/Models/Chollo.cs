using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCoreWebJobs.Models
{
    [Table("DATOSWEBJOB")]
    public class Chollo
    {
        [Key]
        [Column("IDTITULAR")]
        public int IdTitular { get; set; }
        [Column("TITULO")]
        public String Titulo { get; set; }
        [Column("ENLACE")]
        public String Enlace { get; set; }
        [Column("DESCRIPCION")]
        public String Descripcion { get; set; }
        [Column("FECHA")]
        public DateTime Fecha { get; set; }
        [Column("Img")]
        public String Img { get; set; }
    }
}

