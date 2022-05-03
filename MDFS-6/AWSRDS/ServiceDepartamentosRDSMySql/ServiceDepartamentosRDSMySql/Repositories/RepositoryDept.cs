using ServiceDepartamentosRDSMySql.Data;
using ServiceDepartamentosRDSMySql.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceDepartamentosRDSMySql.Repositories
{
    public class RepositoryDept
    {
        public HospitalContext context;
        public RepositoryDept(HospitalContext context)
        {
            this.context = context;
        }
        public List<Departamento> GetDepats()
        {
            return this.context.Departamentos.ToList();
        }
        public Departamento FindDepartamento(int id)
        {
            return context.Departamentos.FirstOrDefault(x => x.Id == id);
        }
    }
}
