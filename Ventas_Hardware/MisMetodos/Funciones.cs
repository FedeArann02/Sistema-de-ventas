using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ventas_Hardware
{
    public class Funciones
    {
        private static Form frmActivo;
        public static void AbrirForm(Form frmHija, Panel contenedor)
        {
            try
            {
                if (frmActivo != null)
                {
                    frmActivo.Close();
                }

                frmActivo = frmHija;
                frmHija.TopLevel = false;
                frmHija.FormBorderStyle = FormBorderStyle.None;
                frmHija.Dock = DockStyle.Fill;
                contenedor.Controls.Add(frmHija);
                frmHija.Show();
            }
            catch (Exception ex){
                MessageBox.Show("Error al cargar el formulario \n\n"+ ex.Message +"", "Comuniquese con el desarrollador", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
