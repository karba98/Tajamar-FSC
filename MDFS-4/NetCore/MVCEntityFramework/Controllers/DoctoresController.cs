using Microsoft.AspNetCore.Mvc;
using MVCEntityFramework.Models;
using MVCEntityFramework.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCEntityFramework.Controllers
{
    public class DoctoresController : Controller
    {
        RepositoryDoctores repo;
        public DoctoresController(RepositoryDoctores repo)
        {
            this.repo = repo;
        }
        public IActionResult Index()
        {
            List<Doctor> doctores = repo.GetDoctores();
            return View(doctores);
        }
        [HttpPost]
        public IActionResult Index(int doctor, String Especialidad)
        {
            this.repo.UpdateEspecialidad(doctor, Especialidad);
            List<Doctor> doctores = repo.GetDoctores();
            return View(doctores);
        }
        public IActionResult DocsEspecialidad(String ? especialidad)
        {   
            if(especialidad != null)
            {
                List<Doctor> doctores = repo.GetDoctoresEspecialidad(especialidad);
                ViewBag.especialidades = repo.GetEspecialidades();
                return View(doctores);
            }
            else
            {
                List<Doctor> doctores = repo.GetDoctores();
                ViewBag.especialidades = repo.GetEspecialidades();
                return View(doctores);
            }
        }
        [HttpPost]
        public IActionResult DocsEspecialidad(String espe,bool s)
        {
            List<Doctor> doctores = repo.GetDoctoresEspecialidad(espe);
            ViewBag.especialidades = repo.GetEspecialidades();
            return View(doctores);
        }
        public IActionResult UpdateSalario()
        {
            ViewBag.especialidades = repo.GetEspecialidades();
            return View();
        }
        [HttpPost]
        public IActionResult UpdateSalario(String espe, int incremento)
        {
            repo.UpdateSalarioEspecialidad(incremento, espe);
            return RedirectToAction("DocsEspecialidad", new { especialidad = espe});
        }
    }
}
