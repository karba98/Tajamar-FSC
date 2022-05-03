using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    #region ENUMERACIONES
    public enum TipoGenero
    {
        Masculino=0,Femenino=1
    }

    public enum Paises
    {
        España=0,Inglaterra=1, Francia=2,Argentina=3
    }
    #endregion
    public class Persona 
    {
        #region CONSTRUCTORES
        public Persona()
        {
            Debug.WriteLine("Constructor Persona Vacio");
        }
        public Persona(int cualquiercosa)
        {
            Debug.WriteLine("Constructor Persona con cualquier cosa");
        }

        public Persona(String Nombre,String Apellido)
        {
            this.Nombre = Nombre;
            this.Apellidos = Apellido;
            Debug.WriteLine("Constructor Persona 2 parametros");
        }
        #endregion

        #region PROPIEDADES
        //public String Nombre;
        private int _Edad;
        public int Edad
        {
            get { return this._Edad; }
            set {
                if (value < 0)
                {
                    throw new Exception("Edad negativa: "+ value.ToString());
                }
                else { this._Edad = value; }
            }
        }

        private String _Nombre;
        public String Nombre
        {
            get { return this._Nombre;  }
            set { this._Nombre = value; }
        }
        private String _Apellidos;
        public string Apellidos { get => _Apellidos; set => _Apellidos = value; }

        private TipoGenero _Genero;
        public TipoGenero Genero {
            get => _Genero; 
            set {
                _Genero = value; 
                
            } 
        }

        private String[] _Descripciones = new string[5];
        public String this[int index]
        {
            get { return this._Descripciones[index]; }
            set { this._Descripciones[index] = value; }
        }

        private Paises _Nacionalidad;
        public Paises Nacionalidad { get => _Nacionalidad; set => _Nacionalidad = value; }
        public Direccion DomicilioVacaciones { get => _DomicilioVacaciones; set => _DomicilioVacaciones = value; }

        private Direccion _DomicilioVacaciones;
        #endregion

        #region METODOS
        public void MetodoOpcional(int numero, int n2 =99,int n3 = 88)
        {

        }
        public String GetNombrecompleto()
        {
            return _Nombre + " " + _Apellidos;
        }
        public String GetNombrecompleto(Boolean ordenacion)
        {
            if (ordenacion == false)
            {
                return GetNombrecompleto();
            }
            return _Apellidos + " " + _Nombre;
        }
        #endregion
    }
}
