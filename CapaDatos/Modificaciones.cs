using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Security.AccessControl;

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

        //TODO:
        //23-10-2024 FEDE
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

        public void RegistraPagoCliente(string Documentacion, decimal Monto)
        {
            modConfirm = false;
            using (SqlConnection objConexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder Query = new StringBuilder();
                    Query.AppendLine("update CTA_CTE_CLIENTE set pagos = @Monto where Documentacion = @Doc");

                    SqlCommand cmd = new SqlCommand(Query.ToString(), objConexion);
                    {
                        cmd.Parameters.AddWithValue("@Doc", Documentacion);
                        cmd.Parameters.AddWithValue("@Monto", Monto);
                    }
                    objConexion.Open();
                    cmd.ExecuteNonQuery();
                    {
                        modConfirm = true;
                        MessageBox.Show("Pago registrado con éxito", "REGISTRO DE PAGO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error en el procedimiento del pago", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void ActualizarStock(DataGridView dgv) //PROBAR!!!!
        {
            modConfirm = false;
            using (SqlConnection objConexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    objConexion.Open();
                    StringBuilder Update = new StringBuilder();
                    StringBuilder QueryStock = new StringBuilder();

                    Update.AppendLine("update Stock set Cantidad = @Cantidad where Cod_articulo = @CodArt");
                    QueryStock.AppendLine("select Cantidad from Stock where Cod_articulo = @CodArt");

                    foreach (DataGridViewRow fila in dgv.Rows)
                    {
                        if (fila.Cells["C_CodArt"].Value == null || fila.Cells["C_Cantidad"].Value == null)
                        {
                            continue; // Saltar filas vacías si las hay
                        }

                        string Cod_art = fila.Cells["C_CodArt"].Value.ToString(); // Obtiene el código del artículo
                        int CantNueva = int.Parse(fila.Cells["C_Cantidad"].Value.ToString()); // Cantidad del detalle del remito

                        // Primero obtenemos el stock actual
                        SqlCommand cmdCant = new SqlCommand(QueryStock.ToString(), objConexion);
                        cmdCant.Parameters.AddWithValue("@CodArt", Cod_art); // Filtra por código de artículo
                        SqlDataReader dR = cmdCant.ExecuteReader();

                        if (dR.Read()) // Verifica si hay datos
                        {
                            int CantidadStock = int.Parse(dR["Cantidad"].ToString()); // Obtiene la cantidad en stock

                            CantNueva = CantidadStock - CantNueva; // Resta la cantidad del detalle del remito

                            dR.Close(); // Cierra el DataReader antes de ejecutar otra consulta

                            // Ahora actualizamos el stock
                            SqlCommand cmd = new SqlCommand(Update.ToString(), objConexion);
                            cmd.Parameters.AddWithValue("@CodArt", Cod_art); // Parámetro del código de artículo
                            cmd.Parameters.AddWithValue("@Cantidad", CantNueva); // Parámetro de la nueva cantidad

                            cmd.ExecuteNonQuery(); // Ejecuta la actualización
                        }
                        else
                        {
                            dR.Close(); // Cierra el DataReader si no hay datos
                        }
                    }

                    modConfirm = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error en el procedimiento del stock: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        public void RegistraCompraCliente(string Documentacion, decimal Monto)
        {
            modConfirm = false;
            using (SqlConnection objConexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    objConexion.Open();
                    StringBuilder Query = new StringBuilder();
                    StringBuilder QueryCompras = new StringBuilder();

                    Query.AppendLine("update CTA_CTE_CLIENTE set compras = @Monto where Documentacion = @Doc");
                    QueryCompras.AppendLine("select Compras from CTA_CTE_CLIENTE where Documentacion = @Doc");

                    SqlCommand cmd = new SqlCommand(Query.ToString(), objConexion);
                    SqlCommand cmdCompras = new SqlCommand(QueryCompras.ToString(), objConexion);
                    cmdCompras.CommandType = CommandType.Text;

                    cmdCompras.Parameters.AddWithValue("@Doc", Documentacion);
                    SqlDataReader dR = cmdCompras.ExecuteReader();

                    if (dR.Read()) // Asegurarse de que se lee la fila de datos
                    {
                        decimal comprasActuales = decimal.Parse(dR["Compras"].ToString()); // Leer el valor actual de "Compras"
                        Monto += comprasActuales; // Sumar el monto a las compras actuales
                    }

                    dR.Close(); // Cerrar el SqlDataReader antes de ejecutar otro comando

                    cmd.Parameters.AddWithValue("@Doc", Documentacion);
                    cmd.Parameters.AddWithValue("@Monto", Monto); // Parametriza el nuevo monto
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                }
            }
        }

        public void RegistraPagoProveedor(string id_proveedor, decimal Monto)
        {
            modConfirm = false;
            using (SqlConnection objConexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder Query = new StringBuilder();
                    Query.AppendLine("update CTA_CTE_PROVEEDOR set pagos = @Monto where ID_Proveedor = @id");

                    SqlCommand cmd = new SqlCommand(Query.ToString(), objConexion);
                    {
                        cmd.Parameters.AddWithValue("@id", id_proveedor);
                        cmd.Parameters.AddWithValue("@Monto", Monto);
                    }
                    objConexion.Open();
                    cmd.ExecuteNonQuery();
                    {
                        modConfirm = true;
                        MessageBox.Show("Pago registrado con éxito", "REGISTRO DE PAGO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error en el procedimiento del pago", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void RegistraCompraProveedor(string id_proveedor, decimal Monto)
        {
            modConfirm = false;
            using (SqlConnection objConexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    objConexion.Open();
                    StringBuilder Query = new StringBuilder();
                    StringBuilder QueryCompras = new StringBuilder();

                    Query.AppendLine("update CTA_CTE_PROVEEDOR set Compras = @Monto where ID_Proveedor = @id");
                    QueryCompras.AppendLine("select Compras from CTA_CTE_PROVEEDOR where ID_Proveedor = @id");

                    SqlCommand cmd = new SqlCommand(Query.ToString(), objConexion);
                    SqlCommand cmdCompras = new SqlCommand(QueryCompras.ToString(), objConexion);
                    cmdCompras.CommandType = CommandType.Text;

                    cmdCompras.Parameters.AddWithValue("@id", id_proveedor);
                    SqlDataReader dR = cmdCompras.ExecuteReader();

                    if (dR.Read()) // Asegurarse de que se lee la fila de datos
                    {
                        decimal comprasActuales = decimal.Parse(dR["Compras"].ToString()); // Leer el valor actual de "Compras"
                        Monto += comprasActuales; // Sumar el monto a las compras actuales
                    }

                    dR.Close(); // Cerrar el SqlDataReader antes de ejecutar otro comando

                    cmd.Parameters.AddWithValue("@id", id_proveedor);
                    cmd.Parameters.AddWithValue("@Monto", Monto); // Parametriza el nuevo monto
                    cmd.ExecuteNonQuery();

                    modConfirm = true;
                    MessageBox.Show("Compra registrada con éxito", "REGISTRO DE COMPRA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error en el procedimiento del registro de la compra", "Compra a proveedor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void ModificarProveedor(string Nombre, string Apellido, string Telefono, string Correo, string idProveedor)
        {
            modConfirm = false;
            using (SqlConnection objConexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder Query = new StringBuilder();
                    Query.AppendLine("update PROVEEDOR set Nombre = @Nombre, Apellido = @Apellido, Correo = @Correo, Telefono = @Tel where ID_Proveedor = @ID");

                    SqlCommand cmd = new SqlCommand(Query.ToString(), objConexion);
                    {
                        cmd.Parameters.AddWithValue("@Nombre", Nombre);
                        cmd.Parameters.AddWithValue("@Apellido", Apellido);
                        cmd.Parameters.AddWithValue("@Tel", Telefono);
                        cmd.Parameters.AddWithValue("@Correo", Correo);
                        cmd.Parameters.AddWithValue("@ID", idProveedor);
                    }
                    objConexion.Open();
                    cmd.ExecuteNonQuery();
                    {
                        modConfirm = true;
                        MessageBox.Show("Proveedor modificado con éxito", "PROVEEDOR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error en el procedimiento de la modificación", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void ModificarCliente(string Nombre, string Apellido, string Telefono, string Correo, string Direccion, string Entidad, string Documentacion)
        {
            modConfirm = false;
            using (SqlConnection objConexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder Query = new StringBuilder();
                    Query.AppendLine("update CLIENTE set Nombre = @Nombre, Apellido = @Apellido, Correo = @Correo, Telefono = @Tel, Direccion = @Dir, Entidad = @Entidad where Documentacion = @Doc");

                    SqlCommand cmd = new SqlCommand(Query.ToString(), objConexion);
                    {
                        cmd.Parameters.AddWithValue("@Nombre", Nombre);
                        cmd.Parameters.AddWithValue("@Apellido", Apellido);
                        cmd.Parameters.AddWithValue("@Tel", Telefono);
                        cmd.Parameters.AddWithValue("@Correo", Correo);
                        cmd.Parameters.AddWithValue("@Entidad", Entidad);
                        cmd.Parameters.AddWithValue("@Dir", Direccion);
                        cmd.Parameters.AddWithValue("@Doc", Documentacion);
                    }
                    objConexion.Open();
                    cmd.ExecuteNonQuery();
                    {
                        modConfirm = true;
                        MessageBox.Show("Cliente modificado con éxito", "CLIENTE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error en el procedimiento de la modificación", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



    }
}
