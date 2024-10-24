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

namespace Ventas_Hardware
{
    public partial class frmRemitos : Form
    {
        Usuario user_actual = PantallaPrincipal.ObtenerUsuarioActual();
        public CN_Consultas cN_Consultas = new CN_Consultas();
        public DataTable dt = new DataTable();
        public decimal SubTotal;
        public frmRemitos()
        {
            InitializeComponent();
        }

        private void cmbOpciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOpciones.SelectedIndex == 0)//Cliente nuevo
            {
                clear();

                txtDocumentacionCliente.Enabled = false;
                lblDNICUIL_T.Enabled = false;

                txtCodigoPres.Enabled = false;
                lblCodigoPres.Enabled = false;

                btnBuscar.Enabled = false;
                {
                    panelDatosEncabezado.Enabled = true;
                    panelDetalle.Enabled = true;
                }
            }
            else if (cmbOpciones.SelectedIndex == 1)//Cliente regular
            {
                txtDocumentacionCliente.Enabled = true;
                lblDNICUIL_T.Enabled = true;

                txtCodigoPres.Enabled = false;
                lblCodigoPres.Enabled = false;

                btnBuscar.Enabled = true;
                {
                    panelDatosEncabezado.Enabled = false;
                    panelDetalle.Enabled = false;
                }
            }
            else if (cmbOpciones.SelectedIndex == 2)
            {
                txtDocumentacionCliente.Enabled = false;
                lblDNICUIL_T.Enabled= false;

                txtCodigoPres.Enabled = true;
                lblCodigoPres.Enabled = true;

                btnBuscar.Enabled = true;
                {
                    panelDatosEncabezado.Enabled = false;
                    panelDetalle.Enabled = false;
                }
            }
            else
            {
                {
                    panelDatosEncabezado.Enabled = false;
                    panelDetalle.Enabled = false;
                }
            }

            crearCodigoRemito();

        }//Control de opciones de carga de datos

        private void crearCodigoRemito()
        {
            DataTable CodigoR = cN_Consultas.ConsultaUltimoCodigoRemito();
            string LastCode = CodigoR.Rows[0]["Nro_remito"].ToString();
            txtCodigoRemito.Text = GenerarNumeroFactura(LastCode);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbOpciones.SelectedIndex == 1)
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
                else if (cmbOpciones.SelectedIndex == 2)
                {
                    ConsultarPresupuesto();
                }
                else
                {
                    MessageBox.Show("Seleccione una opción válida", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en el procedimiento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConsultarPresupuesto()
        {
            dgvArticulos.Rows.Clear();
            dt = cN_Consultas.ConsultaPresupuesto((txtCodigoPres.Text));

            if (dt.Rows.Count > 0)
            {
                string ArticulosSinStock = ""; //variable para almacenar el mensaje de error
                try
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
                    SubTotal = decimal.Parse(txtSubTotal.Text);

                    dt = cN_Consultas.ConsultaP_Detalle((txtCodigoPres.Text));

                    //Llenar grilla
                    
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {

                        int cantidadGrilla = int.Parse(dt.Rows[i]["Cantidad"].ToString()); //almacena la cantidad demandada de un articulo de la posicion 'i' de la grilla Presupuesto
                        DataTable dtArt = new DataTable();
                        dtArt = cN_Consultas.ConsultaArtMod(dt.Rows[i]["Cod_Articulo"].ToString()); //almacena el articulo obtenido de SQL a traves del codigo del articulo del Presupuesto
                        int cantidadBD = int.Parse(dtArt.Rows[i]["Cantidad"].ToString()); //almacena la cantidad Real de ese articulo

                        if (cantidadGrilla <= cantidadBD) //si la cantidad demandada es menor o IGUAL al stock entonces le permite usar el presupuesto como remito
                        {
                            dgvArticulos.Rows.Add(dt.Rows[i]["Cod_Articulo"], dt.Rows[i]["Descripción"], dt.Rows[i]["Precio unitario"], dt.Rows[i]["Cantidad"], dt.Rows[i]["Precio por cantidad"]);
                            panelDetalle.Enabled = true;
                            txtCodigoPres.Enabled = false;
                            btnBuscar.Enabled = false;
                        }
                        else
                        {
                            ArticulosSinStock += "● " + dtArt.Rows[i]["Descripcion"].ToString() + "\n"; //guarda el articulo en un mensaje de error
                        }
                    }
                    if (ArticulosSinStock.Length > 0)
                    {
                        throw new Exception(); //si hay algun articulo faltante de stock suficiente entonces arroja una excepcion y la toma en el Catch
                    }
                }
                catch(Exception)
                {
                    MessageBox.Show("No se pudo usar el Presupuesto (" + txtCodigoPres.Text + ") por que los siguientes artículos superan la cantidad del Stock: \n" + ArticulosSinStock, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dgvArticulos.Rows.Clear();
                    panelDetalle.Enabled = false;
                    txtCodigoPres.Enabled = true;
                    btnBuscar.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("El presupuesto no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

            private void btnBuscarArt_Click(object sender, EventArgs e)
        {
            BuscarArticulo();
        }

        private void BuscarArticulo()
        {
            dt = cN_Consultas.ConsultaArtMod(txtCodigo.Text);
            if (dt.Rows.Count != 0)
            {
                txtDescripcion.Text = dt.Rows[0]["Descripcion"].ToString();
                txtStock.Text = dt.Rows[0]["Cantidad"].ToString();
            }
            else
            {
                MessageBox.Show("El código que ingresó no se encuentra en la Base de datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                bool ArtExiste = false;
                bool excep = false;
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

                            if ((cantidadActual + int.Parse(txtCantidad.Text)) > int.Parse(txtStock.Text)) //si la cantidad total del Articulo a vender supera la cantidad en stock
                            {
                                MessageBox.Show("Cantidad en stock de " + txtDescripcion.Text + " insuficiente", "Stock", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                ArtExiste = true;
                                excep = true;
                                SubTotal -= PxCant;
                                break;
                            }

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
                    if (dgvArticulos.Rows.Count > 1 && excep == false)
                    {
                        txtDescripcion.Text = "";
                        txtCodigo.Text = "";
                        dgvArticulos.CurrentRow.Selected = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en el procedimiento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                crearCodigoRemito();
            }

            txtCantidad.Text = "";
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
            try
            {
                if (txtDescuento.Text == null || txtDescuento.Text == "")
                {
                    decimal Descuento = 0;
                    if (txtSubTotal.Text == null || txtSubTotal.Text == "")
                    {
                        decimal SubTotal = 0;
                    }
                    else
                    {
                        decimal SubTotal = decimal.Parse(txtSubTotal.Text);
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
                    decimal SubTotal = decimal.Parse(txtSubTotal.Text);
                    txtTotal.Text = Decimal.Round((SubTotal - (SubTotal * Descuento / 100)), 2).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Posible error en el formato ingresado, solo se admiten números enteros o decimales positivos");
                txtDescuento.Text = "";
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            CN_Altas cN_Altas = new CN_Altas();
            CN_Modificaciones cN_Modificaciones = new CN_Modificaciones();

            try
            {
                int Id_usuario = user_actual.ID_Usuario;

                if (String.IsNullOrEmpty(txtDescuento.Text))
                {
                    txtDescuento.Text = "0";
                }

                cN_Altas.CN_AltaRemito(txtDoc.Text, txtNombre.Text, txtApellido.Text, txtTelefono.Text, txtEmail.Text,
                txtEntidad.Text, txtDireccion.Text, decimal.Parse(txtSubTotal.Text), decimal.Parse(txtDescuento.Text),
                decimal.Parse(txtTotal.Text), DateTime.Now, dgvArticulos, txtCodigoRemito.Text, Id_usuario, txtCodigoPres.Text);

                if (cmbOpciones.Text == "Cliente Nuevo" && cN_Altas.clearConf == true)
                {
                    cN_Altas.CN_AltaCliente_PresupuestoRemito(txtDoc.Text, txtNombre.Text, txtApellido.Text, txtDireccion.Text, txtTelefono.Text, txtEmail.Text,
                    txtEntidad.Text); //reegistra cliente nuevo
                }

                if (cN_Altas.clearConf)
                {
                    cN_Modificaciones.RegistraCompraCliente(txtDoc.Text, decimal.Parse(txtTotal.Text));
                    cN_Modificaciones.ActualizarStock(dgvArticulos);
                    clear();
                    clearDetalle();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error general al registrar un remito", "comuníquese con el desarrollador", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //private bool validarStockDesdePresupuesto()
        //{

        //}

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            clear();
            cmbOpciones.Text = "SELECCIONE UNA OPCIÓN";
        }

        private void clear()
        {
            //PanelEncabezado
            cmbOpciones.SelectedIndex = -1;
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
            txtCodigoRemito.Text = "";
            txtCodigo.Text = "";
            txtCantidad.Text = "";
            txtDescripcion.Text = "";
            txtDescuento.Text = "";
            txtSubTotal.Text = "";
            txtTotal.Text = "";
            txtStock.Text = "";
            txtCodigoPres.Text = "";
            btnBuscar.Enabled = false;
        }

        private void clearDetalle()
        {
            txtCodigoRemito.Text = "";
            txtCodigo.Text = "";
            txtCantidad.Text = "";
            txtDescripcion.Text = "";
            txtDescuento.Text = "";
            txtSubTotal.Text = "";
            txtTotal.Text = "";
        }
        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {

            if (dgvArticulos.CurrentRow != null && !dgvArticulos.CurrentRow.IsNewRow && dgvArticulos.CurrentRow.Selected != false)
            {
                DataGridViewRow filaSelec = dgvArticulos.CurrentRow;
                txtCodigo.Text = filaSelec.Cells[0].Value.ToString();
                txtDescripcion.Text = filaSelec.Cells[1].Value.ToString();

                DataTable dtStock = new DataTable();
                dtStock = cN_Consultas.ConsultaArtMod(txtCodigo.Text);
                txtStock.Text = dtStock.Rows[0]["Cantidad"].ToString();
            }
            else if (dgvArticulos.Rows.Count == 0 || dgvArticulos.CurrentRow.Selected == false) //entra solo cuando no hay filas en la grilla o no estan seleccionadas
            {
                txtStock.Text = "";
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
                                decimal PxCant = (Convert.ToDecimal(cantidadActual) - 1) * Precio;
                                decimal PxCantActual = decimal.Parse(fila.Cells["C_Pxcant"].Value.ToString());
                                fila.Cells["C_Cantidad"].Value = cantidadActual - 1;
                                fila.Cells["C_Pxcant"].Value = PxCant;
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
                MessageBox.Show("Seleccione un producto de la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvArticulos.Rows.Count != 0)
            {
                DialogResult dres = MessageBox.Show("¿Desea remover este articulo de la lista?", "Remover", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dres == DialogResult.OK)
                {
                    if (dgvArticulos.Rows.Count == 1)
                    {
                        clearDetalle();
                    }
                    else
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
            cmbOpciones.Text = "";
        }

        private void cmbCliente_DropDownClosed(object sender, EventArgs e)
        {
            if (cmbOpciones.SelectedIndex == -1 || cmbOpciones.Text == "")
            {
                cmbOpciones.Text = "SELECCIONE UNA OPCIÓN";
            }
        }

        private void txtStock_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtStock.Text))
            {
                if (int.Parse(txtStock.Text) <= 5)
                {
                    txtStock.ForeColor = Color.Crimson;
                }
                else if (int.Parse(txtStock.Text) <= 10)
                {
                    txtStock.ForeColor = Color.Yellow;
                }
                else
                {
                    txtStock.ForeColor = Color.White;
                }
            }
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(txtCantidad.Text) && !String.IsNullOrEmpty(txtStock.Text))
                {
                    if (int.Parse(txtStock.Text) < int.Parse(txtCantidad.Text))
                    {
                        MessageBox.Show("Cantidad en stock insuficiente", "Stock", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtCantidad.Text = "";
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error solo se permiten datos numericos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string GenerarNumeroFactura(string ultimoNumeroFactura) //Algoritmo prestado de Nico (un crack)
        {
            // Si no hay último número, comienza con AA-0000-0001
            if (string.IsNullOrEmpty(ultimoNumeroFactura))
                return "AA-0000-0001";

            // Descomponer el número en partes
            string letras = ultimoNumeroFactura.Substring(0, 2);
            string numeros = ultimoNumeroFactura.Substring(3).Replace("-", "");

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
            return $"{letras}-{numeroActual.ToString("D9").Insert(4, "-")}";
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
    }
}
