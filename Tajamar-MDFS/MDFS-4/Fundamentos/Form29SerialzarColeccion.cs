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
using System.Xml.Serialization;
using System.IO;


namespace Fundamentos
{
    public partial class Form29SerialzarColeccion : Form
    {
        XmlSerializer serializer;
        Productos productos;
        public Form29SerialzarColeccion()
        {
            InitializeComponent();
            serializer = new XmlSerializer(typeof(Productos));
            productos = new Productos();
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            try
            {
                Producto prod = new Producto(txtnombre.Text, int.Parse(txtprecio.Text));
                productos.Add(prod);
                PintarProductos();
            }catch(Exception ex)
            {
                MessageBox.Show("No se pudo insertar el producto");
            }

        }
        private void PintarProductos()
        {
            lstproductos.Items.Clear();
            foreach(Producto p in productos)
            {
                lstproductos.Items.Add(p.Nombre);
            }
        }

        private void lstproductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lstproductos.SelectedIndex;
            Producto p = productos[index];
            txtnombre.Text = p.Nombre;
            txtprecio.Text = p.Precio.ToString();
        }

        private async void btnsave_Click(object sender, EventArgs e)
        {
            StreamWriter writter = new StreamWriter("listaproductos.xml");
            serializer.Serialize(writter, productos);
            await writter.FlushAsync();
            writter.Close();
            lstproductos.Items.Clear();

        }

        private void btnread_Click(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader("listaproductos.xml");
            productos = (Productos)serializer.Deserialize(reader);
            reader.Close();
            PintarProductos();
        }
    }
}
