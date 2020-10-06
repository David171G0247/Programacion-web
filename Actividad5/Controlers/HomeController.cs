using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Actividad5.Models;
using Actividad5.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Actividad5.Controlers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public IActionResult Index()
        {
            animalesContext context = new animalesContext();
            var clasificacion = context.Clase.OrderBy(x => x.Nombre);
            return View(clasificacion);
        }
        [Route("/Especies")]
        public IActionResult Especie()
        {
            animalesContext context = new animalesContext();
            var especies = context.Clase.Include(x => x.Especies).OrderBy(x => x.Nombre)
                .Select(x => new EspeciesViewModel { NombreEspecie = x.Nombre, Especies = x.Especies });
            return View(especies);
        }
    }
}