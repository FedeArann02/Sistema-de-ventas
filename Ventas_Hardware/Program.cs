using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using Ventas_Hardware.Formularios.Principales;

namespace Ventas_Hardware
{
    internal static class Program
    {
        //TODO:
        //TERMINADO BY FEDE

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            int cantidadUsuarios = new CN_Usuario().Listar().Count;

            if (cantidadUsuarios >= 1)
            {
                Application.Run(new Login());
            }
            else
            {
                Application.Run(new CrearUsuario());
            }
            
        }
    }
}
