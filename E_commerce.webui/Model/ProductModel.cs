using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using E_commerce.entity;

namespace E_commerce.webui.Model
{
    public class ProductModel
    {
        public int ProductId { get; set; }
        [Display(Name="Name",Prompt="Enter Product Name")]
        [Required(ErrorMessage="Name Zorunlu Alan")]
        [StringLength(60,MinimumLength=5,ErrorMessage="Ürün ismi 5-60 karakter aralığında olmalı")]
        public string Name { get; set; }

        [Required(ErrorMessage="Url Zorunlu Alan")]
        public string Url { get; set; }

        [Required(ErrorMessage="Price Zorunlu Alan")]
        [Range(1,10000,ErrorMessage="1-10000 arası fiyat giriniz.")]

        public double? Price { get; set; }

        [Required(ErrorMessage="Description Zorunlu Alan")]
        [StringLength(100,MinimumLength=5,ErrorMessage="Ürün ismi 5-100 karakter aralığında olmalı")]


        public string Description {get; set; }

        [Required(ErrorMessage="ImageUrl Zorunlu Alan")]
       
        public string ImageUrl { get; set; }
        

        public bool IsApproved { get; set; }

        public List<Category> SelectedCategories { get; set; }
    }
}