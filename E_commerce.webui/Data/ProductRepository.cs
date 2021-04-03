using System.Collections.Generic;
using System.Linq;
using E_commerce.webui.Model;

namespace E_commerce.webui.Data
{
    public static class ProductRepository
    {
        private static List<Product> _products =null;
    
    static ProductRepository(){
        _products = new List<Product>{

           new Product {ProductId=1, Name="Mavi Ultra Yüksek Bel Denim Pantolon", Price=2000,IsApproved=true,Description="99% Pamuk 1% Elastan", ImageUrl="1.jpg",CategoryId=1},
           new Product {ProductId=2, Name="Mavi Mom-Fit Jean Pantolon", Price=4000,IsApproved=true,Description="100% Pamuk", ImageUrl="2.jpg",CategoryId=1},
           new Product {ProductId=3, Name="Carrot-Fit Sweat Pantolon", Price=5000,IsApproved=false,Description="81% Polyester 15% Viskon 4% Elastan", ImageUrl="1.jpg",CategoryId=1},
           new Product {ProductId=4, Name="Mavi", Price=7000,IsApproved=false,Description="81% Polyester 15% Viskon 4% Elastan", ImageUrl="1.jpg",CategoryId=1},
           new Product {ProductId=5, Name="Desenli Gömlek", Price=2000,IsApproved=true,Description="99% Pamuk 1% Elastan", ImageUrl="3.jpg",CategoryId=2},
           new Product {ProductId=6, Name="Düz Gömlek", Price=4000,IsApproved=true,Description="100% Pamuk", ImageUrl="3.jpg",CategoryId=2},
           new Product {ProductId=7, Name="Siyah Gömlek", Price=5000,IsApproved=false,Description="81% Polyester 15% Viskon 4% Elastan", ImageUrl="3.jpg",CategoryId=2},
           new Product {ProductId=8, Name="Beyaz Gömlek", Price=7000,IsApproved=false,Description="81% Polyester 15% Viskon 4% Elastan", ImageUrl="3.jpg",CategoryId=2}
              
        };
    }
    public static List<Product> Products
    {
        get{
            return _products;
        }
    }
    public static void AddProduct(Product product){
        _products.Add(product);
    }

public static Product GetProductById(int id)
{

    return _products.FirstOrDefault(p=>p.ProductId==id);
}
public static void EditProduct(Product product){
    foreach (var p in _products){
        if(p.ProductId==product.ProductId){
p.Name=product.Name;
p.ImageUrl=product.ImageUrl;
p.Description=product.Description;
p.Price=product.Price;
p.CategoryId=product.CategoryId;
p.IsApproved=product.IsApproved;


        }
    }
}

public static void DeleteProduct(int id){
var product =GetProductById(id);

if(product!=null){
    _products.Remove(product);
}
}

    }
}