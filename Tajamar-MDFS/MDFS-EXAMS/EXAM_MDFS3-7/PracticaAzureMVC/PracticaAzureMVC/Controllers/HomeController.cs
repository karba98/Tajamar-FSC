using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PracticaAzureMVC.Filters;
using PracticaAzureMVC.Models;
using PracticaAzureMVC.Services;

namespace PracticaAzureMVC.Controllers
{
    public class HomeController : Controller
    {
        ServiceSeries service;
        public HomeController(ServiceSeries service)
        {
            this.service = service;
        }
        public async Task<IActionResult> Index()
        {
            List<Serie> series = await service.GetSeriesAsync();
            return View(series);
        }
        public async Task<IActionResult> Details(int id)
        {
            List<Personaje> personajes = await service.GetPersonajesSerieAsync(id);
            Serie serie = await service.GetSerieAsync(id);
            ViewBag.Serie = serie.Nombre;
            return View(personajes);
        }
        //[AuthorizeUsers]
        public async Task<IActionResult> Edit(int id)
        {
            Personaje personaje = await service.GetPersonajeAsync(id);
            List<Serie> series = await service.GetSeriesAsync();
            ViewBag.Series = series;
            return View(personaje);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Personaje personaje)
        {
            //String token = HttpContext.User.Claims.First(x => x.Type == "Authentication").Value;
            await service.ModificarPersonajeAsync(personaje.IdPersonaje, personaje.Nombre, personaje.Imagen, 
                personaje.IdSerie);
            return RedirectToAction("Details",new { id=personaje.IdSerie});
        }
        //[AuthorizeUsers]
        public async Task<IActionResult> Create()
        {
            
            List<Serie> series = await service.GetSeriesAsync();
            ViewBag.Series = series;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Personaje personaje)
        {
            
            await service.InsertarPersonajeAsync(personaje.Nombre, personaje.Imagen, personaje.IdSerie
               ) ;
            return RedirectToAction("Details", new { id = personaje.IdSerie });
        }
        
    }
}
