using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Buses.Entities;

using ServiceBus;
using Microsoft.AspNetCore.Mvc;
using Buses.Service;

namespace Buses.Controllers
{
    public class AgenciaController : Controller
    {
        private readonly IAgenciaRepository _agencia;
        public AgenciaController(IAgenciaRepository agencia)
        {
            _agencia = agencia;
        }
        public IActionResult Listado()
        {
            var lstAgencia = _agencia.listadoAgencia();
            return View(lstAgencia);
        }
        public IActionResult Registrar()
        {
            var lstDistrito = _agencia.ListadoDistrito();
            return View(lstDistrito);
        }
        [HttpPost]
        public IActionResult Registrar(ServiceBus.Agencia agencia)
        {
            ServiceBusClient service = new ServiceBusClient();
            service.InsertarAgenciaAsync(agencia);
            return RedirectToAction("Listado","Agencia");
        }
    }
}