using Microsoft.AspNetCore.Mvc;
using MVCCoreDynamoDB.Models;
using MVCCoreDynamoDB.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCoreDynamoDB.Controllers
{
    public class CochesController : Controller
    {
        ServiceAWSDynamoDB service;
        public CochesController(ServiceAWSDynamoDB service)
        {
            this.service = service;
        }
        public async Task<IActionResult> Index()
        {
            List<Coche> coches = await service.GetCoches();
            return View(coches);
        }
        [HttpPost]
        public async Task<IActionResult> Index(String marca)
        {
            if(marca == null || marca == "")
            {
                return View(await service.GetCoches());
            }
            List<Coche> coches = await service.SearchMarca(marca);
            return View(coches);
        }
        public async Task<IActionResult> Details(int id)
        {
            return View(await service.GetCoche(id));
        }
        public async Task<IActionResult> Delete(int id)
        {
            await service.Delete(id);
            return RedirectToAction("Index");
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Coche coche,String incluirmotor,
            String tipo, int caballos,int cilindrada)
        {
            if (incluirmotor != null)
            {
                coche.Motor = new Motor();
                coche.Motor.Caballos = caballos;
                coche.Motor.Cilindrada = cilindrada;
                coche.Motor.Tipo = tipo;

            }

            await service.CreateCoche(coche);
            return RedirectToAction("Index");
            
        }
    }
}
