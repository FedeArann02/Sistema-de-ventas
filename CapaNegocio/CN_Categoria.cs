using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Categoria
    {
        private CD_Categoria objc_categoria = new CD_Categoria();
        
        public List<Categoria> Listar (string filtro)
        {
            return objc_categoria.Listar(filtro);
        }
    }
}
