using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Actividad3.Models;

namespace Actividad3.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            villancicosContext context = new villancicosContext();
            var villancicos = context.Villancico.OrderBy(x => x.Nombre);

            return View(villancicos);
        }
        public IActionResult villancico(int? id)
        {
            if(id==null)
            {
                return RedirectToAction("Index");
            }
            villancicosContext context = new villancicosContext();
            var villancicos = context.Villancico.FirstOrDefault(x => x.Id==id);

            if(villancicos==null)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View(villancicos);
            }


        }
    }
}
