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
    public partial class Form06DiaNacimiento : Form
    {
        public Form06DiaNacimiento()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            try
            {
                int dia = int.Parse(this.txtdia.Text);
                int mes = int.Parse(this.txtmes.Text);
                int anyo = int.Parse(this.txtanyo.Text);

                if (mes == 1)
                {
                    mes = 13;
                    anyo--;
                }else if (mes == 2)
                {
                    mes = 14;
                    anyo--;
                }

                int op1 = ((mes + 1) * 3) / 5;
                int op2 = anyo / 4;
                int op3 = anyo / 100;
                int op4 = anyo / 400;
                int op5 = dia + (mes * 2) + anyo + op1 + op2 - op3 + op4 + 2;
                int op6 = op5 / 7;
                int res = op5 - (op6*7);

                String dianac = "";
                switch (res)
                {
                    case 0: dianac = "Sabado";
                        break;
                    case 1: dianac = "Domingo";
                        break;
                    case 2: dianac = "Lunes";
                        break;
                    case 3: dianac = "Martes";
                        break;
                    case 4: dianac = "Miercoles";
                        break;
                    case 5: dianac = "Jueves";
                        break;
                    case 6: dianac = "Viernes";
                        break;

                }

                this.lblres.Text = "Dia: " + dianac;
            }catch(Exception error)
            {
                MessageBox.Show("Los datos introducidos están mal", "Datos erroneos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private void txtdia_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
