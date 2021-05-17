using System.Collections.Generic;
using E_commerce.business.Abstract;
using E_commerce.dataa.Abstract;
using E_commerce.entity;

namespace E_commerce.business.Concrete
{
    public class OrderManager : IOrderService
    {
        private readonly IUnitOfWork _unitofwork;
        public OrderManager(IUnitOfWork unitofwork)
        {
            _unitofwork=unitofwork;
        }
        public void Create(Order entity)
        {
            _unitofwork.Orders.Create(entity);
             _unitofwork.Save();
        }

        public List<Order> GetOrders(string userId)
        {
            return  _unitofwork.Orders.GetOrders(userId);
        }
    }
}