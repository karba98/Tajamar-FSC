using ApiHospital.Models;
using ApiHospital.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiHospital.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HospitalesController : ControllerBase
    {
        RepositoryHospital repo;
        public HospitalesController(RepositoryHospital repo)
        {
            this.repo = repo;
        }
        [HttpGet]
        public ActionResult<List<Hospital>> GetHospitales()
        {
            return repo.GetHospitales();
        }
        [HttpGet("{id}")]
        public ActionResult<Hospital> GetHospital(int id)
        {
            return repo.GetHospital(id);
        }
    }
}
