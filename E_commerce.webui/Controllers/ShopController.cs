using System.Linq;
using E_commerce.business.Abstract;
using E_commerce.entity;
using E_commerce.webui.Model;
using Microsoft.AspNetCore.Mvc;

namespace E_commerce.webui.Controllers
{
    public class ShopController: Controller
    {
        private IProductService _productService;
        
        public ShopController(IProductService productService)
        {
            this._productService=productService;           
        }
        public IActionResult List(string category,int page=1)
        {
            const int pageSize=3;
            var productViewModel = new ProductListViewModel()
            {
                PageInfo =new PageInfo(){
                 TotalItems = _productService.GetCountByCategory(category),
                 CurrentPage =page,
                 ItemsPerPage=pageSize,
                 CurrentCategory=category
                },
                Product = _productService.GetProductByCategory(category,page,pageSize)
            };

            return View(productViewModel);
        }
        public IActionResult Details(string url)
        {
            if(url==null){
                return NotFound();
            }
            Product product=_productService.GetProductDetails(url);

            if(product==null){
                return NotFound();
            }
            return View(new ProductDetailModel{
                           Product =product,
                           Categories=product.ProductCategories.Select(i=>i.Category).ToList()

            });
        }

         public IActionResult Search(string q){
              
            var productViewModel = new ProductListViewModel()
            {
                 Product = _productService.GetSearchResult(q)
            };

            return View(productViewModel);

         }


    }
}