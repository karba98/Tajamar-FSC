using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using Microsoft.Azure.Cosmos.Table;
using System.IO;
using System.Xml.Linq;

namespace MigracionTablesAzure
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String keys = ConfigurationSettings.AppSettings["storageaccountkey"];
            CloudStorageAccount account = CloudStorageAccount.Parse(keys);
            CloudTableClient client = account.CreateCloudTableClient();
            CloudTable table = client.GetTableReference("tablaalumnos");
            table.CreateIfNotExists();
            Stream contenido =
                this.GetType().Assembly.GetManifestResourceStream("MigracionTablesAzure.alumnos_tables_storage.xml");
            XDocument doc = XDocument.Load(contenido);
            var consulta = from datos in doc.Descendants("alumno")
                           select new Alumno
                           {
                               IdAlumno = datos.Element("idalumno").Value,
                               Nombre = datos.Element("nombre").Value,
                               Curso = datos.Element("curso").Value,
                               Apellidos = datos.Element("apellidos").Value,
                               Nota = datos.Element("nota").Value,
                           };
            foreach(Alumno alumn in consulta)
            {
                TableOperation insert = TableOperation.Insert(alumn);
                table.Execute(insert);
            }
            label1.Text = "Insertado correctamente";
        }
    }
}
