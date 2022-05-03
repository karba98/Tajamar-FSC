using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoCSRF.Controllers
{
    public class TiendaController : Controller
    {
        public IActionResult Productos()
        {
            if (HttpContext.Session.GetString("USUARIO") == null)
            {
                return RedirectToAction("ErrorAcceso", "Identity");
            }
            
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Productos(
            String[] productos,String direccion)
        {
            TempData["PRODUCTOS"] = productos;
            TempData["DIRECCION"] = direccion;
            return RedirectToAction("Pedidos");
        }
        public IActionResult Pedidos()
        {
            if (HttpContext.Session.GetString("USUARIO") == null)
            {
                return RedirectToAction("ErrorAcceso", "Identity");
            }
            String direccion = TempData["DIRECCION"].ToString();
            String[] productos = TempData["PRODUCTOS"] as String[];
            ViewBag.Direccion = direccion;
            return View(productos);
        }
    }
}
