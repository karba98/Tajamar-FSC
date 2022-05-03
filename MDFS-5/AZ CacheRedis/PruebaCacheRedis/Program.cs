using System;
using System.Collections.Generic;

namespace PruebaCacheRedis
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceCacheRedis service = new ServiceCacheRedis();
            String fin = "n";
            while(fin!= "y")
            {
                List<Producto> productos = service.GetProductos();
                if(productos == null)
                {
                    Console.WriteLine("No hay porductos");
                }
                else
                {
                    foreach(Producto p in productos)
                    {
                        int i = 1;
                        Console.WriteLine(i+" "+p.Nombre);
                        i++;
                    }
                    Console.WriteLine("----------------");
                }
                Console.WriteLine("¿Desea finalizar la consulta? (y/n)");
                fin = Console.ReadLine().ToLower();
            }
            Console.WriteLine("Hasta la proxima!");
        }
    }
}
