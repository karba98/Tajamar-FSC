using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TaskWebJob
{
    [Table("DATOSWEBJOB")]
    public class WebJob
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
        [Column("IMG")]
        public String Img { get; set; }
    }
}
