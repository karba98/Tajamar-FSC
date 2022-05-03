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
    public partial class Form04CambiarSala : Form
    {
        SqlCommand comand;
        SqlConnection conection;
        SqlDataReader reader;
        public Form04CambiarSala()
        {
            InitializeComponent();
            //this.conection = new SqlConnection("Data Source=LOCALHOST;Initial Catalog=HOSPITAL;Integrated Security=True");
            this.conection = new SqlConnection("Data Source=localhost;Initial Catalog=HOSPITAL;User ID=sa;Password=MCSD2020");
            this.comand = new SqlCommand();
            

        }
    
        private void LoadSalas()
        {
            lstsalas.Items.Clear();
            conection.Open();
            comand.Connection = conection;
            comand.Parameters.AddWithValue("@hc", txtch.Text);
            comand.CommandType = CommandType.Text;
            comand.CommandText = "select nombre from sala where hospital_cod=@hc";
            this.reader = comand.ExecuteReader();
            while (reader.Read())
            {
                lstsalas.Items.Add(reader["NOMBRE"]);
            }
            reader.Close();
            comand.Parameters.Clear();
            conection.Close();
        }

        private void Form04CambiarSala_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadSalas();
        }

        private void lstsalas_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtnewsala.Text = lstsalas.SelectedItem.ToString();
        }

        private void btncambiar_Click(object sender, EventArgs e)
        {
            String newsalaname = txtnewsala.Text;
            String oldsala = lstsalas.SelectedItem.ToString();
            if (newsalaname != "")
            {
                comand.CommandType = CommandType.Text;
                comand.Parameters.AddWithValue("@newsala", txtnewsala.Text);
                comand.Parameters.AddWithValue("@hc", txtch.Text);
                comand.CommandType = CommandType.Text;
                comand.CommandText = "update sala set nombre = @newsala where nombre ='"+oldsala+"' and hospital_cod = @hc";
                conection.Open();
                comand.Connection = conection;
                int afectados = comand.ExecuteNonQuery();
                conection.Close();
                comand.Parameters.Clear();
                if (afectados > 0)
                {
                    LoadSalas();
                    txtnewsala.Text = "";
                    MessageBox.Show("Salas modificadas: "+afectados);
                }

            }
        }
    }
}
