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
    public partial class Form23ControlesEnEjecucion : Form
    {
        public Form23ControlesEnEjecucion()
        {
            InitializeComponent();
            txtvalor.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int posx = 0;
            for (int i = 1; i <= 5; i++)
            {
                CheckBox cbx = new CheckBox();
                cbx.Text = rnd.Next(1, 50).ToString();
                cbx.AutoSize = true;
                cbx.Location = new Point(posx, 10);
                posx += 50;
                panel1.Controls.Add(cbx);
                cbx.CheckedChanged += Operacion;
            }
        }

        private void Operacion(object sender, EventArgs e)
        {
            int valor = int.Parse(txtvalor.Text);
            CheckBox cbx = (CheckBox)sender;
            int num= int.Parse(cbx.Text);
            if (cbx.Checked)
            {
                valor += num;
            }
            else
            {
                valor -= num;
            }
            txtvalor.Text = valor.ToString();
        }
    }
}
