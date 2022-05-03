using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAdo.Models
{
    public class Empleado
    {
        int EmpNo;
        String Apellido;
        String Oficio;
        int Salario;

        public Empleado(int empNo, string apellido, string oficio, int salario)
        {
            EmpNo = empNo;
            Apellido = apellido;
            Oficio = oficio;
            Salario = salario;
        }

        public int EmpNo1 { get => EmpNo; set => EmpNo = value; }
        public string Apellido1 { get => Apellido; set => Apellido = value; }
        public string Oficio1 { get => Oficio; set => Oficio = value; }
        public int Salario1 { get => Salario; set => Salario = value; }
    }
}
