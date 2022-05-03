using Microsoft.AspNetCore.Mvc;
using MVCEntityFramework.Models;
using MVCEntityFramework.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCEntityFramework.Controllers
{
    public class EnfermosController : Controller
    {
        RepositoryEnfermos repo;
        public EnfermosController(RepositoryEnfermos repo)
        {
            this.repo = repo;
        }
        public IActionResult Index()
        {
            ViewBag.Generos = repo.GetGeneros();
            List<Enfermo> enfermos = repo.GetEnfermos();
            return View(enfermos);
        }
        
        public IActionResult EnfermosGenero(String genero)
        {
            if (genero != null)
            {
                List<Enfermo> enfermos = repo.GetEnfermosGenero(genero);
                ViewBag.Generos = repo.GetGeneros();
                return View(enfermos);
            }
            else
            {
                ViewBag.Generos = repo.GetGeneros();
                return View();
            }
        }
        public IActionResult Detalles(String inscripcion)
        {
            Enfermo enfermo = repo.BuscarEnfermo(inscripcion);
            return View(enfermo);
        }
        public IActionResult Eliminar(String inscripcion)
        {
            repo.EliminarEnfermo(inscripcion);
            return RedirectToAction("Index");
        }
        public IActionResult Insertar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Insertar(
            String inscripcion,
            String apellido,
            String direccion,
            DateTime fechanac,
            String genero,
            String nss)
        {

            repo.InsertarEnfermo(inscripcion, apellido, direccion, fechanac, genero, nss);
            return RedirectToAction("Index");
        }
        public IActionResult Modificar(String inscripcion)
        {
            Enfermo enf = repo.BuscarEnfermo(inscripcion);
            return View(enf);
        }
        [HttpPost]
        public IActionResult Modificar(
            String inscripcion,
            String apellido,
            String direccion,
            DateTime fechanac,
            String genero,
            String nss)
        {
            repo.ModfificarEnfermo(inscripcion, apellido, direccion, fechanac, genero, nss);
            return RedirectToAction("Detalles",new { inscripcion = inscripcion});
        }
    }
}
