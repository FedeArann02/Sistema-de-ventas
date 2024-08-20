using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Usuario
    {
        private CD_Usuario objcd_usuario = new CD_Usuario(); // instancia del objeto cd_usuario de la capa datos

        public List<Usuario> Listar()
        {
            return objcd_usuario.Listar();
        }
    }
}
