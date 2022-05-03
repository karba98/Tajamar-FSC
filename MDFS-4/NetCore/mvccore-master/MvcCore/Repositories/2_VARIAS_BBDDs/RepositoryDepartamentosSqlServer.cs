using Microsoft.Extensions.Caching.Memory;
using MvcCore.Data;
using MvcCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MvcCore.Repositories
{
    public class RepositoryDepartamentosSqlServer : IRepositoryDepartamentos
    {

        private HospitalContext context;

        public RepositoryDepartamentosSqlServer(HospitalContext context)
        {
            this.context = context;
        }

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

        //AÑADIDO MEMORYCACHÉ
        public List<Departamento> GetDepartamentos()
        {
            var consulta = from datos in context.Departamentos
                           select datos;
            return consulta.ToList();
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

        public void InsertDepartamento(int numero, string nombre, string localidad, string filename)
        {
            throw new NotImplementedException();
        }

        public void UpdateDepartamento(int numero, string nombre, string localidad)
        {
            Departamento dept = GetDepartamento(numero);
            dept.Nombre = nombre;
            dept.localidad = localidad;
            context.SaveChanges();
        }

        public void UpdateDepartamento(int numero, string nombre, string localidad, string filename)
        {
            throw new NotImplementedException();
        }
    }
}