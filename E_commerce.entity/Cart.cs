using System.Collections.Generic;

namespace E_commerce.entity
{
    public class Cart
    {
        public int Id { get; set; }
        public string  UserId { get; set; }
        public List<CartItem> CartItems { get; set; }
    }
}