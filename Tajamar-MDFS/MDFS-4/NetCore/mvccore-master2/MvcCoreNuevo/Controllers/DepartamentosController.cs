using Microsoft.AspNetCore.Mvc;
using MvcCoreNuevo.Models;
using MvcCoreNuevo.Repositories;
using System;
using System.Collections.Generic;

namespace MvcCoreNuevo.Controllers
{
    public class DepartamentosController : Controller
    {
        private IRepositoryHospital repo;

        public DepartamentosController(IRepositoryHospital repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details(int id)
        {
            Departamento dept = repo.GetDept(id);
            return View(dept);
        }

        public IActionResult PaginarVistaDeptRegistro(int? posicion)
        {
            if (posicion == null)
            {
                posicion = 1;
            }
            int ultimo = repo.NumeroRegistrosVistaDept();
            int siguiente = posicion.Value + 1;

            if (siguiente > ultimo)
            {
                siguiente = ultimo;
            }
            int anterior = posicion.Value - 1;
            if (anterior < 1)
            {
                anterior = 1;
            }
            VistaDept vdept = repo.GetRegistroDept(posicion.Value);
            ViewBag.anterior = anterior;
            ViewBag.ultimo = ultimo;
            ViewBag.siguiente = siguiente;

            return View(vdept);
        }

        public IActionResult PaginarVistaDeptGrupo(int? posicion)
        {
            if (posicion == null)
            {
                posicion = 1;
            }
            ViewBag.Registros = repo.NumeroRegistrosVistaDept();

            List<VistaDept> departamentos = repo.GetGrupoDept(posicion.Value);
            return View(departamentos);
        }
        public IActionResult PaginarRegistroDeptSP(int? posicion)
        {
            if (posicion == null)
            {
                posicion = 1;
            }
            int ultimo = 0;
            Departamento dept = repo.GetRegistroSP(posicion.Value, ref ultimo);
            int siguiente = posicion.Value + 1;

            if (siguiente > ultimo)
            {
                siguiente = ultimo;
            }
            int anterior = posicion.Value - 1;
            if (anterior < 1)
            {
                anterior = 1;
            }
            ViewBag.anterior = anterior;
            ViewBag.ultimo = ultimo;
            ViewBag.siguiente = siguiente;

            return View(dept);
        }
        public IActionResult PaginarGrupoDeptSP(int? posicion)
        {
            if (posicion == null)
            {
                posicion = 1;
            }
            int registros = 0;
            List<Departamento> departamentos = repo.GetGrupoDeptsp(posicion.Value, ref registros);
            ViewBag.Registros = registros;
            return View(departamentos);
        }
        public IActionResult TrabajadoresPaged(int? posicion)
        {
            if (posicion == null)
            {
                posicion = 1;
            }

            int registros = 0;
            List<Trabajador> trabajadores = repo.GetTrabajadoresGrupo(posicion.Value, ref registros);
            ViewBag.PosicionActual = posicion;
            ViewBag.Registros = registros;
            return View(trabajadores);
        }
        public IActionResult TrabajadoresPagedSalario(int? posicion, int? salario)
        {
            if (posicion == null)
            {
                posicion = 1;
            }
            if (salario == null)
            {
                salario = 0;
            }
            int registros = 0;
            List<Trabajador> trabajadores = repo.GetTrabajadoresGrupoSalario(posicion.Value, ref registros,salario.Value);
            ViewBag.Salario = salario;
            ViewBag.Registros = registros;
            ViewBag.Salario = salario;
            return View(trabajadores);
        }
        [HttpPost]
        public IActionResult TrabajadoresPagedSalario(int salario)
        {
            return RedirectToAction("TrabajadoresPagedSalario", new { posicion = 1, salario = salario });
        }
    }
}