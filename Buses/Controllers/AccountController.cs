 using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Buses.Models;
using Microsoft.AspNetCore.Mvc;

using Buses.Identity;

namespace Buses.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AplicationUser> _userManager;
        private readonly SignInManager<AplicationUser> _signInManager;
        public AccountController(UserManager<AplicationUser> userManager, SignInManager<AplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public ViewResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel login)
        {
            var resultado = await _signInManager.PasswordSignInAsync(
                login.Email,
                login.Password,
                login.Remenber,
                false
                );
            if (resultado.Succeeded)
            {
                return RedirectToAction("Index", "PaginaPrincipal");
            }
            return RedirectToAction("Login");
        }
        [HttpGet]
        public async Task<JsonResult> CreateUser(string Email, string Contraseña)
        {
            var variable = 0;
            var resultado = await _userManager.CreateAsync(
                    new AplicationUser
                    {
                        UserName = Email,
                        Email = Email
                    }, Contraseña
                );
            if (resultado.Succeeded)
            {
                variable = 1;
            }
            {
            }
                return Json(variable);
        }
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "PaginaPrincipal");
;        }
    }
}