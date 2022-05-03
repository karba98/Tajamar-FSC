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
   // CREATE PROCEDURE TODOSHOSPITALES
   //AS

   //     SELECT* FROM HOSPITAL
   // GO
   // ------------------------------------------------
   // CREATE VIEW DOCTORESPLANTILLA
   // AS

   //     SELECT APELLIDO, SALARIO, HOSPITAL_COD FROM DOCTOR

   //     UNION
   //     SELECT APELLIDO, SALARIO, HOSPITAL_COD FROM PLANTILLA
   // GO
   // ---------------------------------------------------
   // CREATE PROCEDURE DATOSHOSPITALES
   // (@NOMBRE NVARCHAR(30), @SUMA INT OUT
   // , @MEDIA INT OUT, @PERSONAS INT OUT)
   // AS
   //     DECLARE @HOSPITALCOD INT

   //     SELECT @HOSPITALCOD = HOSPITAL_COD FROM HOSPITAL

   //     WHERE NOMBRE = @NOMBRE

   //     SELECT* FROM DOCTORESPLANTILLA
   //    WHERE HOSPITAL_COD = @HOSPITALCOD

   //    SELECT @SUMA = SUM(SALARIO), @MEDIA = AVG(SALARIO)
   // 	, @PERSONAS = COUNT(APELLIDO) FROM DOCTORESPLANTILLA

   //     WHERE HOSPITAL_COD = @HOSPITALCOD
   // GO


    #endregion
    public partial class Form08HospitalesPlantillaYDocs : Form
    {
        SqlConnection connection;
        SqlDataReader reader;
        SqlCommand command;
        public Form08HospitalesPlantillaYDocs()
        {
            InitializeComponent();
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["cadena"].ConnectionString);
            command = new SqlCommand();
            command.Connection = connection;
            lstemples.View = View.Details;
            LoadHospitales();
        }

        private void LoadHospitales()
        {
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "TODOSHOSPITALES";
            connection.Open();
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                cmbhospis.Items.Add(reader["Nombre"]);
            }
            reader.Close();
            connection.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstemples.Items.Clear();
            String name = cmbhospis.SelectedItem.ToString();
            command.Parameters.AddWithValue("@NOMBRE", name);
            SqlParameter paramsum = new SqlParameter("@SUMA",0);
            SqlParameter parammedia = new SqlParameter("@MEDIA", 0);
            SqlParameter parampersonas = new SqlParameter("@PERSONAS", 0);
            paramsum.Direction = ParameterDirection.Output;
            parammedia.Direction = ParameterDirection.Output;
            parampersonas.Direction = ParameterDirection.Output;

            command.Parameters.Add(paramsum);
            command.Parameters.Add(parammedia);
            command.Parameters.Add(parampersonas);
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "DATOSHOSPITALES";
            connection.Open();
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                var item1 = new ListViewItem(new[] { 
                    reader["APELLIDO"].ToString(),
                    reader["SALARIO"].ToString()+"€", 
                    reader["HOSPITAL_COD"].ToString(), 
                });
                lstemples.Items.Add(item1);
                
            }
            reader.Close();
            txtpersonas.Text = parampersonas.Value.ToString();
            txtsmedio.Text = parammedia.Value.ToString()+"€";
            txtstotal.Text = paramsum.Value.ToString()+"€";
            command.Parameters.Clear();
            connection.Close();

        }
    }
}
