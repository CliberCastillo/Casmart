using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Buses.Common
{
    public static class GenerarCodigoBus
    {
        public static string CodigoBus(int NumeroBus)
        {
            NumeroBus = NumeroBus + 1;
            string codigo;

            if (NumeroBus >= 0 && NumeroBus <= 9)
            {
                codigo = "BU000" + NumeroBus;
            }
            else if (NumeroBus >= 10 && NumeroBus <= 99)
            {
                codigo = "BU00" + NumeroBus;
            }
            else if (NumeroBus >= 100 && NumeroBus <= 999)
            {
                codigo = "BU0" + NumeroBus;
            }
            else if (NumeroBus >= 1000 && NumeroBus <= 9999)
            {
                codigo = "Bu" + NumeroBus;
            }
            else
            {
                codigo = "P"+NumeroBus;
            }
            return codigo;
        }
    }
}
