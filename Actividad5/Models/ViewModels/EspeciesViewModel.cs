using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Actividad5.Models.ViewModels
{
    public class EspeciesViewModel
    {
        public string NombreEspecie { get; set; }
        public ICollection<Models.Especies> Especies { get; set; }
    }
}
