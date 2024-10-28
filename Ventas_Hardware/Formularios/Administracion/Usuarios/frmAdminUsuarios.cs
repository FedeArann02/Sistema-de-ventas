using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;
using Org.BouncyCastle.Asn1.Cmp;

namespace Ventas_Hardware.Formularios.Administracion.Usuarios
{
    public partial class frmAdminUsuarios : Form
    {
        public frmAdminUsuarios()
        {
            InitializeComponent();
        }

        private void txtDocumentacion_TextChanged(object sender, EventArgs e)
        {
            dtUsuarios.Clear();
            dtUsuarios = CN_Consultas.ConsultaUsuario(txtDocumentacion.Text);
            if (dtUsuarios.Rows.Count > 0)
            {
                txtNombre.Text = dtUsuarios.Rows[0]["Nombre"].ToString();
                txtApellido.Text = dtUsuarios.Rows[0]["Apellido"].ToString();
                txtComision.Text = dtUsuarios.Rows[0]["Comision"].ToString();
                txtContraseña.Text = dtUsuarios.Rows[0]["Contraseña"].ToString();

                if (bool.Parse(dtUsuarios.Rows[0]["Estado"].ToString()))
                {
                    cmbEstado.SelectedIndex = 1;
                }
                else
                {
                    cmbEstado.SelectedIndex = 0;
                }

                if (dtUsuarios.Rows[0]["IdRol"].ToString() == "1")
                {
                    cmbRoles.SelectedIndex = 0;
                }
                else
                {
                    cmbRoles.SelectedIndex = 1;
                }
                
                RolActual = cmbRoles.Text;
            }
            else
            {
                txtApellido.Text = string.Empty;
                txtComision.Text= string.Empty;
                txtContraseña.Text= string.Empty;
                txtNombre.Text= string.Empty;
                cmbRoles.SelectedIndex = -1;
                cmbEstado.SelectedIndex= -1;
            }
        }

        private void modificarUsuario()
        {
            if (!camposVacios() && comisionValida())
            {
                CN_Modificaciones.ModificarUsuario(txtNombre.Text, txtApellido.Text, decimal.Parse(txtComision.Text), txtContraseña.Text, cmbEstado.SelectedIndex.ToString(), (cmbRoles.SelectedIndex + 1).ToString(), txtDocumentacion.Text);

                Usuario objUsuario = new CN_Usuario().Listar().Where(u => u.DNI == txtDocumentacion.Text).FirstOrDefault();
                PantallaPrincipal.usuario_actual = objUsuario;

                if (cmbRoles.Text == "Vendedor")
                {
                    this.Close();
                }
                else
                {
                    clear();
                }

            }
            else
            {
                MessageBox.Show("Complete todos los campos del usuario y verifique que los datos sean correctos", "USUARIO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool camposVacios()
        {
            bool validar = false;
            string[] textsArray = {txtNombre.Text, txtApellido.Text, txtComision.Text, txtContraseña.Text, txtDocumentacion.Text, cmbEstado.Text, cmbRoles.Text};
            foreach (string item in textsArray)
            {
                if (String.IsNullOrEmpty(item))
                {
                    validar = true;
                }
            }

            return validar;
        }

        private bool comisionValida()
        {
            bool validar = false;

            if (decimal.TryParse(txtComision.Text, out decimal Comision))
            {
                validar = true;
            }

            return validar;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            dtUsuarios.Clear();
            dtUsuarios = CN_Consultas.ConsultaUsuario("ADMIN");

            if (PantallaPrincipal.usuario_actual.DNI == txtDocumentacion.Text && cmbEstado.Text == "INACTIVO" && dtUsuarios.Rows.Count < 2)
            {
                MessageBox.Show("No puede deshabilitar su usuario si hay un único administrador", "USUARIO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (PantallaPrincipal.usuario_actual.DNI == txtDocumentacion.Text && RolActual != cmbRoles.Text && dtUsuarios.Rows.Count < 2)
            {
                MessageBox.Show("No puede cambiar su Rol de administrador a uno mas bajo si hay un único administrador", "USUARIO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                modificarUsuario();
            }

        }

        private void clear()
        {
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtComision.Text = string.Empty;
            txtContraseña.Text = string.Empty;
            txtDocumentacion.Text = string.Empty;
            cmbEstado.Text = string.Empty;
            cmbRoles.Text = string.Empty;
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtComision_TextChanged(object sender, EventArgs e)
        {
            if (txtComision.Text == "")
            {
                txtComision.Text = "0";
            }
            else if (decimal.TryParse(txtComision.Text, out decimal comision))
            {
                if (comision > 100)
                {
                    MessageBox.Show("La comision no puede ser mayor al 100%", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ingrese un caracter válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        DataTable dtUsuarios = new DataTable();
        CN_Consultas CN_Consultas = new CN_Consultas();
        CN_Modificaciones CN_Modificaciones = new CN_Modificaciones();
        private string RolActual;

    }
}
