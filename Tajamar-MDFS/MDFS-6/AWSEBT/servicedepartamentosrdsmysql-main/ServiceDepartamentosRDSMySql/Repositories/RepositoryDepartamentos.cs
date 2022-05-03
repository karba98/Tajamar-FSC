using ServiceDepartamentosRDSMySql.Data;
using ServiceDepartamentosRDSMySql.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceDepartamentosRDSMySql.Repositories
{
    public class RepositoryDepartamentos
    {
        DepartamentosContext context;

        public RepositoryDepartamentos(DepartamentosContext context)
        {
            this.context = context;
        }

        public List<Departamento> GetDepartamentos()
        {
            return this.context.Departamentos.ToList();
        }

        public Departamento FindDepartamento(int id)
        {
            return this.context.Departamentos
                .SingleOrDefault(x => x.IdDepartamento == id);
        }
    }
}
