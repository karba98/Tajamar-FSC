using ProyectoCeroEF.Data;
using ProyectoCeroEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoCeroEF.Repositories
{
    public class HospitalRepository
    {
        public HospitalesContext context;
        public HospitalRepository(HospitalesContext context)
        {
            this.context = context;
        }
        public List<Departamento> GetDepartamentos()
        {
            var consulta = from datos in context.Departamentos
                           select datos;
            return consulta.ToList();
    }
    }
    
}
