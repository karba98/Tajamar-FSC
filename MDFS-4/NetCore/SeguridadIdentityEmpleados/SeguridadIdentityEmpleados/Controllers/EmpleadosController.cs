using Microsoft.AspNetCore.Mvc;
using SeguridadIdentityEmpleados.Filters;
using SeguridadIdentityEmpleados.Models;
using SeguridadIdentityEmpleados.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SeguridadIdentityEmpleados.Controllers
{
    public class EmpleadosController : Controller
    {
        IRepositoryEmpleados repo;
        public EmpleadosController(IRepositoryEmpleados repo)
        {
            this.repo = repo;
        }
        [AuthorizeEmpleados]
        public IActionResult Perfil()
        {
            String dato = HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            int empno = int.Parse(dato);
            Empleado emp = repo.BuscarObjetoEmpleado(empno);
            return View(emp);
        }
        [AuthorizeEmpleados]
        public IActionResult EmpleadosSubordinados()
        {
            String dato = HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            int empno = int.Parse(dato);
            List<Empleado> empleados = repo.GetSubordinados(empno);
            return View(empleados);
        }
    }
}
