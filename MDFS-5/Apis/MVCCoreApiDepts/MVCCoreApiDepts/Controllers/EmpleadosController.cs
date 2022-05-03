using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCCoreApiDepts.Filters;
using MVCCoreApiDepts.Models;
using MVCCoreApiDepts.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCoreApiDepts.Controllers
{
    public class EmpleadosController : Controller
    {
        ServiceOAuthEmpleados service;
        public EmpleadosController(ServiceOAuthEmpleados service)
        {
            this.service = service;
        }
        [EmpleadosAuthorize]
        public async Task<IActionResult> PerfilEmpelado()
        {
            String token = HttpContext.Session.GetString("TOKEN");
            Empleado emp = await service.GetPerfil(token);
            return View(emp);
        }
        [EmpleadosAuthorize]
        public async Task<IActionResult> Subordinados()
        {
            String token = HttpContext.Session.GetString("TOKEN");
            List<Empleado> subordinados = await service.GetSubordinados(token);
            return View(subordinados);
        }
        
    }
}
