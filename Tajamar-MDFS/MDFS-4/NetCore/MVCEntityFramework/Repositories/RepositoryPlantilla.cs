using MVCEntityFramework.Data;
using MVCEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCEntityFramework.Repositories
{
    public class RepositoryPlantilla
    {
        HospitalContext context;
        public RepositoryPlantilla(HospitalContext context)
        {
            this.context = context;
        }
        public List<Plantilla> GetPlantilla()
        {
            var consulta = from datos in context.Plantilla
                           select datos;
            return consulta.ToList();
        }
        public ResumenPlantilla GetPlantillaPorSalario(int salario)
        {
            var consulta = from datos in context.Plantilla
                           where datos.Salario>=salario
                           select datos;
            ResumenPlantilla resumen = new ResumenPlantilla();
            resumen.Empleados = consulta.ToList();
            resumen.NumEmpleados = consulta.ToList().Count();
            resumen.Maximo = consulta.Max(x => x.Salario);
            resumen.Minimo = consulta.Min(x => x.Salario);
            return resumen;
        }
    }
}
