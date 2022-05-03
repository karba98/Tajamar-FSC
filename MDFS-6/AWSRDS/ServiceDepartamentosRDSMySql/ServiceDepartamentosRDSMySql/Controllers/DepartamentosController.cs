using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceDepartamentosRDSMySql.Models;
using ServiceDepartamentosRDSMySql.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceDepartamentosRDSMySql.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartamentosController : ControllerBase
    {
        RepositoryDept repo;
        public DepartamentosController(RepositoryDept repo)
        {
            this.repo = repo;
        }
        [HttpGet]
        public List<Departamento> GteDepartamentos()
        {
            return this.repo.GetDepats();
        }
        [HttpGet("{id}")]
        public Departamento FindDept(int id)
        {
            return repo.FindDepartamento(id);
        }
    }
}
