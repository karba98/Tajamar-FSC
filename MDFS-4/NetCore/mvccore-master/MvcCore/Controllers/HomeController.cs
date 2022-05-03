using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MvcCore.Extensions;
using MvcCore.Helpers;
using MvcCore.Models;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MvcCore.Controllers
{
    public class HomeController : Controller
    {
        private MailService mailHelper;
        private FileService fileHelper;

        public HomeController(
            FileService fileHelper,
            MailService mailHelper)
        {
            this.mailHelper = mailHelper;
            this.fileHelper = fileHelper;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult EjemploMail()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> EjemploMail(
            String destino, String asunto, String mensaje, IFormFile fichero)
        {
            String path = null;
            if (fichero != null)
            {
                path = await fileHelper.UploadFileAsync(fichero, Folders.Temp);
            }
            bool sended = mailHelper.SendMail(destino, asunto, mensaje, path);

            if (sended)
            {
                ViewBag.Mensaje = "Mensaje Enviado";
                return View();
            }
            else
            {
                ViewBag.Mensaje = "Error al enviar mensaje";
                return View();
            }
        }

        public IActionResult CifradoHash()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CifradoHash(String contenido, String resultado, String accion)
        {
            if (contenido != null)
            {
                //prueba poniendo contenido "Hoy es miercoles" xD
                
                ViewBag.key = contenido;
                String res = CypherService.EncryptBasico(contenido);
                ViewBag.Res = res;
                if (accion.ToLower() == "comparar")
                {

                    if (resultado != res)
                    {
                        ViewData["Mensaje"] =
                            "<h1 style='color:red '>No son guales</h1>";
                    }
                    else
                    {
                        ViewData["Mensaje"] =
                           "<h1 style='color:green '>Iguales</h1>";
                    }
                }

                return View();
            }
            else
            {
                return View();
            }
        }
        public IActionResult CifradoHashEficiente()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CifradoHashEficiente(int iteraciones,String salt, String contenido,String resultado,String accion)
        {
            String res = CypherService.Encrypt(contenido, iteraciones, salt);
            ViewBag.Iter = iteraciones;
            ViewBag.key = contenido;
            ViewBag.Salt = salt;
            if (accion.ToLower() == "cifrar")
            {
                
                ViewBag.Res = res.Trim();
            }
            else if (accion.ToLower() == "comparar")

            {
                ViewBag.Res = res.Trim();
                String mensaje = "";
                if(res == resultado.Trim())
                {
                    mensaje = "<h1 style='color:green'>Iguales</h1>";

                }
                else
                {
                    mensaje = "<h1 style='color:red'>No son Iguales</h1>";

                }
                ViewBag.Mensaje = mensaje;
            }
            return View();
        }
        public IActionResult EjemploSession(String accion)
        {
            if(accion ==null || accion == "almacenar")
            {
                Persona p = new Persona();
                p.Nombre = "Alumno";
                p.Edad = 22;
                p.Hora = DateTime.Now.ToLongTimeString();

                HttpContext.Session.SetObject("persona", p);

                //String data = ToolKit.Serialize(p);
                //HttpContext.Session.SetString("persona", data);

                //SESSION OBSOLETISIMO
                //byte[] datos = ToolKit.ObjectToByteArray(p);
                //HttpContext.Session.Set("persona", datos);

                ViewBag.Mensaje = "Datos almacenados en session: " + DateTime.Now.ToLongTimeString();

                //HttpContext.Session.SetString("autor", "YourName");
                //HttpContext.Session.SetString("hora", DateTime.Now.ToLongTimeString());
                //ViewBag.Mensaje = "Datos almacenados en session: " + DateTime.Now.ToLongTimeString();


            }
            else if(accion == "mostrar")
            {
                //SESSION OBSOLETISIMO
                //byte[] datos = HttpContext.Session.Get("persona");
                //Persona p = ToolKit.ByteArrayToObject(datos) as Persona;

                //String datos = HttpContext.Session.GetString("persona");
                //Persona p = ToolKit.Deserialize<Persona>(datos);

                Persona p = HttpContext.Session.GetObject<Persona>("persona");
                if (p == null) return View();

               
                ViewBag.Autor = p.Nombre;
                ViewBag.Hora = p.Hora;
                ViewBag.Mensaje = "Mostrando datos";

                //ViewBag.Autor = HttpContext.Session.GetString("autor");
                //ViewBag.Hora = HttpContext.Session.GetString("hora");
                //ViewBag.Mensaje = "Mostrando datos";
            }
            return View();
        }
        public IActionResult EjemploSessionList(String accion)
        {
            List<Persona> personas = new List<Persona>();
            if (accion == null || accion == "almacenar")
            {
                
                for(int i = 0; i < 10; i++)
                {
                    Persona p = new Persona();
                    p.Nombre = "Alumno";
                    p.Edad = 22;
                    p.Hora = DateTime.Now.ToLongTimeString();
                    personas.Add(p);
                }


                //String persons = ToolKit.Serialize(personas);
                //HttpContext.Session.SetString("personas", persons);

                HttpContext.Session.SetObject("personas", personas);

                //byte[] datos = ToolKit.ObjectToByteArray(personas);
                //HttpContext.Session.Set("personas", datos);

                ViewBag.Mensaje = "Datos almacenados en session: " + DateTime.Now.ToLongTimeString();
                return View();
            }
            else if (accion == "mostrar")
            {
                //byte[] datos = HttpContext.Session.Get("personas");
                //personas = ToolKit.ByteArrayToObject(datos) as List<Persona>;

                //String data = HttpContext.Session.GetString("personas");
                //personas = ToolKit.Deserialize<List<Persona>>(data);

                personas = HttpContext.Session.GetObject<List<Persona>>("personas");
                if (personas == null) return View();
                
                
                ViewBag.Mensaje = "Mostrando datos";
                return View(personas);
            }
            return View();
        }
    }
    
}