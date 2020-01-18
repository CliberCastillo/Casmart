using Buses.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Buses.Service
{
    public class DistritoRepository : IDistritoRepository
    {
        private readonly AgenciaBusesContext _context;

        public DistritoRepository(AgenciaBusesContext context)
        {
            _context = context;
        }

        public List<Provincia> ListadoProvincia()
        {
            return _context.Provincia.ToList();
        }
    }
}
