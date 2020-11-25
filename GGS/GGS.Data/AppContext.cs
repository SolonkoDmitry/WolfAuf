using System;
using GGS.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore.SqlServer;

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

    }
}
