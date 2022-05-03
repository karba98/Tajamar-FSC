using Microsoft.AspNetCore.Mvc;
using ProyectoCeroEF.Models;
using ProyectoCeroEF.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoCeroEF.Controllers
{
    public class IndexController : Controller
    {
        HospitalRepository repository;
        public IndexController(HospitalRepository repository)
        {
            this.repository = repository;
        }
        public IActionResult Index()
        {
            List <Departamento> departamentos = repository.GetDepartamentos();
            return View(departamentos);
        }
    }
}
