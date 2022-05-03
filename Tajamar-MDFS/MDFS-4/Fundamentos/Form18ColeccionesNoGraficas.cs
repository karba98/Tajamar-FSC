using System;
using System.Collections;
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
    public partial class Form18ColeccionesNoGraficas : Form
    {
        public Form18ColeccionesNoGraficas()
        {
            InitializeComponent();





            /*ArrayList coleccion = new ArrayList();
            coleccion.Add(this.button1);
            coleccion.Add(this.button2);
            coleccion.Add(this.button3);
            coleccion.Add(this.textBox1);

            ((Button)coleccion[0]).BackColor = Color.Yellow;

            foreach (Control boton in coleccion)
            {
                boton.BackColor = Color.Yellow;
            }
            */
            List<Control> controles = new List<Control>();
            controles.Add(this.button1);
            controles.Add(this.button2);
            controles.Add(this.button3);
            controles.Add(this.textBox1);

            controles[0].BackColor = Color.Yellow;

            foreach(Control ctrl in controles)
            {
                if (ctrl is Button)
                {
                    ctrl.BackColor = Color.Yellow;
                } else if(ctrl is TextBox)
                {
                    ((TextBox)ctrl).Paste();
                }
            }
        }

        private void Form18ColeccionesNoGraficas_Load(object sender, EventArgs e)
        {

        }
    }
}
