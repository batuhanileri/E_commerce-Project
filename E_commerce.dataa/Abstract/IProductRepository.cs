using E_commerce.entity;
using System.Collections.Generic;
namespace E_commerce.dataa.Abstract
{
    public interface IProductRepository: IRepository<Product>
    {
          Product GetProductDetails(string url);
          Product GetByIdWithCategories(int id);
          List<Product> GetProductByCategory(string name,int page,int pageSize);
          List<Product> GetSearchResult(string searchString);
          List<Product> GetHomePagesProducts();
          int GetCountByCategory(string category);
          void Update(Product entity, int[] categoryIds);

    }
}