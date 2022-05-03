using MvcCoreMariaDb.Data;
using MvcCoreMariaDb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreMariaDb.Repositories
{
    public class RepositoryComics
    {
        ComicContext context;

        public RepositoryComics(ComicContext context)
        {
            this.context = context;
        }

        public List<Comic> GetComics()
        {
            return this.context.Comics.ToList();
        }
    }
}
