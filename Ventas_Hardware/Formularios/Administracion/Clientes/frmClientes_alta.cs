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
            cN_AltaCLiente.CN_AltaCliente(txtDoc.Text, txtNombre.Text, txtApellido.Text, txtDireccion.Text, txtTelefono.Text, txtEmail.Text, txtEntidad.Text);
            if (cN_AltaCLiente.clearConf)
            {
                clear();
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
