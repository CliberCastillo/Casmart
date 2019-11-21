using System;
using System.Collections.Generic;

namespace Buses.Entities
{
    public partial class Departamento
    {
        public Departamento()
        {
            Provincia = new HashSet<Provincia>();
        }

        public string IdDepartamento { get; set; }
        public string NombreDepartamento { get; set; }

        public ICollection<Provincia> Provincia { get; set; }
    }
}
