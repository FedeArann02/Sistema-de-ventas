using CapaNegocio;
using iTextSharp.text.pdf;
using iTextSharp.text;
using iTextSharp.tool.xml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ventas_Hardware
{
    public partial class frmAltaPresupuesto : Form
    {

        public frmAltaPresupuesto()
        {
            InitializeComponent();
        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCliente.SelectedIndex == 0)
            {
                clear();

                btnBuscar.Visible = false;
                txtDocumentacionCliente.Visible = false;
                lblDNICUIL_T.Visible = false;
                {
                    panelDatosEncabezado.Enabled = true;
                    panelDetalle.Enabled = true;
                }
            }
            else if (cmbCliente.SelectedIndex == 1)
            {
                btnBuscar.Visible = true;
                txtDocumentacionCliente.Visible = true;
                lblDNICUIL_T.Visible = true;

                {
                    panelDatosEncabezado.Enabled = false;
                    panelDetalle.Enabled = false;
                }
            }
            else
            {
                btnBuscar.Visible = false;
                txtDocumentacionCliente.Visible = false;
                lblDNICUIL_T.Visible = false;

                {
                    panelDatosEncabezado.Enabled = false;
                    panelDetalle.Enabled = false;
                }
            }
            crearCodigoRemito();
        }

        private void crearCodigoRemito()
        {
            DataTable CodigoR = cN_Consultas.ConsultaUltimoCodigoPresupuesto();
            if (CodigoR.Rows.Count > 0)
            {
                string LastCode = CodigoR.Rows[0]["Nro_Presupuesto"].ToString();
                txtCodigoPresupuesto.Text = GenerarNumeroPresupuesto(LastCode);
            }
            else
            {
                txtCodigoPresupuesto.Text = GenerarNumeroPresupuesto(null);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                dt = cN_Consultas.ConsultaCliente(txtDocumentacionCliente.Text);

                txtNombre.Text = dt.Rows[0]["Nombre"].ToString();
                txtApellido.Text = dt.Rows[0]["Apellido"].ToString();
                txtDoc.Text = dt.Rows[0]["Documentacion"].ToString();
                txtEmail.Text = dt.Rows[0]["Correo"].ToString();
                txtTelefono.Text = dt.Rows[0]["Telefono"].ToString();
                txtDireccion.Text = dt.Rows[0]["Direccion"].ToString();
                txtEntidad.Text = dt.Rows[0]["Entidad"].ToString();
                txtDocumentacionCliente.Text = "";
                {
                    panelDetalle.Enabled = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error en el procedimiento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscarArt_Click(object sender, EventArgs e)
        {
            dt = cN_Consultas.ConsultaArtMod(txtCodigo.Text);
            if (dt.Rows.Count != 0)
            {
                txtDescripcion.Text = dt.Rows[0]["Descripcion"].ToString();
            }
            else
            {
                MessageBox.Show("El código que ingresó no se encuentra en la Base de datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(txtCantidad.Text) > 0 || !txtCantidad.Text.Contains("-"))
                {
                    bool ArtExiste = false;
                    dt = cN_Consultas.ConsultaArtMod(txtCodigo.Text);
                    decimal Precio = precioVenta();
                    decimal PxCant = Convert.ToDecimal(txtCantidad.Text) * Precio;
                    SubTotal += PxCant;
                    {
                        foreach (DataGridViewRow fila in dgvArticulos.Rows)
                        {
                            if (fila.Cells["C_CodArt"].Value != null && fila.Cells["C_CodArt"].Value.ToString() == txtCodigo.Text)
                            {
                                // Si el código ya existe, actualiza la cantidad sumando la nueva cantidad
                                int cantidadActual = Convert.ToInt32(fila.Cells["C_Cantidad"].Value);
                                decimal PxCantActual = decimal.Parse(fila.Cells["C_Pxcant"].Value.ToString());
                                fila.Cells["C_Cantidad"].Value = cantidadActual + int.Parse(txtCantidad.Text);
                                fila.Cells["C_Pxcant"].Value = PxCantActual + PxCant;
                                ArtExiste = true;
                                break;
                            }
                        }

                        if (!ArtExiste)
                        {
                            dgvArticulos.Rows.Add(txtCodigo.Text, txtDescripcion.Text, Precio, txtCantidad.Text, PxCant);
                        }
                        if (dgvArticulos.Rows.Count > 1)
                        {
                            txtDescripcion.Text = "";
                            txtCodigo.Text = "";
                            txtCantidad.Text = "";
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No se puede ingresar cantidades negativas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error en el procedimiento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            txtSubTotal.Text = SubTotal.ToString();
        }

        private decimal precioVenta()
        {
            dt = cN_Consultas.ConsultaArtMod(txtCodigo.Text);
            decimal costo = decimal.Parse(dt.Rows[0]["Costo"].ToString());
            decimal Ganancia = decimal.Parse(dt.Rows[0]["Ganancia"].ToString());
            decimal Precio_Venta = costo + (costo * Ganancia / 100);
            return Decimal.Round(Precio_Venta, 2);
        }

        private void reCalcular()
        {
            decimal SubTotal = 0;
            try
            {
                if (txtDescuento.Text == null || txtDescuento.Text == "")
                {
                    decimal Descuento = 0;
                    if (txtSubTotal.Text == null || txtSubTotal.Text == "")
                    {
                        SubTotal = 0;
                    }
                    else
                    {
                        SubTotal = decimal.Parse(txtSubTotal.Text);
                        txtTotal.Text = Decimal.Round((SubTotal - (SubTotal * Descuento / 100)), 2).ToString();
                    }
                }
                else if (decimal.Parse(txtDescuento.Text) > 100)
                {
                    MessageBox.Show("El descuento no puede ser mayor al 100%", "Error");
                    txtDescuento.Text = "";
                }
                else
                {
                    decimal Descuento = decimal.Parse(txtDescuento.Text);
                    SubTotal = decimal.Parse(txtSubTotal.Text);
                    txtTotal.Text = Decimal.Round((SubTotal - (SubTotal * Descuento / 100)), 2).ToString();
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Posible error en el formato ingresado, solo se admiten números enteros o decimales positivos");
                txtDescuento.Text = "";
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            CN_Altas cN_Altas = new CN_Altas();
            try
            {
                if (String.IsNullOrEmpty(txtDescuento.Text)) txtDescuento.Text = "0";

                cN_Altas.CN_PresupAlta(txtDoc.Text, txtNombre.Text, txtApellido.Text, txtTelefono.Text, txtEmail.Text,
                txtEntidad.Text, txtDireccion.Text, decimal.Parse(txtSubTotal.Text), decimal.Parse(txtDescuento.Text),
                decimal.Parse(txtTotal.Text), DateTime.Today, dgvArticulos, txtCodigoPresupuesto.Text);

                if (cmbCliente.Text == "Cliente Nuevo")
                {
                    cN_Altas.CN_AltaCliente_PresupuestoRemito(txtDoc.Text, txtNombre.Text, txtApellido.Text, txtDireccion.Text, txtTelefono.Text, txtEmail.Text,
                    txtEntidad.Text);
                }

                if (cN_Altas.clearConf)
                {
                    imprimirPresupuesto();
                    clear();
                    clearDetalle();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al generar el presupuesto, revise los campos y completelos.", "Presupuesto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void imprimirPresupuesto()
        {
            SaveFileDialog sfDialog = new SaveFileDialog(); //creamos un objeto tipo SavefileDialog
            sfDialog.FileName = "Presupuesto_" + txtCodigoPresupuesto.Text + "_" +DateTime.Now.ToString("ddMMyyyyHHmmss") + ".pdf"; //le asignamos un nombre predeterminado

            string paginaHTML_texto = Properties.Resources.plantilla.ToString();

            paginaHTML_texto = paginaHTML_texto.Replace("@NOMBRE", txtNombre.Text);
            paginaHTML_texto = paginaHTML_texto.Replace("@APELLIDO", txtApellido.Text);
            paginaHTML_texto = paginaHTML_texto.Replace("@DOCUMENTO", txtDoc.Text);
            paginaHTML_texto = paginaHTML_texto.Replace("@TELEFONO", txtTelefono.Text);
            paginaHTML_texto = paginaHTML_texto.Replace("@ENTIDAD", txtEntidad.Text);
            paginaHTML_texto = paginaHTML_texto.Replace("@CORREO", txtEmail.Text);
            paginaHTML_texto = paginaHTML_texto.Replace("@DIRECCION", txtDireccion.Text);
            paginaHTML_texto = paginaHTML_texto.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));
            paginaHTML_texto = paginaHTML_texto.Replace("@SUBTOTAL", txtSubTotal.Text);
            paginaHTML_texto = paginaHTML_texto.Replace("@DESCUENTO", txtDescuento.Text);
            paginaHTML_texto = paginaHTML_texto.Replace("@TOTAL", txtTotal.Text);
            paginaHTML_texto = paginaHTML_texto.Replace("@NROBOLETA", txtCodigoPresupuesto.Text);

            {
                string Filas = string.Empty;
                foreach (DataGridViewRow row in dgvArticulos.Rows)
                {
                    Filas += "<tr>";
                    Filas += "<td>" + row.Cells["C_CodArt"].Value.ToString() + "</td>";
                    Filas += "<td>" + row.Cells["C_Descripcion"].Value.ToString() + "</td>";
                    Filas += "<td>" + row.Cells["C_PrecioUnit"].Value.ToString() + "</td>";
                    Filas += "<td>" + row.Cells["C_Cantidad"].Value.ToString() + "</td>";
                    Filas += "<td>" + row.Cells["C_Pxcant"].Value.ToString() + "</td>";
                    Filas += "</tr>";
                }

                paginaHTML_texto = paginaHTML_texto.Replace("@FILAS", Filas);

            }

            if (sfDialog.ShowDialog() == DialogResult.OK) //si presionamos OK
            {
                using (FileStream stream = new FileStream(sfDialog.FileName, FileMode.Create)) //acceso a archivos con filestream
                {
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25); //instanciamos un documento con tamaño de hoja A4
                    PdfWriter pdfWr = PdfWriter.GetInstance(pdfDoc, stream); //instanciamos el PDFWRITER

                    pdfDoc.Open(); //Abrimos el documento

                    pdfDoc.Add(new Phrase("")); //Podrías añadir un contenido de prueba, o usar un espacio en blanco si no quieres añadir texto aquí

                    iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.SUPHARDLOGO, System.Drawing.Imaging.ImageFormat.Png);
                    img.ScaleToFit(80, 60);
                    img.Alignment = iTextSharp.text.Image.UNDERLYING;
                    img.SetAbsolutePosition(pdfDoc.LeftMargin, pdfDoc.Top - 60);
                    pdfDoc.Add(img);

                    using (StringReader sr = new StringReader(paginaHTML_texto)) //Usar StringReader en lugar de StreamReader
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(pdfWr, pdfDoc, sr); //Parseamos el contenido HTML
                    }

                    MessageBox.Show("Presupuesto guardado con éxito", "PRESUPUESTO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pdfDoc.Close(); //Cerramos el documento
                    stream.Close(); //Cerramos el acceso a archivos filestream
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            clear();
            cmbCliente.Text = "SELECCIONE UNA OPCIÓN";
        }

        private void clear()
        {
            //PanelEncabezado
            cmbCliente.SelectedIndex = -1;
            txtDocumentacionCliente.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDoc.Text = "";
            txtEmail.Text = "";
            txtTelefono.Text = "";
            txtDireccion.Text = "";
            txtEntidad.Text = "";

            //PanelDetalle
            dgvArticulos.Rows.Clear();
            txtCodigoPresupuesto.Text = "";
            txtCodigo.Text = "";
            txtCantidad.Text = "";
            txtDescripcion.Text = "";
            txtDescuento.Text = "";
            txtSubTotal.Text = "";
            txtTotal.Text = "";
            
        }

        private void clearDetalle()
        {
            txtCodigoPresupuesto.Text = "";
            txtCodigo.Text = "";
            txtCantidad.Text = "";
            txtDescripcion.Text = "";
            txtDescuento.Text = "";
            txtSubTotal.Text = "";
            txtTotal.Text = "";
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {

            if (dgvArticulos.CurrentRow != null && !dgvArticulos.CurrentRow.IsNewRow)
            {
                DataGridViewRow filaSelec = dgvArticulos.CurrentRow;
                txtCodigo.Text = filaSelec.Cells[0].Value.ToString();
                txtDescripcion.Text = filaSelec.Cells[1].Value.ToString();
                txtCantidad.Text = filaSelec.Cells[3].Value.ToString();
            }
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            if (txtDescripcion.Text != null && txtDescripcion.Text != "")
            {
                foreach (DataGridViewRow fila in dgvArticulos.Rows)
                {
                    if (fila.Cells["C_CodArt"].Value != null && fila.Cells["C_CodArt"].Value.ToString() == txtCodigo.Text)
                    {
                        decimal Precio = precioVenta();

                        int cantidadActual = Convert.ToInt32(fila.Cells["C_Cantidad"].Value);
                        if (cantidadActual == 1)
                        {
                            SubTotal -= Precio;
                            txtSubTotal.Text = SubTotal.ToString();
                            DataGridViewRow filaSelec = dgvArticulos.CurrentRow;
                            dgvArticulos.Rows.Remove(filaSelec);

                            if (dgvArticulos.Rows.Count == 0)
                            {
                                clearDetalle();
                            }
                        }
                        else
                        {
                            if (cantidadActual > 0)
                            {
                                decimal PxCant = (Convert.ToDecimal(txtCantidad.Text) - 1) * Precio;
                                decimal PxCantActual = decimal.Parse(fila.Cells["C_Pxcant"].Value.ToString());
                                fila.Cells["C_Cantidad"].Value = cantidadActual - 1;
                                fila.Cells["C_Pxcant"].Value = PxCant;
                                txtCantidad.Text = (cantidadActual - 1).ToString();
                                SubTotal -= Precio;
                                txtSubTotal.Text = SubTotal.ToString();
                                break;
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un producto de la lista","Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvArticulos.Rows.Count != 0)
            {
                DialogResult dres = MessageBox.Show("¿Desea remover este articulo de la lista?", "Remover", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dres == DialogResult.OK)
                {
                    foreach (DataGridViewRow fila in dgvArticulos.Rows)
                    {
                        DataGridViewRow filaSelec = dgvArticulos.CurrentRow;
                        decimal Precio = precioVenta();
                        if (fila.Cells["C_CodArt"].Value != null && fila.Cells["C_CodArt"].Value.ToString() == txtCodigo.Text)
                        {
                            //decimal PxCant = (Convert.ToDecimal(txtCantidad.Text)) * Precio;
                            decimal PxCantActual = decimal.Parse(fila.Cells["C_Pxcant"].Value.ToString());
                            SubTotal -= PxCantActual;
                            txtSubTotal.Text = SubTotal.ToString();
                            dgvArticulos.Rows.Remove(filaSelec);
                            break;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un producto de la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtDescuento_TextChanged(object sender, EventArgs e)
        {
            reCalcular();
        }

        private void txtSubTotal_TextChanged(object sender, EventArgs e)
        {
            reCalcular();
        }

        private void cmbCliente_DropDown(object sender, EventArgs e)
        {
            cmbCliente.Text = "";
        }

        private void cmbCliente_DropDownClosed(object sender, EventArgs e)
        {
            if (cmbCliente.SelectedIndex == -1 || cmbCliente.Text == "")
            {
                cmbCliente.Text = "SELECCIONE UNA OPCIÓN";
            }
        }

        public string GenerarNumeroPresupuesto(string ultimoNumeroPresupuesto) //Algoritmo prestado de Nico (un crack)
        {
            // Si no hay último número, comienza con AA-0000-0001
            if (string.IsNullOrEmpty(ultimoNumeroPresupuesto))
                return "AA-0000-0001";

            // Descomponer el número en partes
            string letras = ultimoNumeroPresupuesto.Substring(0, 2);
            string numeros = ultimoNumeroPresupuesto.Substring(3).Replace("-", "");

            // Incrementar el número
            int numeroActual = int.Parse(numeros);
            numeroActual++;

            // Si se alcanzó el límite de 999999999, cambiar las letras
            if (numeroActual > 999999999)
            {
                numeroActual = 1;  // Reinicia el número
                letras = IncrementarLetras(letras);  // Cambia las letras
            }

            // Retornar el nuevo número en formato AA-0000-0000
            return $"{letras}-{numeroActual.ToString("D8").Insert(4, "-")}";
        }

        public string IncrementarLetras(string letras)
        {
            char[] letrasArray = letras.ToCharArray();
            // Incrementa la segunda letra, y si llega a 'Z', incrementa la primera
            if (letrasArray[1] < 'Z')
            {
                letrasArray[1]++;
            }
            else
            {
                letrasArray[1] = 'A';
                if (letrasArray[0] < 'Z')
                    letrasArray[0]++;
                else
                    throw new Exception("Se han agotado todas las combinaciones de letras contactese con el desarrollador.");
            }
            return new string(letrasArray);
        }

        private void txtDocumentacionCliente_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtDocumentacionCliente.Text))
            {
                btnBuscar.Enabled = false;
            }
            else
            {
                btnBuscar.Enabled = true;
            }
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtTotal.Text) || decimal.TryParse(txtTotal.Text, out decimal Total))
            {
                if (decimal.Parse(txtTotal.Text) > 0)
                {
                    btnGenerar.Enabled = true;
                }
                else
                {
                    btnGenerar.Enabled = false;
                }
            }
            else
            {
                btnGenerar.Enabled = false;
            }
        }

        public CN_Consultas cN_Consultas = new CN_Consultas();
        public DataTable dt = new DataTable();
        public decimal SubTotal;


    }
}
