using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PracticaAdoRCastro.Data;
using PracticaAdoRCastro.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PracticaAdoRCastro.Controllers
{
    public class HomeController : Controller
    {
        LibreriaContext libcontext;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            this.libcontext = new LibreriaContext();
        }

        public IActionResult Index()
        {
            ViewBag.DefaultGenero = "Todos";
            ViewBag.generos = libcontext.GetAllGeneros();
            List<Libro> libros = libcontext.GetLibros();
            return View(libros);
        }
        [HttpPost]
        public IActionResult Index(String genero)
        {
            if (genero == "Todos")
            {
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.generos = libcontext.GetAllGeneros();
                List<Libro> libros = libcontext.GetLibrosPorGenero(genero);
                ViewBag.DefaultGenero = genero;
                return View(libros);
            }
            
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult Detalles(int idLibro)
        {
            Libro libro = libcontext.GetLibro(idLibro);
            return View(libro);
        }
        public IActionResult Update(int idLibro)
        {
            Libro libro = libcontext.GetLibro(idLibro);
            ViewBag.generos = libcontext.GetAllGeneros();
            return View(libro);
        }
        [HttpPost]
        public IActionResult Update(int id, String titulo, String Autor, String genero,String Sinopsis)
        {
            Libro libro = libcontext.GetLibro(id);
            
            int afectados = libcontext.UpdateLibro(id,titulo,Autor,libcontext.GetIdGenero(genero),Sinopsis);
            if (afectados > 0)
            {
                return RedirectToAction("Detalles", new { idLibro = id });
            }

            else
            {
                ViewBag.Error = "Error al actualizar libro";
                return View(libro);
            }
        }
        public IActionResult DeleteGenero()
        {
            List<String> generos = libcontext.GetAllGeneros();
            return View(generos);
        }
        [HttpPost]
        public IActionResult DeleteGenero(String genero)
        {
            int afectados = libcontext.DeleteGenero(genero);
            if (afectados > 0)
            {
                return RedirectToAction("Index");
            }
            else
            {

            }
            return View();
        }
        public IActionResult AddGenero()
        {
           
            return View();
        }
        [HttpPost]
        public IActionResult AddGenero(String genero)
        {
            int afectados = libcontext.AddGenero(genero,libcontext.GetLastIdGenero());
            if (afectados > 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Error = "El genero no se ha podido insertar";
                return View();
            }
            
        }
        public IActionResult AddLibro()
        {
            ViewBag.generos = libcontext.GetAllGeneros();
            return View();
        }

        [HttpPost]
        public IActionResult AddLibro(String titulo,String Autor,String genero,String Sinopsis,String imagen)
        {
            int id = libcontext.GetLastIdLibro();
            int afectados = libcontext.AddLibro(id, titulo, Autor, libcontext.GetIdGenero(genero), Sinopsis,imagen);
            if (afectados > 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.generos = libcontext.GetAllGeneros();
                ViewBag.Error = "Error al insertar";
                return View();
            }
            
        }

    }
}
