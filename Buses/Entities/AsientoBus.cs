using System;
using System.Collections.Generic;

namespace Buses.Entities
{
    public partial class AsientoBus
    {
        public string IdAsientoBus { get; set; }
        public string IdBus { get; set; }
        public string NumeroAsiento { get; set; }

        public Bus IdBusNavigation { get; set; }
    }
}
