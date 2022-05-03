using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceNumeroDoble
{
    public class NumneroDobleClass : INumeroDobleContract
    {
        public int GetNumeroDoble(int numero)
        {
            return numero * 2;
        }

        public string GetSaludo(string nombre)
        {
            return "Hola " + nombre;
        }

        public string Invisible()
        {
            return "Soy invisible";
        }
    }
}
