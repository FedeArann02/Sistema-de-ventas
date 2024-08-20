using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Stock
    {
        public int ID_stock {  get; set; }
        public Articulo Cod_articulo {  get; set; }
        public int Cantidad {  get; set; }
        public decimal Costo {  get; set; }
        public decimal Ganancia {  get; set; }
    }
}
