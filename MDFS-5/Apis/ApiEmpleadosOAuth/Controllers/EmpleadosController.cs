using ApiEmpleadosOAuth.Models;
using ApiEmpleadosOAuth.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ApiEmpleadosOAuth.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadosController : ControllerBase
    {
        /*
         [Authorize]
        se accede con header como GET, NO pasando un body json
        header: "Authorization":"bearer TOKEN"

         */

        public RepositoryEmpleados repo;
        public EmpleadosController(RepositoryEmpleados repo)
        {
            this.repo = repo;
        }
        [Authorize]
        [HttpGet]
        public ActionResult<List<Empleado>> GetEmpleados()
        {
            return repo.GetEmpleados();
        }
        [Authorize]
        [HttpGet]
        [Route("{id}")]
        public ActionResult<Empleado> GetEmpleados(int id)
        {
            return repo.GetEmpleado(id);
        }
        [Authorize]
        [HttpGet]
        [Route("profile")]
        //ACCEDE A LAS CLAIMS Y SACA EL USUARIO
        public ActionResult<Empleado> GetProfile()
        {
            List<Claim> claims = HttpContext.User.Claims.ToList();
            String jsonuser = claims.SingleOrDefault(x => x.Type == "UserData").Value;
            Empleado empleadoUsusario = JsonConvert.DeserializeObject<Empleado>(jsonuser);
            return empleadoUsusario;
        }
        [Authorize]
        [HttpGet]
        [Route("[action]")]
        public ActionResult<List<Empleado>> Subordinados()
        {
            List<Claim> claims = HttpContext.User.Claims.ToList();
            String jsonEMpleado = claims.SingleOrDefault(x => x.Type == "UserData").Value;
            Empleado emp = JsonConvert.DeserializeObject<Empleado>(jsonEMpleado);
            return repo.GetSubordinados(emp.IdEmpleado);
        }
    }
}
