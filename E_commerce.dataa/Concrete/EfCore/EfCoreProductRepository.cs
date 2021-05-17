using System.Collections.Generic;
using System.Linq;
using E_commerce.dataa.Abstract;
using E_commerce.entity;
using Microsoft.EntityFrameworkCore;

namespace E_commerce.dataa.Concrete.EfCore
{
    public class EfCoreProductRepository : EfCoreGenericRepository<Product>, IProductRepository
    {
        public EfCoreProductRepository(ShopContext context):base(context)
        {
            
        }
        private ShopContext ShopContext
        {
            get {return context as ShopContext;}
        }
        public Product GetByIdWithCategories(int id)
        {
            
                    return ShopContext.Products.Where(i=>i.ProductId==id)
                    .Include(i=>i.ProductCategories).ThenInclude(i=>i.Category).FirstOrDefault();
    
        }

        public int GetCountByCategory(string category)
        {
            
                var products = ShopContext.Products.AsQueryable(); 

                if(!string.IsNullOrEmpty(category)) 
                {
                       products =products.Include(i=>i.ProductCategories)
                                         .ThenInclude(i=>i.Category)
                                         .Where(i=>i.ProductCategories.Any(a=>a.Category.Url==category));
                }
                 return products.Count();


            
        }

        public List<Product> GetHomePagesProducts()
        {
           
                return ShopContext.Products
                .Where(i=>i.IsApproved && i.IsHome==true).ToList();
            
        }

        

        public List<Product> GetProductByCategory(string name,int page,int pageSize)
        {
            
                var products = ShopContext.Products
                .Where(i=>i.IsApproved)
                .AsQueryable(); 

                if(!string.IsNullOrEmpty(name)) 
                {
                       products =products.Include(i=>i.ProductCategories)
                                         .ThenInclude(i=>i.Category)
                                         .Where(i=>i.ProductCategories.Any(a=>a.Category.Url==name));
                }
                 return products.Skip((page-1)*pageSize).Take(pageSize).ToList();


            
        }

        public Product GetProductDetails(string url)
        {
             
                return ShopContext.Products.Where(i =>i.Url==url).Include(i =>i.ProductCategories)
                .ThenInclude(i =>i.Category)
                .FirstOrDefault();
            
        }

        public List<Product> GetSearchResult(string searchString)
        {
            
                var products = ShopContext.Products
                .Where(i=>i.IsApproved && i.Name.ToLower().Contains(searchString.ToLower()) || i.Description.ToLower().Contains(searchString.ToLower()))
                .AsQueryable(); 

                 return products.ToList();


            
        }

        public void Update(Product entity, int[] categoryIds)
        {
             
                var products = ShopContext.Products
                .Include(i=>i.ProductCategories)
                .FirstOrDefault(i=>i.ProductId==entity.ProductId);
                 
                 if(products!=null)
                 {
                        products.Name=entity.Name;
                        products.Price=entity.Price;
                        products.Description=entity.Description;
                        products.Url=entity.Url;
                        products.ImageUrl=entity.ImageUrl;

                        products.ProductCategories=categoryIds.Select(catid=>new ProductCategory()
                        {
                            ProductId =entity.ProductId,
                            CategoryId=catid
                        }).ToList();
                  
                 }


            
        }
    }
}