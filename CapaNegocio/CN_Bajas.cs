using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Bajas
    {
        Bajas objcd_Bajas = new Bajas();
        public void CN_BajaPresupuesto(string Cod_Presupuesto)
        {
            objcd_Bajas.EliminarPresupuesto(Cod_Presupuesto);
        }
    }
}
