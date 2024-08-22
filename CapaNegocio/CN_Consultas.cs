using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaNegocio;

namespace CapaNegocio
{
    public class CN_Consultas
    {
        private Consultas Querys = new Consultas();

        public DataTable DataTable ()
        {
            return Querys.ConsultaArt();
        }
    }
}
