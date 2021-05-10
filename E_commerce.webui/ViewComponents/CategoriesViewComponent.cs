using System.Collections.Generic;
using E_commerce.business.Abstract;
using Microsoft.AspNetCore.Mvc;
namespace E_commerce.webui.ViewComponents

{
    public class CategoriesViewComponent:ViewComponent
    {
        private ICategoryService _categoryService;
        
        public CategoriesViewComponent(ICategoryService categoryService)
        {
            this._categoryService=categoryService;
            
        }
         public IViewComponentResult Invoke(){

             if(RouteData.Values["category"]!=null)
                ViewBag.SelectedCategory = RouteData?.Values["category"];
         return View(_categoryService.GetAll());
        
        }
        
    }
}