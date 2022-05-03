using ApiCrudDoctores.Data;
using NugetDoctoresModelsRC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCrudDoctores.Repositories
{
    public class RepositoryDoctores
    {
        private DoctoresContext context;
        public RepositoryDoctores(DoctoresContext context)
        {
            this.context = context;
        }
        public List<Doctor> GetDoctores()
        {
            return context.Doctores.ToList();
        }
        public Doctor BuscarDoctor(int id)
        {
            return context.Doctores.SingleOrDefault(x => x.IdDoctor == id);
        }
        public void DeleteDoctor(int id)
        {
            Doctor doc = BuscarDoctor(id);
            this.context.Doctores.Remove(doc);
            context.SaveChanges();
        }
        public void InsertDoctor(int id, String apellido,String especialidad, int hospitalCod, int salario)
        {
            Doctor doc = new Doctor
            {
                IdDoctor=id,
                Apellido=apellido,
                Especialidad=especialidad,
                HospitalCod=hospitalCod,
                Salario=salario
            };
            context.Doctores.Add(doc);
            context.SaveChanges();
        }
        public void UpdateDoctor(int id, String apellido,String especialidad, int hospitalCod, int salario)
        {
            Doctor doc = BuscarDoctor(id);
            doc.Apellido = apellido;
            doc.Especialidad = especialidad;
            doc.HospitalCod = hospitalCod;
            doc.Salario = salario;
            context.SaveChanges();
        }
        public void IncrementarSalarioPorHospital(int incremento, int hospitalcod)
        {
            List<Doctor> doctores = context.Doctores.Where(x => x.HospitalCod == hospitalcod).ToList();
            foreach(Doctor doc in doctores)
            {
                doc.Salario += incremento;
            }
            context.SaveChanges();
        }
        public List<String> GetEspecialidades()
        {
            var consulta = (from datos in context.Doctores
                            select datos.Especialidad).Distinct();
            return consulta.ToList();
        }
        public List<Doctor> GetDoctoresEspecialidades(List<String> especialidades)
        {
            return context.Doctores.Where(x => especialidades.Contains(x.Especialidad)).ToList();
        }
    }
}
