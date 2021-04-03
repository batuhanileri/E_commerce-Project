using System.Collections.Generic;
using E_commerce.data.Abstract;
using E_commerce.entity;

namespace E_commerce.data.Concrete.SQL
{
    public class SQLProductRepository :IProductRepository
    {
        Product GetById(int id)
          {
              throw new System.NotImplementedException();
          }
         List<Product> GetAll(){
              throw new System.NotImplementedException();
          }

          void Create(Product entity){
              throw new System.NotImplementedException();
          }
          void Delete(int id)
          {
              throw new System.NotImplementedException();
          }
          void Update(Product entity)
          {
              throw new System.NotImplementedException();
          }

    }
}