using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using E_commerce.business.Abstract;
using E_commerce.entity;
using E_commerce.webui.Identity;
using E_commerce.webui.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace E_commerce.webui.Controllers
{
    [Authorize(Roles="admin")]
    public class AdminController : Controller
      { 
              private IProductService _productService;
              private ICategoryService _categoryService;
              private RoleManager<IdentityRole> _roleManager;
              private UserManager<User> _userManager;

              public AdminController(IProductService productService,
                                     ICategoryService categoryService,
                                     RoleManager<IdentityRole> roleManager,
                                     UserManager<User> userManager)
              {
                 _productService =productService;
                 _categoryService = categoryService;
                 _roleManager=roleManager;
                 _userManager=userManager;
              }
              public async Task<ActionResult> UserEdit(string id)
              {                
                  var user = await _userManager.FindByIdAsync(id);
                  if(user!=null)
                  {
                      var selectedRoles =await _userManager.GetRolesAsync(user);
                      var roles= _roleManager.Roles.Select(i=>i.Name);

                      ViewBag.Roles=roles;
                      return View(new UserDetailModel(){
                      UserId=user.Id,
                      UserName=user.UserName,
                      FirstName=user.FirstName,
                      LastName=user.LastName,
                      Email=user.Email,
                      SelectedRoles=selectedRoles
                          
                      });

                  }
                  return Redirect("~/admin/user/list");
              }
              [HttpPost]
              public async Task<ActionResult> UserEdit(UserDetailModel model,string[] selectedRoles)
              {  
                    if(ModelState.IsValid)
                    {
                        var user = await _userManager.FindByIdAsync(model.UserId);
                        if(user!=null)
                        {
                            user.FirstName=model.FirstName;
                            user.LastName=model.LastName;
                            user.UserName=model.UserName;
                            user.Email=model.Email;
                        
                        var result =await _userManager.UpdateAsync(user);
                        if(result.Succeeded)
                        {
                            var userRoles = await _userManager.GetRolesAsync(user);
                            selectedRoles=selectedRoles?? new string[]{};
                            await _userManager.AddToRolesAsync(user,selectedRoles.Except(userRoles).ToArray<string>());
                            await _userManager.RemoveFromRolesAsync(user,userRoles.Except(selectedRoles).ToArray<string>());
                             
                            return Redirect("/admin/user/list");
                        }
                        }
                              return Redirect("/admin/user/list");
                    }
                    return View(model);
              }
              public ActionResult UserList()
              {
                 
                  return View(_userManager.Users);
              }
            public async Task<IActionResult> RoleEdit(string id)
            {
                var role =await _roleManager.FindByIdAsync(id);

                var members =new List<User>();
                var nonmembers =new List<User>();
                
                foreach (var user in _userManager.Users)
                {
                    var list= await _userManager.IsInRoleAsync(user,role.Name)?members:nonmembers;
                    list.Add(user);
                }

                 var model =new RoleDetails()
                 {
                     Role=role,
                     Members=members,
                     NonMembers=nonmembers
                 };

                return View(model);
            }
            [HttpPost]
            public async Task<IActionResult> RoleEdit(RoleEditModel model)
            {
                if(ModelState.IsValid)
                {
                  foreach (var userId in model.IdsToAdd?? new string[]{})
                    {
                         var user= await _userManager.FindByIdAsync(userId);
                         if(user!=null)
                         {
                             var result =await _userManager.AddToRoleAsync(user,model.RoleName);
                            if(!result.Succeeded)
                           {
                              foreach (var error in result.Errors)
                              {
                                  ModelState.AddModelError("",error.Description);
                              } 
                           }

                         }
                    }
                  foreach (var userId in model.IdsToDelete?? new string[]{})
                    {
                         var user= await _userManager.FindByIdAsync(userId);
                         if(user!=null)
                         {
                             var result =await _userManager.RemoveFromRoleAsync(user,model.RoleName);
                            if(!result.Succeeded)
                           {
                              foreach (var error in result.Errors)
                              {
                                  ModelState.AddModelError("",error.Description);
                              } 
                           }

                         }
                    }
                }
                return RedirectToAction("RoleList");
            }
            public IActionResult RoleList()
            {
                return View(_roleManager.Roles);
            }
            [HttpGet]
            public IActionResult RoleCreate()
            {
                return View();
            }
            [HttpPost]
            public async Task<IActionResult> RoleCreate(RoleModel model)
            {
                if(ModelState.IsValid)
                {
                   var result = await _roleManager.CreateAsync(new IdentityRole(model.Name));
                   if(result.Succeeded)
                   {
                       return RedirectToAction("RoleList");
                   }
                   else
                   {
                       foreach(var error in result.Errors)
                       {
                           ModelState.AddModelError("",error.Description);
                       }
                   }
                }
                return View(model);
            }

              public IActionResult ProductList()
              {
                return View(new ProductListViewModel(){
                      
                      Products=_productService.GetAll()
                  });
              }
              public IActionResult CategoryList()
              {
                return View(new CategoryListViewModel(){
                      
                      Categories=_categoryService.GetAll()
                  });
              }
              [HttpGet]
              public IActionResult ProductCreate(){
                  return View();
              }

              [HttpPost]
              public IActionResult ProductCreate(ProductModel model)
              {
                  if(ModelState.IsValid){
                  var entity =new Product()
                  {
                     Name=model.Name,
                     Url=model.Url,
                     Price=model.Price,
                     Description=model.Description      
                  };
                  
                  _productService.Create(entity);
                  return RedirectToAction("ProductList");
                  } 
                  return View(model);
              }

             [HttpGet]
              public IActionResult CategoryCreate(){
                  return View();
              }

              [HttpPost]
              public IActionResult CategoryCreate(CategoryModel model){
                  
                  if(ModelState.IsValid){
                  var entity =new Category()
                  {
                     Name=model.Name,
                     Url=model.Url
                     
                  };
                  _categoryService.Create(entity);
                  return RedirectToAction("CategoryList");
                  }
                  return View(model);
              }
              [HttpGet]
              public IActionResult ProductEdit(int? id)
              {
                  if(id==null){
                      return NotFound();
                  }
                  var entity =_productService.GetByIdWithCategories((int)id);
 
                  if(entity==null){
                      return NotFound();

                  }
                  var model =new ProductModel(){
                      ProductId =entity.ProductId,
                      Name=entity.Name,
                      Url=entity.Url,
                      Price=entity.Price,
                      Description=entity.Description,
                      ImageUrl=entity.ImageUrl,
                      SelectedCategories=entity.ProductCategories.Select(i=>i.Category).ToList()
                  };
                  
                   ViewBag.Categories= _categoryService.GetAll();


                  return View(model);
              }

              [HttpPost]
              public async Task<IActionResult> ProductEdit(ProductModel model,int[] categoryIds,IFormFile file)
              {  
                  if(ModelState.IsValid){
                  var entity=_productService.GetById(model.ProductId);
                  if(entity==null){
                      return NotFound();
                  }
                  entity.Name=model.Name;
                  entity.Price=model.Price;
                  entity.Url=model.Url;                  
                  entity.Description=model.Description;       
                
                  if (file!=null)
                  { 
                            entity.ImageUrl=file.FileName;
                            var extention = Path.GetExtension(file.FileName);
                            var randomName=string.Format($"{Guid.NewGuid()}{extention}");
                            entity.ImageUrl=randomName;
                            var path = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot\\images",file.FileName);
                             
                            using(var stream =new FileStream(path,FileMode.Create)){
                                await file.CopyToAsync(stream);
                            }
                  }
                  _productService.Update(entity,categoryIds);
                  return RedirectToAction("ProductList");
                  }
                   ViewBag.Categories= _categoryService.GetAll();

                  return View(model);
              }
              [HttpGet]
              public IActionResult CategoryEdit(int? id)
              {
                  if(id==null){
                      return NotFound();
                  }
                  var entity =_categoryService.GetByIdWithProducts((int)id);
 
                  if(entity==null){
                      return NotFound();

                  }
                  var model =new CategoryModel(){
                      CategoryId =entity.CategoryId,
                      Name=entity.Name,
                      Url=entity.Url,
                      Products=entity.ProductCategories.Select(p=>p.Product).ToList()
                  };
         
                  return View(model);
              }

              [HttpPost]
              public IActionResult CategoryEdit(CategoryModel model)
              {  
                  if(ModelState.IsValid){
                  var entity=_categoryService.GetById(model.CategoryId);
                  if(entity==null){
                      return NotFound();
                  }
                  entity.Name=model.Name;         
                  entity.Url=model.Url;        
                  _categoryService.Update(entity);
                  return RedirectToAction("CategoryList");
              }
              return View(model);
              }
              
              public IActionResult DeleteProduct(int productId)
              {
                  var entity= _productService.GetById(productId);

                  if(entity!=null)
                  {
                      _productService.Delete(entity);
                  }
                  return RedirectToAction("ProductList");
              }
             public IActionResult DeleteCategory(int categoryId)
              {
                  var entity= _categoryService.GetById(categoryId);

                  if(entity!=null)
                  {
                      _categoryService.Delete(entity);
                  }
                  return RedirectToAction("CategoryList");
              }
              [HttpPost]
            public IActionResult DeleteFromCategory(int productId,int categoryId)
              {
                  _categoryService.DeleteFromCategory(productId,categoryId);
                  return Redirect("/admin/categories/"+categoryId);
              }
      }
}