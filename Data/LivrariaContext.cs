using Microsoft.EntityFrameworkCore;
using LivrariaAPI.Models;
using System.Collections.Generic;

namespace LivrariaAPI.Data
{
    public class LivrariaContext : DbContext
    {
        public LivrariaContext(DbContextOptions<LivrariaContext> options)
            : base(options)
        {
        }

        public DbSet<Livro> Livros { get; set; }
    }
}
