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
using System.Windows.Forms.VisualStyles;
using CapaEntidad;

namespace Ventas_Hardware
{
    public partial class PantallaPrincipal : Form
    {
        private static Usuario Usuario_actual;
        private static Form frmActicvo = null;
        public PantallaPrincipal(Usuario obj_usuario)
        {
            Usuario_actual = obj_usuario;
            InitializeComponent();
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PantallaPrincipal_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = Usuario_actual.Nombre;
        }

        private void AbrirForm (Form frmHija)
        {
            if (frmActicvo != null)
            {
                frmActicvo.Close();
            }

            frmActicvo = frmHija;
            frmHija.TopLevel = false;
            frmHija.FormBorderStyle = FormBorderStyle.None;
            frmHija.Dock = DockStyle.Fill;
            panContenedor.Controls.Add(frmHija);
            frmHija.Show();
        }

        private void btnArticulos_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmArticulos());
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmCliente());
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmProveedores());
        }

        private void btnPresupuestos_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmPresupuestos());
        }

        private void btnRemitos_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmRemitos());
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmReportes());
        }

        private void btnListaCompras_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmListaCompras());
        }

        private void vendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmVendedores());
        }

        private void Cliente_alta_menu_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmClientes_alta());
        }

        private void Cliente_mod_menu_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmClientes_modificacion());
        }

        private void Proveedores_alta_menu_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmProveedores_alta());
        }

        private void Proveedores_mod_menu_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmProveedores_modificacion());
        }

        private void Categorias_alta_menu_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmCatSubcat_alta());
        }
    }
}
