using PracticaAzureAPI.Data;
using PracticaAzureAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticaAzureAPI.Repositories
{
    public class RepositorySeries
    {
        public SeriesContext context;
        public RepositorySeries(SeriesContext context)
        {
            this.context = context;
        }

        public UsuarioAzure Existeusuario(String nombre,String password) 
        {
            try
            {
                return context.Usuarios.SingleOrDefault(x => x.Nombre == nombre && x.Pass == password);
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        public List<Personaje> GetPersonajes()
        {
            return context.Personajes.ToList();
        }
        public List<Serie> GetSeries()
        {
            return context.Series.ToList();
        }
        public Serie BuscarSerie(int id)
        {
            return context.Series.SingleOrDefault(x => x.IdSerie == id);
        }
        public Personaje BuscarPersonaje(int id)
        {
            return context.Personajes.SingleOrDefault(x => x.IdPersonaje == id);
        }
        public List<Personaje> BuscarPersonajesSerie(int id)
        {
            return context.Personajes.Where(x => x.IdSerie == id).ToList() ;
        }
        public void InsertPersonaje(int id, String nombre, String imagen, int idserie)
        {
            Personaje personaje = new Personaje()
            {
                IdPersonaje = MaxIdPersonaje(),
                Nombre = nombre,
                Imagen = imagen,
                IdSerie = idserie
            };
            context.Personajes.Add(personaje);
            context.SaveChanges();
        }public void ModificarPersonaje(int id, String nombre,String imagen,int idserie)
        {
            Personaje personaje = BuscarPersonaje(id);
            personaje.IdSerie = idserie;
            personaje.Nombre = nombre;
            personaje.Imagen = imagen;
            context.SaveChanges();
        }
        private int MaxIdPersonaje()
        {
            return context.Personajes.Max(x => x.IdPersonaje)+1;
        }
    }
}
