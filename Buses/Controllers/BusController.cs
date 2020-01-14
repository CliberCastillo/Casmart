using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Buses.Models;
using Buses.Service;
using Microsoft.AspNetCore.Mvc;

using ServiceBus;
using Buses.Common;
namespace Buses.Controllers
{
    public class BusController : Controller
    {
        private ServiceBusClient _serviceBus = new ServiceBusClient();
        private readonly IBusRepository _bus;
        public BusController(IBusRepository bus)
        {
            _bus = bus;
        }
        public IActionResult Listado()
        {
            var lstBus = _serviceBus.ListaBusesAsync().Result;
            return View(lstBus);
        }
        public IActionResult Registrar()
        {
            var numeroBuses = _bus.ObtenerNumeroBus();
            ViewBag.codigoBus = GenerarCodigoBus.CodigoBus(numeroBuses);
            return View();
        }
        [HttpPost]
        public IActionResult Registrar(BusViewModel busV)
        {
            Bus bus = new Bus
            {
                IdBus = busV.IdBus,
                EstadoBus = busV.EstadoBus,
                NroPlaca = busV.NroPlaca,
                NumeroAsiento = busV.NumeroAsiento
            };
            if (ModelState.IsValid)
            {
                _serviceBus.InsertarBusAsync(bus);
                ViewBag.mensaje = "OK";
                return View();
            }
            else
            {
                ViewBag.mensaje = "Error";
                return View();
            }
        }
    }
}