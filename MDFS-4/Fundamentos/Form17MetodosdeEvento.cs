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
    public partial class Form17MetodosdeEvento : Form
    {
        public Form17MetodosdeEvento()
        {
            InitializeComponent();
        }

        private void lblraton_MouseHover(object sender, EventArgs e)
        {

        }

        private void lblraton_MouseMove(object sender, MouseEventArgs e)
        {
            this.lblraton.Text = "X: " + e.X + " Y: " + e.Y;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
           
        }
    }
}
