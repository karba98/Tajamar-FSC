using ApiCrudDoctores.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NugetDoctoresModelsRC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCrudDoctores.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctoresController : ControllerBase
    {
        public RepositoryDoctores repo;
        public DoctoresController(RepositoryDoctores repo)
        {
            this.repo = repo;
        }
        [HttpGet]
        public ActionResult<List<Doctor>> GetDoctores()
        {
            return repo.GetDoctores();
        }
        [HttpGet("{id}")]
        public ActionResult<Doctor> GetDoctor(int id)
        {
            return repo.BuscarDoctor(id);
        }
        [HttpPost]
        public void Insertdoctor(Doctor doctor)
        {
            repo.InsertDoctor(
                doctor.IdDoctor,doctor.Apellido,doctor.Especialidad,
                doctor.HospitalCod,doctor.Salario);
        }
        [HttpPut]
        public void UpdateDoctor(Doctor doctor)
        {
            repo.UpdateDoctor(
                doctor.IdDoctor, doctor.Apellido, doctor.Especialidad,
                doctor.HospitalCod, doctor.Salario);
        }
        [HttpDelete("{id}")]
        public void DeleteDoctor(int id)
        {
            repo.DeleteDoctor(id);
        }
        [HttpPut]
        [Route("[action]/{incremento}/{hospitalcod}")]
        public void IncrementarSalario(int incremento, int hospitalcod)
        {
            repo.IncrementarSalarioPorHospital(incremento, hospitalcod);
        }
        [HttpGet]
        [Route("especialidades")]
        public ActionResult<List<String>> GetEspecialidades()
        {
            return repo.GetEspecialidades();
        }
        [HttpGet]
        [Route("porespecialidades")]
        public ActionResult<List<Doctor>> GetDoctoresEspecialidades([FromQuery] List<String> especialidades)
        {
            return repo.GetDoctoresEspecialidades(especialidades);
        }
    }
}
