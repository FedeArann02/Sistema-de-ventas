using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Permiso
    {
        private CD_Permiso objcd_permiso = new CD_Permiso(); // instancia del objeto cd_permiso de la capa datos

        public List<Permiso> Listar(int idusuario)
        {
            return objcd_permiso.Listar(idusuario);
        }
    }
}
