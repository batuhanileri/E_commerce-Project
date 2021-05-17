using E_commerce.entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace E_commerce.dataa.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(m=>m.ProductId);
            builder.Property(m=>m.Name).IsRequired().HasMaxLength(100);
           
            builder.HasData(
            new Product(){ProductId=1,Name="Mavi Pantalon",Url="mavi-pantalon",Price=140,ImageUrl="1.jpg",Description="%100 Pamuk",IsApproved=true},
            new Product(){ProductId=2,Name="Yeşil Pantalon",Url="yesil-pantalon",Price=150,ImageUrl="4.jpg",Description="%100 Pamuk",IsApproved=true},
            new Product(){ProductId=3,Name="Kırmızı Pantalon",Url="kirmizi-pantalon",Price=160,ImageUrl="5.jpg",Description="%100 Pamuk",IsApproved=true},
            new Product(){ProductId=4,Name="Siyah Pantalon",Url="siyah-pantalon",Price=170,ImageUrl="6.jpg",Description="%100 Pamuk",IsApproved=true},
            new Product(){ProductId=5,Name="Beyaz Pantalon",Url="beyaz-pantalon",Price=180,ImageUrl="7.jpg",Description="%100 Pamuk",IsApproved=true},          
            new Product(){ProductId=6,Name="Siyah Gömlek",Url="siyah-gomlek",Price=200,ImageUrl="8.jpg",Description="%100 Pamuk",IsApproved=true},          
            new Product(){ProductId=7,Name="Beyaz Gömlek",Url="beyaz-gomlek",Price=50,ImageUrl="9.jpg",Description="%100 Pamuk",IsApproved=true},          
            new Product(){ProductId=8,Name="Yesil Gömlek",Url="yesil-gomlek",Price=10,ImageUrl="10.jpg",Description="%100 Pamuk",IsApproved=true}

            );
        }
    }
}