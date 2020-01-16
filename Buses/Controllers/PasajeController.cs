using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Buses.Service;
using Microsoft.AspNetCore.Mvc;

using Buses.Models;
using Buses.Common;
using Buses.Entities;
using ServiceBus;

namespace Buses.Controllers
{
    public class PasajeController : Controller
    {
        private readonly IViajeRepository _viaje;
        public PasajeController(IViajeRepository viaje)
        {
            _viaje = viaje;
        }
        public JsonResult RegistrarPasaje(string IdItinerario, string dniPasajero, string fechaViaje, string numeroAsiento, int precioPasaje, string estado)
        {
            
            var numeroPasajes = _viaje.ObtenerNumeroPasaje();
            var codigoPasaje = GenerarCodigoPasaje.CodigoPasaje(numeroPasajes);
            _viaje.GuardarPasaje(codigoPasaje, IdItinerario, dniPasajero, fechaViaje, numeroAsiento, precioPasaje, estado);

            return Json("PasajeGuardado");
            
        }
        public JsonResult RegistrarPasajero(string Nombre, string ApellidoPaterno, string ApellidoMaterno,string Telefono, string TipoDocumento, string NumeroDocumento,string Correo)
        {

            var numeroPasajeros = _viaje.ObtenerNumeroPasajeros();
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

            if (!_viaje.ExistePasajero(NumeroDocumento))
            {
                if (_viaje.GuardarPasajero(pasajero))
                {
                    return Json("PasajeroGuardado");
                }
                else
                {
                    return Json("NoGuardado");

                }
            }
            else
            {
                return Json("YaGuardado");

            }
        }

        [HttpPost]
        public IActionResult Index(AgenciaViajesViewModel viajes)
        {
            ViewBag.Origen = viajes.Origen;
            ViewBag.Destino = viajes.Destino;
            var lstViajesDisponibles = _viaje.ObtenerItinerarioViaje(viajes);
            return View(lstViajesDisponibles);
        }
        public IActionResult Asientos(string IdItinerario)
        {
            ViewBag.IdItinerario = IdItinerario;
            var lstResumenCompra = _viaje.FechaYHoraViaje(IdItinerario);
            return View(lstResumenCompra);
        }
        public IActionResult ListadoViaje()
        {
            var listado = _viaje.ListadoViaje();
            return View(listado);
        }
        [HttpPost]
        public IActionResult MiCompra(string DNI)
        {
            ServiceBusClient _service = new ServiceBusClient();
            var lstMisCompras = _service.MisComprasAsync(DNI).Result;
            return View(lstMisCompras);
        } 

    }
}