using Microsoft.AspNetCore.Mvc;
using MVCEntityFramework.Models;
using MVCEntityFramework.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCEntityFramework.Controllers
{
    public class PlantillaController : Controller
    {
        RepositoryPlantilla repo;
        public PlantillaController(RepositoryPlantilla repo)
        {
            this.repo = repo;
        }
        public IActionResult Plantilla()
        {
            List<Plantilla> plantilla = repo.GetPlantilla();
            ResumenPlantilla rpla = new ResumenPlantilla();
            rpla.Empleados = plantilla;
            return View(rpla);
        }
        [HttpPost]
        public IActionResult Plantilla(int salario)
        {
            ResumenPlantilla res = repo.GetPlantillaPorSalario(salario);
            return View(res);
        }
    }
}
