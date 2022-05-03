using Microsoft.AspNetCore.Mvc;
using ProyectoLimpioCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoLimpioCore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Cosas()
        {
            Persona person = new Persona();
            person.nombre = "Raul";
            person.edad = 22;
            return View(person);
        }
    }

}
