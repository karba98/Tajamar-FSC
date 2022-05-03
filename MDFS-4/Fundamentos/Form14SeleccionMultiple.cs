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
    public partial class Form14SeleccionMultiple : Form
    {
        public Form14SeleccionMultiple()
        {
            InitializeComponent();
        }

        private void Form14SeleccionMultiple_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String elem = this.txtelemento.Text;
            this.lstelementos.Items.Add(elem);

            this.txtelemento.SelectAll();
            this.txtelemento.Focus();
        }

        private void btnseleccionados_Click(object sender, EventArgs e)
        {
            String indices = "";
            String items = "";

            try
            {
                foreach (int num in this.lstelementos.SelectedIndices)
                {
                    indices += num + ", ";
                }
                this.lblindices.Text = "Indices: " + indices;

                foreach (object obj in this.lstelementos.SelectedItems)
                {
                    items += obj + ",";
                }
                this.lblseleccionados.Text = "Seleccionados: " + items;
            }
            catch (Exception ex)
            {

            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            int seleccionados = this.lstelementos.SelectedIndices.Count-1;
            for (int i = seleccionados; i >= 0; i--)
            {
                int indexseleccionados = this.lstelementos.SelectedIndices[i];
                this.lstelementos.Items.RemoveAt(indexseleccionados);
            }
        }
    }
}
