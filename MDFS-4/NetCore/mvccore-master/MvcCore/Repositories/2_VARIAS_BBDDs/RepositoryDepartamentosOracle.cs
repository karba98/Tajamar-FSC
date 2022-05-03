using MvcCore.Models;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCore.Repositories
{
    public class RepositoryDepartamentosOracle : IRepositoryDepartamentos
    {
        //NO USA ENTITY FRAMEWORK
        //CON LO CUAL TIRAMOS DE LINQ Y ADAPTER DE OARACLE
        OracleDataAdapter adaptador;
        DataTable tabla;
        OracleCommandBuilder builder;
        
        public RepositoryDepartamentosOracle(String cadenaOracle)
        {
            adaptador = new OracleDataAdapter("select * from dept", cadenaOracle);
            this.builder = new OracleCommandBuilder(adaptador);
            tabla = new DataTable();
            adaptador.Fill(tabla);
        }
        public void DeleteDepartamento(int id)
        {
            DataRow row = GetDataRowDeptNo(id);
            row.Delete();
            adaptador.Update(tabla);
            tabla.AcceptChanges();
        }
        private DataRow GetDataRowDeptNo(int iddept)
        {
            DataRow fila = tabla.AsEnumerable()
                .Where(x => x.Field<int>("DEPT_NO") == iddept).FirstOrDefault();
            return fila;
        }
        public Departamento GetDepartamento(int id)
        {
            var consulta = from datos in tabla.AsEnumerable()
                           where datos.Field<int>("DEPT_NO")==id
                           select new Departamento
                           {
                               Numero = datos.Field<int>("DEPT_NO"),
                               Nombre = datos.Field<String>("DNOMBRE"),
                               localidad = datos.Field<String>("LOC")
                           };
            return consulta.FirstOrDefault();
        }

        public List<Departamento> GetDepartamentos()
        {
            var consulta = from datos in tabla.AsEnumerable()
                           select new Departamento
                           {
                               Numero = datos.Field<int>("DEPT_NO"),
                               Nombre = datos.Field<String>("DNOMBRE"),
                               localidad = datos.Field<String>("LOC")
                           };
            return consulta.ToList();
        }

        public void InsertDepartamento(int numero, string nombre, string localidad)
        {
            DataRow row = tabla.NewRow();
            row["DEPT_NO"] = numero;
            row["DNOMBRE"] = nombre;
            row["LOC"] = localidad;
            tabla.Rows.Add(row);
            adaptador.Update(tabla);
            tabla.AcceptChanges();
        }

        public void UpdateDepartamento(int numero, string nombre, string localidad)
        {
            DataRow row = GetDataRowDeptNo(numero);
            row["DNOMBRE"] = nombre;
            row["LOC"] = localidad;
            adaptador.Update(tabla);
            tabla.AcceptChanges();
        }

        public void InsertDepartamento(int numero, string nombre, string localidad, string filename)
        {
            throw new NotImplementedException();
        }

        public void UpdateDepartamento(int numero, string nombre, string localidad, string filename)
        {
            throw new NotImplementedException();
        }
    }
}
