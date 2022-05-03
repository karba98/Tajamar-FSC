using MVCEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace MVCEntityFramework.Data
{
    public class DepartamentosContextSQL : IDepartamentosContext
    {
        
        private SqlDataAdapter adapter;
        private DataTable tabladept;
        
        public DepartamentosContextSQL(string cadena)
        {
            //string cadena = "Data Source=LOCALHOST;Initial Catalog=HOSPITAL;Integrated Security=True";
            this.adapter = new SqlDataAdapter("select * from dept", cadena);
            this.tabladept = new DataTable();
            this.adapter.Fill(tabladept);
        }
        public List<Departamento> GetDepartamentos()
        {
            //SELECT LINQ
            var consulta = from datos in
                               this.tabladept.AsEnumerable()
                           select datos;
            List<Departamento> departamentos = new List<Departamento>();
            foreach(var dato in consulta)
            {
                Departamento dept = new Departamento();
                dept.Num = Convert.ToInt32(dato.Field<int>("DEPT_NO"));
                dept.Nombre = dato.Field<String>("DNOMBRE");
                dept.Loc = dato.Field<String>("LOC");

                departamentos.Add(dept);
            }
            return departamentos;

        }
    }
}
