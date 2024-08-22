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
            Funciones.AbrirForm(new frmAltaPresupuesto(), panel_contenedor);
        }

        private void altaPresupuestoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Funciones.AbrirForm(new frmAltaPresupuesto(), panel_contenedor);
        }

        private void buscarPresupuestoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Funciones.AbrirForm(new frmBuscarPresupuesto(), panel_contenedor);
        }
    }
}
