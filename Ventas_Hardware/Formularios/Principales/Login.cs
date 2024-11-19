using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;
using Ventas_Hardware.Formularios.Principales;
using Ventas_Hardware.MisFunciones;

namespace Ventas_Hardware
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            panel1.BackColor = cols.loginSignUpBackColorLogo;
            pictureBox1.BackColor = cols.loginSignUpBackColorLogo;
            pictureBox2.BackColor = cols.loginSignUpBackColorLogo;
            this.BackColor = cols.loginSignUpBackColor;
        }

        Colores cols = new Colores();

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            Usuario objUsuario = new CN_Usuario().Listar().Where(u => u.DNI == txtDocumento.Text && //Expresión LAMBDA que nos devuelve un usuario
            u.Contraseña == txtContraseña.Text).FirstOrDefault(); //"DONDE" el DNI y la contraseña sean iguales a las ingresadas.

            if (objUsuario != null) //Si se "encontró" (no es nulo) el usuario entones va a dar permiso para acceder.
            {
                PantallaPrincipal frm = new PantallaPrincipal(objUsuario);
                frm.Show();
                this.Hide();
                frm.FormClosing += frm_closing;
            }
            else
            {
                MessageBox.Show("No se encontró el usuario, verifique que los datos ingresados sean correctos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            this.Show();
            txtContraseña.Text = "";
            txtDocumento.Text = "";
        }

        private void pbxNoVer_Click(object sender, EventArgs e)
        {
            pbxVer.Visible = true;
            pbxNoVer.Visible = false;
            txtContraseña.UseSystemPasswordChar = false;
        }

        private void pbxVer_Click(object sender, EventArgs e)
        {
            pbxVer.Visible = false;
            pbxNoVer.Visible = true;
            txtContraseña.UseSystemPasswordChar = true;
        }

        private void lblCrearCuenta_Click(object sender, EventArgs e)
        {
            // Ocultar el formulario principal
            this.Hide();

            // Crear y mostrar el nuevo formulario
            Form otroFormulario = new CrearUsuario();
            otroFormulario.FormClosed += (s, args) => this.Close(); // Cierra el formulario principal al cerrar el nuevo formulario
            otroFormulario.Show();
        }

    }
}
