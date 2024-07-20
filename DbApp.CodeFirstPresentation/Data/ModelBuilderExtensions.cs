using DbApp.CodeFirstPresentation.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace DbApp.CodeFirstPresentation.Data
{
    internal static class ModelBuilderExtensions
    {
        internal static void SeedData(this ModelBuilder modelBuilder)
        {
            //Dummy data 
            modelBuilder.Entity<Category>().HasData(
                new Category() { CategoryId = 1, Name = "Elektronik" },
                new Category() { CategoryId = 2, Name = "Kitap" },
                new Category() { CategoryId = 3, Name = "Giyim" }
            );

            modelBuilder.Entity<Product>().HasData(
             new Product() { ProductId = 1, Name = "İphone 15 pro max", Price = 84.500m, IsActive = true, CreaDate = DateTime.Now, CategoryId = 1 },
             new Product() { ProductId = 2, Name = "sahomi ultra x", Price = 78, IsActive = true, CreaDate = DateTime.Now, CategoryId = 1 },
             new Product() { ProductId = 3, Name = "Yoldaki mühendis", Price = 200, IsActive = true, CreaDate = DateTime.Now.AddDays(-5), CategoryId = 2 }
           );
        }
    }
}
