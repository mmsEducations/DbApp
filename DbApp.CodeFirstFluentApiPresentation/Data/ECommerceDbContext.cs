

namespace DbApp.CodeFirstFluentApiPresentation.Data
{
    internal class ECommerceDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; } //ECommerceDbContext cnt = new ECommerceDbContext(); cnt.Products;
        public DbSet<Category> Categories { get; set; }


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
            //Category entity = new Cayegory();

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("Categories");

                entity.HasKey(c => c.CategoryId);

                entity.Property(c => c.CategoryId)
                     .HasColumnName("category_id");

                entity.Property(c => c.Name)
                      .IsRequired()
                      .HasMaxLength(100)
                      .HasColumnName("name");

                //Category->products->category
                entity.HasMany(p => p.Products)
                      .WithOne(c => c.Category)
                      .HasForeignKey(x => x.CategoryId);

            });

            //has-With 

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Products");

                entity.HasKey(p => p.ProductId);

                entity.Property(p => p.ProductId)
                     .HasColumnName("product_id")
                     .HasColumnOrder(1);

                entity.Property(p => p.Name)
                      .IsRequired()
                      .HasMaxLength(100)
                      .HasColumnName("name")
                      .HasColumnOrder(2);

                entity.Property(p => p.Price)
                     .HasColumnType("decimal(18,2)")
                     .HasColumnName("price")
                     .HasColumnOrder(3);

                entity.Property(p => p.CreaDate)
                      .HasColumnType("DateTime2")
                      .HasColumnName("crea_date")
                      .HasColumnOrder(4);

                entity.Property(p => p.IsActive)
                      .HasColumnName("is_active")
                      .HasColumnOrder(5);

                entity.Ignore(p => p.Count);

                entity.Property(p => p.CategoryId)
                     .HasColumnName("category_id");

                entity.HasOne(p => p.Category)
                      .WithMany(p => p.Products)
                      .HasForeignKey(p => p.CategoryId);

            });

        }


    }
}
