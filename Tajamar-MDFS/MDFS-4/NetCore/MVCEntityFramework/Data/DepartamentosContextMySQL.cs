using MVCEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
namespace MVCEntityFramework.Data
{
    public class DepartamentosContextMySQL : IDepartamentosContext
    {
        private MySqlDataAdapter adapter;
        private DataTable table;
        private MySqlConnection connection;
        public DepartamentosContextMySQL(String cadena)
        {
            adapter = new MySqlDataAdapter("select * from dept", cadena);
            table = new DataTable();
            adapter.Fill(this.table);
        }
        public List<Departamento> GetDepartamentos()
        {
            var consulta = from res in table.AsEnumerable()
                           select res;
            List<Departamento> departamentos = new List<Departamento>();
            foreach (var dato in consulta)
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
