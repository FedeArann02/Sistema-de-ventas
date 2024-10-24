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
    public class CD_Rol
    {
        public List<Rol> Listar()
        {
            List<Rol> Lista = new List<Rol>();
            using (SqlConnection obj_conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string Query = "select r.IdRol, r.Descripcion from ROL r";
                    SqlCommand cmd = new SqlCommand(Query, obj_conexion);
                    cmd.CommandType = CommandType.Text; //indico al comando que es un tipo de comando de Texto.
                    obj_conexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Lista.Add(new Rol()
                            {
                                IdRol = int.Parse(dr["IdRol"].ToString()),
                                Descripcion = dr["Descripcion"].ToString()
                            });
                        }
                    }
                }
                catch (Exception)
                {
                    Lista = new List<Rol>();
                }
            }
            return Lista;
        }
    }
}
