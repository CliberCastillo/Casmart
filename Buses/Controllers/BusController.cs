using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Buses.Service;
using Microsoft.AspNetCore.Mvc;
using ServiceBus;

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
            return View();
        }
        [HttpPost]
        public IActionResult Registrar(Bus bus)
        {
            return View();
        }
    }
}