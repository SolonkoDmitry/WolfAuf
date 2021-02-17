using GGS.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace GGS.Data
{
    public interface IGameRepository
    {
        IEnumerable<Game> Games { get; }
    }

    public class MyAppContext : DbContext
    {
        public DbSet<Game> Games { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Section> Sections { get; set; }


        public MyAppContext(DbContextOptions options) : base(options)
        {
        }

        public MyAppContext()
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

    public class EFGameRepository : IGameRepository
    {
        public MyAppContext context = new MyAppContext();

        public IEnumerable<Game> Games
        {
            get { return context.Games; }
        }





    }
}

