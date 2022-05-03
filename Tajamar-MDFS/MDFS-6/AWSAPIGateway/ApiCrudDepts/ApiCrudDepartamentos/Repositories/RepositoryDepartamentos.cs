using ApiCrudDepartamentos.Data;
using ApiCrudDepartamentos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCrudDepartamentos.Repositories
{
    public class RepositoryDepartamentos
    {
        public DepartamentosContext context;
        public RepositoryDepartamentos(DepartamentosContext context)
        {
            this.context = context;
        }
        public List<Departamento> GetDepartamentos()
        {
            return this.context.Departamentos.ToList();
        }
        public Departamento GetDepartamento(int id)
        {
            return context.Departamentos.SingleOrDefault(x => x.Id == id);
        }
        public void DeleteDepartamento(int id)
        {
            Departamento dept = GetDepartamento(id);
            context.Departamentos.Remove(dept);
            context.SaveChanges();
        }
        public void CreateDepartamento(int id, String Nombre,String Localidad)
        {
            Departamento dept = new Departamento()
            {
                Id = id,
                Localidad = Localidad,
                Nombre = Nombre
            };
            this.context.Departamentos.Add(dept);
            this.context.SaveChanges();
        }
        public void UpdateDepartamento(int id, String Nombre, String Localidad)
        {
            Departamento dept = GetDepartamento(id);
            dept.Id = id;
            dept.Localidad = Localidad;
            dept.Nombre = Nombre;
            context.SaveChanges();
        }
    }
}
