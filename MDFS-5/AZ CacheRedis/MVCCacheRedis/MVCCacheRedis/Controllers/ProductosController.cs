using Microsoft.AspNetCore.Mvc;
using MVCCacheRedis.Models;
using MVCCacheRedis.Repositories;
using MVCCacheRedis.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCacheRedis.Controllers
{
    public class ProductosController : Controller
    {
        RepositoryProductos repo;
        ServiceCacheRedis cache;
        public ProductosController(RepositoryProductos repo,ServiceCacheRedis cache)
        {
            this.cache = cache;
            this.repo = repo;
        }
        public IActionResult Index()
        {
            return View(this.repo.GetProductos());
        }
        public IActionResult Details(String id)
        {
            return View(this.repo.BuscarProducto(id));
        }
        public IActionResult SeleccionarFavorito(String id)
        {

            cache.AlmacenarProducto(repo.BuscarProducto(id));
            return RedirectToAction("Index");
        }
        public IActionResult Favoritos()
        {
            return View(this.cache.GetProductos());
        }
        public IActionResult Eliminar(String id)
        {
            cache.EliminarProducto(id);
            return RedirectToAction("Favoritos");
        }
    }
}
