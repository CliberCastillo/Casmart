using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Buses.Service;
using Microsoft.AspNetCore.Mvc;

namespace Buses.Controllers
{
    public class PasajeController : Controller
    {
        private readonly IMantenimientoViaje _mantenimientoViaje;
        public PasajeController(IMantenimientoViaje mantenimientoViaje)
        {
            _mantenimientoViaje = mantenimientoViaje;
        }
        [HttpPost]
        public IActionResult Index(string origen, string destino, DateTime fecha)
        {
            var ltsViajesDisponibles = _mantenimientoViaje.ObtenerItinerarioViaje(origen, destino, fecha);
            return View(ltsViajesDisponibles);
        }
    }
}