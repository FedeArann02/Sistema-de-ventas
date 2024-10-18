using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ventas_Hardware
{
    public partial class frmProveedores : Form
    {
        CN_Consultas cN_Consultas = new CN_Consultas();
        CN_Modificaciones CN_Modificaciones = new CN_Modificaciones();
        DataTable dt = new DataTable();
        
        public frmProveedores()
        {
            InitializeComponent();
            cargaCombos();
        }

        private void cargaCombos()
        {
            DataTable ClienteCombo = cN_Consultas.ConsultaProveedores();
            ClienteCombo.Columns.Add("NombreApellido", typeof(string), "Nombre + ' ' + Apellido");

            cmbProveedor.DisplayMember = "NombreApellido";
            cmbProveedor.ValueMember = "ID_proveedor";
            cmbProveedor.DataSource = ClienteCombo;
            //cmbProveedor.SelectedIndex = -1;
        }

        private void cargarTextBoxes(string ID_Proveedor)
        {
            dt = cN_Consultas.ConsultaProveedores(ID_Proveedor);
            txtNombre.Text = dt.Rows[0]["nombre"].ToString();
            txtApellido.Text = dt.Rows[0]["Apellido"].ToString();
            txtEmail.Text = dt.Rows[0]["correo"].ToString();
            txtTelefono.Text = dt.Rows[0]["Telefono"].ToString();
            dt.Clear();
        }

        private void cargarCTACTE(string ID_Proveedor)
        {
            dt = cN_Consultas.ConsultaProveedorCtaCte(ID_Proveedor);
            txtTotalPagoEstAct.Text = dt.Rows[0]["Pagos"].ToString();
            txtTotalCompraEstAct.Text = dt.Rows[0]["Compras"].ToString();
            txtDeuda.Text = (decimal.Parse(txtTotalCompraEstAct.Text) - decimal.Parse(txtTotalPagoEstAct.Text)).ToString();
            dt.Clear();
        }

        private void cmbProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarTextBoxes(cmbProveedor.SelectedValue.ToString());
            verGrillaFiltrada(dgvArticulos, cmbProveedor.SelectedValue.ToString()); //a prueba
            cargarCTACTE(cmbProveedor.SelectedValue.ToString());
        }

        private void dgvArticulos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvArticulos.CurrentRow != null && !dgvArticulos.CurrentRow.IsNewRow)
            {
                DataGridViewRow filaSelec = dgvArticulos.CurrentRow;
                txtCodigoDetalle.Text = filaSelec.Cells[0].Value.ToString();
                txtDescDetalle.Text = filaSelec.Cells[1].Value.ToString();
                txtCatDetalle.Text = filaSelec.Cells[2].Value.ToString();
                txtSubCatDetalle.Text = filaSelec.Cells[3].Value.ToString();
                txtProvDetalle.Text = filaSelec.Cells[4].Value.ToString();
                txtStockDetalle.Text = filaSelec.Cells[5].Value.ToString();
                txtCostoDetalle.Text = filaSelec.Cells[6].Value.ToString();
                txtGananciaDetalle.Text = filaSelec.Cells[7].Value.ToString();
                txtPrecioVentaDetalle.Text = precioVenta().ToString();

                panelDetalle.Visible = true;
            }
            else
            {
                //Clear()
            }
        }

        private void verGrillaFiltrada(DataGridView DGV, string proveedor) //funcion que filtra con la grilla
        {
            try
            {
                DataTable pepe = new CN_Consultas().DataTable();
                DataView dv = new DataView(pepe);
                dv.RowFilter = "Convert(ID_Proveedor, 'System.String') LIKE '%" + proveedor + "%'";
                DGV.DataSource = dv;
                dgvArticulos.Columns["Codigo"].Visible = true;
                dgvArticulos.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvArticulos.Columns["Descripcion"].Visible = true;
                dgvArticulos.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                foreach (DataGridViewColumn columna in dgvArticulos.Columns)
                {
                    if (columna.Name != "Codigo" && columna.Name != "Descripcion")
                    {
                        columna.Visible = false;
                    }
                }
                dgvArticulos.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en el procedimiento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private decimal precioVenta()
        {
            decimal costo = decimal.Parse(txtCostoDetalle.Text);
            decimal Ganancia = decimal.Parse(txtGananciaDetalle.Text);
            decimal Precio_Venta = costo + (costo * Ganancia / 100);
            return Decimal.Round(Precio_Venta, 2); //Decimal.Round = redondea los decimales a dos valores
        }

        private void clearAll()
        {
            txtApellido.Text = "";
            txtNombre.Text = "";
            txtTelefono.Text = "";
            txtEmail.Text = "";

            txtTotalPago.Text = "";
            txtTotalCompra.Text = "";
            txtTotalPagoEstAct.Text = "";
            txtTotalCompraEstAct.Text = "";
        }

        private void btnRegistrarCompra_Click(object sender, EventArgs e)
        {
            try
            {
                //los decimal abarcan un maximo de 19 caracteres (IMPORTANTE PARA VALIDAR EN CADA ENTRADA DE DECIMAL);
                if (txtTotalCompra.Text.Length < 20 && decimal.Parse(txtTotalCompra.Text) >= 0)
                {
                    CN_Modificaciones.RegistraCompraProveedor(Convert.ToString(cmbProveedor.SelectedValue), decimal.Parse(txtTotalCompra.Text));
                    txtTotalCompra.Text = "";
                    cargarCTACTE(Convert.ToString(cmbProveedor.SelectedValue));
                }
                else
                {
                    MessageBox.Show("Monto fuera de rango, ingrese un valor correcto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTotalCompra.Text = "0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de formato de entrada, solo puede ingresar valores enteros o decimales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegistrarpago_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTotalPago.Text.Length < 20 && decimal.Parse(txtTotalPago.Text) >= 0)
                {
                    decimal Monto = decimal.Parse(txtTotalPago.Text) + decimal.Parse(txtTotalPagoEstAct.Text);
                    CN_Modificaciones.RegistraPagoProveedor(Convert.ToString(cmbProveedor.SelectedValue), Monto);
                    txtTotalPago.Text = "";
                    cargarCTACTE(Convert.ToString(cmbProveedor.SelectedValue));
                }
                else
                {
                    MessageBox.Show("Monto fuera de rango, ingrese un valor correcto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTotalPago.Text = "0";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error de formato de entrada, solo puede ingresar valores enteros o decimales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
