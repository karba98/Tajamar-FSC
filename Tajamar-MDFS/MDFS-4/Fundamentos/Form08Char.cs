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
    public partial class Form08Char : Form
    {
        public Form08Char()
        {
            InitializeComponent();
        }

        private void btnrecorrer_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 255; i++)
            {
                char caracter = (char)i;
                if (char.IsLetter(caracter))
                {
                    this.txtletras.Text += caracter;
                }else if (char.IsNumber(caracter))
                {
                    this.txtnumeros.Text += caracter;
                }
                else if (char.IsSymbol(caracter))
                {
                    this.txtsimbolos.Text += caracter;
                }
                else if (char.IsPunctuation(caracter))
                {
                    this.txtpuntuacion.Text += caracter;
                }
            }
        }
    }
}
