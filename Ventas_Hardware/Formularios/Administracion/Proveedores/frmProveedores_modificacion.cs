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

namespace Ventas_Hardware
{
    public partial class frmProveedores_modificacion : Form
    {
        CN_Modificaciones modificaciones = new CN_Modificaciones();
        CN_Consultas consultas = new CN_Consultas();
        DataTable dt = new DataTable();
        public frmProveedores_modificacion()
        {
            InitializeComponent();
            llenarCombo();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llenarCombo()
        {
            cmbProveedor.DataSource = consultas.ConsultaProveedores();
            cmbProveedor.ValueMember = "ID_Proveedor";
            cmbProveedor.DisplayMember = "Nombre";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            modificaciones.ModificarProveedor(txtNombre.Text, txtApellido.Text, txtTelefono.Text, txtEmail.Text, cmbProveedor.SelectedValue.ToString());
        }

        private void cmbProveedor_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cargarTextBoxes(cmbProveedor.SelectedValue.ToString());
        }
        private void cargarTextBoxes(string ID_Proveedor)
        {
            dt = consultas.ConsultaProveedores(ID_Proveedor);
            txtNombre.Text = dt.Rows[0]["nombre"].ToString();
            txtApellido.Text = dt.Rows[0]["Apellido"].ToString();
            txtEmail.Text = dt.Rows[0]["correo"].ToString();
            txtTelefono.Text = dt.Rows[0]["Telefono"].ToString();
            dt.Clear();
        }
    }
}
