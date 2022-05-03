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
    public partial class Form16Referencia : Form
    {
        public Form16Referencia()
        {
            InitializeComponent();
        }

        //Por valor
        void DobleNumero(int numero)
        {
            numero = numero * 2;
        }

        //Por referencia
        void CambiarColor(Button boton)
        {
            boton.BackColor = Color.Red;
        }

        void DobleReferencia(ref int numero)
        {
            numero = numero * 2;
        }

        int DobleReferenciaReturn(int numero)
        {
            numero = numero * 2;
            return numero;
        }

        private void btnllamada_Click(object sender, EventArgs e)
        {
            try
            {
                int numero = int.Parse(txtnumero.Text);
                this.DobleNumero(numero);
                

                this.CambiarColor(this.btnllamada);

                //No se usa
                //this.DobleReferencia(ref numero);

                numero = this.DobleReferenciaReturn(numero);
                this.lblres.Text = "Resultado: " + numero;
            }
            catch(Exception ex) { }

        }
        
    }
}
