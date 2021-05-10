using System.Collections.Generic;
using E_commerce.entity;

namespace E_commerce.business.Abstract
{
    public interface ICategoryService
    {
          Category GetById(int id);
          Category GetByIdWithProducts(int categoryId);

          List<Category> GetAll();

          void Create(Category entity);

          void Delete(Category entity);
          
          void Update(Category entity);
          void DeleteFromCategory(int productId,int categoryId);
    }
}