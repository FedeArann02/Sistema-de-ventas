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
                catch (Exception ex)
                {
                    MessageBox.Show("Error en el procedimiento del registro", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void altaPresupuesto(string Doc, string Nombre, string Apellido, string Tel, string Mail, string Ent, string Dir, decimal Sub, decimal Descuento, decimal Total, DateTime F_H, DataGridView dgv, string NroP)
        {
            clearConfirm = false;

            using (SqlConnection objConexion = new SqlConnection(Conexion.cadena)) // using me permite cerrar automaticamente la conexion
            {
                objConexion.Open();
                try
                {
                    
                    StringBuilder insertDetalleQuery = new StringBuilder();
                    StringBuilder insertPresupuestoQuery = new StringBuilder();

                    insertPresupuestoQuery.AppendLine("INSERT INTO H_Presupuesto(Nro_presupuesto, dni, nombre, Apellido, tel, email, entidad, direccion, subtotal, descuento, total, fecha_hora) VALUES");
                    insertPresupuestoQuery.AppendLine("(@NroP, @documentacion, @Nombre, @Apellido, @Telefono, @Mail, @Entidad, @Direccion, @Subtotal, @Descuento, @Total, @FechaHora);");

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

                    clearConfirm = true;
                    MessageBox.Show("Presupuesto guardado con éxito", "PRESUPUESTO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error en el procedimiento del Registro", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                    SqlCommand cmd = new SqlCommand(Query.ToString(), objConexion);
                    {
                        cmd.Parameters.AddWithValue("@Doc", Doc);
                        cmd.Parameters.AddWithValue("@Nombre", Nombre);
                        cmd.Parameters.AddWithValue("@Apellido", Apellido);
                        cmd.Parameters.AddWithValue("@Dir", Dir);
                        cmd.Parameters.AddWithValue("@Tel", Tel);
                        cmd.Parameters.AddWithValue("@Correo", Correo);
                        cmd.Parameters.AddWithValue("@Entidad", Entidad);
                    }
                    objConexion.Open();
                    cmd.ExecuteNonQuery();
                    clearConfirm = true;
                    MessageBox.Show("Cliente registrado con éxito", "CLIENTE", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
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
                catch (Exception ex)
                {
                    MessageBox.Show("Error en el procedimiento del registro", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
