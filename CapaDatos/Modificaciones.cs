using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Modificaciones
    {
        public bool modConfirm;
        public void modArt(string Codigo, string Descripcion, int Cantidad, decimal Costo, decimal Ganancia)
        {
            modConfirm = false;
            using (SqlConnection objConexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder Query = new StringBuilder();
                    Query.AppendLine("UPDATE ARTICULO SET Descripcion = @Descripcion where Cod_articulo = @Cod_articulo");
                    Query.AppendLine("UPDATE STOCK SET Cantidad = @Cantidad, Costo = @Costo, Ganancia = @Ganancia where Cod_articulo = @Cod_articulo");

                    SqlCommand cmd = new SqlCommand(Query.ToString(), objConexion);
                    {
                        cmd.Parameters.AddWithValue("@Cod_articulo", Codigo);
                        cmd.Parameters.AddWithValue("@Descripcion", Descripcion);
                        cmd.Parameters.AddWithValue("@Cantidad", Cantidad);
                        cmd.Parameters.AddWithValue("@Costo", Costo);
                        cmd.Parameters.AddWithValue("@Ganancia", Ganancia);
                    }
                    objConexion.Open();
                    cmd.ExecuteNonQuery();
                    {
                        modConfirm = true;
                        MessageBox.Show("Articulo modificado con éxito", "MODIFICACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error en el procedimiento de modificación", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        public void modArt(int Cod_Categoria, int Cod_SubCategoria, int ID_Proveedor, decimal Costo) //SOBRECARGA DEL MÉTODO modArt (MODIFICA EL COSTO)
        {
            modConfirm = false;
            using (SqlConnection objConexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder Query = new StringBuilder();
                    Query.AppendLine("UPDATE s SET s.Costo += s.Costo*@NuevoCosto/100 FROM STOCK s");
                    Query.AppendLine("INNER JOIN ARTICULO a ON s.Cod_articulo = a.Cod_articulo");
                    Query.AppendLine("INNER JOIN PROVEEDOR p ON a.ID_Proveedor = p.ID_Proveedor");
                    Query.AppendLine("INNER JOIN CATEGORIA c ON a.Cod_categoria = c.Cod_categoria");
                    Query.AppendLine("INNER JOIN SUBCATEGORIA sc ON a.Cod_subcategoria = sc.Cod_subcategoria");
                    Query.AppendLine("WHERE p.ID_Proveedor = @ID_Proveedor");
                    Query.AppendLine("OR c.Cod_categoria = @Cod_Categoria");
                    Query.AppendLine("OR sc.Cod_subcategoria = @Cod_SubCategoria");

                    SqlCommand cmd = new SqlCommand(Query.ToString(), objConexion);
                    {
                        cmd.Parameters.AddWithValue("@ID_Proveedor", ID_Proveedor);
                        cmd.Parameters.AddWithValue("@Cod_Categoria", Cod_Categoria);
                        cmd.Parameters.AddWithValue("@Cod_subcategoria", Cod_SubCategoria);
                        cmd.Parameters.AddWithValue("@NuevoCosto", Costo);
                    }
                    objConexion.Open();
                    cmd.ExecuteNonQuery();
                    {
                        modConfirm = true;
                        MessageBox.Show("Costos modificados con éxito", "MODIFICACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error en el procedimiento de modificación", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void modArt_Ganancia(int Cod_Categoria, int Cod_SubCategoria, int ID_Proveedor, decimal Ganancia)
        {
            modConfirm = false;
            using (SqlConnection objConexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder Query = new StringBuilder();
                    Query.AppendLine("UPDATE s SET s.Ganancia += s.Ganancia*@NuevaGanancia/100 FROM STOCK s");
                    Query.AppendLine("INNER JOIN ARTICULO a ON s.Cod_articulo = a.Cod_articulo");
                    Query.AppendLine("INNER JOIN PROVEEDOR p ON a.ID_Proveedor = p.ID_Proveedor");
                    Query.AppendLine("INNER JOIN CATEGORIA c ON a.Cod_categoria = c.Cod_categoria");
                    Query.AppendLine("INNER JOIN SUBCATEGORIA sc ON a.Cod_subcategoria = sc.Cod_subcategoria");
                    Query.AppendLine("WHERE p.ID_Proveedor = @ID_Proveedor");
                    Query.AppendLine("OR c.Cod_categoria = @Cod_Categoria");
                    Query.AppendLine("OR sc.Cod_subcategoria = @Cod_SubCategoria");

                    SqlCommand cmd = new SqlCommand(Query.ToString(), objConexion);
                    {
                        cmd.Parameters.AddWithValue("@ID_Proveedor", ID_Proveedor);
                        cmd.Parameters.AddWithValue("@Cod_Categoria", Cod_Categoria);
                        cmd.Parameters.AddWithValue("@Cod_subcategoria", Cod_SubCategoria);
                        cmd.Parameters.AddWithValue("@NuevaGanancia", Ganancia);
                    }
                    objConexion.Open();
                    cmd.ExecuteNonQuery();
                    {
                        modConfirm = true;
                        MessageBox.Show("Costos modificados con éxito", "MODIFICACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error en el procedimiento de modificación", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
