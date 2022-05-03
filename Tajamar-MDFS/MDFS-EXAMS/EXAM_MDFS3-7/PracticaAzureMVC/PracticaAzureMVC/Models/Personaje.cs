using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PracticaAzureMVC.Models
{
    public class Personaje
    {
        public int IdPersonaje { get; set; }
        public String Nombre { get; set; }
        public String Imagen { get; set; }
        public int IdSerie { get; set; }
    }
}
