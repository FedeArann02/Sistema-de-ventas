using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ventas_Hardware
{
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
            cargaComboClientes();
        }
        private void cargaComboClientes()
        {
            DataTable ClienteCombo = cN_Consultas.ConsultaCliente("TodosNombres");
            ClienteCombo.Columns.Add("NombreApellido", typeof(string), "Nombre + ' ' + Apellido");

            this.ClienteCombo.DisplayMember = "NombreApellido";
            this.ClienteCombo.ValueMember = "Documentacion";
            this.ClienteCombo.DataSource = ClienteCombo;
            this.ClienteCombo.SelectedIndex = -1;
        }

        private void cargaGrillaRem_Pres()
        {
            if (cmbRemPres.SelectedIndex == 0) //REMITOS
            {
                dgvRemPres.DataSource = cN_Consultas.ConsultaPresupuesto_Remito_Cliente(txtDoc.Text, "-");
            }
            else if (cmbRemPres.SelectedIndex == 1) //PRESUPUESTOS
            {
                dgvRemPres.DataSource = cN_Consultas.ConsultaPresupuesto_Remito_Cliente(txtDoc.Text, "Presupuesto");
            }
            else
            {
                cmbRemPres.Text = "";
            }
        }

        private void cargarGrillaDetalles(string Nro)
        {
            if (cmbRemPres.SelectedIndex == 0) //REMITOS
            {
                dgvRemPresDetalle.Rows.Clear();
                dtDetalle = cN_Consultas.ConsultaR_Detalle(Nro);
            }
            else if (cmbRemPres.SelectedIndex == 1) //PRESUPUESTOS
            {
                dgvRemPresDetalle.Rows.Clear(); //limpia la grilla para que no se superponga con las otras
                dtDetalle = cN_Consultas.ConsultaP_Detalle(Nro);
            }
            else
            {
                cmbRemPres.Text = "";
            }

            if (dtDetalle.Rows.Count > 0)
            {
                //Llenar grilla
                for (int i = 0; i < dtDetalle.Rows.Count; i++)
                {
                    dgvRemPresDetalle.Rows.Add(dtDetalle.Rows[i]["Cod_Articulo"], dtDetalle.Rows[i]["Descripción"], dtDetalle.Rows[i]["Precio unitario"], dtDetalle.Rows[i]["Cantidad"], dtDetalle.Rows[i]["Precio por cantidad"]);
                }
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (ClienteCombo.SelectedIndex != -1)
            {
                dt = cN_Consultas.ConsultaCliente(ClienteCombo.SelectedValue.ToString());
            }
            else
            {
                dt = cN_Consultas.ConsultaCliente(txtDocumentacionCliente.Text);
            }

            if (dt.Rows.Count != 0)
            {
                txtNombre.Text = dt.Rows[0]["Nombre"].ToString();
                txtApellido.Text = dt.Rows[0]["Apellido"].ToString();
                txtDoc.Text = dt.Rows[0]["Documentacion"].ToString();
                txtEmail.Text = dt.Rows[0]["Correo"].ToString();
                txtTelefono.Text = dt.Rows[0]["Telefono"].ToString();
                txtDireccion.Text = dt.Rows[0]["Direccion"].ToString();
                txtEntidad.Text = dt.Rows[0]["Entidad"].ToString();
                txtDocumentacionCliente.Text = "";

                dtCtaCte = cN_Consultas.ConsultaClienteCtaCte(txtDoc.Text);

                txtCompras.Text = dtCtaCte.Rows[0]["compras"].ToString();
                txtPagos.Text = dtCtaCte.Rows[0]["pagos"].ToString();
                txtDeudas.Text = calcularDeuda().ToString();

                btnBuscar.Enabled = false;
                enablePanels();
            }
            else
            {
                MessageBox.Show("No se encotró el cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void enablePanels()
        {
            panelCTACTE.Enabled = true;
            panelDatosEncabezado.Enabled = true;
            panelRemitos_Presupuestos.Enabled = true;
        }

        private void disablePanels()
        {
            panelCTACTE.Enabled = false;
            panelDatosEncabezado.Enabled = false;
            panelRemitos_Presupuestos.Enabled = false;
        }

        private decimal calcularDeuda()
        {
            decimal pagos = decimal.Parse(txtPagos.Text);
            decimal compras = decimal.Parse(txtCompras.Text);
            return Decimal.Round((compras - pagos), 2);
        }

        private void txtDocumentacionCliente_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(ClienteCombo.Text))
            {
                if(!String.IsNullOrEmpty(txtDocumentacionCliente.Text))
                {
                    btnBuscar.Enabled = true;
                }
                else
                {
                    btnBuscar.Enabled = false;
                }
            }
            else
            {
                if(String.IsNullOrEmpty(txtDocumentacionCliente.Text))
                {
                    btnBuscar.Enabled = true;
                }
                else
                {
                    btnBuscar.Enabled = false;
                }
            }
        }

        private void ClienteCombo_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(ClienteCombo.Text))
            {
                if (String.IsNullOrEmpty(txtDocumentacionCliente.Text) && Count == 1)
                {
                    btnBuscar.Enabled = true;
                    
                }
                else
                {
                    btnBuscar.Enabled = false;
                    Count = 1;
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            clear();
            clearAll();

            disablePanels();

            ClienteCombo.SelectedIndex = -1;
            cmbRemPres.SelectedIndex = -1;
            dgvRemPresDetalle.Rows.Clear();

            for (int i = dgvRemPres.Rows.Count - 1; i > -1; i--)
            {
                dgvRemPres.Rows.RemoveAt(i);
            }
        }

        private void clear()
        {
            txtDocumentacionCliente.Text = "";
            ClienteCombo.Text = "";
            btnBuscar.Enabled = false;
            panelRegistrarPagos.Enabled = false;
        }

        private void clearAll()
        {
            txtApellido.Text = "";
            txtNombre.Text = "";
            txtDocumentacionCliente.Text = "";
            ClienteCombo.Text = "";
            txtTelefono.Text = "";
            txtDireccion.Text = "";
            txtDoc.Text = "";
            txtEmail.Text = "";
            txtEntidad.Text = "";

            txtCompras.Text = "";
            txtDeudas.Text = "";
            txtPagos.Text = "";
            txtMonto.Text = "";

            btnBuscar.Enabled = false;
            panelRegistrarPagos.Enabled = false;
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            panelRegistrarPagos.Enabled = true;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtMonto.Text, out decimal monto) && decimal.TryParse(txtPagos.Text, out decimal pagos))
            {
                decimal Monto = monto + pagos; 

                cN_Modificaciones.RegistraPagoCliente(txtDoc.Text, Monto);

                if (cN_Modificaciones.modConfirm)
                {
                    clearAll();
                }
            }
            else
            {
                MessageBox.Show("Ingrese valores válidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMonto.Text = "";
            }
        }

        private void cmbRemPres_SelectedValueChanged(object sender, EventArgs e)
        {
            cargaGrillaRem_Pres();
        }

        private void dgvRemPres_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow filaSeleccionada = dgvRemPres.Rows[e.RowIndex];
                string Nro = filaSeleccionada.Cells[0].Value.ToString();

                cargarGrillaDetalles(Nro);

            }
        }

        CN_Consultas cN_Consultas = new CN_Consultas();
        CN_Modificaciones cN_Modificaciones = new CN_Modificaciones();
        DataTable dt = new DataTable();
        DataTable dtCtaCte = new DataTable();
        DataTable dtDetalle = new DataTable();

        int Count = 0; //para activar los botones

    }
}
