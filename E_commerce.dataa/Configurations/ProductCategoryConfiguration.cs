using E_commerce.entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace E_commerce.dataa.Configurations
{
    public class ProductCategoryConfiguration : IEntityTypeConfiguration<ProductCategory>
    {
        public void Configure(EntityTypeBuilder<ProductCategory> builder)
        {
             builder.HasKey(c=>new {c.CategoryId,c.ProductId});
             builder.HasData(
                   
                   new ProductCategory(){ProductId=1,CategoryId=1},
                   new ProductCategory(){ProductId=2,CategoryId=1},
                   new ProductCategory(){ProductId=3,CategoryId=1},
                   new ProductCategory(){ProductId=4,CategoryId=1},
                   new ProductCategory(){ProductId=5,CategoryId=1},
                   new ProductCategory(){ProductId=6,CategoryId=2},
                   new ProductCategory(){ProductId=7,CategoryId=2}
              
             );
        }
    }
}