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
    public partial class frmClientes_modificacion : Form
    {
        CN_Consultas consultas = new CN_Consultas();
        CN_Modificaciones modificaciones = new CN_Modificaciones();
        DataTable dt = new DataTable();

        public frmClientes_modificacion()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            modificaciones.ModificarCliente(txtNombre.Text, txtApellido.Text, txtTelefono.Text, txtEmail.Text, txtDireccion.Text, txtEntidad.Text, txtDoc.Text);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dt = consultas.ConsultaCliente(txtDocumentacionCliente.Text);
            if (dt.Rows.Count > 0)
            {
                txtNombre.Text = dt.Rows[0]["Nombre"].ToString();
                txtApellido.Text = dt.Rows[0]["Apellido"].ToString();
                txtDoc.Text = dt.Rows[0]["Documentacion"].ToString();
                txtEmail.Text = dt.Rows[0]["Correo"].ToString();
                txtTelefono.Text = dt.Rows[0]["Telefono"].ToString();
                txtDireccion.Text = dt.Rows[0]["Direccion"].ToString();
                txtEntidad.Text = dt.Rows[0]["Entidad"].ToString();
                txtDocumentacionCliente.Text = "";
            }
            else
            {
                MessageBox.Show("No se encotró el cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtDocumentacionCliente_TextChanged(object sender, EventArgs e)
        {
            if (txtDocumentacionCliente.Text == "")
            {
                btnBuscar.Enabled = false;
            }
            else
            {
                btnBuscar.Enabled = true;
            }
        }
    }
}
