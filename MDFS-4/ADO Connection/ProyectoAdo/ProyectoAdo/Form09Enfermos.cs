using ProyectoAdo.Data;
using ProyectoAdo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoAdo
{
    public partial class Form09Enfermos : Form
    {
        EnfermoContext context;
        public Form09Enfermos()
        {
            InitializeComponent();
            context = new EnfermoContext();
            CargarEnfermos();
        }
        private void CargarEnfermos()
        {
            List<Enfermo> enfermos = context.GetEnfermos();
            this.lsvenfermos.Items.Clear();
            foreach(Enfermo enf in enfermos)
            {
                ListViewItem item = new ListViewItem();
                item.Text = enf.Inscripcion.ToString();
                item.SubItems.Add(enf.Apellido);
                item.SubItems.Add(enf.Direccion);
                item.SubItems.Add(enf.FechaNacimiento);
                item.SubItems.Add(enf.Sex);
                item.SubItems.Add(enf.Nss.ToString());
                lsvenfermos.Items.Add(item);
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            ListViewItem it = lsvenfermos.SelectedItems[0];
            int inscripcion = int.Parse(it.Text);
            context.EliminarEnfermo(inscripcion);
            CargarEnfermos();
        }

        private void lsvenfermos_SelectedIndexChanged(object sender, EventArgs e)
        {
            
           
        }
    }
}
