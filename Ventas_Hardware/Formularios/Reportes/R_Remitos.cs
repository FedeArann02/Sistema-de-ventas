using CapaEntidad;
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

namespace Ventas_Hardware.Formularios.Reportes
{
    public partial class R_Remitos : Form
    {
        public CN_Consultas cN_Consultas = new CN_Consultas();
        public DataTable dt = new DataTable();
        public decimal SubTotal;
        public R_Remitos()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ConsultarRemito();
        }

        private void ConsultarRemito()
        {
            dgvArticulos.Rows.Clear();
            dt = cN_Consultas.ConsultaRemito((txtCodigoRemito.Text));

            if (dt.Rows.Count > 0)
            {
                //llenar textboxes
                txtNombre.Text = dt.Rows[0]["nombre"].ToString();
                txtApellido.Text = dt.Rows[0]["Apellido"].ToString();
                txtDoc.Text = dt.Rows[0]["dni"].ToString();
                txtEmail.Text = dt.Rows[0]["email"].ToString();
                txtTelefono.Text = dt.Rows[0]["tel"].ToString();
                txtDireccion.Text = dt.Rows[0]["direccion"].ToString();
                txtEntidad.Text = dt.Rows[0]["entidad"].ToString();
                txtSubTotal.Text = dt.Rows[0]["subtotal"].ToString();
                txtDescuento.Text = dt.Rows[0]["descuento"].ToString();
                txtTotal.Text = dt.Rows[0]["total"].ToString();
                txtFechaHora.Text = dt.Rows[0]["Fecha y hora"].ToString();
                SubTotal = decimal.Parse(txtSubTotal.Text);

                dt = cN_Consultas.ConsultaR_Detalle((txtCodigoRemito.Text));

                //Llenar grilla
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dgvArticulos.Rows.Add(dt.Rows[i]["Cod_Articulo"], dt.Rows[i]["Descripción"], dt.Rows[i]["Precio unitario"], dt.Rows[i]["Cantidad"], dt.Rows[i]["Precio por cantidad"]);
                    panelDetalle.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("No se encontro el remito o no existe", "REMITO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void clear()
        {
            //PanelEncabezado
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDoc.Text = "";
            txtEmail.Text = "";
            txtTelefono.Text = "";
            txtDireccion.Text = "";
            txtEntidad.Text = "";

            //PanelDetalle
            dgvArticulos.Rows.Clear();
            txtDescuento.Text = "";
            txtSubTotal.Text = "";
            txtTotal.Text = "";
            txtCodigoRemito.Text = "";
            btnBuscar.Enabled = false;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRemitosXVendedor_Click(object sender, EventArgs e)
        {

        }

        private void txtCodigoRemito_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtCodigoRemito.Text))
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
