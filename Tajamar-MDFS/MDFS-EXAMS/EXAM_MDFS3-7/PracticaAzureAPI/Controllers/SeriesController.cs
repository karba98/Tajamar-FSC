using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PracticaAzureAPI.Models;
using PracticaAzureAPI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticaAzureAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeriesController : ControllerBase
    {
        public RepositorySeries repo;
        public SeriesController(RepositorySeries repo)
        {
            this.repo = repo;
        }
        [HttpGet]
        [Route("[action]")] 
        public ActionResult<List<Personaje>> ListaPersonajes()
        {
            List<Personaje> personajes = repo.GetPersonajes();
            return personajes;
        }
        [HttpGet]
        [Route("[action]")] 
        public ActionResult<List<Serie>> ListaSeries()
        {
            List<Serie> series = repo.GetSeries();
            return series;
        }
        [HttpGet]
        [Route("personajes/{id}")] 
        public ActionResult<Personaje> BuscarPersonaje(int id)
        {
            Personaje personaje = repo.BuscarPersonaje(id);
            return personaje;
        }
        [HttpGet]
        [Route("{id}")] 
        public ActionResult<Serie> BuscarSerie(int id)
        {
            Serie serie = repo.BuscarSerie(id);
            return serie;
        }
        [HttpGet]
        [Route("[action]/{idserie}")]
        public ActionResult<List<Personaje>> ListaPersonajesSerie(int idserie)
        {
            List<Personaje> personajes = repo.BuscarPersonajesSerie(idserie);
            return personajes;
        }
        //[Authorize]
        [HttpPost]
        [Route("NuevoPersonaje")]
        public void InsertPersonaje(Personaje p)
        {
            repo.InsertPersonaje(p.IdPersonaje, p.Nombre, p.Imagen, p.IdSerie);
        }
        //[Authorize]
        [HttpPut]
        [Route("ModificarPersonaje")]
        public void ModificarPersonaje(Personaje p)
        {
            repo.ModificarPersonaje(p.IdPersonaje, p.Nombre, p.Imagen, p.IdSerie);
        }
    }
}
