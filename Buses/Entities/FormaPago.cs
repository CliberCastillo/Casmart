using System;
using System.Collections.Generic;

namespace Buses.Entities
{
    public partial class FormaPago
    {
        public FormaPago()
        {
            Facturacion = new HashSet<Facturacion>();
        }

        public string IdFormaPago { get; set; }
        public string NombreFormaPago { get; set; }

        public ICollection<Facturacion> Facturacion { get; set; }
    }
}
