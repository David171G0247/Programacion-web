using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Practica_1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Sumar(int n1, int n2)
        {
            int res = n1 + n2;
            return View(res);
        }
        public IActionResult Numeros()
        {
            List<int> numeros = new List<int> { 10, 56, 44, 24, 2};
            return View(numeros);
        }
    }
}
