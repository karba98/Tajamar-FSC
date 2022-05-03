using Microsoft.EntityFrameworkCore;
using MVCCoreWebJobs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCoreWebJobs.Data
{
    public class ChollosContext : DbContext
    {
        public ChollosContext(DbContextOptions options) : base(options) { }
        public DbSet<Chollo> Chollos { get; set; }
    }
}
