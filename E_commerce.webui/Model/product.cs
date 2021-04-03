
using System.ComponentModel.DataAnnotations;

namespace E_commerce.webui.Model
{
    public class Product
    {
        public int ProductId { get; set; } 

        [Required]       
        [StringLength(60,MinimumLength=10,ErrorMessage="Ürün ismi 10-60 karakter arasında olması gerekiyor.")] 
        public string Name { get; set; }

        [Required (ErrorMessage="Fiyat Girmelisiniz.")]   
           [Range(1,10000)]
        public double Price { get; set; }

        public string Description {get; set; }
        [Required]      
        public string ImageUrl { get; set; }

        public bool IsApproved { get; set; }
        [Required]
        public int? CategoryId { get; set; }



    }
}