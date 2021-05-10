using System.Collections.Generic;
using System.Linq;
using E_commerce.dataa.Abstract;
using E_commerce.entity;
using Microsoft.EntityFrameworkCore;

namespace E_commerce.dataa.Concrete.EfCore
{
    public class EfCoreCategoryRepository : EfCoreGenericRepository<Category, ShopContext>, ICategoryRepository
    {
        public void DeleteFromCategory(int productId, int categoryId)
        {
           using (var context=new ShopContext()){
               var cmd = "delete from productcategory where ProductId=@p0 and CategoryId=@p1";
                context.Database.ExecuteSqlRaw(cmd,productId,categoryId);


               }
        }

        public Category GetByIdWithProducts(int categoryId)
        {
            using (var context=new ShopContext()){
                return context.Categories.Where(i=>i.CategoryId==categoryId)
                .Include(i=>i.ProductCategories).ThenInclude(i=>i.Product).FirstOrDefault();
            }
        }

        
    }
}