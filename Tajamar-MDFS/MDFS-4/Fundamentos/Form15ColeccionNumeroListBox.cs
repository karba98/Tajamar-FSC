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
    public partial class Form15ColeccionNumeroListBox : Form
    {
        public Form15ColeccionNumeroListBox()
        {
            InitializeComponent();
        }

        private void btngenerar_Click(object sender, EventArgs e)
        {
            this.lstnumeros.Items.Clear();
            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {

                int num = rand.Next(1, 99);
                this.lstnumeros.Items.Add(num);
            }
        }

        private void btnmostrardatos_Click(object sender, EventArgs e)
        {
            int suma = 0;
            foreach(object obj in this.lstnumeros.Items)
            {
                int num = (int)obj;
                suma += num;
            }
            this.txtsuma.Text = suma.ToString();
            suma = 0;
            foreach (object obj in this.lstnumeros.Items)
            {
                int num = (int)obj;
                if (num % 2 == 0)
                {
                    suma += num;
                }
                
            }
            this.txtpares.Text = suma.ToString();
            suma = 0;
            foreach (object obj in this.lstnumeros.Items)
            {
                int num = (int)obj;
                if (num % 2 != 0)
                {
                    suma += num;
                }

            }
            this.txtimpares.Text = suma.ToString();

        }

        private void btnseleccionados_Click(object sender, EventArgs e)
        {
            int suma = 0;
            foreach (object obj in this.lstnumeros.SelectedItems)
            {
                int num = (int)obj;
                suma += num;
            }
            this.txtsuma.Text = suma.ToString();
            suma = 0;
            foreach (object obj in this.lstnumeros.SelectedItems)
            {
                int num = (int)obj;
                if (num % 2 == 0)
                {
                    suma += num;
                }

            }
            this.txtpares.Text = suma.ToString();
            suma = 0;
            foreach (object obj in this.lstnumeros.SelectedItems)
            {
                int num = (int)obj;
                if (num % 2 != 0)
                {
                    suma += num;
                }

            }
            this.txtimpares.Text = suma.ToString();

        }
    }
}
