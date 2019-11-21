using System;
using System.Collections.Generic;

namespace Buses.Entities
{
    public partial class UsuarioEmpleado
    {
        public string IdUsuario { get; set; }
        public string Usuario { get; set; }
        public string Contrasenia { get; set; }
        public string Idempleado { get; set; }

        public Empleado IdempleadoNavigation { get; set; }
    }
}
