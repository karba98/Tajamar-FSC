using Microsoft.AspNetCore.Mvc;
using MvcCoreNuevo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreNuevo.Controllers
{
    public class CochesController : Controller
    {
        private List<Coche> GetCoches()
        {
            Coche car = new Coche
            {
                IdCoche=1,
                Marca = "Audi",
                Modelo = "R8",
                VelocidadMaxima = 350
            };
            Coche car2 = new Coche
            {
                IdCoche = 2,
                Marca = "BMW",
                Modelo = "Serie S",
                VelocidadMaxima = 340
            };
            Coche car3 = new Coche
            {
                IdCoche = 3,
                Marca = "Msserati",
                Modelo = "Ray",
                VelocidadMaxima = 450
            };
            List<Coche> coches = new List<Coche>();
            coches.Add(car);
            coches.Add(car2);
            coches.Add(car3);

            return coches;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CochesAsincronos()
        {
            return View();
        }
        public IActionResult GetCochesPartial()
        {
            List<Coche> coches = this.GetCoches();
            return PartialView("_CochesPartial",coches);
        }
        public IActionResult DetallesCochePartial(int id)
        {
            Coche c = this.GetCoches().Where(x => x.IdCoche == id).FirstOrDefault();
            return PartialView("_DetallesCochePartial",c);
        }
    }
}
