using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using CsvHelper.Configuration;

namespace WilsonInformer.Models
{
    public class Parte
    {
        public String N_parte { get; set; }
        public String Envios { get; set; }
        public int Bult { get; set; }
        public DateTime F_Albaran { get; set; }

        public String Orig { get; set; }
        public String Dest { get; set; }
        public String Propi { get; set; }
        public String Serv { get; set; }
        public String Abonado { get; set; }

        public String Tipo { get; set; }

        public String Estado { get; set; }

        public String Gestor { get; set; }

        public String Resolucion { get; set; }

        public DateTime Fecha_parte { get; set; }

        public DateTime Fecha_resolucion { get; set; }


        public String Fecha_parteString { get; set; }

        public String Fecha_resolucionString { get; set; }
  
        public String F_AlbaranString { get; set; }

        public String Tiempo { get; set; }
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
    public class ParteMap : ClassMap<Parte>
    {
        public ParteMap()
        {
            Map(l => l.N_parte).Name("N. parte");
            Map(l => l.Envios).Name("Envios");
            Map(l => l.Bult).Name("Bult");
            Map(l => l.F_AlbaranString).Name("F. Albaran");
            Map(l => l.Orig).Name("Orig.");
            Map(l => l.Dest).Name("Dest.");
            Map(l => l.Propi).Name("Propi.");
            Map(l => l.Serv).Name("Serv.");
            Map(l => l.Abonado).Name("Abonado");
            Map(l => l.Tipo).Name("Tipo");
            Map(l => l.Estado).Name("Estado");
            Map(l => l.Gestor).Name("Gestor");
            Map(l => l.Resolucion).Name("Resolución");
            Map(l => l.Fecha_parteString).Name("Fecha parte");
            Map(l => l.Fecha_resolucionString).Name("F.Resolución");
            Map(l => l.Accion).Name("Acción");
        }
    }
}
