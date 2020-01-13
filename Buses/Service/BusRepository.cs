using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Buses.Entities;

namespace Buses.Service
{
    public class BusRepository : IBusRepository
    {
        private readonly AgenciaBusesContext _context;
        public BusRepository(AgenciaBusesContext context)
        {
            _context = context;
        }

        public List<Bus> ListadoBus()
        {
            return _context.Bus.ToList();
        }
    }
}
