using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Articulo
    {
        public int ID_articulo { get; set; }
        public string  Cod_articulo { get; set; }
        public string Descripcion { get; set; }
        public Proveedor objProveedor { get; set; }
        public Subcategoria objSubcategoria { get; set; }
        public Categoria objCategoria { get; set; }
    }
}
