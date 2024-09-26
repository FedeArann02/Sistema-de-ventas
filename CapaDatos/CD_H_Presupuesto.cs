using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CapaDatos;
using CapaEntidad;

namespace CapaDatos
{
    public class CD_H_Presupuesto
    {
        public List<H_Presupuesto> ListarNombreNro()
        {
            List<H_Presupuesto> Lista = new List<H_Presupuesto>();
            using (SqlConnection obj_conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string Query = "select p.nombre, p.id_Presupuesto, p.Nro_presupuesto, p.dni from H_Presupuesto p";
                    SqlCommand cmd = new SqlCommand(Query.ToString(), obj_conexion);
                    cmd.CommandType = CommandType.Text;
                    obj_conexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Lista.Add(new H_Presupuesto()
                            {
                                nombre = dr["nombre"].ToString(),
                                id_presupuesto = Convert.ToInt32(dr["id_presupuesto"]),
                                Nro_presupuesto = dr["Nro_presupuesto"].ToString(),
                                dni = dr["dni"].ToString()
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    Lista = new List<H_Presupuesto>();
                }
            }
            return Lista;
        }
    }
}
