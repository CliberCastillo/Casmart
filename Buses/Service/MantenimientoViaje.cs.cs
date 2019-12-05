using Buses.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Buses.Service
{
    public class MantenimientoViaje: IMantenimientoViaje
    {
        private readonly AgenciaBusesContext _context;
        public MantenimientoViaje(AgenciaBusesContext context)
        {
            _context = context;
        }
        

        public List<Agencia> ObtenerListadoAgencia()
        {
            return _context.Agencia.ToList();
        }
    }
}
