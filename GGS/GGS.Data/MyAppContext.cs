using GGS.Domain;
using Microsoft.EntityFrameworkCore;
using System;

namespace GGS.Data
{
    public class MyAppContext : DbContext
    {
        public DbSet<Game> Games { get; set; }

        public DbSet<Category> Categories { get; set; }

        public MyAppContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            // optionsBuilder.UseLoggerFactory(ConsoleLoggerFactory);
        }
    }
}