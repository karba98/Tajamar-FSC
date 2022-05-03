using ProyectoAdo.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAdo.Data
{
    class PlantillaContext
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataReader reader;

        public PlantillaContext()
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["cadena"].ConnectionString);
            command = new SqlCommand();
            command.Connection = connection;
        }
        public List<Hospital> GetHospitales()
        {
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "select * from hospital";
            connection.Open();
            reader = command.ExecuteReader();
            List<Hospital> hospitales = new List<Hospital>();
            while (reader.Read())
            {
                Hospital h = new Hospital(
                    int.Parse(reader["HOSPITAL_COD"].ToString()),
                    reader["NOMBRE"].ToString(),
                    reader["DIRECCION"].ToString(),
                    reader["TELEFONO"].ToString(),
                    int.Parse(reader["NUM_CAMA"].ToString())
                    );
                hospitales.Add(h);

            }
            reader.Close();
            connection.Close();
            return hospitales;
            
        }

        public List<EmpleadoPlantilla> GetEmpleados(List<int> hospitales)
        {
            List<EmpleadoPlantilla> empleados = new List<EmpleadoPlantilla>();
            if (hospitales.Count != 0)
            {
                String datos = "";
                foreach (int h in hospitales)
                {
                    datos += h.ToString() + ",";
                }
                datos = datos.Trim(',');

                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "select * from plantilla where hospital_cod in(" + datos + ")";
                connection.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    EmpleadoPlantilla emple = new EmpleadoPlantilla(
                        int.Parse(reader["HOSPITAL_COD"].ToString()),
                        int.Parse(reader["SALA_COD"].ToString()),
                        int.Parse(reader["EMPLEADO_NO"].ToString()),
                        reader["APELLIDO"].ToString(),
                        reader["FUNCION"].ToString(),
                        reader["T"].ToString(),
                        int.Parse(reader["SALARIO"].ToString())
                        );
                    empleados.Add(emple);
                }
                reader.Close();

                connection.Close();
            }

            
            
            return empleados;
        }
    }
}
