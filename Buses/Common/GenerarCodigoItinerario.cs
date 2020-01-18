using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Buses.Common
{
    public static class GenerarCodigoItinerario
    {
        public static string CodigoItinerario(int NumeroItinerario)
        {
            NumeroItinerario = NumeroItinerario + 1;
            string codigo;

            if (NumeroItinerario >= 0 && NumeroItinerario <= 9)
            {
                codigo = "NR000" + NumeroItinerario;
            }
            else if (NumeroItinerario >= 10 && NumeroItinerario <= 99)
            {
                codigo = "NR00" + NumeroItinerario;
            }
            else if (NumeroItinerario >= 100 && NumeroItinerario <= 999)
            {
                codigo = "Nr0" + NumeroItinerario;
            }
            else if (NumeroItinerario >= 1000 && NumeroItinerario <= 9999)
            {
                codigo = "NR" + NumeroItinerario;
            }
            else
            {
                codigo = "N"+ NumeroItinerario;
            }
            return codigo;
        }
    }
}
