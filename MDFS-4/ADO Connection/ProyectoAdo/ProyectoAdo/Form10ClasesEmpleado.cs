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
    public partial class Form10ClasesEmpleado : Form
    {
        EmpleadosContext context; 
        public Form10ClasesEmpleado()
        {
            InitializeComponent();
            context = new EmpleadosContext();
            LoadEmpleados("");
            LoadOficios();
        }

        private void LoadOficios()
        {
            List<String> oficios = context.GetOficios();
            foreach(String o in oficios)
            {
                cmboficios.Items.Add(o);
            }
        }

        private void LoadEmpleados(String oficio)
        {
            lsvempleados.Items.Clear();
            List<Empleado> empleados = context.GetEmpleados(oficio);
            foreach (Empleado emp in empleados)
            {
                ListViewItem it = new ListViewItem();
                
                it.Text = emp.EmpNo1.ToString();
                it.SubItems.Add(emp.Apellido1.ToString());
                it.SubItems.Add(emp.Oficio1.ToString());
                it.SubItems.Add(emp.Salario1.ToString());
                lsvempleados.Items.Add(it);
            }
        }

        private void Form10ClasesEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void cmboficios_SelectedIndexChanged(object sender, EventArgs e)
        {
            String oficio = cmboficios.SelectedItem.ToString();
            LoadEmpleados(oficio);

        }

        private void btnincrement_Click(object sender, EventArgs e)
        {
            if (txtincrementos.Text != "" && cmboficios.Text!="")
            {
                int afectados = context.Incrementar(cmboficios.Text, int.Parse(txtincrementos.Text));
                if (afectados > 0)
                {
                    LoadEmpleados(cmboficios.Text);
                }
            }
        }
    }
}
