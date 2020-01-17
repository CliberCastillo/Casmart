using Buses.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Buses.Service
{
    public class AgenciaRepository : IAgenciaRepository
    {
        private readonly AgenciaBusesContext _context;
        public AgenciaRepository(AgenciaBusesContext context)
        {
            _context = context;
        }
        public List<Agencia> listadoAgencia()
        {
            return _context.Agencia.ToList();
        }

        public List<Distrito> ListadoDistrito()
        {
            return _context.Distrito.ToList();
        }
    }
}
