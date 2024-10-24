using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

//GUARDAR EN PDF
using iTextSharp.text; //
using iTextSharp.text.pdf; //
using iTextSharp.tool.xml; //
using System.IO;
using iTextSharp.testutils; //


namespace Ventas_Hardware.Formularios.Reportes
{
    public partial class R_Presupuestos : Form
    {
        public CN_Consultas cN_Consultas = new CN_Consultas();
        public DataTable dt = new DataTable();
        public CN_Modificaciones modificacion = new CN_Modificaciones();

        public R_Presupuestos()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ConsultarPresupuesto();
        }

        private void ConsultarPresupuesto()
        {
            dgvArticulos.Rows.Clear();
            dt = cN_Consultas.ConsultaPresupuesto((txtCodigoPres.Text));

            if (dt.Rows.Count > 0)
            {
                //Lllenar textboxes
                txtNombre.Text = dt.Rows[0]["nombre"].ToString();
                txtApellido.Text = dt.Rows[0]["Apellido"].ToString();
                txtDoc.Text = dt.Rows[0]["dni"].ToString();
                txtEmail.Text = dt.Rows[0]["email"].ToString();
                txtTelefono.Text = dt.Rows[0]["tel"].ToString();
                txtDireccion.Text = dt.Rows[0]["direccion"].ToString();
                txtEntidad.Text = dt.Rows[0]["entidad"].ToString();
                txtSubTotal.Text = dt.Rows[0]["subtotal"].ToString();
                txtDescuento.Text = dt.Rows[0]["descuento"].ToString();
                txtTotal.Text = dt.Rows[0]["total"].ToString();
                txtFechaHora.Text = dt.Rows[0]["Fecha y hora"].ToString();
                txtCodigoPres.Text = dt.Rows[0]["Nro_presupuesto"].ToString();

                dt = cN_Consultas.ConsultaP_Detalle((txtCodigoPres.Text));

                //Llenar grilla
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dgvArticulos.Rows.Add(dt.Rows[i]["Cod_Articulo"], dt.Rows[i]["Descripción"], dt.Rows[i]["Precio unitario"], dt.Rows[i]["Cantidad"], dt.Rows[i]["Precio por cantidad"]);
                    panelDetalle.Enabled = true;

                }
            }
            else
            {
                MessageBox.Show("El presupuesto no se encontró o no existe", "PRESUPUESTO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void clear()
        {
            //PanelEncabezado
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDoc.Text = "";
            txtEmail.Text = "";
            txtTelefono.Text = "";
            txtDireccion.Text = "";
            txtEntidad.Text = "";

            //PanelDetalle
            dgvArticulos.Rows.Clear();
            txtFechaHora.Text = "";
            txtDescuento.Text = "";
            txtSubTotal.Text = "";
            txtTotal.Text = "";
            txtCodigoPres.Text = "";

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfDialog = new SaveFileDialog(); //creamos un objeto tipo SavefileDialog
            sfDialog.FileName = "Presupuesto" + DateTime.Now.ToString("ddMMyyyyHHmmss") + ".pdf"; //le asignamos un nombre predeterminado

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
            paginaHTML_texto = paginaHTML_texto.Replace("@NROBOLETA", txtCodigoPres.Text);

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

                    MessageBox.Show("Reporte guardado con éxito", "REPORTES-PRESUPUESTO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pdfDoc.Close(); //Cerramos el documento
                    stream.Close(); //Cerramos el acceso a archivos filestream
                }
            }
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtTotal.Text))
            {
                btnImprimir.Enabled = false;
            }
            else
            {
                btnImprimir.Enabled = true;
            }
        }
    }
}
