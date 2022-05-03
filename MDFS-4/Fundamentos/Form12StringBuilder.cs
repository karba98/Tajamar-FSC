using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Fundamentos
{
    public partial class Form12StringBuilder : Form
    {
        public Form12StringBuilder()
        {
            InitializeComponent();
            foreach(Control control in this.Controls)
            {
                control.BackColor = Color.Yellow;
            }
            

        }

        private void Form12StringBuilder_Load(object sender, EventArgs e)
        {

        }  

        private void btnreverse_Click(object sender, EventArgs e)
        {
            Stopwatch krono = new Stopwatch();
            krono.Start();

            String texto = this.txttexto.Text;
            /*
            char[] charArray = texto.ToCharArray();
            Array.Reverse(charArray);

            this.txttexto.Text = new String(charArray);
            */
            
            for (int i = 0; i < texto.Length; i++)
            {
                char letra = texto[texto.Length - 1];
                texto = texto.Remove(texto.Length - 1);
                texto = texto.Insert(i, letra.ToString());
            }

            this.txttexto.Text = texto;
            krono.Stop();
            TimeSpan interval = krono.Elapsed;
            this.lbltiempo.Text = "Tiempo: "+interval.TotalSeconds+" segundos";
        }


        private void btnreverseB_Click(object sender, EventArgs e)
        {
            Stopwatch krono = new Stopwatch();
            krono.Start();
            StringBuilder texto = new StringBuilder();
            texto.Append(this.txttexto.Text);
            for(int i = 0; i < texto.Length; i++)
            {
                char letra = texto[texto.Length - 1];
                texto = texto.Remove(texto.Length - 1,1);
                texto = texto.Insert(i, letra);
            }
            this.txttexto.Text = texto.ToString();
            krono.Stop();
            TimeSpan interval = krono.Elapsed;
            this.lbltiempo.Text = "Tiempo: " + interval.TotalSeconds + " segundos";
        }
    }
}
