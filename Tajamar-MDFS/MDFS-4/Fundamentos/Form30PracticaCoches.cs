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
using System.Xml.Serialization;
using ProyectoClases;

namespace Fundamentos
{
    public partial class Form30PracticaCoches : Form
    {
        Coches coches;
        XmlSerializer serializer;
        public Form30PracticaCoches()
        {
            InitializeComponent();
            coches = new Coches();
            serializer = new XmlSerializer(typeof(Coches));
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            try
            {
                Coche coche = new Coche
                    (txtmarca.Text,txtmodelo.Text);
                if (txtpath.Text != "")
                {
                    //MemoryStream ms = new MemoryStream();
                    //pctcoche.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    //byte[] buff = ms.GetBuffer();
                    //coche.Image = buff;

                    coche.ImagePath = txtpath.Text;
                }

                coches.Add(coche);

                pctcoche.Image = null;
                txtmarca.Text = "";
                txtpath.Text = "";
                txtmodelo.Text = "";
                PintarCoches();

            }catch(Exception ex)
            {
                MessageBox.Show("Algo salió mal");
            }
        }

        private void PintarCoches()
        {
            lstcoches.Items.Clear();
            foreach(Coche coche in coches)
            {
                lstcoches.Items.Add(coche.Marca + " " + coche.Modelo);
            }
        }

        private async void btnsave_Click(object sender, EventArgs e)
        {
            StreamWriter writter = new StreamWriter(@"cochesdata\coches.xml");
            serializer.Serialize(writter, coches);
            await writter.FlushAsync();
            writter.Close();
            lstcoches.Items.Clear();
            coches.Clear();

            txtmarca.Text = "";
            txtmodelo.Text = "";

            pctcoche.Image = null;
        }

        private void lstcoches_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lstcoches.SelectedIndex;
            Coche c = coches[index];
            txtmarca.Text = c.Marca;
            txtmodelo.Text = c.Modelo;
            if (c.ImagePath != null)
            {
                pctcoche.Image = Image.FromFile(c.ImagePath);
                txtpath.Text = c.ImagePath;
            }
            else
            {
                pctcoche.Image = null;
                txtpath.Text = "";
            }
        }

        private void btnload_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader reader = new StreamReader(@"cochesdata\coches.xml");
                coches = (Coches)serializer.Deserialize(reader);
                reader.Close();
                PintarCoches();
            }
            catch(Exception ex) { }
            
        }


        private async void btnimage_Click(object sender, EventArgs e)
        {
            //PictureBox1.Image = Image.FromFile
            //(@"C:\MyPict.jpg");

            //pictureBox1.Image = Bitmap.FromStream(stream);

            OpenFileDialog open = new OpenFileDialog();
            DialogResult result = open.ShowDialog();
            if (result == DialogResult.OK)
            {
                String path = open.FileName;
                pctcoche.Image = Image.FromFile
                (path);
                txtpath.Text = path;
            }
        }
    }
}
