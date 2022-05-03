using Microsoft.AspNetCore.Mvc;
using MVCSender.Models;
using MVCSender.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCSender.Controllers
{
    public class AWSMessagesController : Controller
    {
        private ServiceSQS service;
        public AWSMessagesController(ServiceSQS service)
        {
            this.service = service;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(MensajeUsuario mensajeUsuario)
        {
            mensajeUsuario.Fecha = DateTime.Now;
            bool respuesta = await service.SendMessageAsync(mensajeUsuario);
            if (respuesta) ViewBag.Mensaje = "Enviado con exito";
            else ViewBag.Mensaje = "No se pudo enviar el mensaje";
            return View();
        }
    }
}
