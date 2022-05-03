using Microsoft.AspNetCore.Mvc;
using MVCEntityFramework.Models;
using MVCEntityFramework.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCEntityFramework.Controllers
{
    public class EmpleadosController : Controller
    {
        RepositoryEmpleados repo;
        public EmpleadosController (RepositoryEmpleados repo)
        {
            this.repo = repo;
        }
        public IActionResult Empleados(String oficio)
        {
            if(oficio != null)
            {
                ViewBag.oficios = repo.GetOficios();
                List<Empleado> empleados = repo.GetEmpleadosOficio(oficio);
                return View(empleados);
            }
            else
            {
                ViewBag.oficios = repo.GetOficios();
                List<Empleado> empleados = repo.GetEmpleados();
                return View(empleados);
            }
        }
        [HttpPost]
        public IActionResult Empleados(String oficio, int incremento)
        {
            if(oficio == "Todos")
            {
                return RedirectToAction("Empleados");
            }
            else
            {
                ViewBag.oficios = repo.GetOficios();
                repo.IncrementSalario(oficio, incremento);
                return RedirectToAction("Empleados", new { oficio = oficio });
            }
        }
        public IActionResult EmpleadosDeptLambda()
        {
            return View();
        }
        [HttpPost]
        public IActionResult EmpleadosDeptLambda(int dept)
        {
            ResumenDepartamento resumen = repo.GettEmpleadosDepartamento(dept);
            return View(resumen);
        }
    }
}
