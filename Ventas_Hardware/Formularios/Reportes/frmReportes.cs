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
            SelectedMenuColor(btnPresupuestos);
            Funciones.AbrirForm(new R_Presupuestos(), panel_contenedor);
        }

        private void btnPresupuestos_Click(object sender, EventArgs e)
        {
            SelectedMenuColor(btnPresupuestos);
            Funciones.AbrirForm(new R_Presupuestos(), panel_contenedor);
        }

        private void btnRemitos_Click(object sender, EventArgs e)
        {
            SelectedMenuColor(btnRemitos);
            Funciones.AbrirForm(new R_Remitos(), panel_contenedor);
        }

        private void btnIngresosEgresos_Click(object sender, EventArgs e)
        {
            SelectedMenuColor(btnIngresosEgresos);
            Funciones.AbrirForm(new R_IngresosEgresos(), panel_contenedor);
        }

        private void btnBalanceGral_Click(object sender, EventArgs e)
        {
            SelectedMenuColor(btnBalanceGral);
            Funciones.AbrirForm(new R_BalanceGral(), panel_contenedor);
        }
        private void SelectedMenuColor(Button boton)
        {
            btnRemitos.BackColor = btnPresupuestos.BackColor = btnIngresosEgresos.BackColor = btnBalanceGral.BackColor = Color.FromArgb(116, 89, 160);
            boton.BackColor = Color.FromArgb(106, 79, 150);
        }
    }
}
