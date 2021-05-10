using Microsoft.EntityFrameworkCore;
using E_commerce.entity;

namespace E_commerce.dataa.Concrete.EfCore
{
    public class ShopContext:DbContext
    {
        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=shopDb");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           modelBuilder.Entity<ProductCategory>().HasKey(c=>new {c.CategoryId,c.ProductId});
        }


    }
}