using Microsoft.AspNetCore.Mvc;
using MvcCore.Repositories;

namespace MvcCore.Controllers
{
    public class JoyeriasController : Controller
    {
        private RepositoryJoyerias repo;

        public JoyeriasController(RepositoryJoyerias repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {
            return View(repo.GetJoyerias());
        }
    }
}