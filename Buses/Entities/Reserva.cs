using System;
using System.Collections.Generic;

namespace Buses.Entities
{
    public partial class Reserva
    {
        public Reserva()
        {
        }

        public string IdReserva { get; set; }
        public string IdPasajero { get; set; }
        public string IdEmpleado { get; set; }
        public DateTime? FechaReserva { get; set; }
        public string IdItinerario { get; set; }
        public DateTime? FechaLimite { get; set; }
        public string Estado { get; set; }

        public Empleado IdEmpleadoNavigation { get; set; }
        public ItinerarioViaje IdItinerarioNavigation { get; set; }
        public Pasajero IdPasajeroNavigation { get; set; }
    }
}
