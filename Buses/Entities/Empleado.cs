using System;
using System.Collections.Generic;

namespace Buses.Entities
{
    public partial class Empleado
    {
        public Empleado()
        {
            Reserva = new HashSet<Reserva>();
            UsuarioEmpleado = new HashSet<UsuarioEmpleado>();
        }

        public string IdEmpleado { get; set; }
        public string Nombres { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string IdCargo { get; set; }
        public string IdArea { get; set; }
        public string Telefono { get; set; }
        public string NumeroDocumento { get; set; }
        public string TipoDocumento { get; set; }
        public string Correo { get; set; }

        public Area IdAreaNavigation { get; set; }
        public ICollection<Reserva> Reserva { get; set; }
        public ICollection<UsuarioEmpleado> UsuarioEmpleado { get; set; }
    }
}
