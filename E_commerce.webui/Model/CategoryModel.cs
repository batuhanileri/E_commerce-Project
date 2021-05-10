using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using E_commerce.entity;

namespace E_commerce.webui.Model
{
    public class CategoryModel
    {
     public int CategoryId { get; set; }

    [Required(ErrorMessage="Name Zorunlu Alan")]
    [StringLength(60,MinimumLength=5,ErrorMessage="Kategori ismi 5-60 karakter aralığında olmalı")]
    public string Name{ get; set; }

    [Required(ErrorMessage="Url Zorunlu Alan")]

    public string Url{ get; set; }
    public List<Product> Products {get; set;}
    }
}