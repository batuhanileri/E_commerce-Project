using Microsoft.EntityFrameworkCore;
using E_commerce.entity;
using E_commerce.dataa.Configurations;

namespace E_commerce.dataa.Concrete.EfCore
{
    public class ShopContext:DbContext
    {
        public ShopContext(DbContextOptions options): base(options)
        {

        }
        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Order> Orders { get; set; }         
        public DbSet<OrderItem> OrderItems { get; set; }

        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // {
        //     optionsBuilder.UseSqlite("Data Source=shopDb");
        // }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           modelBuilder.ApplyConfiguration(new ProductConfiguration());
           modelBuilder.ApplyConfiguration(new CategoryConfiguration());
           modelBuilder.ApplyConfiguration(new ProductCategoryConfiguration());

        }


    }
}