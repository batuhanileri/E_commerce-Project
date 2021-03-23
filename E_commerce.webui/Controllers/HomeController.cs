using System;
using System.Collections.Generic;
using E_commerce.webui.Data;
using E_commerce.webui.Model;
using Microsoft.AspNetCore.Mvc;

namespace E_commerce.webui.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
        
        var productViewModel = new ProductViewModel()
            {
                ürün = ProductRepository.Products
            };

            return View(productViewModel);
        }
        //localhost:5000/home/about
        public IActionResult About()
        {
            return View();
        }

        public IActionResult Details(){
            return View();
        }
    }
}