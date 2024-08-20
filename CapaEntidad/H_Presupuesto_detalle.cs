using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    internal class H_Presupuesto_detalle
    {
        public int id_presupuesto_detalle {  get; set; }
        public H_Presupuesto id_presupuesto {  get; set; }
        public string codigo_articulo {  get; set; }
        public string descripcion {  get; set; }
        public decimal precio_unitario {  get; set; }
        public int cantidad {  get; set; }
        public decimal precio_x_cantidad {  get; set; }
    }
}
