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
    public partial class Form03EliminarEnfermo : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public Form03EliminarEnfermo()
        {
            InitializeComponent();
            String cadena = "Data Source=LOCALHOST;Initial Catalog=HOSPITAL;Integrated Security=True";
            cn = new SqlConnection(cadena);
            com = new SqlCommand();
            cargarEnfermos();
        }
        private void cargarEnfermos()
        {
            lstenfermos.Items.Clear();
            com.Connection = cn;
            com.CommandType = CommandType.Text;
            com.CommandText = "select * from enfermo";
            cn.Open();
            this.reader = com.ExecuteReader();
            while (this.reader.Read())
            {
                String apellido = this.reader["Apellido"].ToString();
                String inscripcion = this.reader["Inscripcion"].ToString();
                lstenfermos.Items.Add(inscripcion+" - "+apellido);
            }
            this.reader.Close();
            cn.Close();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            
            com.Parameters.AddWithValue("@inscripcion",txtsearch.Text);
            //com.Parameters.Add(new SqlParameter("@inscripcion", txtsearch.Text));
            String query = "delete from enfermo where inscripcion = @inscripcion";
            com.CommandType = CommandType.Text;
            com.CommandText = query;
            cn.Open();
            int afectados = com.ExecuteNonQuery();
            this.cn.Close();
            cargarEnfermos();
            
            txtsearch.Focus();
            if (txtsearch.Text == "")
            {
                MessageBox.Show("No se ha borrado a nadie");
            }
            txtsearch.Text = "";
            com.Parameters.Clear();
        }
    }
}
