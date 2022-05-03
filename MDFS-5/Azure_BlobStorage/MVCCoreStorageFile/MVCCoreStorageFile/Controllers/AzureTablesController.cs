using Microsoft.AspNetCore.Mvc;
using MVCCoreStorageFile.Models;
using MVCCoreStorageFile.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCoreStorageFile.Controllers
{
    public class AzureTablesController : Controller
    {
        ServiceStorageTable service;
        public AzureTablesController(ServiceStorageTable service)
        {
            this.service = service;
        }
        public async Task<IActionResult> Index()
        {
            List<String> empresas = await service.GetEmpresasAsync();
            ViewBag.Empresas = empresas;
            List<Cliente> clientes = await service.GetClientesAsync(); 
            return View(clientes);
        }
        [HttpPost]
        public async Task<IActionResult> Index(String empresa)
        {
            List<String> empresas = await service.GetEmpresasAsync();
            ViewBag.Empresas = empresas;
            List<Cliente> clientes = await service.GetClientesEmpresa(empresa); 
            return View(clientes);
        }
        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Cliente cliente)
        {
            await service.CreateClientAsync(cliente.Id, cliente.Nombre, cliente.Edad, cliente.Empresa);
            return RedirectToAction("Index");
        }
    }
}
