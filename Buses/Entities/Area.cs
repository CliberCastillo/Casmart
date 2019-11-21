using System;
using System.Collections.Generic;

namespace Buses.Entities
{
    public partial class Area
    {
        public Area()
        {
            Cargo = new HashSet<Cargo>();
            Empleado = new HashSet<Empleado>();
        }

        public string IdArea { get; set; }
        public string NombreArea { get; set; }

        public ICollection<Cargo> Cargo { get; set; }
        public ICollection<Empleado> Empleado { get; set; }
    }
}
