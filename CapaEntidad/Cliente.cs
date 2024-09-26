using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Cliente
    {
        public int ID_cliente {  get; set; }
        public int Estado { get; set; }
        public string Documentacion {  get; set; }
        public string Nombre {  get; set; }
        public string Apellido {  get; set; }
        public string Direccion {  get; set; }
        public string Telefono {  get; set; }
        public string Correo {  get; set; }
        public string Entidad {  get; set; }
    }
}
