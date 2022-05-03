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

namespace Fundamentos
{
    public partial class Form27FicherosPlanos : Form
    {
        public Form27FicherosPlanos()
        {
            InitializeComponent();
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
                    await writer.WriteAsync(GetStringNombre());
                    
                    await writer.FlushAsync();
                    writer.Close();
                }
                this.lstnombres.Items.Clear();
                txttexto.Text = "";

            }
        }

        public String GetStringNombre()
        {
            String datos = "";
            foreach (String name in lstnombres.Items)
            {
                datos += name + ", ";
            }
            return datos;
        }
        public void SetStringNombre(String nombres)
        {
            String  [] names = nombres.Split(',');
            this.lstnombres.Items.Clear();
            foreach(String n in names)
            {
                lstnombres.Items.Add(n);
            }
        }
        private async void btnread_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            DialogResult result = open.ShowDialog();
            if(result == DialogResult.OK)
            {
                String path = open.FileName;
                FileInfo file = new FileInfo(path);
                using (TextReader reader = file.OpenText())
                {
                    String content = await reader.ReadToEndAsync();
                    txttexto.Text = content;
                    this.SetStringNombre(content);
                    reader.Close();
                }
            }
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            String nombre = txtnombre.Text;
            lstnombres.Items.Add(nombre);
            this.txtnombre.Text = "";
            this.txtnombre.Focus();
        }
    }
}
