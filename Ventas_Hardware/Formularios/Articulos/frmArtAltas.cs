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
using Ventas_Hardware.MisMetodos;

namespace Ventas_Hardware
{
    public partial class frmArtAltas : Form
    {
        Validations validations = new Validations();
        public frmArtAltas()
        {
            InitializeComponent();
            cargaCombos();
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

        private void cmbCategoria_TextChanged(object sender, EventArgs e)
        {
            SubCategoriaFuncion();
        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            SubCategoriaFuncion();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            TextBox[] txts = {txtCodigo, txtCosto, txtDescripcion, txtGanancia, txtStock};
            ComboBox[] cmbs = {cmbCategoria, cmbProveedor, cmbSubcategoria};

            if (!Validations.TextboxNullOrEmpty(txts) && !Validations.ComboBoxNullOrEmpty(cmbs))
            {
                CN_Altas cN_Altas = new CN_Altas();

                if (int.TryParse(txtStock.Text, out int stock) || decimal.TryParse(txtCosto.Text, out decimal costo) || decimal.TryParse(txtGanancia.Text, out decimal ganancia))
                {
                    stock = int.Parse(txtStock.Text);
                    costo = decimal.Parse(txtCosto.Text);
                    ganancia = decimal.Parse(txtGanancia.Text);

                    if (validations.Cod_articulo(txtCodigo.Text))
                    {
                        cN_Altas.CN_ArtAlta(txtCodigo.Text.ToUpper(), Convert.ToInt32(cmbCategoria.SelectedValue), Convert.ToInt32(cmbSubcategoria.SelectedValue), txtDescripcion.Text, Convert.ToInt32(cmbProveedor.SelectedValue), stock, costo, ganancia);
                        if (cN_Altas.clearConf)
                        {
                            clear();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Error en los campos numéricos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Los campos no pueden quedar vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void clear()
        {
            txtCodigo.Text = "";
            txtCosto.Text = "";
            txtDescripcion.Text = "";
            txtGanancia.Text = "";
            txtStock.Text = "";
            cmbCategoria.SelectedIndex = -1;
            cmbSubcategoria.SelectedIndex = -1;
            cmbProveedor.SelectedIndex = -1;
        }

    }
}
