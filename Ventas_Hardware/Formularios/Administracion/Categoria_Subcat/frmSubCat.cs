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
        CN_Consultas cN_Consultas = new CN_Consultas();
        CN_Categoria cN_Categoria = new CN_Categoria();
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
            cmbCategorias.DataSource = cN_Categoria.Listar(cmbCategorias.Text);
            cmbCategorias.SelectedIndex = -1;
        }

        private void cmbCategorias_TextChanged(object sender, EventArgs e)
        {
            if (cmbCategorias.Text == "")
            {
                txtNuevaCategoria.Enabled = false;
                btnAgregar.Enabled = false;
                txtNuevaCategoria.Text = "SELECCIONE UNA CATEGORÍA";
            }
            else
            {
                txtNuevaCategoria.Text = "";
                txtNuevaCategoria.Enabled = true;
                btnAgregar.Enabled = true;
            }
        }
    }
}
