using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Buses.Models
{
    public class BusViewModel
    {
        [Required(ErrorMessage = "{0} es obligatorio")]
        [Display(Name = "Codigo")]
        public string IdBus { get; set; }
        [MinLength(7, ErrorMessage = "Mayor a 6 elementos")]
        [Required(ErrorMessage = "{0} es obligatorio")]
        [Display(Name = "Placa")]
        public string NroPlaca { get; set; }
        [Display(Name = "Numero Asiento")]
        public int NumeroAsiento { get; set; }

        [MinLength(5, ErrorMessage = "Mayor a {1} elementos")]
        [Required(ErrorMessage = "{0} es obligatorio")]
        [Display(Name = "Estado")]
        public string EstadoBus { get; set; }
    }
}
