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

        public void modPresupuesto(string Doc, string Nombre, string Apellido, string Tel, string Mail, string Ent, string Dir, decimal Sub, decimal Descuento, decimal Total, DateTime F_H, DataGridView dgv, string NroP)
        {
            modConfirm = false;

            using (SqlConnection objConexion = new SqlConnection(Conexion.cadena)) // using me permite cerrar automaticamente la conexion
            {
                objConexion.Open();
                try
                {

                    StringBuilder insertDetalleQuery = new StringBuilder();
                    StringBuilder DeleteDetalle = new StringBuilder();
                    StringBuilder insertPresupuestoQuery = new StringBuilder();

                    DeleteDetalle.AppendLine("Delete H_presupuesto_detalle where H_Presupuesto_Detalle.Nro_presupuesto = @NroP");
                    SqlCommand cmdDeleteDetalle = new SqlCommand(DeleteDetalle.ToString(), objConexion);
                    cmdDeleteDetalle.Parameters.AddWithValue("NroP", NroP);

                    insertPresupuestoQuery.AppendLine("UPDATE H_Presupuesto SET dni = @documentacion, nombre = @Nombre, Apellido = @Apellido, tel = @Telefono,");
                    insertPresupuestoQuery.AppendLine("email = @Mail, entidad = @Entidad, direccion = @Direccion, subtotal = @Subtotal, descuento = @Descuento, total = @Total, fecha_hora = @FechaHora where Nro_Presupuesto = @NroP;");

                    SqlCommand cmdPresupuesto = new SqlCommand(insertPresupuestoQuery.ToString(), objConexion);

                    cmdPresupuesto.Parameters.AddWithValue("@NroP", NroP);
                    cmdPresupuesto.Parameters.AddWithValue("@documentacion", Doc);
                    cmdPresupuesto.Parameters.AddWithValue("@Nombre", Nombre);
                    cmdPresupuesto.Parameters.AddWithValue("@Apellido", Apellido);
                    cmdPresupuesto.Parameters.AddWithValue("@Telefono", Tel);
                    cmdPresupuesto.Parameters.AddWithValue("@Mail", Mail);
                    cmdPresupuesto.Parameters.AddWithValue("@Entidad", Ent);
                    cmdPresupuesto.Parameters.AddWithValue("@Direccion", Dir);
                    cmdPresupuesto.Parameters.AddWithValue("@Subtotal", Sub);
                    cmdPresupuesto.Parameters.AddWithValue("@Descuento", Descuento);
                    cmdPresupuesto.Parameters.AddWithValue("@Total", Total);
                    cmdPresupuesto.Parameters.AddWithValue("@FechaHora", F_H);

                    cmdDeleteDetalle.ExecuteNonQuery();
                    cmdPresupuesto.ExecuteNonQuery();

                    foreach (DataGridViewRow Rows in dgv.Rows)
                    {
                        if (!Rows.IsNewRow)
                        {
                            insertDetalleQuery.AppendLine("INSERT INTO H_Presupuesto_Detalle(Nro_Presupuesto, Cod_articulo, descripcion, precio_unitario, cantidad, precio_x_cantidad) VALUES");
                            insertDetalleQuery.AppendLine("(@Nro_Presupuesto ,@Cod_articulo, @Descripcion, @PrecioUnitario, @Cantidad, @PxCant);");

                            SqlCommand cmdDetalle = new SqlCommand(insertDetalleQuery.ToString(), objConexion);

                            string CodArt = Rows.Cells["C_CodArt"].Value.ToString();
                            string Desc = Rows.Cells["C_Descripcion"].Value.ToString();
                            decimal P_Unit = decimal.Parse(Rows.Cells["C_PrecioUnit"].Value.ToString());
                            int Cant = int.Parse(Rows.Cells["C_Cantidad"].Value.ToString());
                            decimal PxCant = decimal.Parse(Rows.Cells["C_Pxcant"].Value.ToString());
                            cmdDetalle.Parameters.AddWithValue("@Nro_Presupuesto", NroP);
                            cmdDetalle.Parameters.AddWithValue("@Cod_articulo", CodArt);
                            cmdDetalle.Parameters.AddWithValue("@Descripcion", Desc);
                            cmdDetalle.Parameters.AddWithValue("@PrecioUnitario", P_Unit);
                            cmdDetalle.Parameters.AddWithValue("@Cantidad", Cant);
                            cmdDetalle.Parameters.AddWithValue("@PxCant", PxCant);
                            cmdDetalle.ExecuteNonQuery();
                            insertDetalleQuery.Clear();
                        }
                    }

                    modConfirm = true;
                    MessageBox.Show("Presupuesto modificado con éxito", "PRESUPUESTO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error en el procedimiento del Registro", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
