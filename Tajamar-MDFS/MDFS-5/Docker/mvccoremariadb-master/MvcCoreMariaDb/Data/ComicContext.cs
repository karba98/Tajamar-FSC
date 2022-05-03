using Microsoft.EntityFrameworkCore;
using MvcCoreMariaDb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreMariaDb.Data
{
    public class ComicContext: DbContext
    {
        public ComicContext(DbContextOptions<ComicContext> options) : base(options) { }
        public DbSet<Comic> Comics { get; set; }
    }
}
