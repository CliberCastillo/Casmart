using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Buses.Common
{
    public static class GenerarCodigoPasajero
    {
        public static string CodigoPasajero(int NumeroPasajeros)
        {
            NumeroPasajeros = NumeroPasajeros + 1;
            string codigo;

            if (NumeroPasajeros >= 0 && NumeroPasajeros <= 9)
            {
                codigo = "PA000" + NumeroPasajeros;
            }
            else if (NumeroPasajeros >= 10 && NumeroPasajeros <= 99)
            {
                codigo = "PA00" + NumeroPasajeros;
            }
            else if (NumeroPasajeros >= 100 && NumeroPasajeros <= 999)
            {
                codigo = "PA0" + NumeroPasajeros;
            }
            else if (NumeroPasajeros >= 1000 && NumeroPasajeros <= 9999)
            {
                codigo = "PA" + NumeroPasajeros;
            }
            else
            {
                codigo = "P"+NumeroPasajeros;
            }
            return codigo;
        }
    }
}
