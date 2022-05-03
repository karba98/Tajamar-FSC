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
    public partial class Form09validarEmail : Form
    {
        public Form09validarEmail()
        {
            InitializeComponent();
        }

        private void btnvalidar_Click(object sender, EventArgs e)
        {
            String email = this.txtemail.Text;
            if (!email.Contains("@"))
            {
                this.lblres.Text = "No existe @";
            }else if(email.StartsWith("@") || email.EndsWith("@"))
            {
                this.lblres.Text = "No puede comenzar o terminar por @";
            }else if (email.IndexOf("@")!=email.LastIndexOf("@"))
            {
                this.lblres.Text = "Hay mas de 1 @";
            }else if (!email.Contains("."))
            {
                this.lblres.Text = "No hay punto";
            }else if ((email.IndexOf(".") == email.IndexOf("@") - 1)|| (email.IndexOf(".") == email.IndexOf("@") +1))
            {
                this.lblres.Text = "Punto despues del @";
            }else 
            {
                int ultimaposicion = email.LastIndexOf(".");
                String dominio = email.Substring(ultimaposicion +1);
                if(dominio.Length>=2 && dominio.Length <= 4)
                {
                    this.lblres.Text = "Mail correcto, dominio: ."+dominio;
                }
                else
                {
                    this.lblres.Text = "Dominio de 2 a 4 letras";
                }

            }
        }
    }
}
