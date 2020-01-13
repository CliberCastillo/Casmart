using Buses.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Buses.Service
{
    public interface IBusRepository
    {
        List<Bus> ListadoBus();
    }
}
