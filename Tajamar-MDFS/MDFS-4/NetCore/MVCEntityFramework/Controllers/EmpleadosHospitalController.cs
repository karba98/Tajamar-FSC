using Microsoft.AspNetCore.Mvc;
using MVCEntityFramework.Models;
using MVCEntityFramework.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCEntityFramework.Controllers
{
    public class EmpleadosHospitalController : Controller
    {
        RepositoryEmpleadosHospital repo;
        public EmpleadosHospitalController(RepositoryEmpleadosHospital repo)
        {
            this.repo = repo;
        }
        public IActionResult Index()
        {
            List<EmpleadoHospital> empleados = repo.GetEmpleadosHospital();
            return View(empleados);
        }
        public IActionResult ProcedimientoEmpleadosHospital()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ProcedimientoEmpleadosHospital(int hcod)
        {
            ProcedimientoEmpleadoHospital datos = repo.GetEmpleadosHospital(hcod);
            return View(datos);
        }
        public IActionResult TotalEmpleados()
        {
            ViewBag.destinos = repo.GetDestinosGenerico();
            return View();
        }
        [HttpPost]
        public IActionResult TotalEmpleados(int dest)
        {
            ViewBag.destinos = repo.GetDestinosGenerico();
            return View(repo.GetEmpleadosHospitalGenerico(dest));
        }
    }
}
