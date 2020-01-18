using Buses.DTO;
using Buses.Entities;
using Buses.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Buses.Service
{
    public interface IViajeRepository
    {
        List<Agencia> ObtenerListadoAgencia();
        List<ItinerarioViaje> ObtenerItinerarioViaje(AgenciaViajesViewModel viajes);
        List<ItinerarioViaje> ObtenerListadoAgenciaPromociones();
        ItinerarioViaje FechaYHoraViaje(string IdItinerario);
        int ObtenerNumeroPasajeros();
        int ObtenerNumeroPasaje();
        bool GuardarPasajero(Pasajero pasajero);
        List<ItinerarioBusAgencia> ListadoViaje();
        void GuardarPasaje(string codigoPasaje, string IdItinerario, string dniPasajero, string fechaViaje, string numeroAsiento, int precioPasaje, string estado);
        bool ExistePasajero(string numeroDocumento);
        List<Bus> ObtenerListadoBus();
        void GuardarViaje(ItinerarioViaje itinerario);
        string AgenciaOrigenPorCodigo(string idAgenciaOrigen);
        int numeroItinerario();
    }
}
