using System.Linq;
using E_commerce.dataa.Concrete.EfCore;
using E_commerce.entity;
using Microsoft.EntityFrameworkCore;

namespace E_commerce.dataa.Concrete
{
    public static class SeedDatabase
    {
        public static void Seed(){
            var context =new ShopContext();

            if(context.Database.GetPendingMigrations().Count()==0)
            {
                if(context.Categories.Count()==0)
                {
                    context.Categories.AddRange(Categories);
                }
                if(context.Products.Count()==0)
                {
                    context.Products.AddRange(Products);
                    context.AddRange(ProductCategories);
                }  
            }
            context.SaveChanges();
            }
            private static Category[] Categories={
            new Category(){Name="Pantalon",Url="telefon"},
            new Category(){Name="Gömlek",Url="gomlek"},
            new Category(){Name="Elbise",Url="elbise"}
            
        };
            private static Product[] Products={
            new Product(){Name="Mavi Pantalon",Url="mavi-pantalon",Price=140,ImageUrl="1.jpg",Description="%100 Pamuk",IsApproved=true},
            new Product(){Name="Yeşil Pantalon",Url="yesil-pantalon",Price=150,ImageUrl="4.jpg",Description="%100 Pamuk",IsApproved=true},
            new Product(){Name="Kırmızı Pantalon",Url="kirmizi-pantalon",Price=160,ImageUrl="5.jpg",Description="%100 Pamuk",IsApproved=true},
            new Product(){Name="Siyah Pantalon",Url="siyah-pantalon",Price=170,ImageUrl="6.jpg",Description="%100 Pamuk",IsApproved=true},
            new Product(){Name="Beyaz Pantalon",Url="beyaz-pantalon",Price=180,ImageUrl="7.jpg",Description="%100 Pamuk",IsApproved=true},          
            new Product(){Name="Siyah Gömlek",Url="siyah-gomlek",Price=200,ImageUrl="8.jpg",Description="%100 Pamuk",IsApproved=true},          
            new Product(){Name="Beyaz Gömlek",Url="beyaz-gomlek",Price=50,ImageUrl="9.jpg",Description="%100 Pamuk",IsApproved=true},          
            new Product(){Name="Yesil Gömlek",Url="yesil-gomlek",Price=10,ImageUrl="10.jpg",Description="%100 Pamuk",IsApproved=true},          
        };

        private static ProductCategory[] ProductCategories={

                   new ProductCategory(){Product=Products[0],Category=Categories[0]},
                   new ProductCategory(){Product=Products[1],Category=Categories[0]},
                   new ProductCategory(){Product=Products[2],Category=Categories[0]},
                   new ProductCategory(){Product=Products[3],Category=Categories[0]},
                   new ProductCategory(){Product=Products[4],Category=Categories[0]},
                   new ProductCategory(){Product=Products[5],Category=Categories[1]},
                   new ProductCategory(){Product=Products[6],Category=Categories[1]},
                   new ProductCategory(){Product=Products[7],Category=Categories[1]},
                   


        };
    }
}