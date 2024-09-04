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
                btnBuscar.Visible = false;
                txtDocumentacionCliente.Visible = false;

                {
                    panelDatosEncabezado.Enabled = true;
                    panelDetalle.Enabled = true;
                }
            }
            else if (cmbCliente.SelectedIndex == 1)
            {
                btnBuscar.Visible = true;
                txtDocumentacionCliente.Visible = true;

                {
                    panelDatosEncabezado.Enabled = false;
                    panelDetalle.Enabled = false;
                }
            }
            else
            {
                btnBuscar.Visible = false;
                txtDocumentacionCliente.Visible = false;

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
                CN_Consultas cN_Consultas = new CN_Consultas();
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
        {;
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
                    txtDescripcion.Text = "";
                    txtCodigo.Text = "";
                    txtCantidad.Text = "";
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

        private void btnReCalcular_Click(object sender, EventArgs e)
        {
            decimal Descuento = decimal.Parse(txtDescuento.Text);
            decimal SubTotal = decimal.Parse(txtSubTotal.Text);
            txtTotal.Text = (SubTotal-(SubTotal*Descuento/100)).ToString();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            CN_Altas cN_Altas = new CN_Altas();

            cN_Altas.CN_PresupAlta(txtDoc.Text, txtNombre.Text, txtApellido.Text, txtTelefono.Text, txtEmail.Text, 
            txtEntidad.Text, txtDireccion.Text, decimal.Parse(txtSubTotal.Text), decimal.Parse(txtDescuento.Text), 
            decimal.Parse(txtTotal.Text), DateTime.Now, dgvArticulos);

            if(cN_Altas.clearConf)
            {
                clear();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            clear();
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
            txtCodigo.Text = "";
            txtCantidad.Text = "";
            txtDescripcion.Text = "";
            txtSubTotal.Text = "";
            txtDescuento.Text = "";
            txtTotal.Text = "";
            dgvArticulos.Rows.Clear();
        }
    }
}
