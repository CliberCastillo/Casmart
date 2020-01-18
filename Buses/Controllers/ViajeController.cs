using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Buses.Common;
using Buses.Entities;
using Buses.Models;
using Buses.Service;
using Microsoft.AspNetCore.Mvc;

namespace Buses.Controllers
{
    public class ViajeController : Controller
    {
        private readonly IViajeRepository _viaje;
        public ViajeController(IViajeRepository viaje)
        {
            _viaje = viaje;
        }
        public IActionResult Registrar()
        {
            BusAgenciaViewModel busAgencia = new BusAgenciaViewModel
            {
                buses = _viaje.ObtenerListadoBus(),
                agencias = _viaje.ObtenerListadoAgencia()
            };
            return View(busAgencia);
        }
        [HttpPost]
        public IActionResult Registrar(ItinerarioViaje viaje)
        {
            var AgeciaOrigen = _viaje.AgenciaOrigenPorCodigo(viaje.IdAgencia);
            var numeroDeItinerario = _viaje.numeroItinerario();
            var codigo = GenerarCodigoItinerario.CodigoItinerario(numeroDeItinerario);
            viaje.AgenciaOrigen = AgeciaOrigen;
            viaje.IdItinerario = codigo;
            _viaje.GuardarViaje(viaje);
            return RedirectToAction("Listado");
        }
    }
}