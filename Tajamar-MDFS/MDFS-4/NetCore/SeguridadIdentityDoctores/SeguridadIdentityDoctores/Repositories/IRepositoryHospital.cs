using SeguridadIdentityDoctores.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeguridadIdentityDoctores.Repositories
{
    public interface IRepositoryHospital
    {
        public Doctor GetDoctor(int id);
        public Doctor ExisteDoctor(String apellido,int id);
        public List<Doctor> GetDoctores();
        public List<Doctor> GetDoctoresEspecialidad(String especialidad);
    }
}
