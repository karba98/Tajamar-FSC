
using MvcCore.Data;
using MvcCore.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace MvcCore.Repositories
{
    public class RepositoryDepartamentosMySql : IRepositoryDepartamentos
    {
        private HospitalContext context;
        public RepositoryDepartamentosMySql(HospitalContext context)
        {
            this.context = context;
        }

        public void DeleteDepartamento(int id)
        {
            Departamento d = GetDepartamento(id);
            context.Departamentos.Remove(d);
            context.SaveChanges();
        }

        public Departamento GetDepartamento(int id)
        {
            return context.Departamentos
                .Where(x => x.Numero == id).FirstOrDefault();
        }

        public List<Departamento> GetDepartamentos()
        {
            return context.Departamentos.ToList(); ;
        }

        public void InsertDepartamento(int numero, string nombre, string localidad)
        {
            Departamento d = new Departamento();
            d.Nombre = nombre;
            d.Numero = numero;
            d.localidad = localidad;
            context.Departamentos.Add(d);
            context.SaveChanges();
        }

        public void InsertDepartamento(int numero, string nombre, string localidad, string filename)
        {
            throw new NotImplementedException();
        }

        public void UpdateDepartamento(int numero, string nombre, string localidad)
        {
            Departamento d = GetDepartamento(numero);
            d.Nombre = nombre;
            d.localidad = localidad;
            context.SaveChanges();
        }

        public void UpdateDepartamento(int numero, string nombre, string localidad, string filename)
        {
            throw new NotImplementedException();
        }
    }
}
