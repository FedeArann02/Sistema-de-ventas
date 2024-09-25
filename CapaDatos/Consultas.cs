using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaDatos
{
    public class Consultas
    {
        public DataTable ConsultaArt ()
        {
            DataTable dt = new DataTable();

            using (SqlConnection objConexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder Query = new StringBuilder();
                    Query.AppendLine("select a.Cod_articulo as Codigo, a.Descripcion, c.Nombre as Categoria, s.Nombre as Subcategoria, p.Nombre as Proveedor, st.Cantidad, st.Costo, st.Ganancia, c.Cod_categoria, s.Cod_subcategoria, p.ID_Proveedor from ARTICULO a");
                    Query.AppendLine("inner join CATEGORIA c on a.Cod_categoria = c.Cod_categoria");
                    Query.AppendLine("inner join SUBCATEGORIA s on a.Cod_subcategoria = s.Cod_subcategoria");
                    Query.AppendLine("inner join PROVEEDOR p on a.ID_Proveedor = p.ID_Proveedor");
                    Query.AppendLine("inner join STOCK st on a.Cod_articulo = st.Cod_articulo");

                    SqlCommand cmd = new SqlCommand(Query.ToString(), objConexion);
                    cmd.CommandType = CommandType.Text;
                    objConexion.Open ();
                    SqlDataReader dR = cmd.ExecuteReader ();
                    dt.Load (dR);
                }
                catch (Exception ex)
                {
                    dt = new DataTable();
                }
            }
            return dt;
        }

        public DataTable ConsultaArtMod(string Codigo)
        {
            DataTable dt = new DataTable();

            using (SqlConnection objConexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder Query = new StringBuilder();
                    Query.AppendLine("select a.Cod_articulo as Codigo, a.Descripcion, c.Nombre as Categoria, s.Nombre as Subcategoria, p.Nombre as Proveedor, st.Cantidad, st.Costo, st.Ganancia, c.Cod_categoria, s.Cod_subcategoria, p.ID_Proveedor from ARTICULO a");
                    Query.AppendLine("inner join CATEGORIA c on a.Cod_categoria = c.Cod_categoria");
                    Query.AppendLine("inner join SUBCATEGORIA s on a.Cod_subcategoria = s.Cod_subcategoria");
                    Query.AppendLine("inner join PROVEEDOR p on a.ID_Proveedor = p.ID_Proveedor");
                    Query.AppendLine("inner join STOCK st on a.Cod_articulo = st.Cod_articulo");
                    Query.AppendLine("where a.Cod_articulo = @Codigo");

                    SqlCommand cmd = new SqlCommand(Query.ToString(), objConexion);
                    cmd.Parameters.AddWithValue("@Codigo", Codigo);
                    cmd.CommandType = CommandType.Text;
                    objConexion.Open();
                    SqlDataReader dR = cmd.ExecuteReader();
                    dt.Load(dR);
                }
                catch (Exception ex)
                {
                    dt = new DataTable();
                }
            }
            return dt;
        }

        public DataTable ConsultaCliente(string Documentacion)
        {
            DataTable dt = new DataTable();

            using (SqlConnection objConexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder Query = new StringBuilder();
                    if (Documentacion == "TodosNombres")
                    {
                        Query.AppendLine("SELECT ID_cliente, Documentacion, Nombre, Apellido, Direccion, Telefono, Correo, Entidad");
                        Query.AppendLine("FROM CLIENTE");
                    }
                    else
                    {
                        Query.AppendLine("SELECT ID_cliente, Documentacion, Nombre, Apellido, Direccion, Telefono, Correo, Entidad");
                        Query.AppendLine("FROM CLIENTE where Documentacion = @Doc");
                    }

                    SqlCommand cmd = new SqlCommand(Query.ToString(), objConexion);
                    cmd.Parameters.AddWithValue("@Doc", Documentacion);
                    cmd.CommandType = CommandType.Text;
                    objConexion.Open();
                    SqlDataReader dR = cmd.ExecuteReader();
                    dt.Load(dR);
                }
                catch (Exception ex)
                {
                    dt = new DataTable();
                }
            }
            return dt;
        }

        public DataTable ConsultaPresupuesto(int id_presupuesto)
        {
            DataTable dt = new DataTable();

            using (SqlConnection objConexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder Query = new StringBuilder();
                    Query.AppendLine("SELECT p.id_presupuesto, p.nombre, p.Apellido, p.tel, p.email, p.entidad, p.dni, p.subtotal, p.descuento, p.total, p.direccion, p.fecha_hora AS 'Fecha y Hora',");
                    Query.AppendLine("d.id_presupuesto_detalle, d.id_presupuesto, d.Cod_articulo, d.descripcion AS 'Descripción', d.precio_unitario AS 'Precio unitario', d.cantidad AS Cantidad, d.precio_x_cantidad AS 'Precio por cantidad'");
                    Query.AppendLine("FROM H_Presupuesto p");
                    Query.AppendLine("INNER JOIN H_Presupuesto_Detalle d ON p.id_presupuesto = d.id_presupuesto");
                    Query.AppendLine("WHERE p.id_presupuesto = @id_presupuesto;");

                    SqlCommand cmd = new SqlCommand(Query.ToString(), objConexion);
                    cmd.Parameters.AddWithValue("@id_presupuesto", id_presupuesto);
                    cmd.CommandType = CommandType.Text;
                    objConexion.Open();
                    SqlDataReader dR = cmd.ExecuteReader();
                    dt.Load(dR);
                }
                catch (Exception ex)
                {
                    dt = new DataTable();
                }
            }
            return dt;
        }

        public DataTable ConsultaPresupuestoDetalle(int id_presupuesto)
        {
            DataTable dt = new DataTable();

            using (SqlConnection objConexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder Query = new StringBuilder();
                    Query.AppendLine("SELECT d.id_presupuesto_detalle, d.id_presupuesto, d.Cod_articulo, d.descripcion AS 'Descripción', d.precio_unitario AS 'Precio unitario', d.cantidad AS Cantidad, d.precio_x_cantidad AS 'Precio por cantidad'");
                    Query.AppendLine("FROM H_Presupuesto_detalle d");
                    Query.AppendLine("WHERE d.id_presupuesto = @id_presupuesto;");

                    SqlCommand cmd = new SqlCommand(Query.ToString(), objConexion);
                    cmd.Parameters.AddWithValue("@id_presupuesto", id_presupuesto);
                    cmd.CommandType = CommandType.Text;
                    objConexion.Open();
                    SqlDataReader dR = cmd.ExecuteReader();
                    dt.Load(dR);
                }
                catch (Exception ex)
                {
                    dt = new DataTable();
                }
            }
            return dt;
        }
    }
}
