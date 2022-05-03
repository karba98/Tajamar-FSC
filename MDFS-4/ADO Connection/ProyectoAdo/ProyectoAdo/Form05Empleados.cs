using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

#region PROCEDIMIENTO
//create procedure TODOSLOSEMPLEADOS
//AS
//select * from emp
//GO

//create procedure BUSCAREMPLEADO
//(@apellido nvarchar(40))
//AS
//select * from emp where apellido like @apellido +'%'
//GO
#endregion
namespace ProyectoAdo
{
    public partial class Form05Empleados : Form
    {
        SqlConnection connection;
        SqlDataReader reader;
        SqlCommand command;
        public Form05Empleados()
        {
            InitializeComponent();
            String cadena = "Data Source=localhost;Initial Catalog=HOSPITAL;User ID=sa;Password=MCSD2020";
            this.connection = new SqlConnection(cadena);
            this.command = new SqlCommand();
            this.command.Connection = connection;
            command.CommandType = CommandType.Text;
            command.CommandText = "TODOSLOSEMPLEADOS";
            connection.Open();
            this.reader = command.ExecuteReader();
            while (reader.Read())
            {
                lstapellidos.Items.Add(reader["APELLIDO"]);
            }
            reader.Close();
            connection.Close();

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            String apellido = txtapellido.Text;
            command.Parameters.AddWithValue("@apellido", apellido);
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "BUSCAREMPLEADO";
            connection.Open();
            reader = command.ExecuteReader();
            lstapellidos.Items.Clear();
            while (reader.Read())
            {
                lstapellidos.Items.Add(reader["APELLIDO"].ToString());
            }
            reader.Close();
            command.Parameters.Clear();
            connection.Close();

        }
    }
}
