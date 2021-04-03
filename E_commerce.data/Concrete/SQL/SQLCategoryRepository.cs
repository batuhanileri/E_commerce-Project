using System.Collections.Generic;
using E_commerce.data.Abstract;
using E_commerce.entity;

namespace E_commerce.data.Concrete.SQL
{
    public class SQLCategoryRepository : ICategoryRepository
    {
        Category GetById(int id)
          {
              throw new System.NotImplementedException();
          }
         List<Category> GetAll(){
              throw new System.NotImplementedException();
          }

          void Create(Category entity){
              throw new System.NotImplementedException();
          }
          void Delete(int id)
          {
              throw new System.NotImplementedException();
          }
          void Update(Category entity)
          {
              throw new System.NotImplementedException();
          }

    }
}