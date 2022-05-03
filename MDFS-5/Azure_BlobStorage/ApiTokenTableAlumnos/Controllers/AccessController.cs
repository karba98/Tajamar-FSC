using ApiTokenTableAlumnos.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTokenTableAlumnos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccessController : ControllerBase
    {
        ServiceTableAlumnos service;
        public AccessController(ServiceTableAlumnos service)
        {
            this.service = service;
        }
        [HttpGet]
        [Route("[action]/{curso}")]
        public ActionResult Token(String curso)
        {
            return Ok(
                new
                {
                    token = this.service.GetKeySas(curso)
                }
            );
        }
    }
}
