using ServiceDoctoresSql.Data;
using ServiceDoctoresSql.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceDoctoresSql.Repositories
{
    public class RepositoryDoctores
    {
        DoctoresContext context;
        public RepositoryDoctores()
        {
            this.context = new DoctoresContext();
        }
        public List<Doctor> GetDoctores() { return context.Doctores.ToList(); }
        public Doctor BuscarDoctor(int Id) { return context.Doctores.SingleOrDefault(x => x.Id == Id); }
    }
}
