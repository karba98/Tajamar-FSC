using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ProyectoDatos.Models;

namespace ProyectoDatos.Data
{
    public class HospitalContext
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataReader reader;
        public HospitalContext()
        {
            String cadena = "Data Source=LOCALHOST;Initial Catalog=HOSPITAL;Integrated Security=True";
            connection = new SqlConnection(cadena);
            command = new SqlCommand();
            command.Connection = connection;
        }
        public List<Hospital> GetHospitales()
        {
            List<Hospital> hospitales = new List<Hospital>();
            this.command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "select * from hospital";
            connection.Open();
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                Hospital hospital = new Hospital();
                hospital.Nombre = reader["NOMBRE"].ToString(); ;
                hospital.Direccion = reader["DIRECCION"].ToString();
                hospital.IdHospital = Convert.ToInt32(reader["HOSPITAL_COD"]);
                hospital.Camas = Convert.ToInt32(reader["NUM_CAMA"]);
                hospital.Telefono = reader["TELEFONO"].ToString();
                hospitales.Add(hospital);
            }
            reader.Close();
            connection.Close();
            return hospitales;
        }

        public int CrearHospital(string nombre, string direccion,string telefono, int camas, int id)
        {
            command.CommandType = System.Data.CommandType.Text;
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@nombre", nombre);
            command.Parameters.AddWithValue("@direccion", direccion);
            command.Parameters.AddWithValue("@telefono", telefono);
            command.Parameters.AddWithValue("@camas", camas);
            command.CommandText = "insert into hospital values(@id,@nombre,@direccion,@telefono,@camas)";
            connection.Open();
            int afectados = command.ExecuteNonQuery();
            connection.Close();
            command.Parameters.Clear();
            return afectados;
        }

        public Hospital BuscarHospital(int id)
        {
            this.command.Parameters.AddWithValue("@id", id);
            this.command.CommandText = "select * from hospital where hospital_cod=@id";
            this.command.CommandType = System.Data.CommandType.Text;
            this.connection.Open();
            this.reader = command.ExecuteReader();
            this.reader.Read();
            Hospital hospital = new Hospital();
            hospital.Nombre = reader["NOMBRE"].ToString(); ;
            hospital.Direccion = reader["DIRECCION"].ToString();
            hospital.Telefono = reader["TELEFONO"].ToString();
            hospital.IdHospital = Convert.ToInt32(reader["HOSPITAL_COD"]);
            hospital.Camas = Convert.ToInt32(reader["NUM_CAMA"]);
            reader.Close();
            connection.Close();
            command.Parameters.Clear();
            return hospital;

        }

        public int ModificarHospital(Hospital h)
        {
            command.CommandType = System.Data.CommandType.Text;
            command.Parameters.AddWithValue("@id", h.IdHospital);
            command.Parameters.AddWithValue("@nombre", h.Nombre);
            command.Parameters.AddWithValue("@direccion", h.Direccion);
            command.Parameters.AddWithValue("@telefono", h.Telefono);
            command.Parameters.AddWithValue("@camas", h.Camas);
            command.CommandText = "update hospital set nombre=@nombre, direccion =@direccion,num_cama = @camas,telefono =@telefono where hospital_cod=@id";
            connection.Open();
            int afectados = command.ExecuteNonQuery();
            connection.Close();
            command.Parameters.Clear();
            return afectados;
        }

        public int EliminarHospital(int id)
        {
            this.command.CommandText = "delete from hospital where hospital_cod=@id";
            this.command.CommandType = System.Data.CommandType.Text;
            command.Parameters.AddWithValue("@id", id);
            connection.Open();
            int af = command.ExecuteNonQuery();
            connection.Close();
            command.Parameters.Clear();
            return af;
        }
    }
}
