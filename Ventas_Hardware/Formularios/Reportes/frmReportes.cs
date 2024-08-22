using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ventas_Hardware.Formularios.Reportes;

namespace Ventas_Hardware
{
    public partial class frmReportes : Form
    {
        public frmReportes()
        {
            InitializeComponent();
            Funciones.AbrirForm(new R_Presupuestos(), panel_contenedor);
        }

        private void presupuestosTSM_Click(object sender, EventArgs e)
        {
            Funciones.AbrirForm(new R_Presupuestos(), panel_contenedor);
        }

        private void RemitosTSM_Click(object sender, EventArgs e)
        {
            Funciones.AbrirForm(new R_Remitos(), panel_contenedor);

        }

        private void IngEgrVariosTSM_Click(object sender, EventArgs e)
        {
            Funciones.AbrirForm(new R_IngresosEgresos(), panel_contenedor);

        }

        private void balanceGeneralTSM_Click(object sender, EventArgs e)
        {
            Funciones.AbrirForm(new R_BalanceGral(), panel_contenedor);

        }
    }
}
