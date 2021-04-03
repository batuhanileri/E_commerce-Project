using System.Collections.Generic;
using E_commerce.webui.Data;
using E_commerce.webui.Model;
using Microsoft.AspNetCore.Mvc;
namespace E_commerce.webui.ViewComponents

{
    public class CategoriesViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke(){
               ViewBag.SelectedCategory = RouteData?.Values["id"];
        return View(CategoryRepository.Categories);
        }
        
    }
}