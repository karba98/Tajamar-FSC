using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using SeguridadIdentityDoctores.Models;
using SeguridadIdentityDoctores.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SeguridadIdentityDoctores.Controllers
{
    public class IdentityController : Controller
    {
        IRepositoryHospital repo;
        public IdentityController(IRepositoryHospital repo)
        {
            this.repo = repo;
        }
        public IActionResult LogIn()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> LogIn(String username, String password)
        {
            try
            {
                Doctor doctor = repo.ExisteDoctor(username, int.Parse(password));
                if (doctor == null)
                {
                    ViewBag.Mensaje = "Usuario / Passeord Incorrecto";
                    return View();
                }
                else
                {
                    ClaimsIdentity identidad = new ClaimsIdentity(
                        CookieAuthenticationDefaults.AuthenticationScheme, 
                        ClaimTypes.Name,ClaimTypes.Role);
                    identidad.AddClaim(new Claim(ClaimTypes.NameIdentifier, doctor.IdDoctor.ToString()));
                    identidad.AddClaim(new Claim(ClaimTypes.Name, doctor.Apellido));
                    ClaimsPrincipal principal = new ClaimsPrincipal(identidad);

                    await HttpContext.SignInAsync(
                        CookieAuthenticationDefaults.AuthenticationScheme, principal, new AuthenticationProperties
                        {
                            IsPersistent = true,
                            ExpiresUtc = DateTime.Now.AddMinutes(15)
                        }) ;

                    //estatico
                    //return RedirectToAction("Perfil", "Doctores");

                    String action = TempData["action"].ToString();
                    String controller = TempData["controller"].ToString();

                    return RedirectToAction(action, controller);
                }
            }catch(Exception ex)
            {
                ViewBag.Mensaje = "Usuario / Passeord Incorrecto";
                return View();
            }
            
        }
        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Home");
        }
    }
}
