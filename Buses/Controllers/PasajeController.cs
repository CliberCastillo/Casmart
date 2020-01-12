using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Buses.Service;
using Microsoft.AspNetCore.Mvc;

using Buses.Models;
using Buses.Common;
using Buses.Entities;

namespace Buses.Controllers
{
    public class PasajeController : Controller
    {
        private readonly IMantenimientoViaje _mantenimientoViaje;
        public PasajeController(IMantenimientoViaje mantenimientoViaje)
        {
            _mantenimientoViaje = mantenimientoViaje;
        }
        public JsonResult RegistrarPasaje(string dniPasajero, string fechaViaje, string numeroAsiento, string precioPasaje)
        {
            var numeroPasajeros = _mantenimientoViaje.ObtenerNumeroPasajeros();
            var codigoPasajero = GenerarCodigoPasajero.CodigoPasajero(numeroPasajeros);
            return Json("");
            
        }
        public JsonResult RegistrarPasajero(string Nombre, string ApellidoPaterno, string ApellidoMaterno,string Telefono, string TipoDocumento, string NumeroDocumento,string Correo)
        {
            var numeroPasajeros = _mantenimientoViaje.ObtenerNumeroPasajeros();
            var codigoPasajero = GenerarCodigoPasajero.CodigoPasajero(numeroPasajeros);

            Pasajero pasajero = new Pasajero
            {
                IdPasajero = codigoPasajero,
                Nombres = Nombre,
                ApellidoPaterno = ApellidoPaterno,
                ApellidoMaterno = ApellidoMaterno,
                Telefono = Telefono,
                TipoDocumento = TipoDocumento,
                NumeroDocumento = NumeroDocumento,
                Correo = Correo
            };
            if (_mantenimientoViaje.GuardarPasajero(pasajero) == "Registrado")
            {
                return Json("PasajeroGuardado");
            }
            else
            {
                return Json("PasajeroNoGuardado");
            }
        }

        [HttpPost]
        public IActionResult Index(AgenciaViajesViewModel viajes)
        {
            ViewBag.Origen = viajes.Origen;
            ViewBag.Destino = viajes.Destino;
            var lstViajesDisponibles = _mantenimientoViaje.ObtenerItinerarioViaje(viajes);
            return View(lstViajesDisponibles);
        }
        public IActionResult Asientos(string IdItinerario)
        {
            var lstResumenCompra = _mantenimientoViaje.FechaYHoraViaje(IdItinerario);
            return View(lstResumenCompra);
        }
        
    }
}