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
    public partial class Form07DateTime : Form
    {
        public Form07DateTime()
        {
            InitializeComponent();
            DateTime fechaactual = DateTime.Now;
            this.txtfechaactual.Text = fechaactual.ToString();
        }

        private void Form07DateTime_Load(object sender, EventArgs e)
        {
            
        }

        private void txtfechaactual_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbxcambiarformato_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime fecha = DateTime.Parse(this.txtfechaactual.Text);
                if (this.cbxcambiarformato.Checked)
                {
                    this.txtfechaactual.Text = fecha.ToLongDateString();
                }
                else
                {
                    this.txtfechaactual.Text = fecha.ToShortDateString();
                }
            }
            catch(Exception error)
            {
                DateTime fechaactual = DateTime.Now;
                this.txtfechaactual.Text = fechaactual.ToString();
            }
            
        }

        private void btnmostrarr_Click(object sender, EventArgs e)
        {
            try
            {
                int incremento = int.Parse(this.txtincremento.Text);
                DateTime fecha = DateTime.Parse(this.txtfechaactual.Text);

                if (cbxdia.Checked)
                {
                    fecha = fecha.AddDays(incremento);
                }if (cbxmes.Checked)
                {
                    fecha = fecha.AddMonths(incremento);
                }if (cbxanyo.Checked)
                {
                    fecha = fecha.AddYears(incremento);
                }
                
                this.txtnuevafecha.Text = fecha.ToString();
                if (DateTime.IsLeapYear(fecha.Year))
                {
                    this.lbldatos.Text = "Es bisiesto";
                }
                else
                {
                    this.lbldatos.Text = "No es bisiesto";
                }
            }
            catch(Exception error)
            {

            }
            
        }
    }
}
