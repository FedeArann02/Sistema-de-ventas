using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Ingreso_egreso
    {
        public int ID_movimiento {  get; set; }
        public Vendedor ID_vendedor {  get; set; }
        public char tipo {  get; set; }
        public string detalle {  get; set; }
        public decimal monto {  get; set; }
        public DateTime fecha {  get; set; } // Date en SQL
        public string mes {  get; set; } //Char (2)
        public string año {  get; set; } //char (4)
    }
}
