using Microsoft.Extensions.Caching.Memory;
using MvcCore.Data;
using MvcCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCore.Repositories
{
    public class RepositoryHospitalSqlServer : IRepositoryHospital
    {
        private HospitalContext context;
        private IMemoryCache cache;

        public RepositoryHospitalSqlServer(HospitalContext context, IMemoryCache cache)
        {
            this.cache = cache;
            this.context = context;
        }
        #region DEPARTAMENTOS SQLSERVER
        public void DeleteDepartamento(int id)
        {
            Departamento dept = GetDepartamento(id);
            context.Departamentos.Remove(dept);
            context.SaveChanges();
        }

        public Departamento GetDepartamento(int id)
        {
            return this.context.Departamentos.Where(x => x.Numero == id).FirstOrDefault();
        }

        public List<Departamento> GetDepartamentos()
        {
            //ADD CACHÉ

            //var consulta = from datos in context.Departamentos
            //               select datos;
            //return consulta.ToList();

            if (cache.Get("departamentos") == null)
            {
                var consulta = from datos in context.Departamentos
                               select datos;
                cache.Set("departamentos", consulta.ToList());
                return consulta.ToList();
            }
            else
            {
                return cache.Get("departamentos") as List<Departamento>;
            }
        }

        

        public void InsertDepartamento(int numero, string nombre, string localidad)
        {
            Departamento dept = new Departamento();
            dept.Nombre = nombre;
            dept.Numero = numero;
            dept.localidad = localidad;
            context.Departamentos.Add(dept);
            context.SaveChanges();
        }

        public void UpdateDepartamento(int numero, string nombre, string localidad)
        {
            Departamento dept = GetDepartamento(numero);
            dept.Nombre = nombre;
            dept.localidad = localidad;
            context.SaveChanges();
        }
        #endregion
        #region EMPLEADOS SQLSERVER
        public List<Empleado> GetEmpleados()
        {
            return context.Empleados.OrderBy(z=>z.Dept_no).ToList();
        }

        public List<Empleado> GetEmpleadosDept(List<int> ids)
        {
            var consulta = from datos in context.Empleados
                           where ids.Contains(datos.Dept_no)
                           select datos;
            return consulta.ToList();
        }


        #endregion

        public void InsertDepartamento(int numero, string nombre, string localidad, string filename)
        {
            Departamento dept = new Departamento();
            dept.Nombre = nombre;
            dept.Numero = numero;
            dept.localidad = localidad;
            dept.Imagen = filename;
            context.Departamentos.Add(dept);
            context.SaveChanges();
        }

        public void UpdateDepartamento(int numero, string nombre, string localidad, string filename)
        {
            Departamento dept = GetDepartamento(numero);
            dept.Nombre = nombre;
            dept.localidad = localidad;
            dept.Imagen = filename;
            context.SaveChanges();
        }

        public List<Empleado> GetEmpleadosSession(List<int> idsempleados)
        {
            //var consulta = from datos in context.Empleados
            //               where idsempleados.Contains(datos.IDEmpelado)
            //               select datos;
            return context.Empleados.Where(x => idsempleados.Contains(x.IDEmpelado)).ToList();
        }

       
    }
}
