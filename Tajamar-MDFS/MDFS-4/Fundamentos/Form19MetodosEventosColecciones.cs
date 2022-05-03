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
    
    public partial class Form19MetodosEventosColecciones : Form
    {
        int contador;

        List<Button> lista;

        public Form19MetodosEventosColecciones()
        {
            this.contador = 0;
            
            InitializeComponent();
            this.lista = new List<Button>();
            /*this.lista.Add(button1);
            this.lista.Add(button2);
            this.lista.Add(button3);*/
            foreach(Control c in this.Controls)
            {
                if (c is Button)
                {
                    lista.Add((Button)c);
                }
            }
            
        }

        private void cbxasociar_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cbxasociar.Checked==true)
            {
                this.contador += this.lista.Count;
                this.AddEvents(true);
               
            }
            else
            {
                this.contador -= this.lista.Count;
                this.AddEvents(false);

            }
        }

        void AddEvents(bool activo)
        {
            foreach (Button boton in this.lista)
            {
                if (activo)
                {
                    boton.Click += MostrarMensaje;
                }
                else
                {
                    boton.Click -= MostrarMensaje;
                    boton.BackColor = Color.Transparent;
                }
            }
            lbleventos.Text = "Eventos: " + contador;
        }

        private void MostrarMensaje(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            boton.BackColor = Color.Yellow;
        }

        private void Form19MetodosEventosColecciones_Load(object sender, EventArgs e)
        {

        }
    }
}
