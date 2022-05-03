using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoCSRF.Controllers
{
    public class IdentityController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(String user, String pass)
        {
            if(user.ToLower() == "admin" && pass == "admin")
            {
                HttpContext.Session.SetString("USUARIO", user);
                return RedirectToAction("Productos", "Tienda");
            }
            else
            {
                ViewBag.Mensaje = "Usuario o password incorrectos";
                return View();
            }
            
        }
        public IActionResult ErrorAcceso()
        {
            return View();
        }
    }
}
