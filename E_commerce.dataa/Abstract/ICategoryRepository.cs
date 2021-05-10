using E_commerce.entity;
using System.Collections.Generic;
namespace E_commerce.dataa.Abstract
{
    public interface ICategoryRepository: IRepository<Category>
    {
          
         Category GetByIdWithProducts(int categoryId);
         void DeleteFromCategory(int productId,int categoryId);
    }
}