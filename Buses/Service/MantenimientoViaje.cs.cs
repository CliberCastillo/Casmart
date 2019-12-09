using Buses.Entities;
using Buses.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Buses.Service
{
    public class MantenimientoViaje: IMantenimientoViaje
    {
        private readonly AgenciaBusesContext _context;
        public MantenimientoViaje(AgenciaBusesContext context)
        {
            _context = context;
        }

        public List<ItinerarioViaje> ObtenerItinerarioViaje(AgenciaViajesViewModel viajes)
        {
            return _context.ItinerarioViaje.Where(x => x.AgenciaOrigen == viajes.Origen && x.AgenciaDestino == viajes.Destino && x.HoraViaje == viajes.Fecha).ToList();
        }

        public List<Agencia> ObtenerListadoAgencia()
        {
            return _context.Agencia.ToList();
        }
    }
}
