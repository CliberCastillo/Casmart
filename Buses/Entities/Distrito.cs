using System;
using System.Collections.Generic;

namespace Buses.Entities
{
    public partial class Distrito
    {
        public Distrito()
        {
            Agencia = new HashSet<Agencia>();
        }

        public string Cpostal { get; set; }
        public string NombreDistrito { get; set; }
        public string Idprovincia { get; set; }

        public Provincia IdprovinciaNavigation { get; set; }
        public ICollection<Agencia> Agencia { get; set; }
    }
}
