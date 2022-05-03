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
    public partial class FormSumar : Form
    {
        public FormSumar()
        {
            InitializeComponent();
        }

        private void txtn1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtn2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsumar_Click(object sender, EventArgs e)
        {
            int n1, n2;
            n1 = int.Parse(this.txtn1.Text);
            n2 = int.Parse(this.txtn2.Text);

            int suma = n1 + n2;

            this.lblresultado.Text = suma.ToString();
        }
    }
}
