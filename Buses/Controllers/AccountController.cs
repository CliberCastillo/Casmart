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
        public IActionResult Login()
        {
            return View();
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
                ViewBag.Succeeded = true;
                return RedirectToAction("Index", "PaginaPrincipal");
            }
            {
                ViewBag.Falied = false;
                return RedirectToAction("Index", "PaginaPrincipal");
            }
        }
    }
}