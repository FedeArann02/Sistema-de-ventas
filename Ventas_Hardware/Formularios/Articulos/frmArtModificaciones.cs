using CapaEntidad;
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
    public partial class frmArtModificaciones : Form
    {
        CN_Modificaciones cN_Modificaciones = new CN_Modificaciones();
        public frmArtModificaciones()
        {
            InitializeComponent();
            cargaCombos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            llenarTextboxes();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            cN_Modificaciones.modArt(txtCodigo.Text, txtDescripcion.Text, int.Parse(txtStock.Text), decimal.Parse(txtCosto.Text), decimal.Parse(txtGanancia.Text));
            if (cN_Modificaciones.modConfirm)
            {
                clear();
                disableButtons();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            clear();
            txtCodigo.Enabled = true;
            disableButtons();
        }

        private void btnRecalcular_Click(object sender, EventArgs e)
        {
            txtPrecioVenta.Text = precioVenta().ToString();
        }

        private void cargaCombos()
        {
            List<Categoria> categoria = new CN_Categoria().Listar(cmbCategoria.Text);
            List<Proveedor> proveedor = new CN_Proveedores().Listar();

            cmbProveedor.DisplayMember = "Nombre";
            cmbProveedor.ValueMember = "ID_Proveedor";
            cmbProveedor.DataSource = proveedor;
            cmbProveedor.SelectedIndex = -1;

            cmbCategoria.DisplayMember = "Nombre";
            cmbCategoria.ValueMember = "Cod_categoria";
            cmbCategoria.DataSource = categoria;
            cmbCategoria.SelectedIndex = -1;

        }

        private void SubCategoriaFuncion()
        {
            if (cmbCategoria.SelectedIndex != -1 && cmbCategoria.SelectedValue != null)
            {
                int selectedCategoriaId = (int)cmbCategoria.SelectedValue;

                List<Subcategoria> subcategoria = new CN_Subcategoria().Listar()
                    .Where(s => s.objCategoria.Cod_categoria == selectedCategoriaId)
                    .ToList(); //Lambda que aplica el metodo Where de la clase List, que filtra donde los codigos hagan match.

                cmbSubcategoria.DisplayMember = "Nombre";
                cmbSubcategoria.ValueMember = "Cod_Subcategoria";
                cmbSubcategoria.DataSource = subcategoria;
                cmbSubcategoria.SelectedIndex = -1;
            }
            else
            {
                // Limpiar el ComboBox de Subcategorías si no hay una categoría seleccionada
                cmbSubcategoria.DataSource = null;
            }
        }

        private void llenarTextboxes()
        {
            CN_Consultas cN_Consultas = new CN_Consultas();
            DataTable dt = new DataTable();
            dt = cN_Consultas.ConsultaArtMod(txtCodigo.Text);
            if (dt.Rows.Count != null && dt.Rows.Count != 0)
            {
                txtCategoria.Text = dt.Rows[0]["Categoria"].ToString();
                txtSubCategoria.Text = dt.Rows[0]["SubCategoria"].ToString();
                txtDescripcion.Text = dt.Rows[0]["Descripcion"].ToString();
                txtProveedor.Text = dt.Rows[0]["Proveedor"].ToString();
                txtStock.Text = dt.Rows[0]["Cantidad"].ToString();
                txtCosto.Text = dt.Rows[0]["Costo"].ToString();
                txtGanancia.Text = dt.Rows[0]["Ganancia"].ToString();
                txtPrecioVenta.Text = precioVenta().ToString();
                {
                    enableButtons();
                    txtCodigo.Enabled = false;
                }
            }
            else 
            {
                MessageBox.Show("El código que ingresó no se encuentra en la Base de datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void enableButtons()
        {
            btnRecalcular.Enabled = true;
            btnCancelar.Enabled = true;
            btnGuardar.Enabled = true;
            {
                txtDescripcion.Enabled = true;
                txtCosto.Enabled = true;
                txtGanancia.Enabled = true;
                txtPrecioVenta.Enabled = true;
                txtStock.Enabled = true;
            }
        }
        private void disableButtons()
        {
            btnRecalcular.Enabled = false;
            btnCancelar.Enabled = false;
            btnGuardar.Enabled = false;
            {
                txtDescripcion.Enabled = false;
                txtCosto.Enabled = false;
                txtGanancia.Enabled = false;
                txtPrecioVenta.Enabled = false;
                txtStock.Enabled = false;
            }
        }

        private void clear()
        {
            txtCodigo.Text = "";
            txtCategoria.Text = "";
            txtSubCategoria.Text = "";
            txtDescripcion.Text = "";
            txtProveedor.Text = "";
            txtStock.Text = "";
            txtCosto.Text = "";
            txtGanancia.Text = "";
            txtPrecioVenta.Text = "";
            txtAumentoGanancia.Text = "";
            txtAumentoCosto.Text = "";
            cmbCategoria.SelectedIndex = -1;
            cmbProveedor.SelectedIndex = -1;
            cmbSubcategoria.SelectedIndex = -1;
        }

        private decimal precioVenta()
        {
            decimal costo = decimal.Parse(txtCosto.Text);
            decimal Ganancia = decimal.Parse(txtGanancia.Text);
            decimal Precio_Venta = costo + (costo * Ganancia / 100);
            return Decimal.Round(Precio_Venta, 2);
        }
        private void cmbCategoria_TextChanged(object sender, EventArgs e)
        {
            SubCategoriaFuncion();
        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            SubCategoriaFuncion();
        }

        private void btnAplicarCosto_Click(object sender, EventArgs e)
        {
            cN_Modificaciones.modArt(Convert.ToInt32(cmbCategoria.SelectedValue), Convert.ToInt32(cmbSubcategoria.SelectedValue), Convert.ToInt32(cmbProveedor.SelectedValue), decimal.Parse(txtAumentoCosto.Text));
            if (cN_Modificaciones.modConfirm)
            {
                clear();
                disableButtons();
            }
        }

        private void btnAplicarGanancia_Click(object sender, EventArgs e)
        {
            cN_Modificaciones.modArt_Ganancia(Convert.ToInt32(cmbCategoria.SelectedValue), Convert.ToInt32(cmbSubcategoria.SelectedValue), Convert.ToInt32(cmbProveedor.SelectedValue), decimal.Parse(txtAumentoGanancia.Text));
            if (cN_Modificaciones.modConfirm)
            {
                clear();
                disableButtons();
            }
        }
    }
}
