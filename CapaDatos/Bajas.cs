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

                    string Query = @"delete H_Presupuesto_Detalle where Nro_Presupuesto = @NroP
                                    delete H_Presupuesto where Nro_Presupuesto = @NroP";

                    SqlCommand cmd = new SqlCommand(Query, objConexion);
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@NroP", Codigo_Presupuesto);

                    cmd.ExecuteNonQuery();

                }
                catch (Exception)
                {
                    MessageBox.Show("Error insesperado a la hora de guardar el remito desde un presupuesto, por favor contactese con el programador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
