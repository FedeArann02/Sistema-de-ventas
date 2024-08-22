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
            Funciones.AbrirForm(new frmArtConsultas(), contenedor);
        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Funciones.AbrirForm(new frmArtConsultas(), contenedor);
        }

        private void altasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Funciones.AbrirForm(new frmArtAltas(), contenedor);

        }

        private void modificacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Funciones.AbrirForm(new frmArtModificaciones(), contenedor);

        }
    }
}
