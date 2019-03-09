using DreamsAndBytes.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DreamsAndBytes.DataAccess.Concrete.EntityFramework
{
    public class DreamsAndBytesContext:DbContext
    {
       protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
       {
           optionsBuilder.UseSqlServer(@"Server=DESKTOP-VTHIF08;Database=DreamsAndBytesDB;Trusted_Connection=true");
       }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}