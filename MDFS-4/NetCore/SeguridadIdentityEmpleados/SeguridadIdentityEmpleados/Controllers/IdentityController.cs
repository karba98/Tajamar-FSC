using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using SeguridadIdentityEmpleados.Models;
using SeguridadIdentityEmpleados.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SeguridadIdentityEmpleados.Controllers
{
    public class IdentityController : Controller
    {
        IRepositoryEmpleados repo;
        public IdentityController(IRepositoryEmpleados repo)
        {
            this.repo = repo;
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(String apellido, int idempleado)
        {
            Empleado emp = repo.GetEmpleado(apellido, idempleado);
            if(emp == null)
            {
                ViewBag.Error = "Error al acceder";
            }
            else
            {
                ClaimsIdentity identity = new ClaimsIdentity(
                    CookieAuthenticationDefaults.AuthenticationScheme, ClaimTypes.Name, ClaimTypes.Role);
                identity.AddClaim(new Claim(ClaimTypes.NameIdentifier,idempleado.ToString()));
                identity.AddClaim(new Claim(ClaimTypes.Name, apellido));
                identity.AddClaim(new Claim(ClaimTypes.Role, emp.Oficio));

                ClaimsPrincipal principal = new ClaimsPrincipal(identity);
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                    principal,
                    new AuthenticationProperties
                    {
                        IsPersistent = true,
                        ExpiresUtc = DateTime.Now.AddMinutes(10)
                    }) ;

                String action = TempData["action"].ToString();
                String controller = TempData["controller"].ToString();
                return RedirectToAction(action,controller);
                
            }
            return View();
        }
        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync(
                CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Home");

        }
    
        public IActionResult AccesoDenegado()
        {
            return View();
        }
    }
}
