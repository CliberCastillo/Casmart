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
            agencias = new List<Agencia>();
        }
        public List<Agencia> agencias { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
        public DateTime Fecha { get; set; }
    }
}
