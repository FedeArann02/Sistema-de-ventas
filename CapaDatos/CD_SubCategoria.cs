using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_SubCategoria
    {
        public List<Subcategoria> Listar()
        {
            List<Subcategoria> Lista = new List<Subcategoria>();
            using (SqlConnection obj_conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string Query = "select s.Cod_subcategoria, s.Cod_categoria, s.Nombre from SUBCATEGORIA s";
                    SqlCommand cmd = new SqlCommand(Query, obj_conexion);
                    cmd.CommandType = CommandType.Text; //indico al comando que es un tipo de comando de Texto.
                    obj_conexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Lista.Add(new Subcategoria()
                            {
                                Cod_subcategoria = Convert.ToInt32(dr["Cod_subcategoria"]),
                                objCategoria = new Categoria() {Cod_categoria = Convert.ToInt32(dr["Cod_categoria"])},
                                Nombre = dr["Nombre"].ToString()
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    Lista = new List<Subcategoria>();
                }
            }
            return Lista;
        }
    }

}
