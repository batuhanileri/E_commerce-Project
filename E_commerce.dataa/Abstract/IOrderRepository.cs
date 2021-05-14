using System.Collections.Generic;
using E_commerce.entity;

namespace E_commerce.dataa.Abstract
{
    public interface IOrderRepository : IRepository<Order>
    {
        List<Order> GetOrders(string userId);
    }
}