using System;
using System.Collections.Generic;

namespace Buses.Entities
{
    public partial class Cargo
    {
        public string IdCargo { get; set; }
        public string NombreCargo { get; set; }
        public string IdArea { get; set; }

        public Area IdAreaNavigation { get; set; }
    }
}
