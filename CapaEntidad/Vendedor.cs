using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Vendedor
    {
        public int ID_vendedor {  get; set; }
        public string DNI {  get; set; }
        public string Nombre {  get; set; }
        public string Apellido {  get; set; }
        public string Comision {  get; set; }
    }
}
