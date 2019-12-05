using Buses.Entities;
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

        public List<ItinerarioViaje> ObtenerItinerarioViaje(string origen, string destino, DateTime fechaViaje)
        {
            return _context.ItinerarioViaje.Where(x => x.AgenciaOrigen == origen && x.AgenciaDestino == destino && x.HoraViaje == fechaViaje).ToList();
        }

        public List<Agencia> ObtenerListadoAgencia()
        {
            return _context.Agencia.ToList();
        }
    }
}
