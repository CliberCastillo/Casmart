using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Buses.Common
{
    public static class GenerarCodigoPasaje
    {
        public static string CodigoPasaje(int NumeroPasajeros)
        {
            NumeroPasajeros = NumeroPasajeros + 1;
            string codigo;

            if (NumeroPasajeros >= 0 && NumeroPasajeros <= 9)
            {
                codigo = "NR000" + NumeroPasajeros;
            }
            else if (NumeroPasajeros >= 10 && NumeroPasajeros <= 99)
            {
                codigo = "NR00" + NumeroPasajeros;
            }
            else if (NumeroPasajeros >= 100 && NumeroPasajeros <= 999)
            {
                codigo = "Nr0" + NumeroPasajeros;
            }
            else if (NumeroPasajeros >= 1000 && NumeroPasajeros <= 9999)
            {
                codigo = "NR" + NumeroPasajeros;
            }
            else
            {
                codigo = "N"+NumeroPasajeros;
            }
            return codigo;
        }
    }
}
