using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;
using System.Net.Http.Headers;
using System.Data.SqlTypes;

namespace CapaDatos
{
    public class CD_Usuario
    {

        public List<Usuario> Listar ()
        {
            List<Usuario> Lista = new List<Usuario>();
            using (SqlConnection obj_conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string Query = "select ID_usuario, Contraseña, DNI, Nombre, Apellido from Usuario";
                    SqlCommand cmd = new SqlCommand (Query, obj_conexion);
                    cmd.CommandType = CommandType.Text; //indico al comando que es un tipo de comando de Texto.
                    obj_conexion.Open ();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Lista.Add(new Usuario()
                            {
                                ID_Usuario = Convert.ToInt32(dr["ID_usuario"]),
                                Contraseña = dr["Contraseña"].ToString(),
                                DNI = dr["DNI"].ToString(),
                                Nombre = dr["Nombre"].ToString(),
                                Apellido = dr["Apellido"].ToString()
                            });
                        }
                    }
                }
                catch (Exception)
                {
                    Lista = new List<Usuario>();
                }
            }
            return Lista;
        }


    }
}
