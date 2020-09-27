using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Actividad4.models;
using Microsoft.EntityFrameworkCore;
using Actividad4.Models;
using Actividad4.Models.ViewModels;
using System.Security.Cryptography.X509Certificates;

namespace Actividad4.Controlers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [Route("Peliculas")]
        public IActionResult Peliculas()
        {
            pixarContext context = new pixarContext();
            var peliculas = context.Pelicula.OrderBy(x => x.Nombre);
            return View(peliculas);
        }
        [Route("Cortos")]
        public IActionResult Cortos()
        {
            pixarContext context = new pixarContext();

            var categorias = context.Categoria.Include(x => x.Cortometraje).OrderBy(x=>x.Nombre)
                .Select(x=> new CortosViewModel { NombreCategoria=x.Nombre, cortometrajes=x.Cortometraje});

            return View(categorias);
        }
        [Route("Peliculas/{id}")]
        public IActionResult InformacionPelicula(string id)
        {
            pixarContext context = new pixarContext();
            var nombre = id.Replace("-", " ").ToLower();
            var Pelicula = context.Pelicula.Include(x=>x.Apariciones).FirstOrDefault(x => x.Nombre == nombre);
            var Apariciones = context.Apariciones.Include(x => x.IdPersonajeNavigation)
                .Include(x=>x.IdPeliculaNavigation).Where(x=>(x.IdPelicula==Pelicula.Id)).Select(x=>x);
            if(Pelicula==null)
            {
                return RedirectToAction("Peliculas");
            }
            else
            {
                InformacionPeliculaViewModel vm = new InformacionPeliculaViewModel();
                vm.Nombre = Pelicula.Nombre;
                vm.NombreOriginal = Pelicula.NombreOriginal;
                vm.Id = Pelicula.Id;
                vm.FechaEstreno = (DateTime)Pelicula.FechaEstreno;
                vm.Descripcion = Pelicula.Descripción;
                vm.apariciones = Apariciones;
                return View(vm);
            }
        }
        [Route("Cortos/{id}")]
        public IActionResult InformacionCorto(string id)
        {
            pixarContext context = new pixarContext();
            var nombre = id.Replace("-", " ").ToLower();
            var cortometraje = context.Cortometraje.FirstOrDefault(x => x.Nombre.ToLower() == nombre);
           
            if (cortometraje == null)
            {
                return RedirectToAction("Cortos");
            }
            else
            {
                return View(cortometraje);
            }
        }
    }
}