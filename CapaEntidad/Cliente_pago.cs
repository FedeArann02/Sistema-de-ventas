using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Cliente_pago
    {
        public int ID_pago {  get; set; }
        public Cliente ID_cliente {  get; set; }
        public DateTime Fecha {  get; set; }
        public decimal Monto {  get; set; }
    }
}
