using System.Collections.Generic;
using System.Linq;
using E_commerce.dataa.Abstract;
using E_commerce.entity;
using Microsoft.EntityFrameworkCore;

namespace E_commerce.dataa.Concrete.EfCore
{
    public class EfCoreOrderRepository : EfCoreGenericRepository<Order, ShopContext>, IOrderRepository
    {
        public List<Order> GetOrders(string userId)
        {
            using(var context=new ShopContext())
            {
                var orders = context.Orders.Include(i=>i.OrderItems)
                .ThenInclude(i=>i.Product).AsQueryable();

                if(!string.IsNullOrEmpty(userId))
                {
                    orders=orders.Where(i=>i.UserId==userId);
                }

                return orders.ToList();
            }
        }
    }
}