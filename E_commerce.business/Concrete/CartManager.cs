using E_commerce.business.Abstract;
using E_commerce.dataa.Abstract;
using E_commerce.entity;

namespace E_commerce.business.Concrete
{
    public class CartManager : ICartService
    {
        private readonly IUnitOfWork _unitofwork;
        public CartManager(IUnitOfWork unitofwork)
        {
            _unitofwork=unitofwork;
        }

        public void AddToCart(string userId, int productId, int quantity)
        {
            var cart=GetCartByUserId(userId);
            if(cart!=null)
            {
                var index=cart.CartItems.FindIndex(i=>i.ProductId==productId);
                if(index<0)
                {
                    cart.CartItems.Add(new CartItem(){
                           ProductId=productId,
                           Quantity=quantity,
                           CartId=cart.Id 
                    });
                }
                else
                {
                    cart.CartItems[index].Quantity+=quantity;
                }
                _unitofwork.Carts.Update(cart);
                _unitofwork.Save();
            }
        }

        public void CleartCart(int cartId)
        {
            _unitofwork.Carts.ClearCart(cartId);
        }

        public void DeleteFromCart(string userId, int productId)
        {
            var cart =GetCartByUserId(userId);
            if(cart!=null)
            {
                _unitofwork.Carts.DeleteFromCart(cart.Id,productId);
            }
        }

        public Cart GetCartByUserId(string userId)
        {
            return _unitofwork.Carts.GetByUserId(userId);
        }

        public void InitializeCart(string userId)
        {
           _unitofwork.Carts.Create(new Cart(){
               UserId=userId
           });
           _unitofwork.Save();
        }
    }
}