using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceWIlsonInformer.Models
{
    [Table("partes")]
    public class Parte
    {
        [Key]
        [Column("N_parte")]
        public String N_parte { get; set; }
        [Column("Envios")]
        public String Envios { get; set; }
        [Column("Bult")]
        public int Bult { get; set; }
        [Column("F_Albaran")]
        public DateTime F_Albaran { get; set; }

        [Column("Orig")]
        public String Orig { get; set; }
        [Column("Dest")]
        public String Dest { get; set; }
        [Column("Propi")]
        public String Propi { get; set; }
        [Column("Serv")]
        public String Serv { get; set; }
        [Column("Abonado")]
        public String Abonado { get; set; }
        [Column("Tipo")]
        public String Tipo { get; set; }
        [Column("Estado")]
        public String Estado { get; set; }
        [Column("Gestor")]
        public String Gestor { get; set; }
        [Column("Resolucion")]
        public String Resolucion { get; set; }
        [Column("Fecha_parte")]
        public DateTime Fecha_parte { get; set; }
        [Column("F_Resolucion")]
        public DateTime Fecha_resolucion { get; set; }

        [NotMapped]
        public String Fecha_parteString { get; set; }
        [NotMapped]
        public String Fecha_resolucionString { get; set; }
        [NotMapped]
        public String F_AlbaranString { get; set; }

        [Column("Tiempo")]
        public String Tiempo { get; set; }
        [Column("Accion")]
        public String Accion { get; set; }


        public String GetAlbaran(String Envios)
        {
            return Envios.Substring(0, 12);
        }
        public String GetEnvio(String Envios)
        {
            return Envios.Remove(0, 12);
        }



    }
}
