using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Buses.Service;
using Microsoft.AspNetCore.Mvc;

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
    }
}