using RetoMVC.Models;
using RetoMVC.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RetoMVC.Controllers
{

    public class HomeController : Controller
    {
        RepositoryPlantilla repo;
        public HomeController(RepositoryPlantilla repo)
        {
            this.repo = repo;
        }
        public ActionResult Index()
        {
            List <Empleado> empleados = repo.GetEmpleados();
            return View(empleados);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}