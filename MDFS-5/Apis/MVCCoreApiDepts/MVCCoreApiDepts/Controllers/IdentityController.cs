using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCCoreApiDepts.Models;
using MVCCoreApiDepts.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MVCCoreApiDepts.Controllers
{
    public class IdentityController : Controller
    {
        ServiceOAuthEmpleados service;
        public IdentityController(ServiceOAuthEmpleados service)
        {
            this.service = service;
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(String username, String password)
        {
            String token = await service.GetToken(username, password);
            if (token == null)
            {
                ViewBag.Mensaje = "Usuario/Password incorrectos";
                return View();
            }
            else
            {
                Empleado usuario = await service.GetPerfil(token);
                ClaimsIdentity identity = new ClaimsIdentity(
                    CookieAuthenticationDefaults.AuthenticationScheme,
                    ClaimTypes.Name,
                    ClaimTypes.Role);
                identity.AddClaim(new Claim(ClaimTypes.NameIdentifier, usuario.IdEmpleado.ToString()));
                identity.AddClaim(new Claim(ClaimTypes.Name, usuario.Apellido));
                ClaimsPrincipal principal = new ClaimsPrincipal(identity);
                await HttpContext.SignInAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme,principal,new AuthenticationProperties
                        {
                            IsPersistent = true,
                            ExpiresUtc = DateTime.Now.AddMinutes(10)
                        }
                    );
                HttpContext.Session.SetString("TOKEN", token);
                return RedirectToAction("PerfilEmpelado", "Empleados");
            }
            return View();
        }
        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync(
                CookieAuthenticationDefaults.AuthenticationScheme);
            if (HttpContext.Session.GetString("TOKEN") != null)
            {
                HttpContext.Session.Remove("TOKEN");
            }
            return RedirectToAction("Index", "Home");
        }
    }
}
