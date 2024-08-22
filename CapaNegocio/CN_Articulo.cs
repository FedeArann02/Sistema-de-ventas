using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;
using CapaNegocio;

namespace CapaNegocio
{
    public class CN_Articulo
    {
        private CD_Articulo objcd_articulo = new CD_Articulo();

        public List<Articulo> Listar()
        {
            return objcd_articulo.Listar();
        }
    }
}
