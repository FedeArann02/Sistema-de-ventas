using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Proveedores
    {
        private CD_Proveedor objcd_proveedores = new CD_Proveedor();

        public List <Proveedor> Listar ()
        {
            return objcd_proveedores.Listar();
        }
    }
}
