using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Buses.Models;
using Buses.Service;

namespace Buses.Controllers
{
    public class PaginaPrincipalController : Controller
    {
        private readonly IMantenimientoViaje _mantenimientoViaje;
        public PaginaPrincipalController(IMantenimientoViaje mantenimientoViaje)
        {
            _mantenimientoViaje = mantenimientoViaje;
        }
        public IActionResult Index()
        {
            var viajes = _mantenimientoViaje.ObtenerListadoAgencia();
            return View(viajes);
        }
        public IActionResult Login(string usuario, string contraseña)
        {
            if (_mantenimientoViaje.Login(usuario,contraseña))
            {
                ViewBag.message = "Bienvenido";
            }
            return RedirectToAction("Index");
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
