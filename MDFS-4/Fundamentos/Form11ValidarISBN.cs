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
    public partial class Form11ValidarISBN : Form
    {
        public Form11ValidarISBN()
        {
            InitializeComponent();
        }

        private void btnvalidar_Click(object sender, EventArgs e)
        {
            String isbn = this.txtisbn.Text;
            if (isbn.Length != 10)
            {
                this.lblres.Text = "ISBN no valido";
                this.lblres.BackColor = Color.Red;
                MessageBox.Show("El ISBN debe tener 10 caracteres");
            }
            else
            {
                try
                {
                    int suma = 0;
                    for(int i =0;i<10;i++)
                    {
                        char num = isbn[i];
                        int digito = int.Parse(num.ToString());
                        int indice = i+1;
                        int res = digito * (indice);
                        suma += res;
                    }
                    int division = suma % 11;
                    if(division == 0)
                    {
                        this.lblres.Text = "ISBN Valido";
                        this.lblres.BackColor = Color.Green;
                        this.lblres.ForeColor = Color.White;
                    }
                    else
                    {
                        this.lblres.Text = "ISBN no valido";
                        this.lblres.BackColor = Color.Red;
                    }
                }catch(Exception ex)
                {
                    this.lblres.Text = "ISBN no valido";
                    this.lblres.BackColor = Color.Red;
                }
                
            }

        }
    }
}
