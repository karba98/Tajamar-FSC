using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public class Coche
    {
        public Coche() { }
        public Coche(String marca, String modelo)
        {
            this.Marca = marca;
            this.Modelo = modelo;
        }
        public string Marca { get; set; }
        public string Modelo { get;set; }

        public String ImagePath { get; set; }
        protected byte[] Image { get; set; }
    }
}
