using Microsoft.EntityFrameworkCore;
using ProyectoCeroEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoCeroEF.Data
{
    public class HospitalesContext:DbContext
    {
        public HospitalesContext(DbContextOptions options):base(options)
        {}
        public DbSet<Departamento> Departamentos { get; set; }
    }
}
