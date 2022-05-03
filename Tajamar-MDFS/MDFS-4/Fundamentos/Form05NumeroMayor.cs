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
    public partial class Form05NumeroMayor : Form
    {
        public Form05NumeroMayor()
        {
            InitializeComponent();
        }

        private void txtn1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtn2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtn3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btneval_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(this.txtn1.Text);
            int n2 = int.Parse(this.txtn2.Text);
            int n3 = int.Parse(this.txtn3.Text);
            int mayor, menor, intermedio;

            if(n1>=n2 && n1 >= n3)
            {
                mayor = n1;
            }else if(n2>=n1 && n2 >= n3)
            {
                mayor = n1;
            }
            else
            {
                mayor = n3;
            }


            if(n1<=n2 && n1 <= n3)
            {
                menor = n1;
            }if(n2<=n1 && n2 <= n3)
            {
                menor = n1;
            }
            else
            {
                menor = n3;
            }


            int suma = n1 + n2 + n3;
            intermedio = suma - mayor - menor;

            this.lblres.Text = "Mayor: "+mayor+", \nMenor: "+menor+", \nIntermedio: "+intermedio;
        }
    }
}
