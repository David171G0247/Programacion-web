using System;
using System.Collections.Generic;

namespace Actividad4.models
{
    public partial class Cortometraje
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int? IdCategoria { get; set; }

        public virtual Categoria IdCategoriaNavigation { get; set; }
    }
}
