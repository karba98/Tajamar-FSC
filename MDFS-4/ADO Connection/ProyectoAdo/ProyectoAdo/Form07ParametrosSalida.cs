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
using System.Data.SqlClient;

namespace ProyectoAdo
{
    #region PROCEDIMIENTOS
    //    create procedure EMPLEADOSDEPTOUT
    //(@NOMBRE NVARCHAR(40), @SUMA INT OUT)
    //AS
    //    DECLARE @DEPTN INT

    //    SELECT @DEPTN = DEPT_NO FROM DEPT

    //    WHERE DNOMBRE = @NOMBRE


    //    SELECT* FROM EMP
    //   WHERE DEPT_NO=@DEPTN

    //   SELECT @SUMA = SUM(SALARIO) FROM EMP

    //    WHERE DEPT_NO = @DEPTN
    //GO
    #endregion
    public partial class Form07ParametrosSalida : Form
    {
        SqlConnection connection;
        SqlDataReader reader;
        SqlCommand command;
        public Form07ParametrosSalida()
        {
            InitializeComponent();
            //ACTUALIZAR LIBRERIAS
            //BOTON DERECHO PROYECTO / REFERENCES/ AÑADIR SYSTEM.CONFIGURATION

            //String color = ConfigurationManager.AppSettings.Get("colorFondo");
            //String color = ConfigurationManager.AppSettings["colorFondo"];
            //this.BackColor = Color.FromName(color);
            String cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;
            connection = new SqlConnection(cadena);
            command = new SqlCommand();
            command.Connection = connection;
            LoadDepts();

            //
        }

        private void LoadDepts()
        {
            
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "VERDEPT";
            connection.Open();
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                cmbdept.Items.Add(reader["DNOMBRE"].ToString());
            }
            reader.Close();
            connection.Close();

        }

        private void cmbdept_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstemples.Items.Clear();
            string dept = cmbdept.SelectedItem.ToString();
            command.Parameters.AddWithValue("@NOMBRE", dept);

            SqlParameter param = new SqlParameter();
            param.ParameterName = "@SUMA";
            param.Value = 0;
            param.Direction = ParameterDirection.Output;
            command.Parameters.Add(param);

            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "EMPLEADOSDEPTOUT";
            connection.Open();
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                lstemples.Items.Add(reader["APELLIDO"].ToString());
            }
            reader.Close();
            txtsumasal.Text = param.Value.ToString();
            connection.Close();
            command.Parameters.Clear();
        }

        private void lstdepts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
