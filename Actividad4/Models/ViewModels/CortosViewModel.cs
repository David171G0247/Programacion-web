using Actividad4.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Actividad4.Models
{
    public class CortosViewModel
    {
        public string NombreCategoria { get; set; }
        public IEnumerable<models.Cortometraje> cortometrajes { get; set; }
    }
}
