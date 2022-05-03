using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;//datatable
using System.Data.SqlClient;//data adapter
using ProyectoDatos.Models;

namespace ProyectoDatos.Data
{
    public class EmpleadosContext
    {
        SqlDataAdapter adapter;
        DataTable tabla;

        public EmpleadosContext()
        {
            String cadena = "Data Source=LOCALHOST;Initial Catalog=HOSPITAL;Integrated Security=True";
            adapter = new SqlDataAdapter("SELECT * from EMP",cadena);
            this.tabla = new DataTable();
            adapter.Fill(this.tabla);
        }
        public List<Empleado> GetEmpleados()
        {
            List<Empleado> empleados = new List<Empleado>();
            var consulta = from datos in this.tabla.AsEnumerable()
                           select datos;
            foreach(var row in consulta)
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

        public List<Empleado> getEmpleadosOfiSal(int salario, String oficio)
        {
            if(salario == null || oficio == "" || oficio==null)
            {
                return null;
            }
            else
            {
                List<Empleado> empleados = new List<Empleado>();
                var consulta = from datos in this.tabla.AsEnumerable()
                               where datos.Field<String>("OFICIO").Equals(oficio.ToUpper()) &&
                               datos.Field<int>("SALARIO") > salario
                               select datos;

                if (consulta.Count() == 0)
                {
                    return null;
                }
                else
                {
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
            }
           
           
           
        }

        public Empleado GetEmpleado(int id)
        {
            var consulta = from datos in this.tabla.AsEnumerable()
                           where datos.Field<int>("EMP_NO") == id
                           select datos;
            Empleado emp = new Empleado();
            var row = consulta.First();
            emp.Apellido = row.Field<String>("APELLIDO");
            emp.IdEmpleado = row.Field<int>("EMP_NO");
            emp.Departamento = row.Field<int>("DEPT_NO");
            emp.Salario = row.Field<int>("SALARIO");
            emp.Oficio = row.Field<String>("OFICIO");
            return emp;
        }
    }
}
