using System.Collections.Generic;
using E_commerce.entity;

namespace E_commerce.business.Abstract
{
    public interface IOrderService
    {
         void Create(Order entity);
         List<Order> GetOrders(string userId);
    }
}