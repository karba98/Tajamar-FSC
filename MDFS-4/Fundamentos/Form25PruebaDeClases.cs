using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoClases;

namespace Fundamentos
{
    public partial class Form25PruebaDeClases : Form
    {
        public Form25PruebaDeClases()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            persona.Nombre = "Luis";
            persona.Edad = 22;
            persona.Apellidos = "Perez";

            persona.DomicilioVacaciones = new Direccion("Calle Larga","Salamanca",37188);
            //persona.DomicilioVacaciones.Calle = "Calle Larga";
            //persona.DomicilioVacaciones.Ciudad = "Salamanca";
            //persona.DomicilioVacaciones.CodigoPostal = 37188;

            persona.Genero = TipoGenero.Masculino;
            persona.Nacionalidad = Paises.España;

            persona[1] = "Ojos verdes";
            persona[0] = "rubio";

            persona.MetodoOpcional(99, n3: 8);
            //ssi ponemos MetodoOpcional(99). el valor por defecto de n2 está puesto a 99
            //n3:8 hace referencia al parametro opcional n3

            listBox1.Items.Add("Nombre Completo: " + persona.GetNombrecompleto(true));

            listBox1.Items.Add(persona.DomicilioVacaciones.Calle);

            listBox1.Items.Add("Nombre: " + persona.Nombre);
            listBox1.Items.Add("Edad: " + persona.Edad);
            listBox1.Items.Add("Genero: " + persona.Genero);
            listBox1.Items.Add("Descripcion: " + persona[0]);
            listBox1.Items.Add("Nacionalidad: " + persona.Nacionalidad);
        }

        private void btnempleado_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("");
            Empleado emple = new Empleado();
            emple.Nombre = "Antonio";
            emple.Apellidos = "Castro";
            emple.DomicilioVacaciones = new Direccion("Calle Selin","Salamanca",37188);
            emple.Nacionalidad = Paises.Argentina;
            emple.Edad = 72;

            //emple.SalarioMinimo = 5000; si es internal no lo encuentra
            Director dir = new Director();


            listBox1.Items.Add("Empleado cobra: " + emple.GetSalarioMinimo());
            listBox1.Items.Add("Director cobra: " + dir.GetSalarioMinimo());
            listBox1.Items.Add("Nombre Completo: " + emple.GetNombrecompleto(true));
            listBox1.Items.Add(emple.DomicilioVacaciones.Calle);
            listBox1.Items.Add("Nombre: " + emple.Nombre);
            listBox1.Items.Add("Edad: " + emple.Edad);
            listBox1.Items.Add("Genero: " + emple.Genero);
            listBox1.Items.Add("Descripcion: " + emple[0]);
            listBox1.Items.Add("Nacionalidad: " + emple.Nacionalidad);
            listBox1.Items.Add("Vacaciones empleado: " + emple.GetVacaciones());
            listBox1.Items.Add("Vacaciones director: " + dir.GetVacaciones());


        }
    }
}
