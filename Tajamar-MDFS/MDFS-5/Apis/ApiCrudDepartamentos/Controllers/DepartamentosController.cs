using ApiCrudDepartamentos.Models;
using ApiCrudDepartamentos.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCrudDepartamentos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartamentosController : ControllerBase
    {
        RepositoryDepartamentos repo;
        public DepartamentosController(RepositoryDepartamentos repo)
        {
            this.repo = repo;
        }
        [HttpGet]

        public ActionResult<List<Departamento>> GetDepartamentos()
        {
            return repo.GetDepartamentos();
        }
        [HttpGet("{id}")]
        public ActionResult<Departamento> BuscarDepartamento(int id)
        {
            return repo.GetDepartamento(id);
        }
        [HttpPost]
        public void InsertDepartamento(Departamento dept)
        {
            repo.InsertDepartamento(dept.Id,dept.Nombre,dept.Localidad);
        }
        [HttpPut]
        public void ModificarDepartamento(Departamento dept)
        {
            repo.ModificarDepartamento(dept.Id, dept.Nombre, dept.Localidad);
        }
        [HttpDelete("{id}")]
        public void DeleteDepartamento(int id)
        {
            repo.EliminarDepartamento(id);
        }


    }
}
