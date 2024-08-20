using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class H_Remito
    {
        public string id_remito {  get; set; }
        public DateTime fecha_hora { get; set; }
        public string nombre { get; set; }
        public string tel { get; set; }
        public string email { get; set; }
        public string entidad { get; set; }
        public string dni { get; set; }
        public decimal subtotal { get; set; }
        public decimal descuento { get; set; }
        public decimal total { get; set; }
        public decimal total_costos { get; set; }
        public string mes { get; set; } //Char (2)
        public string año { get; set; }
        public string direccion { get; set; }
    }
}
