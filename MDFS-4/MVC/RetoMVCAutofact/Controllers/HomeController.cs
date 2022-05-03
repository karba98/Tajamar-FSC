using RetoMVCAutofac.Models;
using RetoMVCAutofac.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RetoMVCAutofac.Controllers
{
    public class HomeController : Controller
    {
        RepositoryEmpleados repo;
        public HomeController(RepositoryEmpleados repo)
        {
            this.repo = repo;
        }
        public ActionResult Index()
        {
            List<Empleado> empleados = this.repo.GetEmpleados();
            return View(empleados);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}