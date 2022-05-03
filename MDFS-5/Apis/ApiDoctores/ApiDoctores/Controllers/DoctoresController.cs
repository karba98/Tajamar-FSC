using ApiDoctores.Models;
using ApiDoctores.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiDoctores.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctoresController : ControllerBase
    {
        RepositoryDoctores repo;
        public DoctoresController(RepositoryDoctores repo) { this.repo = repo; }
        [HttpGet]
        public ActionResult<List<Doctor>> GetDoctores()
        {
            return repo.GetDoctores();
        }
        [HttpGet("{id}")]
        public ActionResult<Doctor> GetDoctor(int id)
        {
            return repo.GetDoctor(id);
        }
        [HttpGet]
        [Route("especialidad/{especialidad}")]
        public ActionResult<List<Doctor>> GetDoctorEspecialidad(String especialidad)
        {
            return repo.GetDoctoresEspecialidad(especialidad);
        }
        [HttpGet]
        [Route("especialidades")]
        public ActionResult<List<String>> GetEspecialidades()
        {
            return repo.GetEspecialidades();
        }
        [HttpGet]
        [Route("salario/{salario}")]
        public ActionResult<List<Doctor>> GetDoctoresSalario(int salario)
        {
            return repo.GetDoctoresSalario(salario);
        }
    }
}
