using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public class Director:Empleado
    {
       
        #region CONSTRUCTOR
         public Director()
            {
                this.SalarioMinimo = base.SalarioMinimo+200;
            }
        #endregion
        #region METODOS
        //OVERRIDE FORMA 1
        public new int GetVacaciones()
        {
            Debug.WriteLine("obteniendo vacaciones de director");
            return base.GetVacaciones()+ 25;
        }
        //public override int GetVacaciones()
        //{
        //    Debug.WriteLine("Obteniendo vacaciones de director");
        //    return base.GetVacaciones()+25;
        //}
        #endregion
    }
}
