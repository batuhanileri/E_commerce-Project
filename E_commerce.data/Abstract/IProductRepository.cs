using E_commerce.entity;
using System.Collections.Generic;
namespace E_commerce.data.Abstract
{
    public interface IProductRepository
    {
          Product GetById(int id);

          List<Product> GetAll();

          void Create(Product entity);
          void Delete(int id);
          void Update(Product entity);


    }
}