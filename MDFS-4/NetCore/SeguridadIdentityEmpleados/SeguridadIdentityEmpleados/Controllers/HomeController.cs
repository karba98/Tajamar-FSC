using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SeguridadIdentityEmpleados.Models;
using SeguridadIdentityEmpleados.Repositories;

namespace SeguridadIdentityEmpleados.Controllers
{
    public class HomeController : Controller
    {
        IRepositoryEmpleados repo;
        public HomeController(IRepositoryEmpleados repo)
        {
            this.repo = repo;
        }
        public IActionResult Index()
        {
            List<Empleado> empleados = repo.GetEmpleados();
            return View();
        }
    }
}
