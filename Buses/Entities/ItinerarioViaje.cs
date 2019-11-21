using System;
using System.Collections.Generic;

namespace Buses.Entities
{
    public partial class ItinerarioViaje
    {
        public ItinerarioViaje()
        {
            Pasaje = new HashSet<Pasaje>();
            Reserva = new HashSet<Reserva>();
        }

        public string IdItinerario { get; set; }
        public string IdBus { get; set; }
        public string AgenciaOrigen { get; set; }
        public string AgenciaDestino { get; set; }
        public string IdAgencia { get; set; }
        public DateTime HoraViaje { get; set; }
        public decimal? PrecioViaje { get; set; }

        public Agencia IdAgenciaNavigation { get; set; }
        public Bus IdBusNavigation { get; set; }
        public ICollection<Pasaje> Pasaje { get; set; }
        public ICollection<Reserva> Reserva { get; set; }
    }
}
