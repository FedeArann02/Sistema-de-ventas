using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ventas_Hardware
{
    public partial class frmAltaPresupuesto : Form
    {
        public CN_Consultas cN_Consultas = new CN_Consultas();
        public DataTable dt = new DataTable();
        public decimal SubTotal;

        public frmAltaPresupuesto()
        {
            InitializeComponent();
        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCliente.SelectedIndex == 0)
            {
                clear();

                btnBuscar.Visible = false;
                txtDocumentacionCliente.Visible = false;
                lblDNICUIL_T.Visible = false;
                {
                    panelDatosEncabezado.Enabled = true;
                    panelDetalle.Enabled = true;
                }
            }
            else if (cmbCliente.SelectedIndex == 1)
            {
                btnBuscar.Visible = true;
                txtDocumentacionCliente.Visible = true;
                lblDNICUIL_T.Visible = true;

                {
                    panelDatosEncabezado.Enabled = false;
                    panelDetalle.Enabled = false;
                }
            }
            else
            {
                btnBuscar.Visible = false;
                txtDocumentacionCliente.Visible = false;
                lblDNICUIL_T.Visible = false;

                {
                    panelDatosEncabezado.Enabled = false;
                    panelDetalle.Enabled = false;
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                dt = cN_Consultas.ConsultaCliente(txtDocumentacionCliente.Text);

                txtNombre.Text = dt.Rows[0]["Nombre"].ToString();
                txtApellido.Text = dt.Rows[0]["Apellido"].ToString();
                txtDoc.Text = dt.Rows[0]["Documentacion"].ToString();
                txtEmail.Text = dt.Rows[0]["Correo"].ToString();
                txtTelefono.Text = dt.Rows[0]["Telefono"].ToString();
                txtDireccion.Text = dt.Rows[0]["Direccion"].ToString();
                txtEntidad.Text = dt.Rows[0]["Entidad"].ToString();
                txtDocumentacionCliente.Text = "";
                {
                    panelDetalle.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en el procedimiento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscarArt_Click(object sender, EventArgs e)
        {
            dt = cN_Consultas.ConsultaArtMod(txtCodigo.Text);
            if (dt.Rows.Count != null && dt.Rows.Count != 0)
            {
                txtDescripcion.Text = dt.Rows[0]["Descripcion"].ToString();
            }
            else
            {
                MessageBox.Show("El código que ingresó no se encuentra en la Base de datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try { 
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

            txtSubTotal.Text =SubTotal.ToString();
        }

        private decimal precioVenta()
        {
            dt = cN_Consultas.ConsultaArtMod(txtCodigo.Text);
            decimal costo = decimal.Parse(dt.Rows[0]["Costo"].ToString());
            decimal Ganancia = decimal.Parse(dt.Rows[0]["Ganancia"].ToString());
            decimal Precio_Venta = costo + (costo * Ganancia / 100);
            return Decimal.Round(Precio_Venta, 2);
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
            catch(Exception ex)
            {
                MessageBox.Show("Posible error en el formato ingresado, solo se admiten números enteros o decimales positivos");
                txtDescuento.Text = "";
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            CN_Altas cN_Altas = new CN_Altas();

            cN_Altas.CN_PresupAlta(txtDoc.Text, txtNombre.Text, txtApellido.Text, txtTelefono.Text, txtEmail.Text, 
            txtEntidad.Text, txtDireccion.Text, decimal.Parse(txtSubTotal.Text), decimal.Parse(txtDescuento.Text), 
            decimal.Parse(txtTotal.Text), DateTime.Now, dgvArticulos, txtCodigoPresupuesto.Text);

            if (cmbCliente.Text == "Cliente Nuevo")
            {
                cN_Altas.CN_AltaCliente_PresupuestoRemito(txtDoc.Text, txtNombre.Text, txtApellido.Text, txtDireccion.Text, txtTelefono.Text, txtEmail.Text,
                txtEntidad.Text);
            }

            if (cN_Altas.clearConf)
            {
                clear();
                clearDetalle();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            clear();
            cmbCliente.Text = "SELECCIONE UNA OPCIÓN";
        }

        private void clear()
        {
            //PanelEncabezado
            cmbCliente.SelectedIndex = -1;
            txtDocumentacionCliente.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDoc.Text = "";
            txtEmail.Text = "";
            txtTelefono.Text = "";
            txtDireccion.Text = "";
            txtEntidad.Text = "";

            //PanelDetalle
            dgvArticulos.Rows.Clear();
            txtCodigoPresupuesto.Text = "";
            txtCodigo.Text = "";
            txtCantidad.Text = "";
            txtDescripcion.Text = "";
            txtDescuento.Text = "";
            txtSubTotal.Text = "";
            txtTotal.Text = "";
            
        }

        private void clearDetalle()
        {
            txtCodigoPresupuesto.Text = "";
            txtCodigo.Text = "";
            txtCantidad.Text = "";
            txtDescripcion.Text = "";
            txtDescuento.Text = "";
            txtSubTotal.Text = "";
            txtTotal.Text = "";
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
                MessageBox.Show("Seleccione un producto de la lista","Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvArticulos.Rows.Count != null && dgvArticulos.Rows.Count != 0)
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

        private void txtDescuento_TextChanged(object sender, EventArgs e)
        {
            reCalcular();
        }

        private void txtSubTotal_TextChanged(object sender, EventArgs e)
        {
            reCalcular();
        }

        private void cmbCliente_DropDown(object sender, EventArgs e)
        {
            cmbCliente.Text = "";
        }

        private void cmbCliente_DropDownClosed(object sender, EventArgs e)
        {
            if (cmbCliente.SelectedIndex == -1 || cmbCliente.Text == "")
            {
                cmbCliente.Text = "SELECCIONE UNA OPCIÓN";
            }
        }
    }
}
