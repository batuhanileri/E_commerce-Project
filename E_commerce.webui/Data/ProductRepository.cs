using System.Collections.Generic;
using System.Linq;
using E_commerce.webui.Model;

namespace E_commerce.webui.Data
{
    public static class ProductRepository
    {
        private static List<product> _products =null;
    
    static ProductRepository(){
        _products = new List<product>{
           new product {ProductId=1, Name="Mavi Ultra Yüksek Bel Denim Pantolon", Price=2000,IsApproved=true,Description="99% Pamuk 1% Elastan", ImageUrl="1.jpg"},
           new product {ProductId=2, Name="Mavi Mom-Fit Jean Pantolon", Price=4000,IsApproved=true,Description="100% Pamuk", ImageUrl="2.jpg"},
           new product {ProductId=3, Name="Carrot-Fit Sweat Pantolon", Price=5000,IsApproved=false,Description="81% Polyester 15% Viskon 4% Elastan", ImageUrl="1.jpg"},
           new product {ProductId=4, Name="Mavi", Price=7000,IsApproved=false,Description="81% Polyester 15% Viskon 4% Elastan", ImageUrl="1.jpg"},
        };
    }
    public static List<product> Products
    {
        get{
            return _products;
        }
    }
    public static void AddProduct(product product){
        _products.Add(product);
    }

public static product GetProductById(int id)
{

    return _products.FirstOrDefault(p=>p.ProductId==id);
}

    }
}