using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PruebaNugets.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using CochesNuget;
using CochesNuget.Models;
using NorthWindNuGetRC;
using NorthWindNuGetRC.Models;
using APIPersonajesRC;
using APIPersonajesRC.Models;

namespace PruebaNugets.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult Coches()
        {
            Garaje garaje = new Garaje();
            List<Coche> coches = garaje.GetCoches();
            return View(coches);
        }
        public async Task<IActionResult> PruebaNugetJsonNorthwind()
        {
            NorthWindData data = new NorthWindData();
            
            return View(await data.GetCustomersList());
        }
        public async Task<IActionResult> Detalles(String id)
        {
            NorthWindData data = new NorthWindData();
            CustomerNode node = await data.GetCustomer(id);
            return View(node);
        }
        public async Task<IActionResult> Personajes()
        {
            ApiPersonsajes api = new ApiPersonsajes();
            List<Personaje> personajes = await api.GetPersonajes();
            return View(personajes);
        }
        public async Task<IActionResult> PersonajesDetalles(int id)
        {
            ApiPersonsajes api = new ApiPersonsajes();
            
            Personaje personaje = await api.GetPersonaje(id);
            return View(personaje);
        }
    }
}
