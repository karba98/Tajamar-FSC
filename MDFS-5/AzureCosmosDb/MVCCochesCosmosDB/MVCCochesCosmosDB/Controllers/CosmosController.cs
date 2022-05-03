using Microsoft.AspNetCore.Mvc;
using MVCCochesCosmosDB.Models;
using MVCCochesCosmosDB.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCochesCosmosDB.Controllers
{
    public class CosmosController : Controller
    {
        ServiceCosmosDb service;
        public CosmosController(ServiceCosmosDb service)
        {
            this.service = service;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(String accino)
        {
            await service.CrearBBDDVehiculosAsync();
            await service.CrearColeccionVehiculosAsync();
            List<Vehiculo> coches = this.service.CrearCoches();
            foreach(Vehiculo car in coches)
            {
                await service.InsertarVehiculoAsync(car);
            }
            ViewBag.mensaje = "todo iniciado";
            return View();

        }
        public IActionResult ListCoches()
        {
            return View(service.GetVehiculos());
        }
        public async Task<IActionResult> DetallesCoche(String id)
        {
            return View(await service.FindVehiculo(id));
        }
        public async Task<IActionResult> InsertarVehiculo()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> InsertarVehiculo(Vehiculo car,String motor)
        {
            if (motor != null)
            {
                car.Motor= new Motor() {Caballos=100,Potencia=100,Tipo="De fabrica" };
               
            }
            await service.InsertarVehiculoAsync(car);
            return RedirectToAction("ListCoches");
        }
        public async Task<IActionResult> DeleteVehiculo(String id)
        {
            await service.EliminarVehiculo(id);
            return RedirectToAction("ListCoches");
        }
        public async Task<IActionResult> EditVehiculo(String id)
        {
           
            return View(await service.FindVehiculo(id));
        }
        [HttpPost]
        public async Task<IActionResult> EditVehiculo(Vehiculo car, String motor)
        {
            if (motor != null)
            {
                car.Motor = new Motor() { Caballos = 100, Potencia = 100, Tipo = "De fabrica" };

            }
            await service.ModificarVehiculo(car);
            return RedirectToAction("ListCoches");
        }
    }
}
