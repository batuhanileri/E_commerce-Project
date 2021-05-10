using System.Collections.Generic;
using E_commerce.entity;

namespace E_commerce.business.Abstract
{
    public interface IProductService
    {
          Product GetById(int id);

          Product GetByIdWithCategories(int id);
          Product GetProductDetails(string url);
          List<Product> GetProductByCategory(string name,int page,int pageSize);

          List<Product> GetAll();
          List<Product> GetHomePageProducts();
          List<Product> GetSearchResult(string searchString);

          void Create(Product entity);

          void Delete(Product entity);
          
          void Update(Product entity);
          int GetCountByCategory(string category);
          void Update(Product entity, int[] categoryIds);
    }
}