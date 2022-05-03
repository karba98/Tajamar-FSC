using MVCEntityFramework.Data;
using MVCEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCEntityFramework.Repositories
{

    public class RepositoryEnfermos
    {
        private EnfermosContext context;
        public RepositoryEnfermos(EnfermosContext context)
        {
            this.context = context;
        }
        public List<Enfermo> GetEnfermos()
        {
            var consulta =
                from datos in context.Enfermos
                select datos;
            return consulta.ToList();
        }
        public Enfermo BuscarEnfermo(String inscripcion)
        {
            var consulta = from datos in context.Enfermos
                           where datos.Inscripcion == inscripcion
                           select datos;
            if (consulta.Count() == 0)
            {
                return null;
            }
            else
            {
                return consulta.First();
            }
        }
        public List<Genero> GetGeneros()
        {
            var consulta = (from datos in context.Enfermos
                            select datos.S).Distinct();
            List<Genero> generos = new List<Genero>();
            foreach(String gen in consulta)
            {
                Genero g = new Genero();
                g.Value = gen;
                if (gen.ToLower() == "f")
                {
                    g.Text = "Femenino";
                }
                else
                {
                    g.Text = "PUTOS MACHITOS";
                }
                generos.Add(g);
            }
            return generos;
        } 
        public List<Enfermo> GetEnfermosGenero(String genero)
        {
            var consulta = from datos in this.context.Enfermos
                           where datos.S == genero
                           select datos;
            return consulta.ToList();
        }
        public void EliminarEnfermo(String inscripcion)
        {
            Enfermo enfermo = BuscarEnfermo(inscripcion);
            context.Enfermos.Remove(enfermo);
            context.SaveChanges();
        }
        public void InsertarEnfermo
            (
            String inscripcion,
            String apellido,
            String direccion,
            DateTime fechanac,
            String genero, 
            String nss
            )
        {
            Enfermo enfermo = new Enfermo();
            enfermo.Apellido = apellido;
            enfermo.Inscripcion = inscripcion;
            enfermo.Fecha_Nac = fechanac;
            enfermo.S = genero;
            enfermo.Direccion = direccion;
            enfermo.NSS = nss;

            context.Enfermos.Add(enfermo);
            context.SaveChanges();
        }
        public void ModfificarEnfermo
            (
            String inscripcion,
            String apellido,
            String direccion,
            DateTime fechanac,
            String genero,
            String nss
            )
        {
            Enfermo enfermo = BuscarEnfermo(inscripcion);
            enfermo.Apellido = apellido;
            enfermo.Inscripcion = inscripcion;
            enfermo.Fecha_Nac = fechanac;
            enfermo.S = genero;
            enfermo.Direccion = direccion;
            enfermo.NSS = nss;
            context.SaveChanges();
        }


    }
}
