using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Net.PeerToPeer.Collaboration;
using System.Transactions;
using System.Data.Common;
using CapaEntidad;

namespace CapaDatos
{
    public class Altas
    {
        public bool clearConfirm;
        Bajas baja = new Bajas();

        /// <summary>
        /// da de alta un artículo y lo registra en una base de datos.
        /// </summary>
        /// <param name="Codigo">El código de un artículo</param>
        /// <param name="codCategoria">EL código de la categoría de un artículo</param>
        /// <param name="codSubCategoria">EL código de la sub categoría de un artículo</param>
        /// <param name="Descripcion">La descripción de un artículo</param>
        /// <param name="IdProveedor">El id de un Proveedor</param>
        /// <param name="Cantidad">La cantidad de Stock inicial de un artículo</param>
        /// <param name="Costo">El costo de un artículo</param>
        /// <param name="Ganancia">La ganancia % de un artículo</param>
        public void altaArt(string Codigo, int codCategoria, int codSubCategoria, string Descripcion, int IdProveedor, int Cantidad, decimal Costo, decimal Ganancia)
        {
            clearConfirm = false;

            using (SqlConnection objConexion = new SqlConnection(Conexion.cadena)) // using me permite cerrar automaticamente la conexion
            {
                try
                {
                    StringBuilder Query = new StringBuilder();
                    Query.AppendLine("INSERT INTO ARTICULO(Cod_articulo, Cod_categoria, Cod_subcategoria, Descripcion, ID_Proveedor) VALUES");
                    Query.AppendLine("(@Cod_articulo, @Cod_Categoria, @Cod_subcategoria, @Descripcion, @ID_Proveedor);");
                    Query.AppendLine("INSERT INTO STOCK (Cod_articulo, Cantidad, Costo, Ganancia) VALUES");
                    Query.AppendLine("(@Cod_articulo, @Cantidad, @Costo, @Ganancia);");

                    SqlCommand cmd = new SqlCommand(Query.ToString(), objConexion);
                    {
                        cmd.Parameters.AddWithValue("@Cod_articulo", Codigo);
                        cmd.Parameters.AddWithValue("@Cod_categoria", codCategoria);
                        cmd.Parameters.AddWithValue("@Cod_subcategoria", codSubCategoria);
                        cmd.Parameters.AddWithValue("@Descripcion", Descripcion);
                        cmd.Parameters.AddWithValue("@ID_Proveedor", IdProveedor);
                        cmd.Parameters.AddWithValue("@Cantidad", Cantidad);
                        cmd.Parameters.AddWithValue("@Costo", Costo);
                        cmd.Parameters.AddWithValue("@Ganancia", Ganancia);
                    }
                    objConexion.Open();
                    cmd.ExecuteNonQuery();
                    {
                        clearConfirm = true;
                        MessageBox.Show("Articulo registrado con éxito", "REGISTRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error en el procedimiento del registro", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void altaPresupuesto(string Doc, string Nombre, string Apellido, string Tel, string Mail, string Ent, string Dir, decimal Sub, decimal Descuento, decimal Total, DateTime F_H, DataGridView dgv, string NroP)
        {
            clearConfirm = false;

            using (SqlConnection objConexion = new SqlConnection(Conexion.cadena))
            {
                objConexion.Open();
                // Iniciar la transacción
                SqlTransaction transaction = objConexion.BeginTransaction();

                try
                {
                    StringBuilder insertDetalleQuery = new StringBuilder();
                    StringBuilder insertPresupuestoQuery = new StringBuilder();

                    // Insert para H_Presupuesto
                    insertPresupuestoQuery.AppendLine("INSERT INTO H_Presupuesto(Nro_presupuesto, dni, nombre, Apellido, tel, email, entidad, direccion, subtotal, descuento, total, fecha_hora) VALUES");
                    insertPresupuestoQuery.AppendLine("(@NroP, @documentacion, @Nombre, @Apellido, @Telefono, @Mail, @Entidad, @Direccion, @Subtotal, @Descuento, @Total, @FechaHora);");

                    SqlCommand cmdPresupuesto = new SqlCommand(insertPresupuestoQuery.ToString(), objConexion, transaction);

                    // Parámetros del presupuesto
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

                    // Ejecutar el insert del presupuesto
                    cmdPresupuesto.ExecuteNonQuery();

                    // Insertar el detalle de cada artículo
                    foreach (DataGridViewRow Rows in dgv.Rows)
                    {
                        if (!Rows.IsNewRow)
                        {
                            insertDetalleQuery.AppendLine("INSERT INTO H_Presupuesto_Detalle(Nro_Presupuesto, Cod_articulo, descripcion, precio_unitario, cantidad, precio_x_cantidad) VALUES");
                            insertDetalleQuery.AppendLine("(@Nro_Presupuesto ,@Cod_articulo, @Descripcion, @PrecioUnitario, @Cantidad, @PxCant);");

                            SqlCommand cmdDetalle = new SqlCommand(insertDetalleQuery.ToString(), objConexion, transaction);

                            // Obtener los valores del DataGridView
                            string CodArt = Rows.Cells["C_CodArt"].Value.ToString();
                            string Desc = Rows.Cells["C_Descripcion"].Value.ToString();
                            decimal P_Unit = decimal.Parse(Rows.Cells["C_PrecioUnit"].Value.ToString());
                            int Cant = int.Parse(Rows.Cells["C_Cantidad"].Value.ToString());
                            decimal PxCant = decimal.Parse(Rows.Cells["C_Pxcant"].Value.ToString());

                            // Parámetros del detalle
                            cmdDetalle.Parameters.AddWithValue("@Nro_Presupuesto", NroP);
                            cmdDetalle.Parameters.AddWithValue("@Cod_articulo", CodArt);
                            cmdDetalle.Parameters.AddWithValue("@Descripcion", Desc);
                            cmdDetalle.Parameters.AddWithValue("@PrecioUnitario", P_Unit);
                            cmdDetalle.Parameters.AddWithValue("@Cantidad", Cant);
                            cmdDetalle.Parameters.AddWithValue("@PxCant", PxCant);

                            // Ejecutar el insert del detalle
                            cmdDetalle.ExecuteNonQuery();

                            insertDetalleQuery.Clear(); // Limpiar el StringBuilder para la próxima iteración
                        }
                    }

                    // Si todo va bien, se confirma la transacción
                    transaction.Commit();

                    clearConfirm = true;
                    MessageBox.Show("Presupuesto guardado con éxito", "PRESUPUESTO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    // Si hay un error, se realiza el rollback
                    transaction.Rollback();
                    MessageBox.Show("Error en el procedimiento del Registro. Se realizó un rollback de los cambios.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void AltaCliente(string Doc, string Nombre, string Apellido, string Dir, string Tel, string Correo, string Entidad)
        {
            clearConfirm = false;

            using (SqlConnection objConexion = new SqlConnection(Conexion.cadena)) // using me permite cerrar automaticamente la conexion
            {
                try
                {
                    StringBuilder Query = new StringBuilder();
                    Query.AppendLine("INSERT INTO CLIENTE (Documentacion, Nombre, Apellido, Direccion, Telefono, Correo, Entidad) VALUES");
                    Query.AppendLine("(@Doc, @Nombre, @Apellido, @Dir, @Tel, @Correo, @Entidad);");
                    Query.AppendLine("INSERT INTO CTA_CTE_CLIENTE(Documentacion, compras, pagos, Fecha) VALUES");
                    Query.AppendLine("(@Doc, 0, 0, @Fecha);");

                    SqlCommand cmd = new SqlCommand(Query.ToString(), objConexion);
                    {
                        cmd.Parameters.AddWithValue("@Doc", Doc);
                        cmd.Parameters.AddWithValue("@Nombre", Nombre);
                        cmd.Parameters.AddWithValue("@Apellido", Apellido);
                        cmd.Parameters.AddWithValue("@Dir", Dir);
                        cmd.Parameters.AddWithValue("@Tel", Tel);
                        cmd.Parameters.AddWithValue("@Correo", Correo);
                        cmd.Parameters.AddWithValue("@Entidad", Entidad);
                        cmd.Parameters.AddWithValue("@Fecha", DateTime.Today);
                    }
                    objConexion.Open();
                    cmd.ExecuteNonQuery();
                    clearConfirm = true;
                    MessageBox.Show("Cliente registrado con éxito", "CLIENTE", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception)
                {
                    MessageBox.Show("Error en el procedimiento del registro", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void AltaCliente_PresupuestoRemito(string Doc, string Nombre, string Apellido, string Dir, string Tel, string Correo, string Entidad)
        {

            using (SqlConnection objConexion = new SqlConnection(Conexion.cadena)) // using me permite cerrar automaticamente la conexion
            {
                try
                {
                    StringBuilder Query = new StringBuilder();
                    Query.AppendLine("INSERT INTO CLIENTE (Documentacion, Nombre, Apellido, Direccion, Telefono, Correo, Entidad) VALUES");
                    Query.AppendLine("(@Doc, @Nombre, @Apellido, @Dir, @Tel, @Correo, @Entidad);");
                    Query.AppendLine("INSERT INTO CTA_CTE_CLIENTE(Documentacion, compras, pagos, Fecha) VALUES");
                    Query.AppendLine("(@Doc, 0, 0, @Fecha);");


                    SqlCommand cmd = new SqlCommand(Query.ToString(), objConexion);
                    {
                        cmd.Parameters.AddWithValue("@Doc", Doc);
                        cmd.Parameters.AddWithValue("@Nombre", Nombre);
                        cmd.Parameters.AddWithValue("@Apellido", Apellido);
                        cmd.Parameters.AddWithValue("@Dir", Dir);
                        cmd.Parameters.AddWithValue("@Tel", Tel);
                        cmd.Parameters.AddWithValue("@Correo", Correo);
                        cmd.Parameters.AddWithValue("@Entidad", Entidad);
                        cmd.Parameters.AddWithValue("@Fecha", DateTime.Now.Date);
                    }
                    objConexion.Open();
                    cmd.ExecuteNonQuery();

                }
                catch (Exception)
                {
                    MessageBox.Show("Error en el procedimiento del registro", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void altaRemito(string Doc, string Nombre, string Apellido, string Tel, string Mail, string Ent, string Dir, decimal Sub, decimal Descuento, decimal Total, DateTime F_H, DataGridView dgv, string NroP, int id_user, string Codigo_Presupuesto)
        {
            clearConfirm = false;

            using (SqlConnection objConexion = new SqlConnection(Conexion.cadena))
            {
                objConexion.Open();
                // Iniciar la transacción
                SqlTransaction transaction = objConexion.BeginTransaction();

                try
                {
                    StringBuilder insertDetalleQuery = new StringBuilder();
                    StringBuilder insertPresupuestoQuery = new StringBuilder();

                    // Insert para H_Remito
                    insertPresupuestoQuery.AppendLine("INSERT INTO H_Remito(Nro_remito, dni, nombre, Apellido, tel, email, entidad, direccion, subtotal, descuento, total, fecha_hora, id_usuario) VALUES");
                    insertPresupuestoQuery.AppendLine("(@NroP, @documentacion, @Nombre, @Apellido, @Telefono, @Mail, @Entidad, @Direccion, @Subtotal, @Descuento, @Total, @FechaHora, @id_usuario);");

                    SqlCommand cmbRemito = new SqlCommand(insertPresupuestoQuery.ToString(), objConexion, transaction);

                    // Parámetros del remito
                    cmbRemito.Parameters.AddWithValue("@NroP", NroP);
                    cmbRemito.Parameters.AddWithValue("@documentacion", Doc);
                    cmbRemito.Parameters.AddWithValue("@Nombre", Nombre);
                    cmbRemito.Parameters.AddWithValue("@Apellido", Apellido);
                    cmbRemito.Parameters.AddWithValue("@Telefono", Tel);
                    cmbRemito.Parameters.AddWithValue("@Mail", Mail);
                    cmbRemito.Parameters.AddWithValue("@Entidad", Ent);
                    cmbRemito.Parameters.AddWithValue("@Direccion", Dir);
                    cmbRemito.Parameters.AddWithValue("@Subtotal", Sub);
                    cmbRemito.Parameters.AddWithValue("@Descuento", Descuento);
                    cmbRemito.Parameters.AddWithValue("@Total", Total);
                    cmbRemito.Parameters.AddWithValue("@FechaHora", F_H);
                    cmbRemito.Parameters.AddWithValue("@id_usuario", id_user);

                    // Ejecutar el insert del remito
                    cmbRemito.ExecuteNonQuery();

                    // Insertar el detalle de cada artículo
                    foreach (DataGridViewRow Rows in dgv.Rows)
                    {
                        if (!Rows.IsNewRow)
                        {
                            insertDetalleQuery.AppendLine("INSERT INTO H_Remito_detalle(Nro_remito, Cod_articulo, descripcion, precio_unitario, cantidad, precio_x_cantidad) VALUES");
                            insertDetalleQuery.AppendLine("(@Nro_Presupuesto, @Cod_articulo, @Descripcion, @PrecioUnitario, @Cantidad, @PxCant);");

                            SqlCommand cmdDetalle = new SqlCommand(insertDetalleQuery.ToString(), objConexion, transaction);

                            // Obtener los valores del DataGridView
                            string CodArt = Rows.Cells["C_CodArt"].Value.ToString();
                            string Desc = Rows.Cells["C_Descripcion"].Value.ToString();
                            decimal P_Unit = decimal.Parse(Rows.Cells["C_PrecioUnit"].Value.ToString());
                            int Cant = int.Parse(Rows.Cells["C_Cantidad"].Value.ToString());
                            decimal PxCant = decimal.Parse(Rows.Cells["C_Pxcant"].Value.ToString());

                            // Parámetros del detalle
                            cmdDetalle.Parameters.AddWithValue("@Nro_Presupuesto", NroP);
                            cmdDetalle.Parameters.AddWithValue("@Cod_articulo", CodArt);
                            cmdDetalle.Parameters.AddWithValue("@Descripcion", Desc);
                            cmdDetalle.Parameters.AddWithValue("@PrecioUnitario", P_Unit);
                            cmdDetalle.Parameters.AddWithValue("@Cantidad", Cant);
                            cmdDetalle.Parameters.AddWithValue("@PxCant", PxCant);

                            // Ejecutar el insert del detalle
                            cmdDetalle.ExecuteNonQuery();

                            insertDetalleQuery.Clear(); // Limpiar el StringBuilder para la próxima iteración
                        }
                    }

                    // Si todo va bien, se confirma la transacción e intenta eliminar algun presupuesto si es que se cargo desde uno

                    if (!String.IsNullOrEmpty(Codigo_Presupuesto))
                        baja.EliminarPresupuesto(Codigo_Presupuesto); //intenta borrar un presupuesto si es que hay alguno

                    transaction.Commit();

                    clearConfirm = true;
                    MessageBox.Show("Remito generado con éxito", "REMITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    // Si hay un error, se realiza el rollback
                    transaction.Rollback();
                    MessageBox.Show("Error en el procedimiento del Registro. Se realizó un rollback de los cambios.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void AltaUsuario(string Nombre, string Apellido, string DNI, string Contraseña, string idRol, decimal comision)
        {
            clearConfirm = false;

            using (SqlConnection objConexion = new SqlConnection(Conexion.cadena)) // using me permite cerrar automaticamente la conexion
            {
                try
                {
                    StringBuilder Query = new StringBuilder();
                    Query.AppendLine("INSERT INTO USUARIO(Nombre, Apellido, Contraseña, DNI, Comision, IdRol) VALUES");
                    Query.AppendLine("(@Nombre, @Apellido, @Constraseña, @DNI, @comision, @Rol);");

                    SqlCommand cmd = new SqlCommand(Query.ToString(), objConexion);
                    {
                        cmd.Parameters.AddWithValue("@Nombre", Nombre);
                        cmd.Parameters.AddWithValue("@Apellido", Apellido);
                        cmd.Parameters.AddWithValue("@DNI", DNI);
                        cmd.Parameters.AddWithValue("@Constraseña", Contraseña);
                        cmd.Parameters.AddWithValue("@Rol", idRol);
                        cmd.Parameters.AddWithValue("@comision", comision);
                    }
                    objConexion.Open();
                    cmd.ExecuteNonQuery();
                    clearConfirm = true;
                    MessageBox.Show("Usuario registrado con éxito", "USUARIO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception)
                {
                    MessageBox.Show("Error en el procedimiento del registro", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void AltaCategoría(string NombreCat)
        {
            clearConfirm = false;

            using (SqlConnection objConexion = new SqlConnection(Conexion.cadena)) // using me permite cerrar automaticamente la conexion
            {
                try
                {
                    StringBuilder Query = new StringBuilder();
                    Query.AppendLine("INSERT INTO Categoria(Nombre) VALUES");
                    Query.AppendLine("(@Nombre);");

                    SqlCommand cmd = new SqlCommand(Query.ToString(), objConexion);
                    {
                        cmd.Parameters.AddWithValue("@Nombre", NombreCat);

                    }
                    objConexion.Open();
                    cmd.ExecuteNonQuery();
                    clearConfirm = true;
                    MessageBox.Show("Categoria registrada con éxito", "CATEGORIA", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception)
                {
                    MessageBox.Show("Error en el procedimiento del registro", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void AltaSubCategoría(string NombreSubCat, string CodCategoria)
        {
            clearConfirm = false;

            using (SqlConnection objConexion = new SqlConnection(Conexion.cadena)) // using me permite cerrar automaticamente la conexion
            {
                try
                {
                    StringBuilder Query = new StringBuilder();
                    Query.AppendLine("INSERT INTO SUBCATEGORIA(Nombre, Cod_categoria) VALUES");
                    Query.AppendLine("(@Nombre, @CodCat);");

                    SqlCommand cmd = new SqlCommand(Query.ToString(), objConexion);
                    {
                        cmd.Parameters.AddWithValue("@Nombre", NombreSubCat);
                        cmd.Parameters.AddWithValue("@CodCat", CodCategoria);
                    }
                    objConexion.Open();
                    cmd.ExecuteNonQuery();
                    clearConfirm = true;
                    MessageBox.Show("Subcategoría registrada con éxito", "SUBCATEGORIA", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception)
                {
                    MessageBox.Show("Error en el procedimiento del registro", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void AltaProveedor(string Nombre, string Apellido, string Correo, string Telefono)
        {
            clearConfirm = false;

            using (SqlConnection objConexion = new SqlConnection(Conexion.cadena)) // using me permite cerrar automaticamente la conexion
            {
                try
                {
                    StringBuilder Query = new StringBuilder();
                    Query.AppendLine("INSERT INTO PROVEEDOR(Nombre, Apellido, Telefono, Correo) VALUES");
                    Query.AppendLine("(@Nombre, @Apellido, @Tel, @Correo);");
                    Query.AppendLine("DECLARE @ID INT = SCOPE_IDENTITY();");  // Capturar el último ID insertado
                    Query.AppendLine("INSERT INTO CTA_CTE_PROVEEDOR(ID_Proveedor, compras, pagos, Fecha) VALUES");
                    Query.AppendLine("(@ID, 0, 0, @Fecha);");

                    SqlCommand cmd = new SqlCommand(Query.ToString(), objConexion);
                    cmd.Parameters.AddWithValue("@Nombre", Nombre);
                    cmd.Parameters.AddWithValue("@Apellido", Apellido);
                    cmd.Parameters.AddWithValue("@Tel", Telefono);
                    cmd.Parameters.AddWithValue("@Correo", Correo);
                    cmd.Parameters.AddWithValue("@Fecha", DateTime.Today);  // Ajusta la fecha según tus necesidades

                    objConexion.Open();
                    cmd.ExecuteNonQuery();
                    clearConfirm = true;

                    MessageBox.Show("Proveedor registrado con éxito", "PROVEEDOR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Error en el procedimiento del registro", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }




    }
}
