using E_commerce.business.Abstract;
using E_commerce.webui.Model;
using Microsoft.AspNetCore.Mvc;

namespace E_commerce.webui.Controllers
{
    public class HomeController : Controller
    {
        private IProductService _productService;
        
        public HomeController(IProductService productService)
        {
            this._productService=productService;
            
        }
        public IActionResult Index()
        {    

        var productViewModel = new ProductListViewModel()
            {
                Product = _productService.GetHomePageProducts()             
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