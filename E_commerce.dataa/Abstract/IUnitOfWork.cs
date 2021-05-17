using System;

namespace E_commerce.dataa.Abstract
{
    public interface IUnitOfWork:IDisposable
    {
         IProductRepository Products{ get;}
         ICartRepository Carts{get;}
         IOrderRepository Orders{get;}
         ICategoryRepository Categories{get;}
         void Save();

    }
}