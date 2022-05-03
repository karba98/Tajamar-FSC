using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public class Producto
    {
        private Producto() { }
        public Producto(String nombre, int Precio)
        {
            this.Nombre = nombre;
            this.Precio = Precio;
        }

        public String Nombre {get;set;}
        private int _Precio;
        public int Precio {
            get { return _Precio; }
            set { 
                if (value < 0)
                {
                    throw new Exception("Precio no puede ser menor que 0");
                }
                else
                {
                    this._Precio = value;
                    this._Precio = value;
                }
            }
        }
    }
}
