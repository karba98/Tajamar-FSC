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
    public partial class Form13ColeccionGrafica : Form
    {
        public Form13ColeccionGrafica()
        {
            InitializeComponent();
            String [] nombres = { "Ana","Luis","Pedro"};
            foreach (String s in nombres)
            {
                this.lstelementos.Items.Add(s);
            }
        }

        private void btninsertar_Click(object sender, EventArgs e)
        {
            String elemento = this.txtelemento.Text;
            if(elemento != "")
            {
                this.lstelementos.Items.Add(elemento);

                this.txtelemento.SelectAll();
                this.txtelemento.Focus();
            }
        }

        private void lstelementos_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lblposicion.Text = "Posicion: " + this.lstelementos.SelectedIndex;
            this.lblseleccionado.Text = "Seleccionado: " + this.lstelementos.SelectedItem;
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            this.lstelementos.Items.Clear();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int indice = this.lstelementos.SelectedIndex;
                this.lstelementos.Items.RemoveAt(indice);
            }
            catch(Exception ex)
            {
                MessageBox.Show("No hay elementos seleccionados");
            }
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            try
            {
                int indice = this.lstelementos.SelectedIndex;
                String elem = this.txtelemento.Text;

                this.lstelementos.Items[indice] = elem;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No hay elementos seleccionados");
            }
        }
    }
}
