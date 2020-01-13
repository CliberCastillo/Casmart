using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Buses.DTO
{
    public class ItinerarioBusAgencia
    {
        public string IdItinerario { get; set; }
        public string IdBus { get; set; }
        public string AgenciaOrigen { get; set; }
        public string AgenciaDestino { get; set; }
        public string IdAgencia { get; set; }
        public DateTime HoraViaje { get; set; }
        //public string Hora { get; set; }
        public decimal? PrecioViaje { get; set; }
        public string NroPlaca { get; set; }
        public int NumeroAsiento { get; set; }
        public string EstadoBus { get; set; }
    }
}
