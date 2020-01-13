using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Buses.Service;
using Microsoft.AspNetCore.Mvc;

namespace Buses.Controllers
{
    public class BusController : Controller
    {
        private readonly IBusRepository _bus;
        public BusController(IBusRepository bus)
        {
            _bus = bus;
        }
        public IActionResult Listado()
        {
            var lstBus = _bus.ListadoBus();
            return View(lstBus);
        }
    }
}