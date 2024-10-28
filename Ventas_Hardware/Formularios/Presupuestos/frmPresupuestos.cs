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
    public partial class frmPresupuestos : Form
    {
        public frmPresupuestos()
        {
            InitializeComponent();
            SelectedMenuColor(btnAltaPresupuesto);
            Funciones.AbrirForm(new frmAltaPresupuesto(), panel_contenedor);
        }

        private void btnAltaPresupuesto_Click(object sender, EventArgs e)
        {
            SelectedMenuColor(btnAltaPresupuesto);
            Funciones.AbrirForm(new frmAltaPresupuesto(), panel_contenedor);
        }

        private void btnBuscarPresupuesto_Click(object sender, EventArgs e)
        {
            SelectedMenuColor(btnBuscarPresupuesto);
            Funciones.AbrirForm(new frmBuscarPresupuesto(), panel_contenedor);
        }

        private void SelectedMenuColor(Button boton)
        {
            btnAltaPresupuesto.BackColor = btnBuscarPresupuesto.BackColor = Color.FromArgb(116, 89, 160);
            boton.BackColor = Color.FromArgb(106, 79, 150);
        }


    }
}
