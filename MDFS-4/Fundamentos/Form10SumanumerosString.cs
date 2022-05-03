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
    public partial class Form10SumanumerosString : Form
    {
        public Form10SumanumerosString()
        {
            InitializeComponent();
        }

        private void btnsumar_Click(object sender, EventArgs e)
        {
            String numeros = this.txtnumeros.Text;
            int suma = 0;
            foreach(char n in numeros)
            {
                int num = int.Parse(n.ToString());
                suma += num;
            }
            this.lblres.Text ="Suma: "+ suma;
        }
    }
}
