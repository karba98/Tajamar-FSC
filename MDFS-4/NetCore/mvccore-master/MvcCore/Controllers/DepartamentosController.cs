using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MvcCore.Helpers;
using MvcCore.Models;
using MvcCore.Repositories;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace MvcCore.Controllers
{

    public class DepartamentosController : Controller
    {
        private IRepositoryHospital repo;
        //private IRepositoryDepartamentos
        PathProvider provider;

        public DepartamentosController(IRepositoryHospital repo, PathProvider provider)
        {
            this.provider = provider;
            this.repo = repo;
        }
        //public DepartamentosController(IRepositoryDepartamentos repo)
        //{
        //    this.repo = repo;
        //}

        public IActionResult Index(bool? deleted)
        {
            if (deleted != null)
            {
                ViewBag.Deleted = true;
            }

            List<Departamento> departamentos = repo.GetDepartamentos();
            return View(departamentos);
        }

        public IActionResult Details(int id)
        {
            Departamento dep = repo.GetDepartamento(id);
            return View(dep);
        }

        public IActionResult Delete(int id)
        {
            repo.DeleteDepartamento(id);
            return RedirectToAction("Index", new { deleted = true });
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Departamento dept, IFormFile file)
        {
            string filename = file.FileName;
            string path = provider.MapPath(filename, Folders.Images);
            using (var stream = new FileStream(path,FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }
            repo.InsertDepartamento(dept.Numero, dept.Nombre, dept.localidad,filename);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            Departamento dep = repo.GetDepartamento(id);
            return View(dep);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Departamento dep,IFormFile file)
        {
            if (file != null)
            {
                string filename = file.FileName;
                string path = provider.MapPath(filename, Folders.Images);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }
                repo.UpdateDepartamento(dep.Numero, dep.Nombre, dep.localidad,filename);
                return RedirectToAction("Details", new { id = dep.Numero });
            }
            else
            {
                repo.UpdateDepartamento(dep.Numero, dep.Nombre, dep.localidad);
                return RedirectToAction("Details", new { id = dep.Numero });
            }
        }
        //IREPOSITORYHOSPITAL
        public IActionResult SeleccionMultiple()
        {
            List<Departamento> departamentos = repo.GetDepartamentos();
            List<Empleado> empleados = repo.GetEmpleados();
            ViewBag.Departamentos = departamentos;
            return View(empleados);
        }
        [HttpPost]
        public IActionResult SeleccionMultiple(List<int> iddepartamentos)
        {
            List<Departamento> departamentos = repo.GetDepartamentos();
            List<Empleado> empleados = repo.GetEmpleadosDept(iddepartamentos);
            ViewBag.Departamentos = departamentos;
            return View(empleados);
        }
    }
}