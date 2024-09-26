using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ventas_Hardware
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        /// //DESKTOP-6M7LNLV\SQLEXPRESS >> SERVIDOR DE NETBOOK fede
        /// DESKTOP-QVQ3K29\SQLEXPRESS >> SERVIDOR PC
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PantallaPrincipal());
        }
    }
}
