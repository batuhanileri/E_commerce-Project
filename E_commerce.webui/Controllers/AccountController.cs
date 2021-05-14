using System.Threading.Tasks;
using E_commerce.business.Abstract;
using E_commerce.webui.Identity;
using E_commerce.webui.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace E_commerce.webui.Controllers
{
    public class AccountController:Controller
    {
        private UserManager<User> _userManager;
        private SignInManager<User> _signInManager;
        private ICartService _cartService;

        public AccountController(UserManager<User> userManager,SignInManager<User> signInManager,ICartService cartService)
        {
            _userManager=userManager;
            _signInManager=signInManager;
            _cartService=cartService;
        }
        public IActionResult Login(string ReturnUrl=null){

            return View(new LoginModel()
            {
                ReturnUrl=ReturnUrl
            }
            );
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginModel model){
            
            if(!ModelState.IsValid)
            {
                return View(model);
            }               
            var user = await _userManager.FindByEmailAsync(model.Email);

            if(user==null){
                ModelState.AddModelError("","Bu email ile hesap oluşturulmamış");
                return View(model);
            }
            var result = await _signInManager.PasswordSignInAsync(user,model.Password,false,false);           
            if(result.Succeeded)
            {
                return Redirect(model.ReturnUrl??"~/");
            }
                ModelState.AddModelError("","Kullanıcı adı veya parola yanlış");           
            return View(model);
        }

        [HttpGet]
        public IActionResult Register(){
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterModel model){
            if(!ModelState.IsValid)
            {
                return View(model);
            }           
            var user = new User()
            {
               FirstName =model.FirstName,
               LastName=model.LastName,
               UserName=model.UserName,
               Email=model.Email
            };
            var result = await _userManager.CreateAsync(user,model.Password);
            if(result.Succeeded)
            {
                _cartService.InitializeCart(user.Id);
                return RedirectToAction("Login","Account");
            }          
            ModelState.AddModelError("","Bilinmeyen bir hata oluştu lütfen tekrar deneyiniz");
            return View(model);           
           }
           public async Task<IActionResult> LogOut(){
                  await _signInManager.SignOutAsync();
                  return Redirect("~/");
           } 

           public IActionResult AccesDenied()
           {
               return View();
           }
    }
}