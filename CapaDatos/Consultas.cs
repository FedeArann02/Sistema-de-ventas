using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaDatos
{
    public class Consultas
    {
        public DataTable ConsultaArt ()
        {
            DataTable dt = new DataTable();

            using (SqlConnection objConexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder Query = new StringBuilder();
                    Query.AppendLine("select a.Cod_articulo as Codigo, a.Descripcion, c.Nombre as Categoria, s.Nombre as Subcategoria, p.Nombre as Proveedor, st.Cantidad, st.Costo, st.Ganancia, c.Cod_categoria, s.Cod_subcategoria, p.ID_Proveedor from ARTICULO a");
                    Query.AppendLine("inner join CATEGORIA c on a.Cod_categoria = c.Cod_categoria");
                    Query.AppendLine("inner join SUBCATEGORIA s on a.Cod_subcategoria = s.Cod_subcategoria");
                    Query.AppendLine("inner join PROVEEDOR p on a.ID_Proveedor = p.ID_Proveedor");
                    Query.AppendLine("inner join STOCK st on a.Cod_articulo = st.Cod_articulo");

                    SqlCommand cmd = new SqlCommand(Query.ToString(), objConexion);
                    cmd.CommandType = CommandType.Text;
                    objConexion.Open ();
                    SqlDataReader dR = cmd.ExecuteReader ();
                    dt.Load (dR);
                }
                catch (Exception ex)
                {
                    dt = new DataTable();
                }
            }
            return dt;
        }
    }
}
