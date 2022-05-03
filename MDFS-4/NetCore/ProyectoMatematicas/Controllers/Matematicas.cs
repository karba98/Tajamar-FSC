using Microsoft.AspNetCore.Mvc;
using ProyectoMatematicas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoMatematicas.Controllers
{
    public class Matematicas : Controller
    {
        public IActionResult TablaMultiplicar()
        {
            return View();
        }
        public IActionResult SumarNumeros()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SumarNumeros(int n1, int n2) {
            ViewBag.Resultado = n1 + n2;
            return View(); 
        }
        [HttpPost]
        public IActionResult TablaMultiplicar(int num)
        {
            List<Operacion> operaciones = new List<Operacion>();
            for(int i = 0; i <= 10; i++)
            {
                Operacion o = new Operacion();
                o.n1 = num;
                o.n2 = i;
                o.result = num * i;
                operaciones.Add(o);
                
            }
            return View(operaciones);
        }
        public List<int> GenerateConjetura(int numero)
        {
            List<int> sucesion = new List<int>();
            sucesion.Add(numero);
            if (numero > 0)
            {
                while (numero != 1)
                {
                    if (numero % 2 == 0)
                    {
                        numero = numero / 2;

                    }
                    else
                    {
                        numero = (numero * 3) + 1;
                    }
                    sucesion.Add(numero);
                }
            }
            return sucesion;
        }

        public IActionResult Collatz(int numero)
        {
            List<int> numeros = new List<int>();
            for(int i = 0; i < 10; i++)
            {
                Random r = new Random();
                int n = r.Next(1, 200);
                numeros.Add(n);
            }
            ViewBag.Numeros = numeros;
            
            return View(GenerateConjetura(numero));
        }
        [HttpPost]
        public IActionResult Collatz(int numero,bool val)
        {
            List<int> numeros = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                Random r = new Random();
                int n = r.Next(1, 200);
                numeros.Add(n);
            }
            ViewBag.Numeros = numeros;
            return View(GenerateConjetura(numero));
        }
    }
}
