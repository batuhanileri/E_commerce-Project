using System.Collections.Generic;
using E_commerce.business.Abstract;
using E_commerce.dataa.Abstract;
using E_commerce.entity;

namespace E_commerce.business.Concrete
{
    public class OrderManager : IOrderService
    {
        private IOrderRepository _orderRepository;
        public OrderManager(IOrderRepository orderRepository)
        {
            _orderRepository=orderRepository;
        }
        public void Create(Order entity)
        {
            _orderRepository.Create(entity);
        }

        public List<Order> GetOrders(string userId)
        {
            return _orderRepository.GetOrders(userId);
        }
    }
}