using Buses.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Buses.Models
{
    public class BusAgenciaViewModel
    {
        public BusAgenciaViewModel()
        {
            buses = new List<Bus>();
            agencias = new List<Agencia>();
        }
        public List<Bus> buses { get; set; }
        public List<Agencia> agencias { get; set; }
    }
}
