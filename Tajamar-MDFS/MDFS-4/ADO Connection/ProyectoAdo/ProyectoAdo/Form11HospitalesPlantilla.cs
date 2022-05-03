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
    public partial class Form11HospitalesPlantilla : Form
    {
        PlantillaContext context;
        List<Hospital> hospitales;
        public Form11HospitalesPlantilla()
        {
            InitializeComponent();
            context = new PlantillaContext();
            LoadHospitales();

        }

        private void LoadHospitales()
        {
            int space = 20;
             hospitales = context.GetHospitales();
            foreach(Hospital h in hospitales)
            {
                CheckBox box = new CheckBox();
                box.Tag = h.Nombre1;
                box.Text = h.Nombre1;
                box.AutoSize = true;
                box.Location = new Point(20, space + 30);
                panel.Controls.Add(box);
                space += 30;

                box.CheckedChanged += new EventHandler(CheckBox_Checked);
            }
        }

        private void CheckBox_Checked(object sender, EventArgs e)
        {
            lsvPlantilla.Items.Clear();
            List<int> codes = new List<int>();
            foreach (CheckBox c in panel.Controls)
            {
                if (c.Checked)
                {
                    foreach(Hospital h in hospitales)
                    {
                        if(h.Nombre1 == c.Text)
                        {
                            codes.Add(h.Cod);
                        }
                    }
                }
            }
            List<EmpleadoPlantilla> empleados = context.GetEmpleados(codes);
            foreach(EmpleadoPlantilla emp in empleados)
            {
                ListViewItem it = new ListViewItem();
                it.Text = emp.Apellido1;
                it.SubItems.Add(emp.Funcion1);
                it.SubItems.Add(emp.Salario1.ToString());
                it.SubItems.Add(emp.Hcode1.ToString());
                lsvPlantilla.Items.Add(it);
            }
        }
    }
}
