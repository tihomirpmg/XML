namespace ProductShop.Data
{
    using Microsoft.EntityFrameworkCore;
    using Models;

    public class ProductShopContext : DbContext
    {
        public ProductShopContext()
        {

        }

        public ProductShopContext(DbContextOptions options):base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<CategoryProduct> CategoryProducts { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=DESKTOP-IUBR93H\TIHOMIR1705;Database=ProductShopXML;Integrated Security=True");
            }
        }
    }
}