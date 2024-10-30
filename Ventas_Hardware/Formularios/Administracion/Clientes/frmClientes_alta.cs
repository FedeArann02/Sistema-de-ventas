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
    public partial class frmClientes_alta : Form
    {
        CN_Altas cN_AltaCLiente = new CN_Altas();
        public frmClientes_alta()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            TextBox[] txts = {txtTelefono, txtNombre, txtApellido, txtDireccion, txtDoc, txtEntidad};
            if (!Validations.TextboxNullOrEmpty(txts))
            {
                if (long.TryParse(txtTelefono.Text, out long tel) && long.TryParse(txtDoc.Text, out long Doc))
                {
                    cN_AltaCLiente.CN_AltaCliente(txtDoc.Text, txtNombre.Text, txtApellido.Text, txtDireccion.Text, txtTelefono.Text, txtEmail.Text, txtEntidad.Text);
                    if (cN_AltaCLiente.clearConf)
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

        private void clear()
        {
            txtApellido.Text = "";
            txtDireccion.Text = "";
            txtDoc.Text = "";
            txtEmail.Text = "";
            txtEntidad.Text = "";
            txtNombre.Text = "";
            txtTelefono.Text = "";
        }

    }
}
