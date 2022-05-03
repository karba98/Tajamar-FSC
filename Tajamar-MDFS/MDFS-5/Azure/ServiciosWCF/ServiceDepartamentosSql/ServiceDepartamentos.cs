using ServiceDepartamentosSql.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceDepartamentosSql
{
    public class ServiceDepartamentos : IServiceDepartamentos
    {
        RepositoryDepartamentos repo;
        public ServiceDepartamentos()
        {
            this.repo = new RepositoryDepartamentos();
        }
        public Departamento BuscarDepartamento(int id)
        {
            return repo.BuscarDepartamento(id);
        }

        public List<Departamento> GetDepartamentos()
        {
            return repo.GetDepartamentos();
        }
    }
}
