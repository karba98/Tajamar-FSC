using Microsoft.WindowsAzure.Storage.Blob;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploStorageBlob
{
    public partial class Form1 : Form
    {
        //ABRIR AZURE STORAGE EMULATOR
        ServiceStorageBlobs service;
        public Form1()
        {
            service = new ServiceStorageBlobs();
            InitializeComponent();
            this.CargarContainers();
        }

        private async void btncreateContainer_Click(object sender, EventArgs e)
        {
            await this.service.CreateContainer(txtContenedor.Text);
            CargarContainers();
        }
        private void CargarContainers()
        {
            this.listContenedores.Items.Clear();
            foreach(String s in service.GetContainers())
            {
                this.listContenedores.Items.Add(s);
            }
        }

        private async void btnSubir_Click(object sender, EventArgs e)
        {
            OpenFileDialog dial = new OpenFileDialog();
            if (dial.ShowDialog() == DialogResult.OK)
            {
                String path = dial.FileName;
                String filename = path.Substring(path.LastIndexOf(@"\") + 1);
                String containername = listContenedores.SelectedItem.ToString();
                await service.UploadBlob(containername, filename, path);
                this.CargarBlobs();
            }
        }
        private void CargarBlobs()
        {
            this.lsvBlob.Items.Clear();
            String containername = listContenedores.SelectedItem.ToString();
            foreach (CloudBlockBlob blob in this.service.GetBlobs(containername))
            {
                String uri = blob.StorageUri.PrimaryUri.ToString();
                String size = blob.Properties.Length.ToString();
                ListViewItem it = new ListViewItem();
                it.Text = uri;
                it.SubItems.Add(size);
                this.lsvBlob.Items.Add(it);
            }

        }

        private void lsvBlob_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvBlob.SelectedItems.Count!=0)
            {
                String uri = lsvBlob.SelectedItems[0].Text;
                pictureBox.Load(uri);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void listContenedores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listContenedores.SelectedIndex != -1)
            {
                this.CargarBlobs();
            }
        }

        private async void btndelete_Click(object sender, EventArgs e)
        {
            String uri = lsvBlob.SelectedItems[0].Text;
            String filename = uri.Substring(uri.LastIndexOf("/") + 1);
            String containerName = listContenedores.SelectedItem.ToString();
            await service.DeleteBLob(containerName, filename);
            
            CargarBlobs();
        }
    }
}
