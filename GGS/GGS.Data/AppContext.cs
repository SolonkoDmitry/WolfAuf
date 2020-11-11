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

        public DbSet<Product> Products { get; set; }
    }
}
