using Microsoft.AspNetCore.Mvc;
using MVCCoreStorageFile.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCoreStorageFile.Controllers
{
    public class QueueController : Controller
    {
        ServiceQueueBus service;
        public QueueController(ServiceQueueBus service)
        {
            this.service = service;
        }
        public async Task<IActionResult> Index()
        {
            List<String> mensajes = await service.RecibirMensajes();
            return View(mensajes);
        }
        [HttpPost]
        public async Task<IActionResult> Index(String mensaje, String accion)
        {
            if(accion == "mensaje")
            {
                await service.SendMessage(mensaje);
            }
            else if(accion == "batch")
            {
                await service.SendBachMessages();
            }

            List<String> mensajes = await service.RecibirMensajes();
            return View(mensajes);
            
        }
    }
}
