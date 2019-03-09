using DreamsAndBytes.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DreamsAndBytes.DataAccess.Concrete.EntityFramework
{
    public class AppContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Todo:Sqlite bağlantısı yapacağım
        //    optionsBuilder.UseSqlServer(
         //       @"Server=(localdb)\mssqllocaldb;Database=DreamsAndBytes;Trusted_Connection=true");
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}