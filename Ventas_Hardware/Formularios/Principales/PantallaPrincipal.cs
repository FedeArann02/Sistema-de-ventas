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
using CapaNegocio;
using Ventas_Hardware.Formularios.Administracion.Categoria_Subcat;

namespace Ventas_Hardware
{
    public partial class PantallaPrincipal : Form
    {
        private static Usuario usuario_actual;

        private static Form frmActicvo = null;

        public PantallaPrincipal(Usuario obj_usuario = null) //Acpeta nulos por el momento para pruebas
        {
            if (obj_usuario == null)
            {
                usuario_actual = new Usuario() { Nombre = "ADMIN PROGRAMADOR", ID_Usuario = 0 };
            }
            else
            {
                usuario_actual = obj_usuario;
            }
            InitializeComponent();
        }

        public static Usuario UsuarioActual() //Método de acceso "GETTER" para saber el usuario actual
        { 
            return usuario_actual;
        }

        private void PantallaPrincipal_Load(object sender, EventArgs e)
        {
            List<Permiso> ListaPermisos = new CN_Permiso().Listar(usuario_actual.ID_Usuario);

            if (!ListaPermisos.Any(m => m.NombreMenu == "administrar"))
            {
                //btnProveedores.Visible = false;
                //btnListaCompras.Visible = false;
                //administrar.Visible = false;
            }

            lblUsuario.Text = usuario_actual.Nombre;
            AbrirForm(new frmInicio());
        }

        private void AbrirForm (Form frmHija)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el formulario \n\n" + ex.Message + "", "Comuniquese con el desarrollador", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AbrirFormDialog(Form frmHija)
        {
            try
            {
                frmHija.FormBorderStyle = FormBorderStyle.None;
                frmHija.StartPosition = FormStartPosition.CenterScreen;
                frmHija.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el formulario \n\n" + ex.Message + "", "Comuniquese con el desarrollador", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnArticulos_Click(object sender, EventArgs e)
        {
            SelectedMenuColor(btnArticulos);
            AbrirForm(new frmArticulos());
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            SelectedMenuColor(btnClientes);
            AbrirForm(new frmCliente());
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            SelectedMenuColor(btnProveedores);
            AbrirForm(new frmProveedores());
        }

        private void btnPresupuestos_Click(object sender, EventArgs e)
        {
            SelectedMenuColor(btnPresupuestos);
            AbrirForm(new frmPresupuestos());
        }

        private void btnRemitos_Click(object sender, EventArgs e)
        {
            SelectedMenuColor(btnRemitos);
            AbrirForm(new frmRemitos());
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            SelectedMenuColor(btnReportes);
            AbrirForm(new frmReportes());
        }

        private void btnListaCompras_Click(object sender, EventArgs e)
        {
            SelectedMenuColor(btnListaCompras);
            AbrirForm(new frmListaCompras());
        }

        private void vendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormDialog(new frmUsuarios());
        }

        private void Cliente_alta_menu_Click(object sender, EventArgs e)
        {
            AbrirFormDialog(new frmClientes_alta());
        }

        private void Cliente_mod_menu_Click(object sender, EventArgs e)
        {
            AbrirFormDialog(new frmClientes_modificacion());
        }

        private void Proveedores_alta_menu_Click(object sender, EventArgs e)
        {
            AbrirFormDialog(new frmProveedores_alta());
        }

        private void Proveedores_mod_menu_Click(object sender, EventArgs e)
        {
            AbrirFormDialog(new frmProveedores_modificacion());
        }

        private void Categorias_alta_menu_Click(object sender, EventArgs e)
        {
            AbrirFormDialog(new frmCategorias());
        }

        private void subcategoríasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormDialog(new frmSubCat());
        }
        private void lblInicio_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmInicio());
            btnArticulos.BackColor = btnClientes.BackColor = btnPresupuestos.BackColor = btnRemitos.BackColor =
                btnReportes.BackColor = btnProveedores.BackColor = btnListaCompras.BackColor = Color.FromArgb(126, 89, 170);
        }
        private void SelectedMenuColor(Button boton)
        {
            btnArticulos.BackColor = btnClientes.BackColor = btnPresupuestos.BackColor = btnRemitos.BackColor =
                btnReportes.BackColor = btnProveedores.BackColor = btnListaCompras.BackColor = Color.FromArgb(126, 89, 170);
            boton.BackColor = Color.FromArgb(106, 79, 150);
        }

        private void pbxCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void pbxMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void pbxMaximizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void pbxPestaña_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }
    }
}
