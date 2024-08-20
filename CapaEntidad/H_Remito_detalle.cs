using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class H_Remito_detalle
    {
        public int id_remito_detalle {  get; set; }
        public H_Remito id_remito {  get; set; }
        public Articulo cod_articulo {  get; set; }
        public string descripcion {  get; set; }
        public int precio_unitario {  get; set; }
        public int cantidad {  get; set; }
        public decimal precio_x_cantidad {  get; set; }
    }
}
