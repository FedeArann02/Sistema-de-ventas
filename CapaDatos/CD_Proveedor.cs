using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class CD_Proveedor
    {
        public List<Proveedor> Listar()
        {
            List<Proveedor> Lista = new List<Proveedor>();
            using (SqlConnection obj_conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string Query = "select p.ID_Proveedor, p.Nombre from PROVEEDOR p";
                    SqlCommand cmd = new SqlCommand(Query.ToString(), obj_conexion);
                    cmd.CommandType = CommandType.Text;
                    obj_conexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Lista.Add(new Proveedor()
                            {
                                ID_Proveedor = Convert.ToInt32(dr["ID_Proveedor"]),
                                Nombre = dr["Nombre"].ToString()
                            });
                        }
                    }
                }
                catch (Exception)
                {
                    Lista = new List<Proveedor>();
                }
            }
            return Lista;
        }
    }
}
