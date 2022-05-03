using ProyectoClases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Fundamentos
{
    public partial class Form28FicheroProductos : Form
    {
        List<Producto> productosBack;
        public Form28FicheroProductos()
        {
            InitializeComponent();
            productosBack = new List<Producto>();
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            try
            {
                String nombre = txtnombre.Text;
                int precio = int.Parse(txtprecio.Text);
                Producto producto = new Producto(nombre, precio);
                productosBack.Add(producto);
                lstproductos.Items.Add(producto.Nombre);
                txtnombre.Text = "";
                txtprecio.Text = "";
                txtnombre.Focus();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Introduzca datos de producto a insertar");
            }
            
        }

        private void lstproductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selected = lstproductos.SelectedIndex + 1;
            lblprod.Text = "Producto: " + selected.ToString() + " de " + lstproductos.Items.Count;
            txtnombre.Text=productosBack[selected-1].Nombre;
            txtprecio.Text = productosBack[selected-1].Precio.ToString();
        }

        private async void btnsave_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            DialogResult respuesta = save.ShowDialog();
            if (respuesta == DialogResult.OK)
            {
                String pathFichero = save.FileName;
                FileInfo file = new FileInfo(pathFichero);
                using (TextWriter writer = file.CreateText())
                {
                    foreach(Producto p in productosBack)
                    {
                        await writer.WriteLineAsync(p.Nombre+","+p.Precio+"€");
                    }

                    await writer.FlushAsync();
                    writer.Close();
                }
                this.lstproductos.Items.Clear();

            }
        }

        private async void btnread_Click(object sender, EventArgs e)
        {
            productosBack.Clear();
            OpenFileDialog open = new OpenFileDialog();
            DialogResult result = open.ShowDialog();
            if (result == DialogResult.OK)
            {
                String path = open.FileName;
                FileInfo file = new FileInfo(path);
                using (TextReader reader = file.OpenText())
                {
                    String content = await reader.ReadToEndAsync();
                    reader.Close();                    
                    string[] prods = content.Split('€');
                    foreach (String p in prods){
                        try
                        {
                            string[] elem = p.Split(',');
                            Producto prod = new Producto(elem[0], int.Parse(elem[1]));
                            productosBack.Add(prod);
                        }
                        catch(Exception ex) { }
                    }

                    lstproductos.Items.Clear();
                    foreach(Producto p in productosBack)
                    {
                        lstproductos.Items.Add(p.Nombre);
                    }
                    
                }
            }
        }

        private void btnprimero_Click(object sender, EventArgs e)
        {
            try
            {
                lstproductos.SetSelected(0, true);
                int index = lstproductos.SelectedIndex;
                txtnombre.Text = productosBack[index - 1].Nombre;
                txtprecio.Text = productosBack[index - 1].Precio.ToString();
            }
            catch(Exception ex) { }
            
        }

        private void btnultimo_Click(object sender, EventArgs e)
        {
            try
            {
                lstproductos.SetSelected(productosBack.Count()-1, true);
                int index = lstproductos.SelectedIndex;
                txtnombre.Text = productosBack[index ].Nombre;
                txtprecio.Text = productosBack[index ].Precio.ToString();
            }
            catch (Exception ex) { }
        }

        private void btnanterior_Click(object sender, EventArgs e)
        {
            try
            {
                lstproductos.SetSelected(lstproductos.SelectedIndex - 1, true);
                int index = lstproductos.SelectedIndex;
                txtnombre.Text = productosBack[index].Nombre;
                txtprecio.Text = productosBack[index].Precio.ToString();
            }
            catch (Exception ex) { }
        }

        private void btnsiguiente_Click(object sender, EventArgs e)
        {
            try
            {
                lstproductos.SetSelected(lstproductos.SelectedIndex + 1, true);
                int index = lstproductos.SelectedIndex;
                txtnombre.Text = productosBack[index].Nombre;
                txtprecio.Text = productosBack[index].Precio.ToString();
            }
            catch (Exception ex) { }
        }
    }
}
