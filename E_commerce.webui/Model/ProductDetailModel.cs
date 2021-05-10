using System.Collections.Generic;
using E_commerce.entity;

namespace E_commerce.webui.Model
{
    public class ProductDetailModel
    {
        public Product Product { get; set; }
        public List<Category> Categories { get; set; }
    }
}