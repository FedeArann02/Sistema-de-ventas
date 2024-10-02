using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Modificaciones
    {
        Modificaciones objcd_modificaciones = new Modificaciones();
        public bool modConfirm;

        public void modArt(string Codigo, string Descripcion, int Cantidad, decimal Costo, decimal Ganancia)
        {
            objcd_modificaciones.modArt(Codigo, Descripcion, Cantidad, Costo, Ganancia);
            if (objcd_modificaciones.modConfirm)
            {
                modConfirm = true;
            }
            else
            {
                modConfirm = false;
            }
        }
        public void modArt(int Cod_Categoria, int Cod_SubCategoria, int ID_Proveedor, decimal Costo)//Costo
        {
            objcd_modificaciones.modArt(Cod_Categoria, Cod_SubCategoria, ID_Proveedor, Costo);
            if (objcd_modificaciones.modConfirm)
            {
                modConfirm = true;
            }
            else
            {
                modConfirm = false;
            }
        }
        public void modArt_Ganancia(int Cod_Categoria, int Cod_SubCategoria, int ID_Proveedor, decimal Ganancia)
        {
            objcd_modificaciones.modArt_Ganancia(Cod_Categoria, Cod_SubCategoria, ID_Proveedor, Ganancia);
            if (objcd_modificaciones.modConfirm)
            {
                modConfirm = true;
            }
            else
            {
                modConfirm = false;
            }
        }
        public void mod_Presupuesto(string Doc, string Nombre, string Apellido, string Tel, string Mail, string Ent, string Dir, decimal Sub, decimal Descuento, decimal Total, DateTime F_H, DataGridView dgv,string NroP)
        {
            objcd_modificaciones.modPresupuesto(Doc, Nombre, Apellido, Tel, Mail, Ent, Dir, Sub, Descuento, Total, F_H, dgv, NroP);

            if (objcd_modificaciones.modConfirm)
            {
                modConfirm = true;
            }
            else
            {
                modConfirm = false;
            }
        }

        public void RegistraPagoCliente(string Documentacion, decimal Monto)
        {
            objcd_modificaciones.RegistraPagoCliente(Documentacion, Monto);

            if (objcd_modificaciones.modConfirm)
            {
                modConfirm = true;
            }
            else
            {
                modConfirm = false;
            }
        }

        public void ActualizarStock(DataGridView dgv)
        {
            objcd_modificaciones.ActualizarStock(dgv);

            if (objcd_modificaciones.modConfirm)
            {
                modConfirm = true;
            }
            else
            {
                modConfirm = false;
            }
        }
        
    }
}
