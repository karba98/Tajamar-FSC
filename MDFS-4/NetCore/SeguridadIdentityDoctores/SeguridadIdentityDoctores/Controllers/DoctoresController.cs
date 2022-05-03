using Microsoft.AspNetCore.Mvc;
using SeguridadIdentityDoctores.Filters;
using SeguridadIdentityDoctores.Models;
using SeguridadIdentityDoctores.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SeguridadIdentityDoctores.Controllers
{
    [AuthorizeDoctores]
    public class DoctoresController : Controller
    {
        IRepositoryHospital repo;
        public DoctoresController(IRepositoryHospital repo)
        {
            this.repo = repo;
        }
        public IActionResult Perfil()
        {
            String dato = User.FindFirst(ClaimTypes.NameIdentifier).Value.ToString();
            int iddoctor = int.Parse(dato);
            Doctor doc = repo.GetDoctor(iddoctor);
            return View(doc);
        }
        public IActionResult DoctoresEspecialidad()
        {
            String dato = User.FindFirst(ClaimTypes.NameIdentifier).Value.ToString();
            int iddoctor = int.Parse(dato);
            Doctor doc = repo.GetDoctor(iddoctor);
            List<Doctor> doctores = repo.GetDoctoresEspecialidad(doc.Especialidad);
            return View(doctores);
        }
    }
}
