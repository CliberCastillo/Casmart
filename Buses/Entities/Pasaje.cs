using System;
using System.Collections.Generic;

namespace Buses.Entities
{
    public partial class Pasaje
    {
        public Pasaje()
        {
            Facturacion = new HashSet<Facturacion>();
        }

        public string NroPasaje { get; set; }
        public string IdReserva { get; set; }
        public string IdPasajero { get; set; }
        public string IdEmpleado { get; set; }
        public string IdItinerario { get; set; }
        public DateTime? FechaViaje { get; set; }
        public string Estado { get; set; }
        public string NumeroAsieto { get; set; }
        public int precioPasaje { get; set; }

        public ItinerarioViaje IdItinerarioNavigation { get; set; }
        public Pasajero IdPasajeroNavigation { get; set; }
        public ICollection<Facturacion> Facturacion { get; set; }
    }
}
