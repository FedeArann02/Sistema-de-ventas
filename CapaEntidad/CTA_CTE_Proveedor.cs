using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class CTA_CTE_Proveedor
    {
        public int ID_CtaCteProv {  get; set; }
        public Proveedor ID_Proveedor {  get; set; }
        public decimal Compras {  get; set; }
        public decimal Pagos {  get; set; }
        public DateTime Fecha {  get; set; }
    }
}
