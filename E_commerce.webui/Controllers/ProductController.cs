using Microsoft.AspNetCore.Mvc;
using E_commerce.webui.Model;
using System.Collections.Generic;
using E_commerce.webui.Data;
using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace E_commerce.webui.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {

            var product = new Product { Name = "Pantalons", Price = 5000 };

            ViewBag.Category = "Tekstil";

            return View(product);
        }

        //localhost:5000/product/list
        public IActionResult list(int? id,string q)
        {
           var products = ProductRepository.Products;
           if (id!=null)
            {
                products = products.Where(p=>p.CategoryId==id).ToList();
            }
             if (!string.IsNullOrEmpty(q))
            {
                products = products.Where(i=>i.Name.Contains(q) || i.Description.Contains(q)).ToList();
            }


            var productViewModel = new ProductViewModel()
            {
                ürün = products
            };

            return View(productViewModel);
        }
        //localhost:5000/product/details
       public IActionResult details(int id)
       {
        
           return View(ProductRepository.GetProductById(id));
       }
       [HttpGet]
       public IActionResult Create()
        {
            ViewBag.Categories =new SelectList(CategoryRepository.Categories,"CategoryId","Name");
            return View(new Product());
        }
        [HttpPost]      
        public IActionResult Create(Product p)
        {
            if(ModelState.IsValid) {
                ProductRepository.AddProduct(p);
                return RedirectToAction("list");
            }
            ViewBag.Categories =new SelectList(CategoryRepository.Categories,"CategoryId","Name");

            return View(p);
        }
        [HttpGet]
        public IActionResult Edit(int id){
            ViewBag.Categories =new SelectList(CategoryRepository.Categories,"CategoryId","Name");

            return View(ProductRepository.GetProductById(id));
        }
        [HttpPost]
        public IActionResult Edit(Product p){
            ProductRepository.EditProduct(p);
            return RedirectToAction("list");

        }

        [HttpPost]
        public IActionResult Delete(int ProductId){
            ProductRepository.DeleteProduct(ProductId);
            return RedirectToAction("list");


    
    }
}
}