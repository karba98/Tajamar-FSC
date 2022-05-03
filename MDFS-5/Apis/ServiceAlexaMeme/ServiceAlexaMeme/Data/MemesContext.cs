using Microsoft.EntityFrameworkCore;
using ServiceAlexaMeme.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceAlexaMeme.Data
{
    public class MemesContext:DbContext
    {
        public MemesContext(DbContextOptions<MemesContext> options) : base(options) { }
        public DbSet<Meme> Memes { get; set; }
    }
}
