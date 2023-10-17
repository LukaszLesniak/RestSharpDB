using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Extensions.Configuration;

namespace LechuRestSharp.EntityFrameworkCode
{
    public class LechuDBContext : DbContext
    { 
        public LechuDBContext(DbContextOptions<LechuDBContext> options) : base(options)
        { 
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("Host=localhost;Database=postgres;Username=postgres;Password=123qwe;");
            }
        }

        public DbSet<Author> Cities { get; set; }
    }
}
