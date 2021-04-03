using E_commerce.entity;
using System.Collections.Generic;
namespace E_commerce.data.Abstract
{
    public interface ICategoryRepository
    {
          Category GetById(int id);

          List<Category> GetAll();

          void Create(Category entity);

          void Delete(int id);
          
          void Update(Category entity);


    }
}