using ProyectoClases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
namespace Fundamentos
{
    public partial class Form29SeralizacionProducto : Form
    {
        XmlSerializer serial;
        public Form29SeralizacionProducto()
        {
            InitializeComponent();
            serial = new XmlSerializer(typeof (Producto));

        }

        private void btnleer_Click(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader(@"C:\Users\AlumnoMCSD\Desktop\producto.xml");
            Producto producto = (Producto)serial.Deserialize(reader);
            reader.Close();
            txtproducto.Text = producto.Nombre;
            txtprecio.Text = producto.Precio.ToString();
        }

        private async void btnguardar_Click(object sender, EventArgs e)
        {
            if(txtproducto.Text!="" && txtprecio.Text != "")
            {
                Producto producto = new Producto(txtproducto.Text, int.Parse(txtprecio.Text));
                StreamWriter writer = new StreamWriter(@"C:\Users\AlumnoMCSD\Desktop\producto.xml");
                 
                serial.Serialize(writer,producto);
                await writer.FlushAsync();
                writer.Close();

                lblres.Text = "Guardado";
                txtprecio.Text = "";
                txtproducto.Text = "";
            }
           
        }
    }
}
