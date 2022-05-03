using Microsoft.EntityFrameworkCore;
using MVCEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCEntityFramework.Data
{
    public class EnfermosContext :DbContext
    {
        public EnfermosContext(DbContextOptions<EnfermosContext> options):base(options) { }
        public DbSet<Enfermo> Enfermos { get; set; }
    }
   
}
