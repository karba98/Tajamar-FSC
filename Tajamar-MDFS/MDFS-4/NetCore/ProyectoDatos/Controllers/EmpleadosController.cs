using Microsoft.AspNetCore.Mvc;
using ProyectoDatos.Data;
using ProyectoDatos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoDatos.Controllers
{
    public class EmpleadosController : Controller
    {
        EmpleadosContext context;
        public EmpleadosController()
        {
            context = new EmpleadosContext();
        }
        public IActionResult Empleados()
        {
            List<Empleado> empleados = context.GetEmpleados();
            return View(empleados);
        }
        public IActionResult DetallesEmpleado(int id)
        {
            Empleado emp = context.GetEmpleado(id);
            return View(emp);
        }
        public IActionResult BuscarEmpleSalarioOficio()
        {
            return View();
        }
        [HttpPost]
        public IActionResult BuscarEmpleSalarioOficio(int salario, String oficio)
        {
            List<Empleado> empleados = context.getEmpleadosOfiSal(salario, oficio);
            if(empleados == null)
            {
                ViewBag.Mensaje = "No existen Empleados";
                return View();
            }
            else return View(empleados);
        }
    }
}
