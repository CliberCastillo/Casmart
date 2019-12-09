using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Buses.Service;
using Microsoft.AspNetCore.Mvc;

using Buses.Models;

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
        public IActionResult Index(AgenciaViajesViewModel viajes)
        {
            var ltsViajesDisponibles = _mantenimientoViaje.ObtenerItinerarioViaje(viajes);
            return View(ltsViajesDisponibles);
        }
    }
}