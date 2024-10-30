using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ventas_Hardware.MisMetodos
{
    public class Validations
    {
        public bool Alta_Articulos()
        {
            return true;
        }

        public bool Categoria (string Categoria, bool esAlta) //si la validacion se usa para una alta de una categoria es Alta debe ser true
        {
            if (esAlta == true)
            {
                List<Categoria> articulo = new CN_Categoria().Listar(Categoria);
                if (articulo.Count != 0)
                {
                    MessageBox.Show("Esta categoría ya existe");
                    return false;
                }
                else
                {
                    return true;
                }
            }
            if (Categoria == null || Categoria == "")
            {
                MessageBox.Show("La categoría no puede ser nula o vacía", "Campo obligatorio");
                return false;
            }
            else if (Categoria.Length <5 || Categoria.Length >50)
            {
                MessageBox.Show("La categoría debe tener entre 5 y 50 caracteres");
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool Cod_articulo (string Codigo)
        {
            string patron = @"^[A-Za-z]{1,5}\d{4,15}$";
            List<Articulo> articulo = new CN_Articulo().Listar().Where(a => a.Cod_articulo == Codigo).ToList();

            if (Codigo == null || Codigo == "")
            {
                MessageBox.Show("El código no puede ser nulo o vacío", "Campo obligatorio");
                return false;
            }
            else if (Codigo.Length <4 || Codigo.Length >20)
            {
                MessageBox.Show("La longitud del código debe ser de 4 o más caracteres");
                return false;
            }
            else if (!Regex.IsMatch(Codigo, patron))
            {
                MessageBox.Show("Formato incorrecto, solo se permiten entre 1 a 5 letras seguido de 4 a 15 núumeros\n\tPor ejemplo: ABCDE12345...15");
                return false;
            }
            else if (articulo.Count != 0)
            {
                MessageBox.Show("Este código ya existe, ingrese uno distinto");
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool TextboxNullOrEmpty(TextBox[] textboxes)
        {
            bool Invalid = false;
            foreach (TextBox box in textboxes)
            {
                if (String.IsNullOrEmpty(box.Text))
                {
                    Invalid = true;
                }
            }

            return Invalid;
        }

        public static bool ComboBoxNullOrEmpty(ComboBox[] combos)
        {
            bool Invalid = false;
            foreach (ComboBox box in combos)
            {
                if (String.IsNullOrEmpty(box.Text))
                {
                    Invalid = true;
                }
            }

            return Invalid;
        }

        public bool EsCorreoValido(string correo)
        {
            if (string.IsNullOrEmpty(correo))
                return false;

            string patron = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(correo, patron);
        }

    }
}
