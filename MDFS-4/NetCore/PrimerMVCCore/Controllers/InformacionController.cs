using Microsoft.AspNetCore.Mvc;
using PrimerMVCCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimerMVCCore.Controllers
{
    public class InformacionController : Controller
    {
        public IActionResult Inicio()
        {
            Persona person = new Persona();
            person.edad = 20;
            person.nombre = "Daniel";
            person.email = "danie@jjf.com";
            ViewBag.Apellido = "Castro";
            ViewData["Edad"] = 22;
            return View(person);
        }
       
        public IActionResult VistaDatos(String aplicacion, int version)
        {
            ViewBag.Aplicacion = aplicacion;
            ViewBag.Version = version;
            return View();
        }
        public IActionResult VistaPOST()
        {
            return View();
        }
        [HttpPost]public IActionResult VistaPOST(Persona person)
        {
            //ViewBag.Nombre = cajanombre;
            //ViewBag.Edad = cajaedad;
            //ViewBag.Email = cajaemail;

            return View(person);
        }
        public IActionResult ObjetosPersonas()
        {
            List<Persona> personas = new List<Persona>();
            for(int i = 0; i <= 3; i++)
            {
                Persona p = new Persona();
                p.nombre = "Pepe";
                p.edad = 10;
                p.email = "pepe@you.es";
                personas.Add(p);
            }
            return View(personas);
        }
    }
}
