using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;

namespace CapaNegocio
{

    public class CN_Altas
    {
        Altas objcd_Altas = new Altas();
        
        public bool clearConf;

        public void CN_ArtAlta (string Codigo, int codCategoria, int codSubCategoria, string Descripcion, int IdProveedor, int Cantidad, decimal Costo, decimal Ganancia)
        {
            objcd_Altas.altaArt(Codigo, codCategoria, codSubCategoria, Descripcion, IdProveedor, Cantidad, Costo, Ganancia);
            if (objcd_Altas.clearConfirm)
            {
                clearConf = true;
            }
            else
            {
                clearConf = false;
            }
        }

        public void CN_PresupAlta (string Doc, string Nombre, string Apellido, string Tel, string Mail, string Ent, string Dir, decimal Sub, decimal Descuento, decimal Total, DateTime F_H, DataGridView dgv, string NroP)
        {
            objcd_Altas.altaPresupuesto(Doc, Nombre, Apellido, Tel, Mail, Ent, Dir, Sub, Descuento, Total, F_H, dgv, NroP);

            if (objcd_Altas.clearConfirm)
            {
                clearConf = true;
            }
            else
            {
                clearConf = false;
            }
        }

        public void CN_AltaCliente_PresupuestoRemito(string Doc, string Nombre, string Apellido, string Dir, string Tel, string Correo, string Entidad)
        {
            objcd_Altas.AltaCliente_PresupuestoRemito(Doc, Nombre, Apellido, Dir, Tel, Correo, Entidad);
        }

        public void CN_AltaCliente(string Doc, string Nombre, string Apellido, string Dir, string Tel, string Correo, string Entidad)
        {
            objcd_Altas.AltaCliente(Doc, Nombre, Apellido, Dir, Tel, Correo, Entidad);
            if (objcd_Altas.clearConfirm)
            {
                clearConf = true;
            }
            else
            {
                clearConf = false;
            }
        }

        public void CN_AltaRemito(string Doc, string Nombre, string Apellido, string Tel, string Mail, string Ent, string Dir, decimal Sub, decimal Descuento, decimal Total, DateTime F_H, DataGridView dgv, string NroP, int id_user, string Codigo_Presupuesto)
        {
            objcd_Altas.altaRemito(Doc, Nombre, Apellido, Tel, Mail, Ent, Dir, Sub, Descuento, Total, F_H, dgv, NroP, id_user, Codigo_Presupuesto);

            if (objcd_Altas.clearConfirm)
            {
                clearConf = true;
            }
            else
            {
                clearConf = false;
            }
        }

        public void CN_AltaCategoria(string NombreCat)
        {
            objcd_Altas.AltaCategoría(NombreCat);

            if (objcd_Altas.clearConfirm)
            {
                clearConf = true;
            }
            else
            {
                clearConf = false;
            }
        }
        public void CN_AltaSubCategoria(string NombreSubCat, string CodCat)
        {
            objcd_Altas.AltaSubCategoría(NombreSubCat, CodCat);

            if (objcd_Altas.clearConfirm)
            {
                clearConf = true;
            }
            else
            {
                clearConf = false;
            }
        }
        public void CN_AltaProveedor(string Nombre, string Apellido, string Correo, string Telefono)
        {
            objcd_Altas.AltaProveedor(Nombre, Apellido, Correo, Telefono);

            if (objcd_Altas.clearConfirm)
            {
                clearConf = true;
            }
            else
            {
                clearConf = false;
            }
        }

        public void AltaUsuario(string Nombre, string Apellido, string DNI, string Contraseña, string idRol, decimal comision)
        {
            objcd_Altas.AltaUsuario(Nombre, Apellido, DNI, Contraseña, idRol, comision);

            if (objcd_Altas.clearConfirm)
            {
                clearConf = true;
            }
            else
            {
                clearConf = false;
            }
        }
    }
}
