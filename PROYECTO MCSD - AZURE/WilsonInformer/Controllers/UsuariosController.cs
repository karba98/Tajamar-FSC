using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Security.Claims;
using System.Threading.Tasks;
using WilsonInformer.Extensions;
using WilsonInformer.Filter;
using WilsonInformer.Models;
using WilsonInformer.Services;

namespace WilsonInformer.Controllers
{

    public class UsuariosController : Controller
    {
        private ServiceUsers service;
        public UsuariosController(ServiceUsers service)
        {
            this.service = service;
        }

        public IActionResult Index()
        {
            return View();
        }

        [AuthorizeUsers]
        public IActionResult Registrar()
        {
            return View();
        }

        [AuthorizeUsers]
        [HttpPost]
        public async Task<IActionResult> Registrar(String Nombre, String User, String Id, String Pass, String Apellido, String Email, String Rol, String repeatpass)
        {
            if (Nombre == "" || User == "" || Pass == "" || Apellido == "" || Email == "" ||
                Nombre == null || User == null || Pass == null || Apellido == null || Email == null)
            {
                ViewBag.Alert =
                       "<div class='alert alert-danger' style='height:50px' role='alert'>" +
                         "Hay campos sin rellenar" +
                       "</div> ";
                return View();
            }
            else if (repeatpass != Pass)
            {
                ViewBag.ErrorRepeatPass = "Las contraseñas no coinciden";
                return View();
            }
            else
            {
                
                bool exist = await service.Exist(User,Email,HttpContext.User.FindFirstValue("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier"));
                if (exist)
                {
                    ViewBag.ErrorUser = "Este usuario ya existe";
                    return View();
                }
                
                else
                {
                    bool inserted = await service.InsertUser(Nombre, User, Pass, Apellido, Email, Rol, 
                        HttpContext.User.FindFirstValue("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier"),
                        HttpContext.User.FindFirstValue("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress"));
                    if (inserted)
                    {
                        ViewBag.Alert =
                            "<div class='alert alert-success' style='height:50px' role='alert'>" +
                              "Usuario creado con exito" +
                            "</div> ";
                    }
                    else
                    {
                        ViewBag.Alert =
                            "<div class='alert alert-danger' style='height:50px' role='alert'>" +
                              "Error al crear usuario. El email o Nombre de usuario ya existe" +
                            "</div> ";
                    }
                }
                return View();
            }
        }

        public IActionResult Credenciales()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Credenciales(String User, String Pass)
        {
            Usuario user =  await service.Check(User, Pass);
            if (user != null && user.Token != "")
            {
                
                ClaimsIdentity identidad = new ClaimsIdentity(
                        CookieAuthenticationDefaults.AuthenticationScheme,
                        ClaimTypes.Name, ClaimTypes.Role);
                identidad.AddClaim(new Claim(ClaimTypes.NameIdentifier, user.Token));
                identidad.AddClaim(new Claim(ClaimTypes.Name, user.User));
                identidad.AddClaim(new Claim(ClaimTypes.Role, user.Rol));
                identidad.AddClaim(new Claim(ClaimTypes.Email, user.Email));
                //identidad.AddClaim(new Claim(ClaimTypes.Hash,user.Token));
                ClaimsPrincipal principal = new ClaimsPrincipal(identidad);
                await HttpContext.SignInAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme, principal, new AuthenticationProperties
                    {
                        IsPersistent = true,
                        ExpiresUtc = DateTime.Now.AddMinutes(15)
                    });


                String action = TempData["action"].ToString();
                String controller = TempData["controller"].ToString();
                return RedirectToAction(action, controller);
            }
            else
            {
                ViewBag.Alert =
                    "<div class='alert alert-danger' style='height:50px;margin:10px;width:100%' role='alert'>" +
                      "Credenciales no validas" +
                    "</div> ";
                return View();
            }
        }

        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Partes");
        }

        public IActionResult AccesoDenegado()
        {
            return View();
        }
    }
}