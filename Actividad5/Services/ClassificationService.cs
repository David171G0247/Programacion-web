using Actividad5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Actividad5.Services
{
    public class ClassificationService
    {
        public List<Clase> Clasificacion { get; set; }
        public ClassificationService()
        {
            using (animalesContext context = new animalesContext())
            {
                Clasificacion = context.Clase.OrderBy(x => x.Nombre).ToList();
            }
        }
    }
}
