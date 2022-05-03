using Microsoft.AspNetCore.Mvc;
using MVCCoreApiDepts.Services;
using NugetDoctoresModelsRC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCoreApiDepts.Controllers
{
    public class DoctoresController : Controller
    {
        public ServiceDoctores service;
        public DoctoresController(ServiceDoctores service)
        {
            this.service = service;
        }
        public async Task<IActionResult> Index()
        {
            return View(await service.GetDoctores());
        }
        [HttpPost]
        public async Task<IActionResult> Index(int incremento, int hospitalcod)
        {
            await service.IncrementoSalarioHospitalAsync(incremento, hospitalcod);
            return RedirectToAction("Index");

        }
        public async Task<IActionResult> Detalles(int id)
        {
            return View(await service.GetDoctor(id));
        }
        public async Task<IActionResult> Edit(int id)
        {
            return View(await service.GetDoctor(id));
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Doctor doctor)
        {
            await service.UpdateDoctorAsync(doctor.IdDoctor, doctor.Apellido, doctor.Especialidad, doctor.HospitalCod, doctor.Salario);
            return RedirectToAction("Detalles", new { id = doctor.IdDoctor });
        }
        public async Task<IActionResult> Insert(int id)
        {
            return View(await service.GetDoctor(id));
        }
        [HttpPost]
        public async Task<IActionResult> Insert(Doctor doctor)
        {
            await service.InsertDoctorAsync(doctor.IdDoctor, doctor.Apellido, doctor.Especialidad, doctor.HospitalCod, doctor.Salario);
            return RedirectToAction("Detalles", new { id = doctor.IdDoctor });
        }
        public async Task<IActionResult> Delete(int id)
        {
            await service.DeleteDoctorAsync(id);
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> DoctoresEspecialidad()
        {
            ViewBag.Especialidades = await service.GetEspecialidadesAsync();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> DoctoresEspecialidad(List<String> especialidades)
        {
            ViewBag.Especialidades = await service.GetEspecialidadesAsync();
            List<Doctor> doctores = await service.GetDoctoresEspecialidadesAsync(especialidades);
            return View(doctores);
        }
    }
}
