using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Buses.Controllers
{
    public class PasajeController : Controller
    {
        public IActionResult Hora()
        {
            return View();
        }
    }
}