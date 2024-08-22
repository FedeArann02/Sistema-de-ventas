using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Articulo
    {
        public List<Articulo> Listar()
        {
            List<Articulo> Lista = new List<Articulo>();
            using (SqlConnection obj_conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string Query = "select ARTICULO.Cod_articulo, ARTICULO.Descripcion from ARTICULO";
                    SqlCommand cmd = new SqlCommand(Query, obj_conexion);
                    cmd.CommandType = CommandType.Text; //indico al comando que es un tipo de comando de Texto.
                    obj_conexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Lista.Add(new Articulo()
                            {
                                Cod_articulo = dr["Cod_Articulo"].ToString(),
                                Descripcion = dr["Descripcion"].ToString()
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    Lista = new List<Articulo>();
                }
            }
            return Lista;
        }
    }
}
