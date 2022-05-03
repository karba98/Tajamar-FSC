using Microsoft.AspNetCore.Mvc;
using MVCCoreApis.Models;
using MVCCoreApis.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCoreApis.Controllers
{
    public class DoctoresController : Controller
    {
        ServiceApiDoctores service;
        public DoctoresController(ServiceApiDoctores service)
        {
            this.service = service;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult DoctoresCliente()
        {
            //leemos doctores con Ajax en script
            return View();
        }
        public async Task<IActionResult> DoctoresServidor()
        {
            List<Doctor> doctores = await this.service.GetDoctoresAsync();
            List<String> especialidades = await service.GetEspecialidadesAsync();
            ViewBag.Especialidades = especialidades;
            return View(doctores);
        }
        [HttpPost]
        public async Task<IActionResult> DoctoresServidor(String especialidad)
        {
            List<Doctor> doctores = await service.GetDoctoresEspecialidadAsync(especialidad);
            List<String> especialidades = await service.GetEspecialidadesAsync();
            ViewBag.Especialidades = especialidades;
            return View(doctores);
        }
        public async Task<IActionResult> DetallesDoctorServidor(int id)
        {
            Doctor doc = await service.GetDoctor(id);
            return View(doc);
        }
        public IActionResult DetallesDoctorCliente(int id)
        {
            ViewBag.id = id;
            return View();
        }
    }
}
