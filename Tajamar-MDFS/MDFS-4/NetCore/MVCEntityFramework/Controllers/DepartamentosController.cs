using Microsoft.AspNetCore.Mvc;
using MVCEntityFramework.Data;
using MVCEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCEntityFramework.Controllers
{
    public class DepartamentosController : Controller
    {
        IDepartamentosContext context;
        public DepartamentosController(IDepartamentosContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            List<Departamento> departamentos = context.GetDepartamentos(); 
            return View(departamentos);
        }
    }
}
