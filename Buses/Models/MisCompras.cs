using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Buses.Models
{
    public class MisCompras
    {
        public string Nombres { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string NumeroDocumento { get; set; }
        public string Telefono { get; set; }
        public string AgenciaOrigen { get; set; }
        public string AgenciaDestino { get; set; }
        public DateTime HoraViaje { get; set; }
        public int PrecioViaje { get; set; }
        public string NroPlaca { get; set; }
    }
}
