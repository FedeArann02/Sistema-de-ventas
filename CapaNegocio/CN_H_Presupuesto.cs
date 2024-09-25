using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_H_Presupuesto
    {
        private CD_H_Presupuesto objcd_h_presupuesto = new CD_H_Presupuesto();

        public List<H_Presupuesto> ListarNombreNro()
        {
            return objcd_h_presupuesto.ListarNombreNro();
        }
    }
}
