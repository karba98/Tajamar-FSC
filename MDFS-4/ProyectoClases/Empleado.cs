using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public class Empleado:Persona
    {
        #region CONSTRUCTOR
        public Empleado():base()
            {
                Debug.WriteLine("Constructor Empleado Vacio");
                this.SalarioMinimo = 900;
            }
            public Empleado(String Nombre, String Apellido):base(2)
            {
                this.Nombre = Nombre;
                this.Apellidos = Apellido;
                Debug.WriteLine("Constructor Empleado 2 parametros");
            
            }
        #endregion
        #region PROPIEDADES
        protected int SalarioMinimo { get; set; }
        #endregion
        #region METODOS
        public int GetSalarioMinimo()
        {
            return SalarioMinimo;
        }
        public virtual int GetVacaciones()
        {
            Debug.WriteLine("Obteniendo vacaciones de empleado");
            return 32;
        }
        #endregion
    }
}
