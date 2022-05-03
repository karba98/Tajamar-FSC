using PracticaAdoRCastro.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticaAdoRCastro.Models
{
    public class Libro
    {
        public int IdLibro { get; set; }
        public String Titulo { get; set; }
        public String Autor { get; set; }
        public String Sinopsis { get; set; }
        public String Imagen { get; set; }
        public int IdGenero { get; set; }

        public String GetGenero()
        {
            LibreriaContext context = new LibreriaContext();
            return context.GetGenero(this.IdGenero);
        }
    }
}
