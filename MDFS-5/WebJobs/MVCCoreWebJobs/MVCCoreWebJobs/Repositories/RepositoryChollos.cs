using MVCCoreWebJobs.Data;
using MVCCoreWebJobs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCoreWebJobs.Repositories
{
    public class RepositoryChollos
    {
        ChollosContext context;
        public RepositoryChollos(ChollosContext context)
        {
            this.context = context;
        }
        public List<Chollo> GetChollos()
        {
            return context.Chollos.OrderByDescending(x=>x.IdTitular).ToList();
        }
    }
}
