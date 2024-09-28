using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public  class CN_Subcategoria
    {
        private CD_SubCategoria objcd_Subcategoria = new CD_SubCategoria();

        public List<Subcategoria> Listar()
        {
            return objcd_Subcategoria.Listar();
        }
    }
}
