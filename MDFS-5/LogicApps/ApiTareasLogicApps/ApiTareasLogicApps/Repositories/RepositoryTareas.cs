using ApiTareasLogicApps.Data;
using ApiTareasLogicApps.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTareasLogicApps.Repositories
{
    public class RepositoryTareas
    {
        private TareasContext context;
        public RepositoryTareas(TareasContext context)
        {
            this.context = context;
        }
        public List<Tarea> GetTareas()
        {
            return this.context.Tareas.ToList();
        }
        public Tarea BuscarTarea(int id)
        {
            return this.context.Tareas.SingleOrDefault(x => x.Id == id);
        }
        private int GetMaxTarea()
        {
            return context.Tareas.Max(x => x.Id) +1;
        }
        public void CrearTarea(String nombre,String descripcion,int idEmpleado)
        {
            Tarea task = new Tarea
            {
                Id = GetMaxTarea(),
                Nombre = nombre,
                Descripcion = descripcion,
                IdEmpleado = idEmpleado,
                Estado = "NEW"
            };
            context.Tareas.Add(task);
            context.SaveChanges();
        }
        public List<Tarea> GetTareasEmpleado(int idEmpleado)
        {
            return context.Tareas.Where(x => x.IdEmpleado == idEmpleado 
                && x.Estado == "NEW").OrderByDescending(z => z.Id).ToList();
        }
    }
}
