using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace ProyectoAdo
{
    public partial class Form02BuscadorEmp : Form
    {
        //"Data Source=LOCALHOST;Initial Catalog=HOSPITAL;Integrated Security=True"
        SqlCommand com;
        SqlConnection cn;
        SqlDataReader reader;
        public Form02BuscadorEmp()
        {
            InitializeComponent();
            cn = new SqlConnection("Data Source=LOCALHOST;Initial Catalog=HOSPITAL;Integrated Security=True");
            com = new SqlCommand();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            lstempleados.Items.Clear();
            String dato = txtsearch.Text;
            String query = "select apellido, oficio from emp where oficio = '" + dato+"'";
            com.Connection = cn;
            com.CommandType = CommandType.Text;
            com.CommandText = query;
            cn.Open();
            reader = com.ExecuteReader();
            while (reader.Read())
            {
                String apellido = reader["APELLIDO"].ToString();
                String oficio = reader["OFICIO"].ToString();
                lstempleados.Items.Add(oficio.ToUpper() + ": " + apellido);
            }
            reader.Close();
            cn.Close();
        }

 
    }
}
