using ServiceDoctoresSql.Models;
using ServiceDoctoresSql.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceDoctoresSql
{
    public class ServiceDoctoresWCF : IServiceDoctores
    {
        RepositoryDoctores repo;
        public ServiceDoctoresWCF()
        {
            this.repo = new RepositoryDoctores();
        }
        public Doctor BuscarDoctor(int Id)
        {
            return repo.BuscarDoctor(Id);
        }

        public List<Doctor> GetDoctores()
        {
            return repo.GetDoctores();
        }
    }
}
