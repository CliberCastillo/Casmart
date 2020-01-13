using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Buses.Models;
using Buses.Service;
using Buses.Common;

namespace Buses.Controllers
{
    public class PaginaPrincipalController : Controller
    {
        private readonly IViajeRepository _viaje;
        public PaginaPrincipalController(IViajeRepository viaje)
        {
            _viaje = viaje;
        }
        public IActionResult Index()
        {
            var lstAgenciaPromociones = _viaje.ObtenerListadoAgenciaPromociones()
                .ChunkBy(Constantes.CantidadColumnas);

            AgenciaViajesViewModel ltsAgencia = new AgenciaViajesViewModel
            {
                Agencias = _viaje.ObtenerListadoAgencia(),
                AgenciasPromocionesAgrupado = lstAgenciaPromociones
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
