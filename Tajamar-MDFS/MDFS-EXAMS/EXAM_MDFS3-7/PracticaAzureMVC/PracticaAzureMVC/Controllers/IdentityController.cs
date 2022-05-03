using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PracticaAzureMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Threading.Tasks;

namespace PracticaAzureMVC.Controllers
{
    public class IdentityController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(String username, String password)
        {
            var token = GetAPIToken(username, password, "https://localhost:44328/").Result;


            if (token!=null)
            {
                ClaimsIdentity identidad =
                    new ClaimsIdentity(
                        CookieAuthenticationDefaults.AuthenticationScheme,
                        ClaimTypes.Name,
                        ClaimTypes.Role
                        );
                identidad.AddClaim(new Claim(ClaimTypes.NameIdentifier, username));
                identidad.AddClaim(new Claim(ClaimTypes.Name, username));

                identidad.AddClaim(new Claim(ClaimTypes.Authentication, token));

                ClaimsPrincipal user = new ClaimsPrincipal(identidad);
                await HttpContext.SignInAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme,
                    user,
                    new AuthenticationProperties
                    {
                        IsPersistent = true,
                        ExpiresUtc = DateTime.Now.AddMinutes(15)
                    }
                    );
                String action = TempData["action"].ToString();
                String controller = TempData["controller"].ToString();
                return RedirectToAction(action, controller);
            }
            else
            {
                ViewBag.Mensaje = "Usuario / Password Incorrectos";
                return View();
            }

        }

        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync(
                CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Home");

        }
        private static async Task<string> GetAPIToken(string userName, string password, string apiBaseUri)
        {
            using (HttpClient client = new HttpClient())
            {
                //setup client
                client.BaseAddress = new Uri(apiBaseUri);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                Login login = new Login();
                login.Username = userName;
                login.Password = password;
                String json = JsonConvert.SerializeObject(login);

                StringContent content =
                    new StringContent(json
                    , System.Text.Encoding.UTF8, "application/json");
                String peticion = "api/auth/Login";
                HttpResponseMessage response =
                    await client.PostAsync(peticion, content);
                String contenido =
                    await response.Content.ReadAsStringAsync();
                var jObject = JObject.Parse(contenido);
                return jObject.GetValue("response").ToString();
            }
        }

        

    }
}
