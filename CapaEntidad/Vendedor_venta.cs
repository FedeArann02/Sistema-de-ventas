using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Vendedor_venta
    {
        public int ID_vendedor_venta {  get; set; }
        public Vendedor ID_vendedor {  get; set; }
        public H_Remito id_remito {  get; set; }
        public DateTime Fecha {  get; set; }
        public decimal Remito_total {  get; set; }
        public decimal Remito_costo {  get; set; }
        public decimal Comision {  get; set; }
        public decimal Comision_total {  get; set; }
        public string Mes {  get; set; } //Char (2)
        public string Año {  get; set; } //Char (4)
    }
}
