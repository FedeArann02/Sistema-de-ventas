using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Subcategoria
    {
        public int Cod_subcategoria {  get; set; }
        public Categoria objCategoria { get; set; }
        public string Nombre { get; set; }
    }
}
