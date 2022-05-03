using ApiCrudDepartamentos.Data;
using ApiCrudDepartamentos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCrudDepartamentos.Repository
{
    public class RepositoryDepartamentos
    {
        DepartamentosContext context;
        public RepositoryDepartamentos(DepartamentosContext context)
        {
            this.context = context;
        }
        public List<Departamento> GetDepartamentos()
        {
            return context.Departamentos.ToList();
        }
        public  Departamento GetDepartamento(int id)
        {
            return context.Departamentos.SingleOrDefault(x => x.Id == id);
        }
        public void InsertDepartamento(int id,String Nombre,String Localidad)
        {
            Departamento dept = new Departamento
            {
                Id = id,
                Nombre = Nombre,
                Localidad = Localidad
            };
            context.Departamentos.Add(dept);
            context.SaveChanges();
        }
        public void ModificarDepartamento(int id, String Nombre,String localidad)
        {
            Departamento dept = GetDepartamento(id);
            dept.Nombre = Nombre;
            dept.Localidad = localidad;
            context.SaveChanges();
        }
        public void EliminarDepartamento(int id)
        {
            Departamento dept = GetDepartamento(id);
            context.Departamentos.Remove(dept);
            context.SaveChanges();
        }
    }
}
