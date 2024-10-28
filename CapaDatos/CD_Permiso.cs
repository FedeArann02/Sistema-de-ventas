using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Permiso
    {
        public List<Permiso> Listar(int idusuario)
        {
            List<Permiso> Lista = new List<Permiso>();
            using (SqlConnection obj_conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder Query = new StringBuilder();
                    Query.AppendLine("select P.IdRol, P.NombreMenu from PERMISO p");
                    Query.AppendLine("inner join ROL r on r.IdRol = p.IdRol");
                    Query.AppendLine("inner join USUARIO u on u.IdRol = r.IdRol");
                    Query.AppendLine("where u.ID_usuario = @idusuario");

                    SqlCommand cmd = new SqlCommand(Query.ToString(), obj_conexion);
                    cmd.Parameters.AddWithValue("idusuario", idusuario);
                    cmd.CommandType = CommandType.Text;
                    obj_conexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Lista.Add(new Permiso()
                            {
                                objRol = new Rol() { IdRol = Convert.ToInt32(dr["IdRol"]) },
                                NombreMenu = dr["NombreMenu"].ToString(),
                            });

                        }
                    }
                }
                catch (Exception)
                {
                    Lista = new List<Permiso>();
                }
            }
            return Lista;
        }
    }
}
