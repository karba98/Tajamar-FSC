using Microsoft.AspNetCore.Mvc;
using MvcCore.Models;
using MvcCore.Repositories._4_USUARIOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCore.Controllers
{
    /*
    TABLA USUARIOS EN BD HOSPITAL
     * 
    create table USERHASH
    (IDUSUARIO int PRIMARY KEY,
    NOMBRE NVARCHAR(255),
    USUARIO NVARCHAR(255) UNIQUE,
    PASS VARBINARY(MAX),
    SALT NVARCHAR(255))
     */

    public class UsuariosController : Controller
    {
        RepositoryUsuarios repo;
        public UsuariosController(RepositoryUsuarios repo)
        {
            this.repo = repo;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Registrar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Registrar(String Nombre, String User, String Id, String Pass)
        {
            String theid = Id.Remove(0, 1);
            int id = Convert.ToInt32(theid);
            bool inserted = repo.InsertUsuario(id,Nombre,User,Pass);
            if (inserted)
            {
                ViewBag.Alert =
                    "<div class='alert alert-success' role='alert'>"+
                      "Usuario creado con exito"+
                    "</div> ";
            }
            else
            {
                ViewBag.Alert =
                    "<div class='alert alert-danger' role='alert'>" +
                      "Error al insertar" +
                    "</div> ";
            }
            return View();
        }
        public IActionResult Credenciales()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Credenciales(String User, String Pass)
        {
            Usuario exist = repo.Check(User,Pass);
            if (exist != null)
            {
                ViewBag.Alert =
                    "<div class='alert alert-success' role='alert'>" +
                      "Login correcto" +
                    "</div> ";
            }
            else
            {
                ViewBag.Alert =
                    "<div class='alert alert-danger' role='alert'>" +
                      "Credenciales no validas" +
                    "</div> ";
            }
            return View();
        }
    }
}
