using System;
using System.Collections.Generic;

namespace Buses.Entities
{
    public partial class Provincia
    {
        public Provincia()
        {
            Distrito = new HashSet<Distrito>();
        }

        public string IdProvincia { get; set; }
        public string NombreProvincia { get; set; }
        public string IdDepartamento { get; set; }

        public Departamento IdDepartamentoNavigation { get; set; }
        public ICollection<Distrito> Distrito { get; set; }
    }
}
