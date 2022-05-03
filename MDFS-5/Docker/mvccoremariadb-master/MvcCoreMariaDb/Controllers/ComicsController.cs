using Microsoft.AspNetCore.Mvc;
using MvcCoreMariaDb.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreMariaDb.Controllers
{
    public class ComicsController : Controller
    {
        RepositoryComics repo;

        public ComicsController(RepositoryComics repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {
            return View(this.repo.GetComics());
        }
    }
}
