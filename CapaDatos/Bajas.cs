using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using System.Data.SqlClient;


namespace CapaDatos
{
    public class Bajas
    {
        public void EliminarPresupuesto(string Codigo_Presupuesto)
        {
            using (SqlConnection objConexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    objConexion.Open();

                    // Crear el comando y especificar que es un stored procedure
                    SqlCommand cmd = new SqlCommand("sp_DeletePresupuesto", objConexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Agregar el parámetro para el Nro_Presupuesto
                    cmd.Parameters.AddWithValue("@Nro_Presupuesto", Codigo_Presupuesto);

                    // Ejecutar el procedimiento
                    cmd.ExecuteNonQuery();

                }
                catch (Exception ex)
                {

                }
            }
        }

    }
}
