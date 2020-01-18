using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Buses.Controllers
{
    using Buses.Entities;
    using Buses.Service;
    using ServiceBus;
    public class DistritoController : Controller
    {
        private readonly IDistritoRepository _distrito;
        public DistritoController(IDistritoRepository distrito)
        {
            _distrito = distrito;
        }
        private ServiceBusClient _serviceBus = new ServiceBusClient();

        public IActionResult Listado()
        {
            var lstDistrito = _serviceBus.ListaDistritoAsync().Result;
            return View(lstDistrito);
        }
        public IActionResult Registrar()
        {
            var lstProvincia = _distrito.ListadoProvincia();
            return View(lstProvincia);
        }
        [HttpPost]
        public IActionResult Registrar(ServiceBus.Distrito distrito)
        {
            _serviceBus.InsertarDistritoAsync(distrito);
            return RedirectToAction("Listado");
        }
    }
}