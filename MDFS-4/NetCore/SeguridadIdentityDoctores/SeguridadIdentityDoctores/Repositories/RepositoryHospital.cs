using SeguridadIdentityDoctores.Data;
using SeguridadIdentityDoctores.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeguridadIdentityDoctores.Repositories
{
    public class RepositoryHospital : IRepositoryHospital
    {
        HospitalContext context;
        public RepositoryHospital(HospitalContext context)
        {
            this.context = context;
        }

        public Doctor ExisteDoctor(string apellido, int id)
        {
            return context.Doctores.Where(x => x.IdDoctor == id &&
            x.Apellido==apellido).FirstOrDefault();
        }

        public Doctor GetDoctor(int id)
        {
            return context.Doctores.Where(x => x.IdDoctor == id).SingleOrDefault();
        }

        public List<Doctor> GetDoctores()
        {
            return context.Doctores.ToList();
        }

        public List<Doctor> GetDoctoresEspecialidad(string especialidad)
        {
            return context.Doctores.Where(x=>x.Especialidad==especialidad).ToList();
        }
    }
}
