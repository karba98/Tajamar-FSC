using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public class Mes
    {
        #region CONSTRUCTOR
        public Mes() { }
        public Mes (String Nombre,int Maxima, int Minima)
        {
            this.Maxima = Maxima;
            this.Minima = Minima;
            this.Nombre = Nombre;
        }
        #endregion
        #region PROPIEDADES
        public String Nombre { get; set; }
        public int Maxima { get; set; }
        public int Minima { get; set; }
        private double _Media;
        public double Media 
        {
            get { return ((this.Maxima+this.Minima)/2); }
            set { this._Media = value; }
        }
        #endregion

    }
}
