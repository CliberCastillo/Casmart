using Buses.DTO;
using Buses.Entities;
using Buses.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Buses.Service
{
    public class ViajeRepository : IViajeRepository
    {
        private readonly AgenciaBusesContext _context;
        public ViajeRepository(AgenciaBusesContext context)
        {
            _context = context;
        }

        public void GuardarPasaje(string codigoPasaje, string IdItinerario, string dniPasajero, string fechaViaje, string numeroAsiento, int precioPasaje, string estado)
        {
            var fechViaje = Convert.ToDateTime(fechaViaje);
            var buscarPasajeroDni = _context.Pasajero.Where(x => x.NumeroDocumento == dniPasajero)
                                                        .Select(u => u.IdPasajero)
                                                        .FirstOrDefault();


            Pasaje pasaje = new Pasaje
            {
                NroPasaje = codigoPasaje,
                IdItinerario = IdItinerario,
                IdPasajero = buscarPasajeroDni,
                FechaViaje = fechViaje,
                Estado = estado,
                NumeroAsieto = numeroAsiento,
                precioPasaje = precioPasaje
            };
            _context.Pasaje.Add(pasaje);
            _context.SaveChanges();
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

        public bool ExistePasajero(string numeroDocumento)
        {
            var existePasajero = _context.Pasajero.Any(x => x.NumeroDocumento == numeroDocumento);
            return existePasajero;
        }



        public bool GuardarPasajero(Pasajero pasajero)
        {
            _context.Pasajero.Add(pasajero);
            if (_context.SaveChanges() > 0) return true;
            return false;
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

        public int ObtenerNumeroPasaje()
        {
            var nose = _context.Pasaje.Count();
            return nose; 
        }

        public List<ItinerarioBusAgencia> ListadoViaje()
        {
            var query = _context.ItinerarioViaje
                .Join(_context.Bus, i => i.IdBus, b => b.IdBus, (iv, bs) => new { iv, bs })
                .Join(_context.Agencia, i => i.iv.IdAgencia, a => a.IdAgencia, (ivi, ag) => new { ivi, ag })
                .Select(x => new ItinerarioBusAgencia
                {

                    AgenciaOrigen = x.ivi.iv.AgenciaOrigen,
                    AgenciaDestino = x.ivi.iv.AgenciaDestino,
                    NroPlaca = x.ivi.bs.NroPlaca,
                    NumeroAsiento = x.ivi.bs.NumeroAsiento
                })
                .ToList();

            //var entryPoint = (from iti in _context.ItinerarioViaje
            //                  join bu in _context.Bus on iti.IdBus equals bu.IdBus
            //                  join age in _context.Agencia on iti.IdAgencia equals age.IdAgencia
            //                  select new
            //                  {


            //                  }).Take(10);
            return query;
        }
    }
}
