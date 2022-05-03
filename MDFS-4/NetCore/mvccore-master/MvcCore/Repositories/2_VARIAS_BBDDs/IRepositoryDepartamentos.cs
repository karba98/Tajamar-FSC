using MvcCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCore.Repositories
{
    public interface IRepositoryDepartamentos
    {
        List<Departamento> GetDepartamentos();
        Departamento GetDepartamento(int id);
        void DeleteDepartamento(int id);
        void InsertDepartamento(int numero, String nombre, String localidad);
        void InsertDepartamento(int numero, String nombre, String localidad,String filename);
        void UpdateDepartamento(int numero, String nombre, String localidad);
        void UpdateDepartamento(int numero, String nombre, String localidad, String filename);
    }
}
