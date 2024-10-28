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
using Ventas_Hardware.MisMetodos;

namespace Ventas_Hardware
{
    public partial class frmProveedores_alta : Form
    {
        CN_Altas altas = new CN_Altas();
        public frmProveedores_alta()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            TextBox[] textboxes = {txtNombre, txtApellido, txtEmail, txtTelefono};
            if (!Validations.TextboxNullOrEmpty(textboxes))
            {
                altas.CN_AltaProveedor(txtNombre.Text, txtApellido.Text, txtEmail.Text, txtTelefono.Text);
                txtNombre.Text = string.Empty;
                txtApellido.Text = string.Empty;
                txtEmail.Text = string.Empty;
                txtTelefono.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Los campos no pueden quedar vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
