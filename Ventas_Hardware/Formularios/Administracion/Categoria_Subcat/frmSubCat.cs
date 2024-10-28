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

namespace Ventas_Hardware.Formularios.Administracion.Categoria_Subcat
{
    public partial class frmSubCat : Form
    {
        public frmSubCat()
        {
            InitializeComponent();
            llenarGrilla();
            llenarCombo();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llenarGrilla()
        {
            dgvCategorias.DataSource = cN_Consultas.ConsultaSubcategorias();
        }

        private void llenarCombo()
        {
            cmbCategorias.DisplayMember = "Nombre";
            cmbCategorias.ValueMember = "Cod_categoria";
            cmbCategorias.DataSource = cN_Categoria.Listar();
            cmbCategorias.SelectedIndex = -1;
        }

        private void cmbCategorias_TextChanged(object sender, EventArgs e)
        {
            if (cmbCategorias.Text == "")
            {
                txtNuevaSubCategoria.Enabled = false;
                btnAgregar.Enabled = false;
                txtNuevaSubCategoria.Text = "SELECCIONE UNA CATEGORÍA";
            }
            else
            {
                txtNuevaSubCategoria.Text = "";
                txtNuevaSubCategoria.Enabled = true;
                btnAgregar.Enabled = true;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            LSubCat = cN_Subcategoria.Listar().Where(s => s.Nombre == txtNuevaSubCategoria.Text.ToUpper()).ToList();
            if (LSubCat.Count > 0 && String.IsNullOrEmpty(txtNuevaSubCategoria.Text))
            {
                MessageBox.Show("El nombre de la Subcategoría ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrEmpty(txtNuevaSubCategoria.Text) || String.IsNullOrEmpty(cmbCategorias.Text))
            {
                MessageBox.Show("ingrese un nombre y una Categoría válida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                cN_Altas.CN_AltaSubCategoria(txtNuevaSubCategoria.Text.ToUpper(), cmbCategorias.SelectedValue.ToString());
                
                llenarGrilla();
                llenarCombo();

            }
        }

        CN_Consultas cN_Consultas = new CN_Consultas();
        CN_Altas cN_Altas = new CN_Altas();
        CN_Subcategoria cN_Subcategoria = new CN_Subcategoria();
        CN_Categoria cN_Categoria = new CN_Categoria();
        List<Subcategoria> LSubCat = new List<Subcategoria>();
    }
}
