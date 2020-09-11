using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Paso_de_parámetros.Models;

namespace Paso_de_parámetros.Controlers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Resultado(Suma s)
        {
            return View(s.num1+s.num2);
        }
    }
}
