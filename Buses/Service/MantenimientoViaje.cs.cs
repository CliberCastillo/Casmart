using Buses.Entities;
using Buses.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Buses.Service
{
    public class MantenimientoViaje : IMantenimientoViaje
    {
        private readonly AgenciaBusesContext _context;
        public MantenimientoViaje(AgenciaBusesContext context)
        {
            _context = context;
        }

        public ItinerarioViaje FechaYHoraViaje(string IdItinerario)
        {
            return _context.ItinerarioViaje.Where(x => x.IdItinerario == IdItinerario)
                                                .Select(x => new ItinerarioViaje
                                                {
                                                    HoraViaje = x.HoraViaje,
                                                    AgenciaOrigen = x.AgenciaOrigen,
                                                    AgenciaDestino = x.AgenciaDestino,
                                                    PrecioViaje = x.PrecioViaje
                                                })
                                                .SingleOrDefault();
        }

        public string GuardarPasajero(Pasajero pasajero)
        {
            string mensaje;
            var pasajeros = _context.Pasajero.Where(x => x.NumeroDocumento == pasajero.NumeroDocumento).Count();
            if (pasajeros == 0)
            {
                _context.Pasajero.Add(pasajero);
                _context.SaveChanges();
                mensaje = "Registrado";
            }
            else
            {
                mensaje = "NoRegistrado";
            }
            return mensaje;
        }

        public List<ItinerarioViaje> ObtenerItinerarioViaje(AgenciaViajesViewModel viajes)
        {
            return _context.ItinerarioViaje.Where(x => x.AgenciaOrigen == viajes.Origen && x.AgenciaDestino == viajes.Destino)
                                            .ToList();
        }

        public List<Agencia> ObtenerListadoAgencia()
        {
            return _context.Agencia.ToList();
        }

        public List<ItinerarioViaje> ObtenerListadoAgenciaPromociones()
        {
            return _context.ItinerarioViaje.Where(x => x.PrecioViaje <= 25).ToList();
        }

        public int ObtenerNumeroPasajeros()
        {
            return _context.Pasajero.Count();
        }
    }
}
