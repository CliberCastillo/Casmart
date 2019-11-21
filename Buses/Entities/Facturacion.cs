using System;
using System.Collections.Generic;

namespace Buses.Entities
{
    public partial class Facturacion
    {
        public string NroFacturacion { get; set; }
        public string NroPasaje { get; set; }
        public DateTime FechaEmision { get; set; }
        public string IdformaPago { get; set; }
        public decimal? SubTotal { get; set; }
        public decimal? Igv { get; set; }
        public decimal? Total { get; set; }

        public FormaPago IdformaPagoNavigation { get; set; }
        public Pasaje NroPasajeNavigation { get; set; }
    }
}
