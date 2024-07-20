using DbApp.CodeFirstPresentation.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace DbApp.CodeFirstPresentation.Data
{
    internal class ECommerceDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; } //ECommerceDbContext cnt = new ECommerceDbContext(); cnt.Products;
        public DbSet<Category> Categories { get; set; }

        //Connection string Set etme yöntemi 1
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var constr = @"Server=.;Database=ECommerceDb;Trusted_Connection=True;ConnectRetryCount=0;Encrypt=False";
            optionsBuilder.UseSqlServer(constr);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.SeedData();

            //Fluent Api kodları buraya yazılır?
        }


        /*
        //Connection string Set etme yöntemi 2 
        //birinci kısım burası ikinci kısım program.cs clasının içinde set edilen ksım?neyi set ediyoruz burdaki constructor metodu
        public ECommerceDbContext(DbContextOptions<ECommerceDbContext> options) : base(options)
        { }
        */
    }
}
//<>

//Add-Migration InitialCreate : Database operasyonları için yazdığımız kodları ara c# diline dönüştüren Dosya oluşturulur
//Update-Database             : Oluşan kodları Database'de çalıştırır ve yansıtır