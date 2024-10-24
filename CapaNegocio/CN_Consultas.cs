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

        public DataTable ConsultaClienteCtaCte(string Documentacion)
        {
            return Querys.ConsultaClienteCtaCte(Documentacion);
        }

        public DataTable ConsultaProveedores()
        {
            return Querys.ConsultaProveedores();
        }
        public DataTable ConsultaProveedores(string ID_Proveedor)
        {
            return Querys.ConsultaProveedores(ID_Proveedor);
        }

        public DataTable ConsultaArtXproveedor(string ID_Proveedor)
        {
            return Querys.ConsultaArtXproveedor(ID_Proveedor);
        }

        public DataTable ConsultaProveedorCtaCte(string ID_Proveedor)
        {
            return Querys.ConsultaProveedorCtaCte(ID_Proveedor);
        }

        public DataTable ConsultaPresupuesto(string Nro_prespuesto)
        {
            return Querys.ConsultaPresupuesto(Nro_prespuesto);
        }
        public DataTable ConsultaP_Detalle(string Nro_presupuesto)
        {
            return Querys.ConsultaPresupuestoDetalle(Nro_presupuesto);
        }
        public DataTable ConsultaR_Detalle(string Nro_presupuesto)
        {
            return Querys.ConsultaRemitoDetalle(Nro_presupuesto);
        }
        public DataTable ConsultaPresupuesto_Remito_Cliente(string Documentacion, string Opcion)
        {
            return Querys.ConsultaPresupuesto_Remito_Cliente(Documentacion, Opcion);
        }
        public DataTable ConsultaSubcategorias()
        {
            return Querys.ConsultaSubcategorias();
        }

        public DataTable ConsultaUltimoCodigoRemito()
        {
            return Querys.ConsultaUltimoCodigoRemito();
        }
        public DataTable ConsultaUltimoCodigoPresupuesto()
        {
            return Querys.ConsultaUltimoCodigoPresupuesto();
        }
    }
}
