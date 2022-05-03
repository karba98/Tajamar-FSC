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
    #region PROCEDIMIENTOS
    /*
     create procedure INCREMENTBYOFICIO
    (@oficio nvarchar(40),@increment int)
    as
	    update EMP set SALARIO=salario+@increment where OFICIO=@oficio
    go
    */
    #endregion
    public class EmpleadosContext
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataReader reader;

        public EmpleadosContext()
        {
            String cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;
            connection = new SqlConnection(cadena);
            command = new SqlCommand();
        }
        public List<Empleado> GetEmpleados(String oficio)
        {
            command.Parameters.AddWithValue("@oficio", oficio);
            command.CommandType = System.Data.CommandType.Text;
            String query = "";
            if (oficio == "")
            {
                query = "select * from emp";
            }
            else
            {
                query = "select * from emp where oficio = @oficio";
            }
            command.CommandText = query;
            command.Connection = connection;
            connection.Open();
            reader = command.ExecuteReader();
            List<Empleado> empleados = new List<Empleado>();
            while (reader.Read())
            {
                Empleado emp = new Empleado(
                    int.Parse(reader["EMP_NO"].ToString()),
                    reader["Apellido"].ToString(),
                    reader["oficio"].ToString(),
                    int.Parse(reader["salario"].ToString())
                    );
                empleados.Add(emp);
            }
            reader.Close();
            connection.Close();
            command.Parameters.Clear();
            return empleados;
        }
        public List<String> GetOficios()
        {
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "select distinct oficio from EMP; ";
            command.Connection = connection;
            connection.Open();
            reader = command.ExecuteReader();
            List<String> oficios = new List<String>();
            while (reader.Read())
            {
                oficios.Add(reader["oficio"].ToString());
            }
            reader.Close();
            connection.Close();
            return oficios;
        }
        public int Incrementar(String oficio, int incremento)
        {
            command.Parameters.AddWithValue("@oficio", oficio);
            command.Parameters.AddWithValue("@increment", incremento);
            command.CommandType = System.Data.CommandType.StoredProcedure;
           
            command.CommandText = "INCREMENTBYOFICIO";
            command.Connection = connection;
            connection.Open();
            int afectados = command.ExecuteNonQuery();
            connection.Close();
            command.Parameters.Clear();
            return afectados;
        }
    }
}
