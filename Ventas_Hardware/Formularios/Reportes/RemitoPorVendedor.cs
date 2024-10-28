using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ventas_Hardware.Formularios.Reportes
{
    public partial class RemitoPorVendedor : Form
    {
        public RemitoPorVendedor()
        {
            InitializeComponent();
            initRemXvendedor();
        }

        private void initRemXvendedor()
        {
            llenarCombo();
        }

        private void llenarCombo()
        {
            DataTable UsuariosCombo = Consultas.ConsultaUsuario("TODOS");
            UsuariosCombo.Columns.Add("NombreApellido", typeof(string), "Nombre + ' ' + Apellido");

            cmbUsuarios.DataSource = UsuariosCombo;
            cmbUsuarios.ValueMember = "DNI";
            cmbUsuarios.DisplayMember = "NombreApellido";
            cmbUsuarios.SelectedIndex = -1;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbxFiltroFecha_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxFiltroFecha.Checked)
            {
                dateTimePickerDesde.Enabled = true;
                dateTimePickerHasta.Enabled = true;
                BuscarRemitoFecha();
            }
            else
            {
                dateTimePickerDesde.Enabled = false;
                dateTimePickerHasta.Enabled = false;
                BuscarRemito();
            }
        }

        private void BuscarRemito()
        {

            if (String.IsNullOrEmpty(cmbUsuarios.Text))
            {
                //NADA
            }
            else
            {
                dtRemitosVend = Consultas.ConsultaRemitoPorVendedor(cmbUsuarios.SelectedValue.ToString());
                if (dtRemitosVend.Rows.Count >= 1)
                {
                    dgvRemXvendedor.DataSource = dtRemitosVend;
                }
            }
        }

        private void BuscarRemitoFecha()
        {
            if (String.IsNullOrEmpty(cmbUsuarios.Text))
            {
                MessageBox.Show("Complete los campos correspondientes", "SELECCIONE EL VENDEDOR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                dtRemitosVend = Consultas.ConsultaRemitoPorVendedorFiltrado(cmbUsuarios.SelectedValue.ToString(), dateTimePickerDesde.Value, dateTimePickerHasta.Value);
                dgvRemXvendedor.DataSource = dtRemitosVend;
            }
        }

        private void dateTimePickerDesde_ValueChanged(object sender, EventArgs e)
        {
            BuscarRemitoFecha();
        }

        private void dateTimePickerHasta_ValueChanged(object sender, EventArgs e)
        {
            BuscarRemitoFecha();
        }

        private void cmbUsuarios_SelectionChangeCommitted(object sender, EventArgs e)
        {
            BuscarRemito();
        }


        DataTable dtRemitosVend = new DataTable();
        CN_Consultas Consultas = new CN_Consultas();

    }
}
