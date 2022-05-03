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
    public partial class Form01PrimerAdo : Form
    {
        String cadenaconexion;
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;
        public Form01PrimerAdo()
        {
            
            InitializeComponent();
            //this.cadenaconexion = "Data Source=LOCALHOST;Initial Catalog=HOSPITAL;Integrated Security=True";
            cn = new SqlConnection("Data Source=LOCALHOST;Initial Catalog=HOSPITAL;Integrated Security=True");
            this.com = new SqlCommand();
            this.cn.StateChange += Cn_StateChange;
        }

        private void Cn_StateChange(object sender, StateChangeEventArgs e)
        {
            this.lblstate.Text = "Connection pasando de " + e.OriginalState + " a " + e.CurrentState;
            lblstate.ForeColor = Color.Blue;
        }

        private void btnconnect_Click(object sender, EventArgs e)
        {
            if (this.cn.State == ConnectionState.Closed)
            {
                cn.Open();
                this.lblstate.Text = "Conected";
                this.lblstate.ForeColor = Color.Green;
            }
           
        }

        private void btndisconnect_Click(object sender, EventArgs e)
        {
            this.cn.Close();
            lblstate.ForeColor = Color.Red;
            lblstate.Text = "Disconnected";
        }

        private void btnread_Click(object sender, EventArgs e)
        {
            if (this.cn.State == ConnectionState.Open)
            {
                //pasamos al comando la conexion que vamos a usar
                this.com.Connection = cn;
                //simple select
                this.com.CommandType = CommandType.Text;
                this.com.CommandText = "select * from emp";
                //ejecuta comando
                reader = com.ExecuteReader();

                String column = reader.GetName(0);//0 es columna 0
                String type = this.reader.GetDataTypeName(0);// 0 es columna 0
                lstcolumnas.Items.Add(column);
                lsttipos.Items.Add(type);
                while (reader.Read() != false)
                {
                    lstapellidos.Items.Add(reader.GetString(1));
                    
                }
                reader.Close();

            }
            else
            {
                MessageBox.Show("Conectese a la BD");
            }


        }
    }
}
