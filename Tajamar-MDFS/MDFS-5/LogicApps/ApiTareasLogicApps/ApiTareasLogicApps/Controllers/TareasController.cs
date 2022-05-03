using ApiTareasLogicApps.Models;
using ApiTareasLogicApps.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTareasLogicApps.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TareasController : ControllerBase
    {
        RepositoryTareas repo;
        public TareasController(RepositoryTareas repo)
        {
            this.repo = repo;
        }
        [HttpGet]
        public ActionResult<List<Tarea>> Tareas()
        {
            return repo.GetTareas();
        }
        [HttpGet]
        [Route("{id}")]
        public ActionResult<Tarea> BuscarTarea(int id)
        {
            return repo.BuscarTarea(id);
        }
        [HttpPost]
        [Route("[action]")]
        public void InsertarTarea(Tarea tarea)
        {
            this.repo.CrearTarea(tarea.Nombre, tarea.Descripcion, tarea.IdEmpleado);
        }

        [HttpGet]
        [Route("[action]/{idempleado}/tasks")]
        public ActionResult<List<Tarea>> TareasEmpleado(int idempleado)
        {
            var model = new
            {
                value = repo.GetTareasEmpleado(idempleado)

            };
            return Ok(model);
        }
    }
}
