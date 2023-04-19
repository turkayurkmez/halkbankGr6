using eshop.Application;
using eshop.MVC.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace eshop.MVC.Controllers
{
    public class UsersController : Controller
    {
        private readonly IUserService userService;

        public UsersController(IUserService userService)
        {
            this.userService = userService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login(string? nereye)
        {
            ViewBag.Nereye = nereye;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel loginViewModel, string? nereye)
        {
            if (ModelState.IsValid)
            {
                var user = userService.ValidateUser(loginViewModel.UserName, loginViewModel.Password);
                if (user != null)
                {
                    //kişinin login olduğunu sisteme kaydet!
                    Claim[] claims = new Claim[]
                    {
                        new Claim(ClaimTypes.Name, user.Name),
                        new Claim(ClaimTypes.Email, user.Email),
                        new Claim(ClaimTypes.Role, user.Role)
                    };
                    ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                    await HttpContext.SignInAsync(claimsPrincipal);

                    if (!string.IsNullOrEmpty(nereye) && Url.IsLocalUrl(nereye))
                    {
                        return Redirect(nereye);
                    }
                    return Redirect("/");

                }
                ModelState.AddModelError("login", "Hatalı kullanıcı adı ya da şifre");
            }

            return View();
        }


        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return Redirect("/");
        }

        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}
