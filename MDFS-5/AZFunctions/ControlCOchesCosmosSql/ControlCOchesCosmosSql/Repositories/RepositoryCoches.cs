using ControlCOchesCosmosSql.Data;
using ControlCOchesCosmosSql.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ControlCOchesCosmosSql.Repositories
{
    public class RepositoryCoches
    {
        CochesContext context;
        public RepositoryCoches(CochesContext context)
        {
            this.context = context;
        }
        public Coche BuscarCoche(String id)
        {
            return context.Coches.SingleOrDefault(x=>x.Id==id);
        }
        public void InsertCoche(String id, String marca, String modelo, int velocidad)
        {
            Coche car = new Coche()
            {
                Id = id,
                Marca = marca,
                Modelo = modelo,
                Velocidad = velocidad,
                Estado = "NUEVO",
                Fecha = DateTime.Now
            };
            context.Coches.Add(car);
            context.SaveChanges();
        }
        public void Modificar(String id, String marca, String modelo, int velocidad)
        {
            Coche car = BuscarCoche(id);

            car.Marca = marca;
            car.Modelo = modelo;
            car.Velocidad = velocidad;
            car.Estado = "2ª MANO";
            car.Fecha = DateTime.Now;
            context.SaveChanges();
           
        }
        public void EliminarCoche(String id)
        {
            Coche car = BuscarCoche(id);
            car.Estado = "DESTRUIDO";
            context.SaveChanges();
        }
    }
}
