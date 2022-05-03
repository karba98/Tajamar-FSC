using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAdo.Models
{
    class EmpleadoPlantilla
    {
        int Hcode;
        int Salacod;
        int Empno;
        String Apellido;
        String Funcion;
        String Turno;
        int Salario;

        public EmpleadoPlantilla(int hcode, int salacod, int empno, string apellido, string funcion, string turno, int salario)
        {
            Hcode = hcode;
            Salacod = salacod;
            Empno = empno;
            Apellido = apellido;
            Funcion = funcion;
            Turno = turno;
            Salario = salario;
        }

        public int Hcode1 { get => Hcode; set => Hcode = value; }
        public int Salacod1 { get => Salacod; set => Salacod = value; }
        public int Empno1 { get => Empno; set => Empno = value; }
        public string Apellido1 { get => Apellido; set => Apellido = value; }
        public string Funcion1 { get => Funcion; set => Funcion = value; }
        public string Turno1 { get => Turno; set => Turno = value; }
        public int Salario1 { get => Salario; set => Salario = value; }
    }
}
