using System;
using System.Collections.Generic;

namespace Buses.Entities
{
    public partial class Bus
    {
        public Bus()
        {
            AsientoBus = new HashSet<AsientoBus>();
            ItinerarioViaje = new HashSet<ItinerarioViaje>();
        }

        public string IdBus { get; set; }
        public string NroPlaca { get; set; }
        public int NumeroAsiento { get; set; }
        public string EstadoBus { get; set; }

        public ICollection<AsientoBus> AsientoBus { get; set; }
        public ICollection<ItinerarioViaje> ItinerarioViaje { get; set; }
    }
}
