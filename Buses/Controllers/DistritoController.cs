using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Buses.Controllers
{
    using ServiceBus;
    public class DistritoController : Controller
    {
        private ServiceBusClient _serviceBus = new ServiceBusClient();
        public IActionResult Listado()
        {
            var lstDistrito = _serviceBus.ListaDistritoAsync().Result;
            return View(lstDistrito);
        }
    }
}