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
    public partial class Form04CambiarForm : Form
    {
        public Form04CambiarForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtx_TextChanged(object sender, EventArgs e)
        {

        }

        private void txty_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtrojo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtverde_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtazul_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncolor_Click(object sender, EventArgs e)
        {
            try
            {
                int r = int.Parse(this.txtrojo.Text);
                int g = int.Parse(this.txtverde.Text);
                int b = int.Parse(this.txtazul.Text);
                this.BackColor = Color.FromArgb(r, g, b);
            }
            catch (Exception error)
            {

            }
           
        }

        private void btnposicion_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(this.txtx.Text);
                int y = int.Parse(this.txty.Text);
                //this.btnposicion.SetBounds(x, y, this.btnposicion.Width, this.btnposicion.Height);
                this.btnposicion.Location = new Point(x,y);
            }catch(Exception errro)
            {
               
            }
            
        }
    }
}
