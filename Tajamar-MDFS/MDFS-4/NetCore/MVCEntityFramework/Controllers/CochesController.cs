using Microsoft.AspNetCore.Mvc;
using MVCEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCEntityFramework.Controllers
{
    public class CochesController : Controller
    {
        private ICoche car;
        public CochesController(ICoche car)
        {
            this.car = car;
        }
        public IActionResult Index()
        {
            return View(this.car);
        }
        [HttpPost]
        public IActionResult Index (String accion)
        {
            if (accion.ToLower() == "acelerar")
            {
                this.car.Acelerar();
            }
            else
            {
                this.car.Frenar();
            }
            return View(this.car);
        }
    }
}
