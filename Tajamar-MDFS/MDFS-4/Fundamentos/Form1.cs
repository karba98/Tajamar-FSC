using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fundamentos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnpulsa_Click(object sender, EventArgs e)
        {
            //PULSAR EL BOTON
            this.txtbox.Text = "SOY UN TEXTO";
            //MODIFICAR OBJETO (HACERLO COMO NEW OBJETO)
            
            this.btnpulsa.Size = new Size(100, 200);//Lo normal
            this.btnpulsa.BackColor = Color.Red;
            //Al ser Color una estructura con normas, no se crea como new Object

            //ENUMERACION (CUADRADITO AMARILLO EN LA AYUSDA)
            //Serie de posibilidades para una propiedad (son tipos int, pero las muestra cmo string)
            this.txtbox.TextAlign = HorizontalAlignment.Center;

        }                                             

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
