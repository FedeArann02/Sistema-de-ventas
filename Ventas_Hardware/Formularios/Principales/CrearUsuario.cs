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

namespace Ventas_Hardware.Formularios.Principales
{
    public partial class CrearUsuario : Form
    {
        public CrearUsuario()
        {
            InitializeComponent();
            RolesValues();
        }

        private void RolesValues()
        {
            int cantidadUsuarios = new CN_Usuario().Listar().Count;

            if (cantidadUsuarios >= 1)
            {
                cmbRoles.Text = "Vendedor";
                ValueRol = "2";
            }
            else
            {
                cmbRoles.Text = "Administrador";
                ValueRol = "1";
            }
        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            TextBox[] Txts = { txtDocumentacion, txtNombre, txtApellido, txtContraseña, txtComision };

            if (!validaCampos(Txts))
            {
                if (decimal.TryParse(txtComision.Text, out decimal comision) && long.TryParse(txtDocumentacion.Text, out long Doc))
                {
                    altas.AltaUsuario(txtNombre.Text, txtApellido.Text, txtDocumentacion.Text, txtContraseña.Text, ValueRol, comision);
                    if (altas.clearConf)
                    {
                        clear();
                        irLogin();
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese datos válidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Los campos no pueden quedar vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool validaCampos(TextBox[] textboxes)
        {
            bool Invalid = false;
            foreach (TextBox box in textboxes)
            {
                if (String.IsNullOrEmpty(box.Text))
                {
                    Invalid = true;
                }
            }

            return Invalid;
        }

        private void clear()
        {
            txtApellido.Text = string.Empty;
            txtComision.Text = string.Empty;
            txtContraseña.Text = string.Empty;
            txtDocumentacion.Text = string.Empty;
            txtNombre.Text = string.Empty;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            irLogin();
        }

        private void irLogin()
        {
            // Ocultar el formulario principal
            this.Hide();

            // Crear y mostrar el nuevo formulario
            Form otroFormulario = new Login();
            otroFormulario.FormClosed += (s, args) => this.Close(); // Cierra el formulario principal al cerrar el nuevo formulario
            otroFormulario.Show();
        }

        CN_Altas altas = new CN_Altas();
        private string ValueRol = "";

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

        private void cmbRoles_TextChanged(object sender, EventArgs e)
        {
            int cantidadUsuarios = new CN_Usuario().Listar().Count;

            if (cantidadUsuarios >= 1)
            {
                cmbRoles.Text = "Vendedor";
                ValueRol = "2";
            }
            else
            {
                cmbRoles.Text = "Administrador";
                ValueRol = "1";
            }
        }
    }
}
