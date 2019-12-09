using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Buses.Models;
using Buses.Service;

namespace Buses.Controllers
{
    public class PaginaPrincipalController : Controller
    {
        private readonly IMantenimientoViaje _mantenimientoViaje;
        public PaginaPrincipalController(IMantenimientoViaje mantenimientoViaje)
        {
            _mantenimientoViaje = mantenimientoViaje;
        }
        public IActionResult Index()
        {
            AgenciaViajesViewModel ltsAgencia = new AgenciaViajesViewModel
            {
                Agencias = _mantenimientoViaje.ObtenerListadoAgencia(),
                AgenciasPromociones = _mantenimientoViaje.ObtenerListadoAgenciaPromociones()
            };
            return View(ltsAgencia);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
