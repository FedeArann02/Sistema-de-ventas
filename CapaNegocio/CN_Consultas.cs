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

        public DataTable ConsultaArtMod(string Codigo)
        {
            return Querys.ConsultaArtMod(Codigo);
        }

        public DataTable ConsultaCliente(string Documentacion)
        {
            return Querys.ConsultaCliente(Documentacion);
        }

        public DataTable ConsultaPresupuesto(string Nro_prespuesto)
        {
            return Querys.ConsultaPresupuesto(Nro_prespuesto);
        }
        public DataTable ConsultaP_Detalle(string Nro_presupuesto)
        {
            return Querys.ConsultaPresupuestoDetalle(Nro_presupuesto);
        }
    }
}
