using eshop.API.Models;
using eshop.Application;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace eshop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = _userService.ValidateUser(model.UserName, model.Password);
                if (user != null)
                {
                    Claim[] claims = new Claim[]
                    {
                        new Claim(ClaimTypes.Role, user.Role),
                        new Claim(System.IdentityModel.Tokens.Jwt.JwtRegisteredClaimNames.Email, user.Email),
                        new Claim(System.IdentityModel.Tokens.Jwt.JwtRegisteredClaimNames.UniqueName, user.UserName)


                    };

                    var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("BU-CÜMLE-ÇOK-GİZLİ"));
                    var credential = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                    var token = new System.IdentityModel.Tokens.Jwt.JwtSecurityToken(
                        issuer: "api.halkbank.com",
                        audience: "client",
                        claims: claims,
                        notBefore: DateTime.Now,
                        expires: DateTime.Now.AddDays(15),
                        signingCredentials: credential
                        );

                    return Ok(new { token = new JwtSecurityTokenHandler().WriteToken(token) });
                }
                ModelState.AddModelError("login", "Kullanıcı adı ya da şifre yanlış");
            }

            return BadRequest(ModelState);
        }
    }
}
