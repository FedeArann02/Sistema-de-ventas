using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;
using System.Data.SqlClient;
using System.Net.NetworkInformation;

namespace CapaDatos
{
    public class CD_Categoria
    {
        public List<Categoria> Listar(string filtro)
        {
            List<Categoria> Lista = new List<Categoria>();
            using (SqlConnection obj_conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder Query = new StringBuilder();
                    Query.Append("select c.Cod_categoria, c.Nombre from CATEGORIA c ");
                    Query.Append("where c.Nombre LIKE @filtro");
                    SqlCommand cmd = new SqlCommand(Query.ToString(), obj_conexion);
                    cmd.Parameters.AddWithValue("filtro", filtro + "%");
                    cmd.CommandType = CommandType.Text; //indico al comando que es un tipo de comando de Texto.
                    obj_conexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Lista.Add(new Categoria()
                            {
                                Cod_categoria = Convert.ToInt32(dr["Cod_categoria"]),
                                Nombre = dr["Nombre"].ToString()
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    Lista = new List<Categoria>();
                }
            }
            return Lista;
        }
    }
}
