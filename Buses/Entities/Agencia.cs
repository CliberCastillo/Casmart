using System;
using System.Collections.Generic;

namespace Buses.Entities
{
    public partial class Agencia
    {
        public Agencia()
        {
            ItinerarioViaje = new HashSet<ItinerarioViaje>();
        }

        public string IdAgencia { get; set; }
        public string NombreAgencia { get; set; }
        public string Cpostal { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string EstadoAgencia { get; set; }

        public Distrito CpostalNavigation { get; set; }
        public ICollection<ItinerarioViaje> ItinerarioViaje { get; set; }
    }
}
