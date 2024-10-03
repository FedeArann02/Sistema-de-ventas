using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ventas_Hardware
{
    public partial class frmBuscarPresupuesto : Form
    {
        public CN_Consultas cN_Consultas = new CN_Consultas();
        public DataTable dt = new DataTable();
        public CN_Modificaciones modificacion = new CN_Modificaciones();
        public decimal SubTotal;
        public frmBuscarPresupuesto()
        {
            InitializeComponent();
            cargaCombos();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                ConsultarPresupuesto();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en el procedimiento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbNombres_SelectedIndexChanged(object sender, EventArgs e)
        {
            NroFuncion();
        }
        private void cargaCombos()
        {
            DataTable ClienteCombo = cN_Consultas.ConsultaCliente("TodosNombres");
            ClienteCombo.Columns.Add("NombreApellido", typeof(string), "Nombre + ' ' + Apellido");

            cmbNombres.DisplayMember = "NombreApellido";
            cmbNombres.ValueMember = "Documentacion";
            cmbNombres.DataSource = ClienteCombo;
            cmbNombres.SelectedIndex = -1;
        }

        private void NroFuncion()
        {
            if (cmbNombres.SelectedIndex != -1 && cmbNombres.SelectedValue != null)
            {
                cmbNro.SelectedIndex = -1;
                string selectedDNI = cmbNombres.SelectedValue.ToString();

                List<H_Presupuesto> presupuestos = new CN_H_Presupuesto().ListarNombreNro()
                    .Where(p => p.dni == selectedDNI)
                    .ToList(); //Lambda que aplica el metodo Where de la clase List, que filtra donde los codigos hagan match.

                cmbNro.DisplayMember = "Nro_presupuesto";
                cmbNro.ValueMember = "Nro_presupuesto";
                cmbNro.DataSource = presupuestos;
                cmbNro.SelectedIndex = -1;
            }
            else
            {
                // Limpiar el ComboBox de Subcategorías si no hay una categoría seleccionada
                cmbNro.DataSource = null;
            }
        }

        private void ConsultarPresupuesto()
        {
            dgvArticulos.Rows.Clear();
            dt = cN_Consultas.ConsultaPresupuesto((cmbNro.Text));

            //Lllenar textboxes
            txtNombre.Text = dt.Rows[0]["nombre"].ToString();
            txtApellido.Text = dt.Rows[0]["Apellido"].ToString();
            txtDoc.Text = dt.Rows[0]["dni"].ToString();
            txtEmail.Text = dt.Rows[0]["email"].ToString();
            txtTelefono.Text = dt.Rows[0]["tel"].ToString();
            txtDireccion.Text = dt.Rows[0]["direccion"].ToString();
            txtEntidad.Text = dt.Rows[0]["entidad"].ToString();
            txtSubTotal.Text = dt.Rows[0]["subtotal"].ToString();
            txtDescuento.Text = dt.Rows[0]["descuento"].ToString();
            txtTotal.Text = dt.Rows[0]["total"].ToString();
            txtFechaHora.Text = dt.Rows[0]["Fecha y hora"].ToString();
            txtCodigoPresupuesto.Text = dt.Rows[0]["Nro_presupuesto"].ToString();
            SubTotal = decimal.Parse(txtSubTotal.Text);

            dt = cN_Consultas.ConsultaP_Detalle((cmbNro.Text));

            //Llenar grilla
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dgvArticulos.Rows.Add(dt.Rows[i]["Cod_Articulo"], dt.Rows[i]["Descripción"], dt.Rows[i]["Precio unitario"], dt.Rows[i]["Cantidad"], dt.Rows[i]["Precio por cantidad"]);
                panelDetalle.Enabled = true;
                cmbNro.SelectedIndex = -1;
                cmbNombres.SelectedIndex = -1;
            }
        }

        private void clear()
        {
            //PanelEncabezado
            cmbNombres.SelectedIndex = -1;
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDoc.Text = "";
            txtEmail.Text = "";
            txtTelefono.Text = "";
            txtDireccion.Text = "";
            txtEntidad.Text = "";

            //PanelDetalle
            dgvArticulos.Rows.Clear();
            txtFechaHora.Text = "";
            txtCodigoPresupuesto.Text = "";
            txtCodigo.Text = "";
            txtCantidad.Text = "";
            txtDescripcion.Text = "";
            txtDescuento.Text = "";
            txtSubTotal.Text = "";
            txtTotal.Text = "";
            txtCodigoPresupuesto.Text = "";
            
        }

        private decimal precioVenta()
        {
            dt = cN_Consultas.ConsultaArtMod(txtCodigo.Text);
            decimal costo = decimal.Parse(dt.Rows[0]["Costo"].ToString());
            decimal Ganancia = decimal.Parse(dt.Rows[0]["Ganancia"].ToString());
            decimal Precio_Venta = costo + (costo * Ganancia / 100);
            return Decimal.Round(Precio_Venta, 2);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                bool ArtExiste = false;
                dt = cN_Consultas.ConsultaArtMod(txtCodigo.Text);
                decimal Precio = precioVenta();
                decimal PxCant = Convert.ToDecimal(txtCantidad.Text) * Precio;
                SubTotal += PxCant;
                {
                    foreach (DataGridViewRow fila in dgvArticulos.Rows)
                    {
                        if (fila.Cells["C_CodArt"].Value != null && fila.Cells["C_CodArt"].Value.ToString() == txtCodigo.Text)
                        {
                            // Si el código ya existe, actualiza la cantidad sumando la nueva cantidad
                            int cantidadActual = Convert.ToInt32(fila.Cells["C_Cantidad"].Value);
                            decimal PxCantActual = decimal.Parse(fila.Cells["C_Pxcant"].Value.ToString());
                            fila.Cells["C_Cantidad"].Value = cantidadActual + int.Parse(txtCantidad.Text);
                            fila.Cells["C_Pxcant"].Value = PxCantActual + PxCant;
                            ArtExiste = true;
                            break;
                        }
                    }

                    if (!ArtExiste)
                    {
                        dgvArticulos.Rows.Add(txtCodigo.Text, txtDescripcion.Text, Precio, txtCantidad.Text, PxCant);
                    }
                    if (dgvArticulos.Rows.Count > 1)
                    {
                        txtDescripcion.Text = "";
                        txtCodigo.Text = "";
                        txtCantidad.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en el procedimiento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            txtSubTotal.Text = SubTotal.ToString();
        }

        private void reCalcular()
        {
            try
            {
                if (txtDescuento.Text == null || txtDescuento.Text == "")
                {
                    decimal Descuento = 0;
                    if (txtSubTotal.Text == null || txtSubTotal.Text == "")
                    {
                        decimal SubTotal = 0;
                    }
                    else
                    {
                        decimal SubTotal = decimal.Parse(txtSubTotal.Text);
                        txtTotal.Text = Decimal.Round((SubTotal - (SubTotal * Descuento / 100)), 2).ToString();
                    }
                }
                else if (decimal.Parse(txtDescuento.Text) > 100)
                {
                    MessageBox.Show("El descuento no puede ser mayor al 100%", "Error");
                    txtDescuento.Text = "";
                }
                else
                {
                    decimal Descuento = decimal.Parse(txtDescuento.Text);
                    decimal SubTotal = decimal.Parse(txtSubTotal.Text);
                    txtTotal.Text = Decimal.Round((SubTotal - (SubTotal * Descuento / 100)), 2).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Posible error en el formato ingresado, solo se admiten números enteros o decimales positivos");
                txtDescuento.Text = "";
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            clear();
            panelDetalle.Enabled = false;
            panelDatosEncabezado.Enabled = false;
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            if (txtDescripcion.Text != null && txtDescripcion.Text != "")
            {
                foreach (DataGridViewRow fila in dgvArticulos.Rows)
                {
                    if (fila.Cells["C_CodArt"].Value != null && fila.Cells["C_CodArt"].Value.ToString() == txtCodigo.Text)
                    {
                        decimal Precio = precioVenta();

                        int cantidadActual = Convert.ToInt32(fila.Cells["C_Cantidad"].Value);
                        if (cantidadActual == 1)
                        {
                            SubTotal -= Precio;
                            txtSubTotal.Text = SubTotal.ToString();
                            DataGridViewRow filaSelec = dgvArticulos.CurrentRow;
                            dgvArticulos.Rows.Remove(filaSelec);

                            if (dgvArticulos.Rows.Count == 0)
                            {
                                clearDetalle();
                            }
                        }
                        else
                        {
                            if (cantidadActual > 0)
                            {
                                decimal PxCant = (Convert.ToDecimal(txtCantidad.Text) - 1) * Precio;
                                decimal PxCantActual = decimal.Parse(fila.Cells["C_Pxcant"].Value.ToString());
                                fila.Cells["C_Cantidad"].Value = cantidadActual - 1;
                                fila.Cells["C_Pxcant"].Value = PxCant;
                                txtCantidad.Text = (cantidadActual - 1).ToString();
                                SubTotal -= Precio;
                                txtSubTotal.Text = SubTotal.ToString();
                                break;
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un producto de la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvArticulos.Rows.Count != 0)
            {
                DialogResult dres = MessageBox.Show("¿Desea remover este articulo de la lista?", "Remover", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dres == DialogResult.OK)
                {
                    if (dgvArticulos.Rows.Count == 1)
                    {
                        clearDetalle();
                    }
                    else
                    {
                        foreach (DataGridViewRow fila in dgvArticulos.Rows)
                        {
                            DataGridViewRow filaSelec = dgvArticulos.CurrentRow;
                            decimal Precio = precioVenta();
                            if (fila.Cells["C_CodArt"].Value != null && fila.Cells["C_CodArt"].Value.ToString() == txtCodigo.Text)
                            {
                                //decimal PxCant = (Convert.ToDecimal(txtCantidad.Text)) * Precio;
                                decimal PxCantActual = decimal.Parse(fila.Cells["C_Pxcant"].Value.ToString());
                                SubTotal -= PxCantActual;
                                txtSubTotal.Text = SubTotal.ToString();
                                dgvArticulos.Rows.Remove(filaSelec);
                                break;
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un producto de la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void clearDetalle()
        {
            txtFechaHora.Text = "";
            txtCodigoPresupuesto.Text = "";
            txtCodigo.Text = "";
            txtCantidad.Text = "";
            txtDescripcion.Text = "";
            txtDescuento.Text = "";
            txtSubTotal.Text = "";
            txtTotal.Text = "";
        }

        private void btnBuscarArt_Click(object sender, EventArgs e)
        {
            dt = cN_Consultas.ConsultaArtMod(txtCodigo.Text);
            if (dt.Rows.Count != 0)
            {
                txtDescripcion.Text = dt.Rows[0]["Descripcion"].ToString();
            }
            else
            {
                MessageBox.Show("El código que ingresó no se encuentra en la Base de datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow != null && !dgvArticulos.CurrentRow.IsNewRow)
            {
                DataGridViewRow filaSelec = dgvArticulos.CurrentRow;
                txtCodigo.Text = filaSelec.Cells[0].Value.ToString();
                txtDescripcion.Text = filaSelec.Cells[1].Value.ToString();
                txtCantidad.Text = filaSelec.Cells[3].Value.ToString();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            modificacion.mod_Presupuesto(txtDoc.Text, txtNombre.Text, txtApellido.Text, txtTelefono.Text, txtEmail.Text,
            txtEntidad.Text, txtDireccion.Text, decimal.Parse(txtSubTotal.Text), decimal.Parse(txtDescuento.Text),
            decimal.Parse(txtTotal.Text), DateTime.Now, dgvArticulos, txtCodigoPresupuesto.Text);

            if (modificacion.modConfirm)
            {
                clear();
                clearDetalle();
            }
        }

        private void txtDescuento_TextChanged(object sender, EventArgs e)
        {
            reCalcular();
        }

        private void txtSubTotal_TextChanged(object sender, EventArgs e)
        {
            reCalcular();
        }
    }
}