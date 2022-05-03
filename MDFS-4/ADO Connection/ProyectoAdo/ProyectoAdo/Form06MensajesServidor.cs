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

namespace ProyectoAdo
{
    #region PROCEDIEMIENTOS
    //create procedure INSERTDEPT
    //(@NUM int, @NOM nvarchar(40),@loc nvarchar(40))
    //as
    // insert into dept values(@num, @nom, @loc)
    //go

    //create procedure VERDEPT
    //as
    // select* from dept
    //go

    /*
     alter procedure INSERTDEPT
    (@NUM int, @NOM nvarchar(40),@loc nvarchar(40))
    as
	if(@loc ='TERUEL')
		begin
			print 'TERUEL NO EXISTE'
		end
	ELSE
		BEGIN
			insert into dept values(@num, @nom, @loc)
		END
    go
     */
    #endregion
    public partial class Form06MensajesServidor : Form
    {
        SqlConnection connection;
        SqlDataReader reader;
        SqlCommand command;
        public Form06MensajesServidor()
        {
            InitializeComponent();
            String cadena = "Data Source=localhost;Initial Catalog=HOSPITAL;User ID=sa;Password=MCSD2020";
            connection = new SqlConnection(cadena);
            command = new SqlCommand();
            command.Connection = connection;
            connection
                    .InfoMessage += Connection_InfoMessage;
            LoadDepts();
            
        }

        private void LoadDepts()
        {
            lstdept.Items.Clear();
            lstloc.Items.Clear();
            lstnom.Items.Clear();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "VERDEPT";
            connection.Open();
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                lstdept.Items.Add(reader["DEPT_NO"].ToString());
                lstnom.Items.Add(reader["DNOMBRE"].ToString());
                lstloc.Items.Add(reader["LOC"].ToString());
            }
            reader.Close();
            connection.Close();
        }



        private void lstdept_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstnom.SelectedIndex = lstdept.SelectedIndex;
            lstnom.Focus();
            lstloc.SelectedIndex = lstdept.SelectedIndex;
            lstloc.Focus();
        }

        private void lstnom_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstdept.SelectedIndex = lstnom.SelectedIndex;
            lstdept.Focus();
            lstloc.SelectedIndex = lstnom.SelectedIndex;
            lstloc.Focus();
        }

        private void lstloc_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstnom.SelectedIndex = lstloc.SelectedIndex;
            lstnom.Focus();
            lstdept.SelectedIndex = lstloc.SelectedIndex;
            lstdept.Focus();
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            lblmessage.Text = "";
            if(txtnom.Text=="" || txtloc.Text ==""|| txtnum.Text == "")
            {
                MessageBox.Show("Introduzca los datos");
            }
            else
            {
                command.Parameters.AddWithValue("@NOM", txtnom.Text);
                command.Parameters.AddWithValue("@NUM", txtnum.Text);
                command.Parameters.AddWithValue("@LOC", txtloc.Text);
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "INSERTDEPT";
                connection.Open();
                int afectados = command.ExecuteNonQuery();
                connection.Close();
                command.Parameters.Clear();
                
                LoadDepts();
            }
           
        }

        private void Connection_InfoMessage(object sender, SqlInfoMessageEventArgs e)
        {
            lblmessage.ForeColor = Color.Red;
            this.lblmessage.Text = e.Message;
            MessageBox.Show(e.Errors.ToString());
        }
    }
}
