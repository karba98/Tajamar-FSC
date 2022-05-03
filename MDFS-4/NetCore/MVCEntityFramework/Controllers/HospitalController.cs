using Microsoft.AspNetCore.Mvc;
using MVCEntityFramework.Models;
using MVCEntityFramework.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCEntityFramework.Controllers
{
    public class HospitalController : Controller
    {
        RepositoryHospital repo;
        public HospitalController(RepositoryHospital  repo)
        {
            this.repo = repo;
        }
        public IActionResult Index()
        {
            List<Hospital> hospitales = repo.GetHospitales();
            return View(hospitales);
        }
        
       
    }
}
