using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Azure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.File;
namespace EjemploStorageFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void botonleerfichero_Click(object sender, EventArgs e)
        {
            String key = CloudConfigurationManager.GetSetting("storagestring");
            CloudStorageAccount storageaccount = CloudStorageAccount.Parse(key);
            CloudFileClient client = storageaccount.CreateCloudFileClient();
            CloudFileShare fileshare = client.GetShareReference("ejemplo");
            CloudFileDirectory root = fileshare.GetRootDirectoryReference();
            CloudFile file = root.GetFileReference("Radiant.log");
            String contenido = await file.DownloadTextAsync();
            txtcontenido.Text = contenido;
            
        }
    }
}
