using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAdo.Models
{
    class Hospital
    {
        int cod;
        String Nombre;
        String Direccion;
        String telefono;
        int Camas;

        public Hospital(int cod, string nombre, string direccion, string telefono, int camas)
        {
            this.cod = cod;
            Nombre = nombre;
            Direccion = direccion;
            this.telefono = telefono;
            Camas = camas;
        }

        public int Cod { get => cod; set => cod = value; }
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Direccion1 { get => Direccion; set => Direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public int Camas1 { get => Camas; set => Camas = value; }
    }
}
