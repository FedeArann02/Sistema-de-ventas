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
using System.Windows.Input;

namespace Ventas_Hardware
{
    public partial class frmUsuarios : Form
    {
        CN_Altas altas = new CN_Altas();
        public frmUsuarios()
        {
            InitializeComponent();
            llenarCombo();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clear()
        {
            txtApellido.Text = string.Empty;
            txtComision.Text = string.Empty;
            txtContraseña.Text = string.Empty;
            txtDocumentacion.Text = string.Empty;
            txtNombre.Text = string.Empty;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            TextBox[] Txts = { txtDocumentacion, txtNombre, txtApellido, txtContraseña, txtComision };
            if (!validaCampos(Txts))
            {
                if (decimal.TryParse(txtComision.Text, out decimal comision) && long.TryParse(txtDocumentacion.Text, out long Doc))
                {
                    altas.AltaUsuario(txtNombre.Text, txtApellido.Text, txtDocumentacion.Text, txtContraseña.Text, cmbRoles.SelectedValue.ToString(), comision);
                    if (altas.clearConf)
                    {
                        clear();
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

        private void llenarCombo()
        {
            CN_Rol rol = new CN_Rol();
            cmbRoles.DataSource = rol.Listar();
            cmbRoles.ValueMember = "IdRol";
            cmbRoles.DisplayMember = "Descripcion";
        }

        private bool validaCampos(TextBox[] textboxes)
        {
            bool Invalid = false;
            foreach (TextBox box in textboxes) {
                if (String.IsNullOrEmpty(box.Text))
                {
                    Invalid = true;
                }
            }

            return Invalid;
        }

        private void txtDocumentacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Si no es un número o carácter de control, se cancela el evento
                e.Handled = true;
            }
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

    }
}
