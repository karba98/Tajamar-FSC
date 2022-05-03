using Microsoft.EntityFrameworkCore;
using ServiceWIlsonInformer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceWIlsonInformer.Data
{
    public class PartesContext:DbContext
    {
        public PartesContext(DbContextOptions<PartesContext> options) : base(options)
        { }
        public DbSet<Parte> Partes { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
