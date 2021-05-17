using E_commerce.entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace E_commerce.dataa.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(m=>m.CategoryId);
            builder.Property(m=>m.Name).IsRequired().HasMaxLength(100);
           
            builder.HasData(
            new Category(){CategoryId=1,Name="Pantalon",Url="telefon"},
            new Category(){CategoryId=2,Name="Gömlek",Url="gomlek"},
            new Category(){CategoryId=3,Name="Elbise",Url="elbise"}

            );
        }
    }
}