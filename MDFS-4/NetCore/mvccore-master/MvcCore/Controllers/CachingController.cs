using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCore.Controllers
{
    public class CachingController : Controller
    {
        private IMemoryCache cache;
        public CachingController (IMemoryCache cache)
        {
            this.cache = cache;
        }
        public IActionResult HoraSistema(int? tiempo)
        {
            if (tiempo == null)
            {
                tiempo = 5;
            }
            String fecha = 
                DateTime.Now.ToShortDateString()+", "+
                DateTime.Now.ToLongTimeString();

            if (cache.Get("fecha") == null)
            {
                cache.Set("fecha", fecha, 
                    new MemoryCacheEntryOptions()
                    .SetAbsoluteExpiration(TimeSpan.FromSeconds(
                        tiempo.GetValueOrDefault()))) ;
                ViewBag.Fecha = cache.Get("fecha");
                ViewBag.Mensaje = "Almacenando en caché "+tiempo.Value+"s";
            }
            else
            {
                fecha = cache.Get("fecha").ToString() ;
                ViewBag.Fecha = fecha;
                ViewBag.Mensaje = "Recuperado de caché";
            }

            
            return View();
        }
        [ResponseCache(Duration = 60,VaryByQueryKeys =new string[] { "*"})]
        public IActionResult HoraSistemaDistribuida(int dato)
        {
            String fecha =
               DateTime.Now.ToShortDateString() + ", " +
               DateTime.Now.ToLongTimeString();
            ViewBag.Fecha = fecha;
            ViewBag.Dato = dato;
            return View();
        }
    }
}
