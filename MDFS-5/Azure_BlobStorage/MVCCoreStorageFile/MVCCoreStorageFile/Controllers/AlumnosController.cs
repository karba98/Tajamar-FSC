using Microsoft.AspNetCore.Mvc;
using MVCCoreStorageFile.Models;
using MVCCoreStorageFile.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCoreStorageFile.Controllers
{
    public class AlumnosController : Controller
    {
        public ServiceTableAlumnos service;
        public AlumnosController(ServiceTableAlumnos service)
        {
            this.service = service;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(String curso)
        {
            String token = await service.GetTokenAsync(curso);
            List<Alumno> alumnos = service.GetAlumnos(token);
            return View(alumnos);
        }
    }
}
