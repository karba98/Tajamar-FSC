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
    public partial class Form16EjercicioTienda : Form
    {
        public Form16EjercicioTienda()
        {
            InitializeComponent();
        }

        private void btninsertar_Click(object sender, EventArgs e)
        {
            String producto = this.txtproducto.Text;
            if (producto != "")
            {
                this.lsttienda.Items.Add(producto);
            }
            this.txtproducto.Focus();
            this.txtproducto.SelectAll();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            int seleccionados = this.lsttienda.SelectedIndices.Count - 1;
            for (int i = seleccionados; i >= 0; i--)
            {
                int indexseleccionados = this.lsttienda.SelectedIndices[i];
                this.lsttienda.Items.RemoveAt(indexseleccionados);
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            this.lsttienda.Items.Clear();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            
            try
            {
                int indice = this.lsttienda.SelectedIndex;
                String prod = this.txtproducto.Text;
                this.lsttienda.Items[indice] = prod;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No hay producto seleccionados");
            }
        }

        private void btntodos_Click(object sender, EventArgs e)
        {
            foreach(object obj in this.lsttienda.Items)
            {
                this.lstalmacen.Items.Add(obj);
            }
            this.lsttienda.Items.Clear();
        }

        private void btnseleccion_Click(object sender, EventArgs e)
        {
            foreach (object obj in this.lsttienda.SelectedItems)
            {
                this.lstalmacen.Items.Add(obj);
            }
            int seleccionados = this.lsttienda.SelectedIndices.Count - 1;
            for (int i = seleccionados; i >= 0; i--)
            {
                int indexseleccionados = this.lsttienda.SelectedIndices[i];
                this.lsttienda.Items.RemoveAt(indexseleccionados);
            }
        }

        private void btnsubir_Click(object sender, EventArgs e)
        {
            if (lstalmacen.SelectedItem == null || lstalmacen.SelectedIndex < 0)
                return; 

            int newIndex = lstalmacen.SelectedIndex -1;
            if (newIndex < 0 || newIndex >= lstalmacen.Items.Count)
                return; 

            object selected = lstalmacen.SelectedItem;
            lstalmacen.Items.Remove(selected);
            lstalmacen.Items.Insert(newIndex, selected);
            lstalmacen.SetSelected(newIndex, true);
        }

        private void btnbajar_Click(object sender, EventArgs e)
        {
            if (lstalmacen.SelectedItem == null || lstalmacen.SelectedIndex < 0)
                return;

            int newIndex = lstalmacen.SelectedIndex +1;
            if (newIndex < 0 || newIndex >= lstalmacen.Items.Count)
                return;

            object selected = lstalmacen.SelectedItem;
            lstalmacen.Items.Remove(selected);
            lstalmacen.Items.Insert(newIndex, selected);
            lstalmacen.SetSelected(newIndex, true);
        }

        private void btntodost_Click(object sender, EventArgs e)
        {
            foreach (object obj in this.lstalmacen.Items)
            {
                this.lsttienda.Items.Add(obj);
            }
            this.lstalmacen.Items.Clear();
        }

        private void btnseleccioandost_Click(object sender, EventArgs e)
        {
            foreach (object obj in this.lstalmacen.SelectedItems)
            {
                this.lsttienda.Items.Add(obj);
            }
            int seleccionados = this.lstalmacen.SelectedIndices.Count - 1;
            for (int i = seleccionados; i >= 0; i--)
            {
                int indexseleccionados = this.lstalmacen.SelectedIndices[i];
                this.lstalmacen.Items.RemoveAt(indexseleccionados);
            }
        }
    }
}
