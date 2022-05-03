using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using ProyectoAdo.Models;

namespace ProyectoAdo.Data
{
    
    public class EnfermoContext
    {
        private SqlConnection con;
        private SqlCommand com;
        private SqlDataReader reader;
        
        public EnfermoContext()
        {
            String cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;
            Console.WriteLine(cadena);
            con = new SqlConnection(cadena);
            com = new SqlCommand();
            com.Connection = con;
        }

        public List<Enfermo> GetEnfermos()
        {
            com.CommandType = System.Data.CommandType.Text;
            com.CommandText = "select * from enfermo";
            con.Open();
            reader = com.ExecuteReader();
            List<Enfermo> enfermos = new List<Enfermo>();
            while (reader.Read())
            {
                Enfermo en = new Enfermo(
                    Convert.ToInt32(reader["INSCRIPCION"]),
                    reader["APELLIDO"].ToString(),
                    reader["DIRECCION"].ToString(),
                    reader["FECHA_NAC"].ToString(),
                    reader["S"].ToString(),
                    Convert.ToInt32(reader["NSS"])
                    );
                enfermos.Add(en);
                Console.WriteLine(en.Apellido);
            }
            reader.Close();
            con.Close();
            return enfermos;
        }
        public int EliminarEnfermo(int Inscripcion)
        {
            com.Parameters.AddWithValue("@inscripcion", Inscripcion);
            com.CommandType = System.Data.CommandType.Text;
            com.CommandText = "delete from enfermo where inscripcion = @inscripcion";
            con.Open();
            int afectados = com.ExecuteNonQuery();
            com.Parameters.Clear();
            con.Close();
            return afectados;
        }
    }
}
