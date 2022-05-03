using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ProyectoClases
{
    public class Direccion
    {
        #region CONSTRUCTOR
        public Direccion()
        {
            Debug.WriteLine("Entrando en Direccion constructor");
        }
        public Direccion(String calle, String ciudad):this()
        {
            this.Calle = calle;
            this.Ciudad = ciudad;
            Debug.WriteLine("Entrando en Direccion constructor con dos parametros");
        }
        public Direccion(String calle, String ciudad,int codigoPostal):this(calle, ciudad) //Llama a otros constructores
        {
            this.CodigoPostal = codigoPostal;
            Debug.WriteLine("Entrando en Direccion constructor con tres parametros");
        }

        #endregion
        #region PRPIEDADES
        public String Calle { get; set; }
        public String Ciudad { get; set; }
        public int CodigoPostal { get; set; }

        private Direccion _Domicilio;
        public Direccion Domicilio
        {
            get { return this._Domicilio; }
            set { this._Domicilio = value; }
        }
        #endregion

    }
}
