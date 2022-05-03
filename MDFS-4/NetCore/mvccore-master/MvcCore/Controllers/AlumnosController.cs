using Microsoft.AspNetCore.Mvc;
using MvcCore.Models;
using MvcCore.Repositories;
using System.Collections.Generic;

namespace MvcCore.Controllers
{
    public class AlumnosController : Controller
    {
        private RepositoryAlumnos repo;

        public AlumnosController(RepositoryAlumnos repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {
            List<Alumno> alumnos = repo.GetAlumnos();
            return View(alumnos);
        }
        public IActionResult Details(int id)
        {
            Alumno alumno = repo.GetAlumno(id);
            return View(alumno);
        }
        public IActionResult Delete(int id)
        {
            repo.DeleteAlumno(id);
            return RedirectToAction("Index");
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Alumno alumno)
        {
            repo.InsertAlumno(alumno.IdAlumno, alumno.Nombre, alumno.Apellidos, alumno.Nota);
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            Alumno alumno = repo.GetAlumno(id);
            return View(alumno);
        } 
        [HttpPost]
        public IActionResult Edit(Alumno alumno)
        {
            repo.UpdateAlumno(alumno.IdAlumno, alumno.Nombre, alumno.Apellidos, alumno.Nota);
            return RedirectToAction("Details", new { id = alumno.IdAlumno });
        }
        
    }
}