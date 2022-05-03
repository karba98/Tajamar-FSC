using Microsoft.AspNetCore.Mvc;
using ProyectoDatos.Data;
using ProyectoDatos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoDatos.Controllers
{
    public class HospitalesController : Controller
    {
        HospitalContext context;
        public HospitalesController()
        {
            context = new HospitalContext();
        }
        public IActionResult Index()
        {
            List<Hospital> hospitales = context.GetHospitales();
            return View(hospitales);
        }
        public IActionResult Detalles(int id)
        {
            return View(this.context.BuscarHospital(id));
        }
        public IActionResult Delete()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            int afectados = context.EliminarHospital(id);
            if (afectados > 0)
            {
                ViewData["MENSAJE"] = "Hospital Eliminado";
                return RedirectToAction("Index");
            }
            else
            {
                ViewData["MENSAJE"] = "No se encuentra el Hospital";
                return View();
            }
            
            
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(String nombre, String direccion, String telefono,int camas, int id)
        {
            int afectados = context.CrearHospital(nombre, direccion,telefono, camas, id);
            if(afectados > 0)
            {
                //return View("Index"); No funciona, no entra al controler
                //return view("Delete")funciona porque no tiene model que cargar en el model
                
                return RedirectToAction("Index"); //lee el controller Index
            }
            else
            {
                ViewBag.Mensaje = "Error al insertar";
            }
            return View();
        }
        public IActionResult Update(int id)
        {
            Hospital h = this.context.BuscarHospital(id);
            return View(h);
        }
        [HttpPost]
        public IActionResult Update(String nombre, String direccion, String telefono, int camas, int id)
        {
            try
            {
                ViewBag.Mensaje = "Modificando...";
                Hospital h = new Hospital();
                h.Nombre = nombre;
                h.Telefono = telefono;
                h.Direccion = direccion;
                h.Camas = camas;
                h.IdHospital = id;

                int afectados = this.context.ModificarHospital(h);
                if (afectados > 0)
                {
                    ViewBag.Mensaje = "Modificado con exito";
                }
                else
                {
                    ViewBag.Mensaje = "No se pudo modificar";
                }
                return RedirectToAction("Detalles",new { id=h.IdHospital});

            }
            catch(Exception ex)
            {
                ViewBag.Mensaje = "Error al Modificar";
                Hospital h = new Hospital();
                h.Nombre = "";
                h.Telefono = "";
                h.Direccion = "";
                h.Camas = 0;
                h.IdHospital = id;
                return View(h);
            }

        }

        public IActionResult HospitalDetalles()
        {
            List<Hospital> hospitales = context.GetHospitales();
            return View(hospitales);
        }
        [HttpPost]
        public IActionResult HospitalDetalles(int id)
        {
            Hospital h = this.context.BuscarHospital(id);
            ViewBag.Hospital = h;

            List<Hospital> hospitales = context.GetHospitales();
            return View(hospitales);
        }
    }
}
