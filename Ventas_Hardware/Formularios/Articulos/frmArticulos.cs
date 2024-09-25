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
    public partial class frmArticulos : Form
    {
        public frmArticulos()
        {
            InitializeComponent();
            SelectedMenuColor(btnConsultas_Art);
            Funciones.AbrirForm(new frmArtConsultas(), contenedor);
        }
        private void btnConsultas_Art_Click(object sender, EventArgs e)
        {
            SelectedMenuColor(btnConsultas_Art);
            Funciones.AbrirForm(new frmArtConsultas(), contenedor);
        }

        private void btnAltas_Art_Click(object sender, EventArgs e)
        {
            SelectedMenuColor(btnAltas_Art);
            Funciones.AbrirForm(new frmArtAltas(), contenedor);
        }

        private void btnModificaciones_Art_Click(object sender, EventArgs e)
        {
            SelectedMenuColor(btnModificaciones_Art);
            Funciones.AbrirForm(new frmArtModificaciones(), contenedor);
        }
        private void SelectedMenuColor(Button boton)
        {
            btnAltas_Art.BackColor = btnModificaciones_Art.BackColor = btnConsultas_Art.BackColor = Color.FromArgb(116, 89, 160);
            boton.BackColor = Color.FromArgb(106, 79, 150);
        }
    }
}
