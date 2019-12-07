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
        [HttpPost]
        public async Task<IActionResult> CreateUser(NewUserViewModel model)
        {
            var resultado = await _userManager.CreateAsync(
                    new AplicationUser
                    {
                        UserName = model.Email,
                        Email = model.Email
                    }, model.Contraseña
                );
            if (resultado.Succeeded)
            {
                ViewBag.Succeeded = "Se Registro";
                return RedirectToAction("Index", "PaginaPrincipal");
            }
            {
                ViewBag.Falied = "No se Registro";
                return RedirectToAction("Index", "PaginaPrincipal");
            }
        }
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "PaginaPrincipal");
;        }
    }
}