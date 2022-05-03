using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProyectoCrudDepartamentos.Data;
using ProyectoCrudDepartamentos.Models;
using ProyectoCrudDepartamentos.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoCrudDepartamentos.Controllers
{
    public class HomeController : Controller
    {
        DepartamentosContext context;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            context = new DepartamentosContext();
        }

        public IActionResult Index()
        {
            return RedirectToAction("GetDepartamentos");
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

        public IActionResult GetDepartamentos()
        {
            List<Departamento> departamentos = context.GetDepartamentos();
            return View(departamentos);
        }
        public IActionResult Delete(int id)
        {
            int afectados = context.DeleteDept(id);
            return RedirectToAction("GetDepartamentos");
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(String dnombre, int dept_no, String loc)
        {
            int afectados = context.InsertDept(dnombre, dept_no, loc);
            if (afectados > 0) {
                return RedirectToAction("GetDepartamentos");
            }
            else {
                ViewBag.Mensaje = "No se pudo insertar";
                return View(); 
            }
            
        }
        public IActionResult Edit(int id)
        {
            Departamento dept = context.GetDepartamento(id);
            return View(dept);
        }
        [HttpPost]
        public IActionResult Edit(String dnombre,int dept_no,String loc)
        {
            int afectados = context.UpdateDept(dnombre, dept_no, loc);
            if (afectados > 0) 
            {
                return RedirectToAction("GetDepartamentos");
            }
            else
            {
                ViewBag.Mensaje = "Error al actualizar";
                return View(dept_no);
            }

            
        }
        public IActionResult Detalles(int id)
        {
            List<Empleado> empleados = context.GetEmpleadosDept(id);
            return View(empleados);
        }
    }
}
