using Microsoft.AspNetCore.Mvc;
using E_commerce.webui.Model;
using System.Collections.Generic;
using E_commerce.webui.Data;
using System;


namespace E_commerce.webui.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {

            var product = new product { Name = "Pantalons", Price = 5000 };

            ViewBag.Category = "Tekstil";

            return View(product);
        }

        //localhost:5000/product/list
        public IActionResult list()
        {
           
            var productViewModel = new ProductViewModel()
            {
                ürün = ProductRepository.Products
            };

            return View(productViewModel);
        }
        //localhost:5000/product/details
       public IActionResult details(int id)
       {
           

           return View(ProductRepository.GetProductById(id));
       }
    }
}