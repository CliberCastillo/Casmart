using Buses.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Buses.Models
{
    public class AgenciaViajesViewModel
    {
        public AgenciaViajesViewModel()
        {
            Agencias = new List<Agencia>();
            AgenciasPromociones = new List<ItinerarioViaje>();
        }
        public List<Agencia> Agencias { get; set; }
        public List<ItinerarioViaje> AgenciasPromociones { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
        public string FechaViaje { get; set; }
    }
}
