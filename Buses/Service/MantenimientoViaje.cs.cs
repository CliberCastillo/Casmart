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

        public bool Login(string usuario, string contraseña)
        {
            int UsuarioEmpleado = _context.UsuarioEmpleado
                                    .Where(x => x.Usuario == usuario && x.Contrasenia == contraseña)
                                    .Count();

            int UsuarioPasajero = _context.UsuarioPasajero
                                    .Where(x => x.Usuario == usuario && x.Contrasenia == contraseña)
                                    .Count();

            if (UsuarioEmpleado >= 1 || UsuarioPasajero >= 1)
            {
                return true;
            }
            return false;
        }

        public List<Agencia> ObtenerListadoAgencia()
        {
            return _context.Agencia.ToList();
        }
    }
}
