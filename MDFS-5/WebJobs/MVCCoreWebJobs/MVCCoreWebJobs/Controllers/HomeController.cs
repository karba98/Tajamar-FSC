using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCCoreWebJobs.Repositories;

namespace MVCCoreWebJobs.Controllers
{
    public class HomeController : Controller
    {
        RepositoryChollos repo;
        public HomeController(RepositoryChollos repo)
        {
            this.repo = repo;
        }
        public IActionResult Index()
        {
            return View(repo.GetChollos());
        }
    }
}
