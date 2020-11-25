using System;
using GGS.Domain;
using Microsoft.EntityFrameworkCore;

namespace GGS.Data
{
    public class MyAppContext: DbContext

    {
        public MyAppContext()
        {

        }

        public  DbSet<Category> Categories { get; set; }

        public DbSet<Game> Games { get; set; }

        public MyAppContext(DbContextOptions<MyAppContext> options) : base(options)
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
