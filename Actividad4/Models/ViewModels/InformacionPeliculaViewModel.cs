using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Actividad4.models;

namespace Actividad4.Models.ViewModels
{
    public class InformacionPeliculaViewModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string NombreOriginal { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaEstreno { get; set; }
        public IEnumerable<Apariciones> apariciones { get; set; }
    }
}
