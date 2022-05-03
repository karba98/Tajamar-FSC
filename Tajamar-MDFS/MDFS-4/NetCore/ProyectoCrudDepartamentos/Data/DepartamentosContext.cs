using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ProyectoCrudDepartamentos.Models;
using ProyectoCrudDepartamentos.Models;

namespace ProyectoCrudDepartamentos.Data
{
    public class DepartamentosContext
    {
        SqlCommand command;
        SqlDataReader reader;
        SqlConnection connection;
        String cadena;

        SqlDataAdapter adapter;
        SqlDataAdapter adapteremp;

        DataTable tablaemp;
        DataTable tabla;

        public DepartamentosContext()
        {
            cadena = "Data Source=LOCALHOST;Initial Catalog=HOSPITAL;Integrated Security=True";
            adapter = new SqlDataAdapter("SELECT * from DEPT", cadena);
            adapteremp = new SqlDataAdapter("select * from emp", cadena);

            this.tablaemp = new DataTable();
            this.tabla = new DataTable();

            adapteremp.Fill(tablaemp);
            adapter.Fill(this.tabla);

            connection = new SqlConnection(cadena);
            command = new SqlCommand();
            command.Connection = connection;
        }
        public List<Departamento> GetDepartamentos()
        {
            List<Departamento> departamentos = new List<Departamento>();
            var consulta = from res in this.tabla.AsEnumerable()
                           select res;
            foreach(var row in consulta)
            {
                Departamento dept = new Departamento();
                dept.Dept_no = row.Field<int>("DEPT_NO");
                dept.Loc = row.Field<String>("LOC");
                dept.Dnombre = row.Field<String>("DNOMBRE");
                departamentos.Add(dept);
            }
            return departamentos;
        }
        public Departamento GetDepartamento(int id)
        {
            List<Departamento> departamentos = new List<Departamento>();
            var consulta = from res in this.tabla.AsEnumerable()
                           where res.Field<int>("DEPT_NO")==id
                           select res;

             
            Departamento dept = new Departamento();
            var row = consulta.First();
            dept.Dept_no = row.Field<int>("DEPT_NO");
            dept.Loc = row.Field<String>("LOC");
            dept.Dnombre = row.Field<String>("DNOMBRE");
            departamentos.Add(dept);
            
            return dept;
        }

        public int DeleteDept(int id)
        {
            command.Parameters.AddWithValue("@id", id);
            command.CommandType = CommandType.Text;
            command.CommandText = "delete from dept where dept_no = @id";
            connection.Open();
            int afectados = command.ExecuteNonQuery();
            connection.Close();
            command.Parameters.Clear();
            return afectados;
        }

        internal int UpdateDept(string dnombre, int dept_no, string loc)
        {
            command.Parameters.AddWithValue("@num", dept_no);
            command.Parameters.AddWithValue("@dnombre", dnombre);
            command.Parameters.AddWithValue("@loc", loc);
            command.CommandType = CommandType.Text;
            command.CommandText = "update dept set dnombre = @dnombre, loc = @loc  where dept_no=@num";
            connection.Open();
            int afectados = command.ExecuteNonQuery();
            connection.Close();
            command.Parameters.Clear();
            return afectados;
        }

        internal List<Empleado> GetEmpleadosDept(int dept)
        {

            List<Empleado> empleados = new List<Empleado>();
            var consulta = from datos in this.tablaemp.AsEnumerable()
                           where datos.Field<int>("DEPT_NO") == dept
                           select datos;
            foreach (var row in consulta)
            {
                Empleado emp = new Empleado();
                emp.Apellido = row.Field<String>("APELLIDO");
                emp.IdEmpleado = row.Field<int>("EMP_NO");
                emp.Departamento = row.Field<int>("DEPT_NO");
                emp.Salario = row.Field<int>("SALARIO");
                emp.Oficio = row.Field<String>("OFICIO");
                empleados.Add(emp);
            }

           

            return empleados;
        }

        internal int InsertDept(string dnombre, int dept_no, string loc)
        {
            command.Parameters.AddWithValue("@num", dept_no);
            command.Parameters.AddWithValue("@dnombre", dnombre);
            command.Parameters.AddWithValue("@loc", loc);
            command.CommandType = CommandType.Text;
            command.CommandText = "insert into dept values(@num,@dnombre,@loc)";
            connection.Open();
            int afectados = command.ExecuteNonQuery();
            connection.Close();
            command.Parameters.Clear();
            return afectados;
        }
        

    }
}
