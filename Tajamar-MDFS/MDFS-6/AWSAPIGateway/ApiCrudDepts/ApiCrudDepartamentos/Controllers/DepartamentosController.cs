using ApiCrudDepartamentos.Models;
using ApiCrudDepartamentos.Repositories;
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

        [HttpGet]
        public ActionResult<List<Departamento>> Get()
        {
            return repo.GetDepartamentos();
        }
        [HttpGet("{id}")]
        public ActionResult<Departamento> Find(int id)
        {
            return repo.GetDepartamento(id);
        }
        [HttpPost]
        public void Create(Departamento dept)
        {
            repo.CreateDepartamento(dept.Id, dept.Nombre, dept.Localidad);
        }
        [HttpPut]
        public void Update(Departamento dept)
        {
            repo.UpdateDepartamento(dept.Id, dept.Nombre, dept.Localidad);
        }
        [HttpDelete]
        public void Delete(int id)
        {
            repo.DeleteDepartamento(id);
        }

    }
}
