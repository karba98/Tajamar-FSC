using Microsoft.AspNetCore.Mvc;
using MVCCoreApiDepts.Models;
using MVCCoreApiDepts.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCoreApiDepts.Controllers
{
    public class DepartamentosController : Controller
    {
        private ServiceDepartamentos service;
        public DepartamentosController(ServiceDepartamentos service)
        {
            this.service = service;
        }
        public IActionResult ApiClienteAjax()
        {
            return View();
        }
        public async Task<IActionResult> ApiCrudServidor()
        {
            List<Departamento> departamentos = await service.GetDepartamentos();
            return View(departamentos);
        }
        [HttpPut]
        public async Task<IActionResult> Editar(int id,String nombre, String localidad)
        {
            await service.UpdateDepartamentoAsync(id, nombre, localidad);
            return RedirectToAction("ApiCrudServidor");
        }
        [HttpPost]
        public async Task<IActionResult> Insertar(int id,String nombre, String localidad)
        {
            await service.InsertarDepartamentoAsync(id, nombre, localidad);
            return RedirectToAction("ApiCrudServidor");
        }
        public async Task<IActionResult> Borrar(int id)
        {
            await service.DeleteDepartamentoAsync(id);
            return RedirectToAction("ApiCrudServidor");
        }
        public async Task<IActionResult> Detalles(int id)
        {
            return View(await service.BuscarDepartamentoAsync(id));
        }
    }
}
