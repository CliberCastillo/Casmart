using Buses.Entities;
using Buses.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Buses.Service
{
    public interface IMantenimientoViaje
    {
        List<Agencia> ObtenerListadoAgencia();
        List<ItinerarioViaje> ObtenerItinerarioViaje(string origen, string destino, string fechaViaje);
    }
}
