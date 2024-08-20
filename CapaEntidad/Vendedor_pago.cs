using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Vendedor_pago
    {
        public int ID_pago {  get; set; }
        public Vendedor ID_vendedor {  get; set; }
        public DateTime Fecha_pago { get; set; }
        public decimal Monto {  get; set; }
    }
}
