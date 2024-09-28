using CapaEntidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ventas_Hardware
{
    public partial class frmArtConsultas : Form
    {
        public frmArtConsultas()
        {
            InitializeComponent();
        }

        private void frmArtConsultas_Load(object sender, EventArgs e)
        {
            cargaCombos();
        }

        private void cargaCombos()
        {
            List<Categoria> categoria = new CN_Categoria().Listar(cmbCategoria.Text);
            List<Proveedor> proveedor = new CN_Proveedores().Listar();
            List<Articulo> articulo = new CN_Articulo().Listar();

            cmbDescripcion.DisplayMember = "Descripcion";
            cmbDescripcion.ValueMember = "Cod_Articulo";
            cmbDescripcion.DataSource = articulo;
            cmbDescripcion.SelectedIndex = -1;

            cmbProveedor.DisplayMember = "Nombre";
            cmbProveedor.ValueMember = "ID_Proveedor";
            cmbProveedor.DataSource = proveedor;
            cmbProveedor.SelectedIndex = -1;

            cmbCategoria.DisplayMember = "Nombre";
            cmbCategoria.ValueMember = "Cod_categoria";
            cmbCategoria.DataSource = categoria;
            cmbCategoria.SelectedIndex = -1;
        }
        private void verGrillaFiltrada(DataGridView DGV, string codigo = "", string descripcion = "", string categoria = "", string subcat = "", string proveedor = "") //funcion que filtra con la grilla
        {
            try
            {
                DataTable pepe = new CN_Consultas().DataTable();
                DataView dv = new DataView(pepe);
                dv.RowFilter = "Codigo LIKE '%" + codigo + "%' AND Descripcion LIKE '%" + descripcion + "%' AND Categoria LIKE '%" + categoria + "%' AND Subcategoria LIKE '%" + subcat + "%' AND Proveedor LIKE '%" + proveedor + "%'";
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
            }catch (Exception ex)
            {
                MessageBox.Show("Error en el procedimiento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!filtrosVacios())
            {
                verGrillaFiltrada(dgvArticulos, txtCodigo.Text, cmbDescripcion.Text.Trim(), cmbCategoria.Text, cmbSubcategoria.Text, cmbProveedor.Text);
            }
            else
            {
                MessageBox.Show("Debe colocar al menos un criterio de búsqueda.", "mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private bool filtrosVacios ()
        {
            if (txtCodigo.Text == "" && cmbCategoria.Text == "" && cmbSubcategoria.Text == "" && cmbDescripcion.Text == "" && cmbProveedor.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            clear();
        }
        private void clear()
        {
            txtCodigo.Text = "";
            cmbCategoria.Text = "";
            cmbDescripcion.Text = "";
            cmbProveedor.Text = "";
            cmbSubcategoria.Text = "";
            dgvArticulos.Columns.Clear();
            panelDetalle.Visible = false;
            cargaCombos();
            dgvArticulos.Visible = false;
        }
        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
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
                clear();
            }
        }
        private decimal precioVenta()
        {
            decimal costo = decimal.Parse(txtCostoDetalle.Text);
            decimal Ganancia = decimal.Parse(txtGananciaDetalle.Text);
            decimal Precio_Venta = costo + (costo*Ganancia/100);
            return Decimal.Round(Precio_Venta, 2); //Decimal.Round = redondea los decimales a dos valores
        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            SubCategoriaFuncion();
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

        private void cmbCategoria_TextChanged(object sender, EventArgs e)
        {
            SubCategoriaFuncion();
        }

        private void txtStockDetalle_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(txtStockDetalle.Text) <= 5)
            {
                txtStockDetalle.ForeColor = Color.Crimson;
            }
            else if (int.Parse(txtStockDetalle.Text) <= 10)
            {
                txtStockDetalle.ForeColor = Color.Yellow;
            }
            else
            {
                txtStockDetalle.ForeColor= Color.White;
            }
        }
    }
}
