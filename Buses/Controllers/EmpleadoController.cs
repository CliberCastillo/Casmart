using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using ServiceBus;

namespace Buses.Controllers
{
    public class EmpleadoController : Controller
    {
        private ServiceBusClient _serviceBus = new ServiceBusClient();

        public IActionResult Listado()
        {
            var lstEmpleado = _serviceBus.ListaEmpleadoAsync().Result;
            return View(lstEmpleado);
        }
    }
}