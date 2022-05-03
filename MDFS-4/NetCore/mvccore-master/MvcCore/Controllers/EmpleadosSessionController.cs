using Microsoft.AspNetCore.Mvc;
using MvcCore.Extensions;
using MvcCore.Helpers;
using MvcCore.Models;
using MvcCore.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCore.Controllers
{
    public class EmpleadosSessionController : Controller
    {
        IRepositoryHospital repo;
        public EmpleadosSessionController(IRepositoryHospital repo)
        {
            this.repo = repo;
        }
        public IActionResult AlmacenarEmpleados(int? id)
        {
            if(id!= null)
            {
                List<int> sessionemp;
                if (HttpContext.Session.GetObject<List<int>>("EMPLEADOS") == null)
                {
                    sessionemp = new List<int>();
                }
                else
                {
                    sessionemp = HttpContext.Session.GetObject<List<int>>("EMPLEADOS");
                }
                if (sessionemp.Contains(id.Value) == false)
                {
                    sessionemp.Add(id.GetValueOrDefault());
                    HttpContext.Session.SetObject("EMPLEADOS", sessionemp);

                }
                ViewBag.Mensaje = "Datos almacenados "+sessionemp.Count;
            }
            List<Empleado> empleados = repo.GetEmpleados();
            return View(empleados);
        }
        public IActionResult MostrarEmpleados(int? eliminar)
        {
           

            List<int> sessionemples = HttpContext.Session.GetObject<List<int>>("EMPLEADOS");
            if(sessionemples == null)
            {
                return View();
            }
            else
            {
                if (eliminar != null)
                {
                    sessionemples.Remove(eliminar.Value);
                    HttpContext.Session.SetObject("EMPLEADOS", sessionemples);
                }
                List<Empleado> empleados = repo.GetEmpleadosSession(sessionemples);
                return View(empleados);
            }
        }
        [HttpPost]
        public IActionResult MostrarEmpleados(List<int> cantidades)
        {
            List<int> ids = HttpContext.Session.GetObject<List<int>>("EMPLEADOS");
            List<Empleado> empleados = repo.GetEmpleadosSession(ids);

            //TempData["Empleados"] = ToolKit.Serialize(empleados);
            //TempData["Cantidades"] = ToolKit.Serialize(cantidades);

            //TempData["Empleados"] = empleados;
            //TempData["Cantidades"] = cantidades;

            TempData.SetTempObject("Empleados", empleados);
            TempData.SetTempObject("Cantidades", cantidades);
            
            return RedirectToAction("Pedidos");
        }
        public IActionResult Pedidos()
        {
            //ViewBag.Cantidades = ToolKit.Deserialize<List<int>>(TempData["Cantidades"].ToString());
            //return View(ToolKit.Deserialize<List<Empleado>>(TempData["Empleados"].ToString()));

            //ViewBag.Cantidades = TempData["Cantidades"];
            //return View(TempData["Empleados"] as List<Empleado>);

            ViewBag.Cantidades = TempData.GetTempObject<List<int>>("Cantidades");
            return View(TempData.GetTempObject<List<Empleado>>("Empleados"));


            //return View();
        }
        //[HttpPost]
        //public IActionResult Pedidos(List<int> cantidades)
        //{
        //    List<int> ids = HttpContext.Session.GetObject<List<int>>("EMPLEADOS");
        //    List<Empleado> empleados = repo.GetEmpleadosSession(ids);

        //    ViewBag.Cantidades = cantidades;
        //    return View(empleados);
        //}

        public IActionResult ClearCarrito()
        {
            HttpContext.Session.Remove("CANTIDADES");
            return View();
        }
    }
}
