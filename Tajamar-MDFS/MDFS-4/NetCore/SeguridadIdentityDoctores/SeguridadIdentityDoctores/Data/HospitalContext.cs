using Microsoft.EntityFrameworkCore;
using SeguridadIdentityDoctores.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeguridadIdentityDoctores.Data
{
    public class HospitalContext : DbContext
    {

        public HospitalContext(DbContextOptions options) : base(options) { }

        public DbSet<Doctor> Doctores { get; set; }
    }
}
