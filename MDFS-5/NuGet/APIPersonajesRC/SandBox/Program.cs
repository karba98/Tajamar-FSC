using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using APIPersonajesRC;
using APIPersonajesRC.Models;

namespace SandBox
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("-------------");
            List<Personaje> personajes = await GetPersonajes();
            foreach(Personaje p in personajes)
            {
                Console.WriteLine(p.Nombre);
            }
            Console.Write("-------------------");
            Console.Write("Getting personaje 5...");
            Personaje personaje = await GetPersonaje();
            Console.Write(personaje.Nombre + ", " + personaje.IdPersonaje);
        }
        static async Task<List<Personaje>> GetPersonajes()
        {
            ApiPersonsajes api = new ApiPersonsajes();
            List<Personaje> personajes = await api.GetPersonajes();
            return personajes;
        }
        static async Task<Personaje> GetPersonaje()
        {
            int id = 5;
            ApiPersonsajes api = new ApiPersonsajes();
            return await api.GetPersonaje(id);
        }
    }
}
