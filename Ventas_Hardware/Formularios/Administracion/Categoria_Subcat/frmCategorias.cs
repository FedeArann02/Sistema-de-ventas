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
    public partial class frmCategorias : Form
    {

        public frmCategorias()
        {
            InitializeComponent();
            llenarGrilla();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            LCat = cN_Categoria.Listar("").Where(c => c.Nombre == txtNuevaCategoria.Text.ToUpper()).ToList();
            if (LCat.Count > 0 && !String.IsNullOrEmpty(txtNuevaCategoria.Text))
            {
                MessageBox.Show("El nombre de la categoría ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrEmpty(txtNuevaCategoria.Text))
            {
                MessageBox.Show("Ingrese un nombre válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                cN_Altas.CN_AltaCategoria(txtNuevaCategoria.Text.ToUpper());
                llenarGrilla();
                txtNuevaCategoria.Text = string.Empty;
            }

        }

        private void llenarGrilla()
        {
            dgvCategorias.DataSource = cN_Categoria.Listar("");
        }

        CN_Categoria cN_Categoria = new CN_Categoria();
        List<Categoria> LCat = new List<Categoria>();
        CN_Altas cN_Altas = new CN_Altas();
    }
}