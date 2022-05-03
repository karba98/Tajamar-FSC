using ServiceDoctoresSql.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceDoctoresSql.Data
{
    public class DoctoresContext:DbContext
    {
        public DoctoresContext() : base("name=cadenadoctores") { }
        public DbSet<Doctor> Doctores { get; set; }
    }
}
