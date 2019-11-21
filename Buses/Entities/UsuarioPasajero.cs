using System;
using System.Collections.Generic;

namespace Buses.Entities
{
    public partial class UsuarioPasajero
    {
        public string IdUsuarioPasajero { get; set; }
        public string Usuario { get; set; }
        public string Contrasenia { get; set; }
        public string Idpasajero { get; set; }

        public Pasajero IdpasajeroNavigation { get; set; }
    }
}
