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
    public partial class Form21TablaMultiplicar : Form
    {
        int numero;
        public Form21TablaMultiplicar()
        {
            InitializeComponent();
            
        }

        private void btntabla_Click(object sender, EventArgs e)
        {
            try
            {
                numero = int.Parse(txtnumero.Text);
                List<TextBox> lista = new List<TextBox>();
                foreach (TextBox tb in panel1.Controls)
                {
                    lista.Add(tb);
                }
                
                for (int i = 1; i <= lista.Count; i++)
                {
                    lista[i-1].Text = (this.numero * i).ToString();
                }
                
            }catch(Exception ex)
            {

            }

        }

       
    }
}
