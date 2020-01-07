using System;
using System.Collections.Generic;

namespace Buses.Entities
{
    public partial class Pasajero
    {
        public Pasajero()
        {
            Pasaje = new HashSet<Pasaje>();
            UsuarioPasajero = new HashSet<UsuarioPasajero>();
        }

        public string IdPasajero { get; set; }
        public string Nombres { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Telefono { get; set; }
        public string NumeroDocumento { get; set; }
        public string TipoDocumento { get; set; }
        public string Correo { get; set; }

        public ICollection<Pasaje> Pasaje { get; set; }
        public ICollection<UsuarioPasajero> UsuarioPasajero { get; set; }
    }
}
