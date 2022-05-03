using ApiDoctores.Data;
using ApiDoctores.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiDoctores.Repositories
{
    public class RepositoryDoctores
    {
        DoctoresContext context;
        public RepositoryDoctores(DoctoresContext context) { this.context = context; }
        public List<Doctor> GetDoctores()
        {
            return context.Doctores.ToList();

        }
        public Doctor GetDoctor(int id)
        {
            return context.Doctores.SingleOrDefault(x => x.DoctorNo == id);
        }
        public List<String> GetEspecialidades()
        {
            return context.Doctores.Select(x => x.Especialidad).Distinct().ToList();
        }
        public List<Doctor> GetDoctoresEspecialidad(String especialidad)
        {
            return context.Doctores.Where(x=>x.Especialidad==especialidad).ToList();
        }
        public List<Doctor> GetDoctoresSalario(int salario)
        {
            return context.Doctores.Where(x => x.Salario >= salario).ToList();
        }
    }
}
