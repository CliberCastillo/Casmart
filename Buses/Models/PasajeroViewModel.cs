using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Buses.Models
{
    public class PasajeroViewModel
    {
        public string nombres { get; set; }
        public string apellidoPaterno { get; set; }
        public string apellidoMaterno { get; set; }
        public int telefono { get; set; }
        public int dni { get; set; }
        public string correo { get; set; }
    }
}
