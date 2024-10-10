namespace Ventas_Hardware
{
    partial class frmProveedores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblProveedores = new System.Windows.Forms.Label();
            this.cmbProveedor = new System.Windows.Forms.ComboBox();
            this.panelDatosContacto = new System.Windows.Forms.Panel();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblDatos = new System.Windows.Forms.Label();
            this.lblNombreAlt = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.panelDetalle = new System.Windows.Forms.Panel();
            this.lblDetalle = new System.Windows.Forms.Label();
            this.lblDescripcionDetalle = new System.Windows.Forms.Label();
            this.lblPrecioVenta = new System.Windows.Forms.Label();
            this.txtDescDetalle = new System.Windows.Forms.TextBox();
            this.lblGanancia = new System.Windows.Forms.Label();
            this.txtCodigoDetalle = new System.Windows.Forms.TextBox();
            this.lblCosto = new System.Windows.Forms.Label();
            this.txtCatDetalle = new System.Windows.Forms.TextBox();
            this.lblCantStock = new System.Windows.Forms.Label();
            this.txtSubCatDetalle = new System.Windows.Forms.TextBox();
            this.lblProveedorDetalle = new System.Windows.Forms.Label();
            this.txtProvDetalle = new System.Windows.Forms.TextBox();
            this.txtStockDetalle = new System.Windows.Forms.TextBox();
            this.lblSubCatDetalle = new System.Windows.Forms.Label();
            this.txtCostoDetalle = new System.Windows.Forms.TextBox();
            this.lblCategoriaDetalle = new System.Windows.Forms.Label();
            this.txtGananciaDetalle = new System.Windows.Forms.TextBox();
            this.lblCodigoDetalle = new System.Windows.Forms.Label();
            this.txtPrecioVentaDetalle = new System.Windows.Forms.TextBox();
            this.lblArticulos = new System.Windows.Forms.Label();
            this.panelArt = new System.Windows.Forms.Panel();
            this.txtTotalCompra = new System.Windows.Forms.TextBox();
            this.panelCtaCte = new System.Windows.Forms.Panel();
            this.lblEstadoActual = new System.Windows.Forms.Label();
            this.txtDeuda = new System.Windows.Forms.TextBox();
            this.txtTotalPagoEstAct = new System.Windows.Forms.TextBox();
            this.txtTotalCompraEstAct = new System.Windows.Forms.TextBox();
            this.lblttlpagos = new System.Windows.Forms.Label();
            this.lblDuda = new System.Windows.Forms.Label();
            this.lblttlcompras = new System.Windows.Forms.Label();
            this.btnRegistrarpago = new System.Windows.Forms.Button();
            this.btnRegistrarCompra = new System.Windows.Forms.Button();
            this.lbltotalPago = new System.Windows.Forms.Label();
            this.lbltotalCompra = new System.Windows.Forms.Label();
            this.txtTotalPago = new System.Windows.Forms.TextBox();
            this.lblCtaCte = new System.Windows.Forms.Label();
            this.panelDatosContacto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.panelDetalle.SuspendLayout();
            this.panelArt.SuspendLayout();
            this.panelCtaCte.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblProveedores
            // 
            this.lblProveedores.AutoSize = true;
            this.lblProveedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblProveedores.Font = new System.Drawing.Font("Segoe UI Variable Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(89)))), ((int)(((byte)(160)))));
            this.lblProveedores.Location = new System.Drawing.Point(12, 17);
            this.lblProveedores.Name = "lblProveedores";
            this.lblProveedores.Size = new System.Drawing.Size(139, 32);
            this.lblProveedores.TabIndex = 55;
            this.lblProveedores.Text = "Proveedor:";
            // 
            // cmbProveedor
            // 
            this.cmbProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmbProveedor.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProveedor.FormattingEnabled = true;
            this.cmbProveedor.Location = new System.Drawing.Point(181, 17);
            this.cmbProveedor.Margin = new System.Windows.Forms.Padding(1);
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.Size = new System.Drawing.Size(174, 24);
            this.cmbProveedor.TabIndex = 54;
            this.cmbProveedor.SelectedIndexChanged += new System.EventHandler(this.cmbProveedor_SelectedIndexChanged);
            // 
            // panelDatosContacto
            // 
            this.panelDatosContacto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(39)))), ((int)(((byte)(100)))));
            this.panelDatosContacto.Controls.Add(this.lblApellido);
            this.panelDatosContacto.Controls.Add(this.txtApellido);
            this.panelDatosContacto.Controls.Add(this.lblDatos);
            this.panelDatosContacto.Controls.Add(this.lblNombreAlt);
            this.panelDatosContacto.Controls.Add(this.lblMail);
            this.panelDatosContacto.Controls.Add(this.lblTel);
            this.panelDatosContacto.Controls.Add(this.txtTelefono);
            this.panelDatosContacto.Controls.Add(this.txtNombre);
            this.panelDatosContacto.Controls.Add(this.txtEmail);
            this.panelDatosContacto.Location = new System.Drawing.Point(21, 60);
            this.panelDatosContacto.Name = "panelDatosContacto";
            this.panelDatosContacto.Size = new System.Drawing.Size(706, 78);
            this.panelDatosContacto.TabIndex = 57;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.ForeColor = System.Drawing.Color.White;
            this.lblApellido.Location = new System.Drawing.Point(153, 21);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(54, 16);
            this.lblApellido.TabIndex = 62;
            this.lblApellido.Text = "Apellido:";
            // 
            // txtApellido
            // 
            this.txtApellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellido.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.ForeColor = System.Drawing.Color.Black;
            this.txtApellido.Location = new System.Drawing.Point(156, 40);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.ReadOnly = true;
            this.txtApellido.Size = new System.Drawing.Size(114, 22);
            this.txtApellido.TabIndex = 61;
            this.txtApellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(109)))), ((int)(((byte)(190)))));
            this.lblDatos.Location = new System.Drawing.Point(0, 0);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(121, 19);
            this.lblDatos.TabIndex = 60;
            this.lblDatos.Text = "Datos de contacto";
            // 
            // lblNombreAlt
            // 
            this.lblNombreAlt.AutoSize = true;
            this.lblNombreAlt.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreAlt.ForeColor = System.Drawing.Color.White;
            this.lblNombreAlt.Location = new System.Drawing.Point(10, 21);
            this.lblNombreAlt.Name = "lblNombreAlt";
            this.lblNombreAlt.Size = new System.Drawing.Size(55, 16);
            this.lblNombreAlt.TabIndex = 44;
            this.lblNombreAlt.Text = "Nombre:";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMail.ForeColor = System.Drawing.Color.White;
            this.lblMail.Location = new System.Drawing.Point(296, 21);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(39, 16);
            this.lblMail.TabIndex = 48;
            this.lblMail.Text = "Email:";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTel.ForeColor = System.Drawing.Color.White;
            this.lblTel.Location = new System.Drawing.Point(573, 21);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(56, 16);
            this.lblTel.TabIndex = 32;
            this.lblTel.Text = "Teléfono:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefono.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.ForeColor = System.Drawing.Color.Black;
            this.txtTelefono.Location = new System.Drawing.Point(576, 40);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.ReadOnly = true;
            this.txtTelefono.Size = new System.Drawing.Size(116, 22);
            this.txtTelefono.TabIndex = 31;
            this.txtTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.Black;
            this.txtNombre.Location = new System.Drawing.Point(13, 40);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(126, 22);
            this.txtNombre.TabIndex = 43;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.Location = new System.Drawing.Point(299, 40);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(258, 22);
            this.txtEmail.TabIndex = 47;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.AllowUserToAddRows = false;
            this.dgvArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArticulos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(39)))), ((int)(((byte)(100)))));
            this.dgvArticulos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvArticulos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvArticulos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Variable Display", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArticulos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Variable Display", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvArticulos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvArticulos.EnableHeadersVisualStyles = false;
            this.dgvArticulos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(39)))), ((int)(((byte)(100)))));
            this.dgvArticulos.Location = new System.Drawing.Point(13, 30);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.ReadOnly = true;
            this.dgvArticulos.RowHeadersVisible = false;
            this.dgvArticulos.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(330, 126);
            this.dgvArticulos.TabIndex = 58;
            this.dgvArticulos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArticulos_CellContentDoubleClick);
            // 
            // panelDetalle
            // 
            this.panelDetalle.Controls.Add(this.lblDetalle);
            this.panelDetalle.Controls.Add(this.lblDescripcionDetalle);
            this.panelDetalle.Controls.Add(this.lblPrecioVenta);
            this.panelDetalle.Controls.Add(this.txtDescDetalle);
            this.panelDetalle.Controls.Add(this.lblGanancia);
            this.panelDetalle.Controls.Add(this.txtCodigoDetalle);
            this.panelDetalle.Controls.Add(this.lblCosto);
            this.panelDetalle.Controls.Add(this.txtCatDetalle);
            this.panelDetalle.Controls.Add(this.lblCantStock);
            this.panelDetalle.Controls.Add(this.txtSubCatDetalle);
            this.panelDetalle.Controls.Add(this.lblProveedorDetalle);
            this.panelDetalle.Controls.Add(this.txtProvDetalle);
            this.panelDetalle.Controls.Add(this.txtStockDetalle);
            this.panelDetalle.Controls.Add(this.lblSubCatDetalle);
            this.panelDetalle.Controls.Add(this.txtCostoDetalle);
            this.panelDetalle.Controls.Add(this.lblCategoriaDetalle);
            this.panelDetalle.Controls.Add(this.txtGananciaDetalle);
            this.panelDetalle.Controls.Add(this.lblCodigoDetalle);
            this.panelDetalle.Controls.Add(this.txtPrecioVentaDetalle);
            this.panelDetalle.Location = new System.Drawing.Point(18, 322);
            this.panelDetalle.Name = "panelDetalle";
            this.panelDetalle.Size = new System.Drawing.Size(711, 169);
            this.panelDetalle.TabIndex = 59;
            this.panelDetalle.Visible = false;
            // 
            // lblDetalle
            // 
            this.lblDetalle.AutoSize = true;
            this.lblDetalle.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(109)))), ((int)(((byte)(190)))));
            this.lblDetalle.Location = new System.Drawing.Point(3, 0);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Size = new System.Drawing.Size(125, 19);
            this.lblDetalle.TabIndex = 61;
            this.lblDetalle.Text = "Detalle de artículo:";
            // 
            // lblDescripcionDetalle
            // 
            this.lblDescripcionDetalle.AutoSize = true;
            this.lblDescripcionDetalle.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionDetalle.ForeColor = System.Drawing.Color.DarkGray;
            this.lblDescripcionDetalle.Location = new System.Drawing.Point(6, 76);
            this.lblDescripcionDetalle.Name = "lblDescripcionDetalle";
            this.lblDescripcionDetalle.Size = new System.Drawing.Size(73, 16);
            this.lblDescripcionDetalle.TabIndex = 25;
            this.lblDescripcionDetalle.Text = "Descripción:";
            // 
            // lblPrecioVenta
            // 
            this.lblPrecioVenta.AutoSize = true;
            this.lblPrecioVenta.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioVenta.ForeColor = System.Drawing.Color.DarkGray;
            this.lblPrecioVenta.Location = new System.Drawing.Point(521, 124);
            this.lblPrecioVenta.Name = "lblPrecioVenta";
            this.lblPrecioVenta.Size = new System.Drawing.Size(93, 16);
            this.lblPrecioVenta.TabIndex = 30;
            this.lblPrecioVenta.Text = "Precio de venta:";
            // 
            // txtDescDetalle
            // 
            this.txtDescDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(34)))), ((int)(((byte)(100)))));
            this.txtDescDetalle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescDetalle.Enabled = false;
            this.txtDescDetalle.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescDetalle.ForeColor = System.Drawing.Color.White;
            this.txtDescDetalle.Location = new System.Drawing.Point(9, 95);
            this.txtDescDetalle.Name = "txtDescDetalle";
            this.txtDescDetalle.Size = new System.Drawing.Size(435, 22);
            this.txtDescDetalle.TabIndex = 9;
            // 
            // lblGanancia
            // 
            this.lblGanancia.AutoSize = true;
            this.lblGanancia.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGanancia.ForeColor = System.Drawing.Color.DarkGray;
            this.lblGanancia.Location = new System.Drawing.Point(252, 124);
            this.lblGanancia.Name = "lblGanancia";
            this.lblGanancia.Size = new System.Drawing.Size(69, 16);
            this.lblGanancia.TabIndex = 29;
            this.lblGanancia.Text = "%Ganancia:";
            // 
            // txtCodigoDetalle
            // 
            this.txtCodigoDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(34)))), ((int)(((byte)(100)))));
            this.txtCodigoDetalle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodigoDetalle.Enabled = false;
            this.txtCodigoDetalle.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoDetalle.ForeColor = System.Drawing.Color.White;
            this.txtCodigoDetalle.Location = new System.Drawing.Point(9, 46);
            this.txtCodigoDetalle.Name = "txtCodigoDetalle";
            this.txtCodigoDetalle.Size = new System.Drawing.Size(174, 22);
            this.txtCodigoDetalle.TabIndex = 6;
            this.txtCodigoDetalle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCosto.ForeColor = System.Drawing.Color.DarkGray;
            this.lblCosto.Location = new System.Drawing.Point(130, 124);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(43, 16);
            this.lblCosto.TabIndex = 28;
            this.lblCosto.Text = "Costo:";
            // 
            // txtCatDetalle
            // 
            this.txtCatDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(34)))), ((int)(((byte)(100)))));
            this.txtCatDetalle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCatDetalle.Enabled = false;
            this.txtCatDetalle.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCatDetalle.ForeColor = System.Drawing.Color.White;
            this.txtCatDetalle.Location = new System.Drawing.Point(195, 46);
            this.txtCatDetalle.Name = "txtCatDetalle";
            this.txtCatDetalle.Size = new System.Drawing.Size(203, 22);
            this.txtCatDetalle.TabIndex = 7;
            // 
            // lblCantStock
            // 
            this.lblCantStock.AutoSize = true;
            this.lblCantStock.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantStock.ForeColor = System.Drawing.Color.DarkGray;
            this.lblCantStock.Location = new System.Drawing.Point(6, 124);
            this.lblCantStock.Name = "lblCantStock";
            this.lblCantStock.Size = new System.Drawing.Size(110, 16);
            this.lblCantStock.TabIndex = 27;
            this.lblCantStock.Text = "Cantidad en Stock:";
            // 
            // txtSubCatDetalle
            // 
            this.txtSubCatDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(34)))), ((int)(((byte)(100)))));
            this.txtSubCatDetalle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSubCatDetalle.Enabled = false;
            this.txtSubCatDetalle.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubCatDetalle.ForeColor = System.Drawing.Color.White;
            this.txtSubCatDetalle.Location = new System.Drawing.Point(409, 46);
            this.txtSubCatDetalle.Name = "txtSubCatDetalle";
            this.txtSubCatDetalle.Size = new System.Drawing.Size(190, 22);
            this.txtSubCatDetalle.TabIndex = 8;
            // 
            // lblProveedorDetalle
            // 
            this.lblProveedorDetalle.AutoSize = true;
            this.lblProveedorDetalle.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedorDetalle.ForeColor = System.Drawing.Color.DarkGray;
            this.lblProveedorDetalle.Location = new System.Drawing.Point(453, 76);
            this.lblProveedorDetalle.Name = "lblProveedorDetalle";
            this.lblProveedorDetalle.Size = new System.Drawing.Size(63, 16);
            this.lblProveedorDetalle.TabIndex = 26;
            this.lblProveedorDetalle.Text = "Proveedor";
            // 
            // txtProvDetalle
            // 
            this.txtProvDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(34)))), ((int)(((byte)(100)))));
            this.txtProvDetalle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProvDetalle.Enabled = false;
            this.txtProvDetalle.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProvDetalle.ForeColor = System.Drawing.Color.White;
            this.txtProvDetalle.Location = new System.Drawing.Point(456, 95);
            this.txtProvDetalle.Name = "txtProvDetalle";
            this.txtProvDetalle.Size = new System.Drawing.Size(190, 22);
            this.txtProvDetalle.TabIndex = 10;
            // 
            // txtStockDetalle
            // 
            this.txtStockDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(34)))), ((int)(((byte)(100)))));
            this.txtStockDetalle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStockDetalle.Enabled = false;
            this.txtStockDetalle.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockDetalle.ForeColor = System.Drawing.Color.White;
            this.txtStockDetalle.Location = new System.Drawing.Point(9, 143);
            this.txtStockDetalle.Name = "txtStockDetalle";
            this.txtStockDetalle.Size = new System.Drawing.Size(102, 22);
            this.txtStockDetalle.TabIndex = 11;
            this.txtStockDetalle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSubCatDetalle
            // 
            this.lblSubCatDetalle.AutoSize = true;
            this.lblSubCatDetalle.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubCatDetalle.ForeColor = System.Drawing.Color.DarkGray;
            this.lblSubCatDetalle.Location = new System.Drawing.Point(406, 26);
            this.lblSubCatDetalle.Name = "lblSubCatDetalle";
            this.lblSubCatDetalle.Size = new System.Drawing.Size(85, 16);
            this.lblSubCatDetalle.TabIndex = 24;
            this.lblSubCatDetalle.Text = "SubCategoría:";
            // 
            // txtCostoDetalle
            // 
            this.txtCostoDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(34)))), ((int)(((byte)(100)))));
            this.txtCostoDetalle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCostoDetalle.Enabled = false;
            this.txtCostoDetalle.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCostoDetalle.ForeColor = System.Drawing.Color.White;
            this.txtCostoDetalle.Location = new System.Drawing.Point(133, 143);
            this.txtCostoDetalle.Name = "txtCostoDetalle";
            this.txtCostoDetalle.Size = new System.Drawing.Size(102, 22);
            this.txtCostoDetalle.TabIndex = 12;
            this.txtCostoDetalle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCategoriaDetalle
            // 
            this.lblCategoriaDetalle.AutoSize = true;
            this.lblCategoriaDetalle.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriaDetalle.ForeColor = System.Drawing.Color.DarkGray;
            this.lblCategoriaDetalle.Location = new System.Drawing.Point(192, 26);
            this.lblCategoriaDetalle.Name = "lblCategoriaDetalle";
            this.lblCategoriaDetalle.Size = new System.Drawing.Size(64, 16);
            this.lblCategoriaDetalle.TabIndex = 23;
            this.lblCategoriaDetalle.Text = "Categoría:";
            // 
            // txtGananciaDetalle
            // 
            this.txtGananciaDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(34)))), ((int)(((byte)(100)))));
            this.txtGananciaDetalle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGananciaDetalle.Enabled = false;
            this.txtGananciaDetalle.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGananciaDetalle.ForeColor = System.Drawing.Color.White;
            this.txtGananciaDetalle.Location = new System.Drawing.Point(255, 143);
            this.txtGananciaDetalle.Name = "txtGananciaDetalle";
            this.txtGananciaDetalle.Size = new System.Drawing.Size(105, 22);
            this.txtGananciaDetalle.TabIndex = 13;
            this.txtGananciaDetalle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCodigoDetalle
            // 
            this.lblCodigoDetalle.AutoSize = true;
            this.lblCodigoDetalle.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoDetalle.ForeColor = System.Drawing.Color.DarkGray;
            this.lblCodigoDetalle.Location = new System.Drawing.Point(6, 26);
            this.lblCodigoDetalle.Name = "lblCodigoDetalle";
            this.lblCodigoDetalle.Size = new System.Drawing.Size(50, 16);
            this.lblCodigoDetalle.TabIndex = 22;
            this.lblCodigoDetalle.Text = "Código:";
            // 
            // txtPrecioVentaDetalle
            // 
            this.txtPrecioVentaDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(34)))), ((int)(((byte)(100)))));
            this.txtPrecioVentaDetalle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrecioVentaDetalle.Enabled = false;
            this.txtPrecioVentaDetalle.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioVentaDetalle.ForeColor = System.Drawing.Color.White;
            this.txtPrecioVentaDetalle.Location = new System.Drawing.Point(524, 143);
            this.txtPrecioVentaDetalle.Name = "txtPrecioVentaDetalle";
            this.txtPrecioVentaDetalle.Size = new System.Drawing.Size(122, 22);
            this.txtPrecioVentaDetalle.TabIndex = 14;
            this.txtPrecioVentaDetalle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblArticulos
            // 
            this.lblArticulos.AutoSize = true;
            this.lblArticulos.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArticulos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(109)))), ((int)(((byte)(190)))));
            this.lblArticulos.Location = new System.Drawing.Point(3, 0);
            this.lblArticulos.Name = "lblArticulos";
            this.lblArticulos.Size = new System.Drawing.Size(195, 19);
            this.lblArticulos.TabIndex = 62;
            this.lblArticulos.Text = "Artículos que me proporciona:";
            // 
            // panelArt
            // 
            this.panelArt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(39)))), ((int)(((byte)(100)))));
            this.panelArt.Controls.Add(this.lblArticulos);
            this.panelArt.Controls.Add(this.dgvArticulos);
            this.panelArt.Location = new System.Drawing.Point(21, 147);
            this.panelArt.Name = "panelArt";
            this.panelArt.Size = new System.Drawing.Size(357, 169);
            this.panelArt.TabIndex = 63;
            // 
            // txtTotalCompra
            // 
            this.txtTotalCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtTotalCompra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalCompra.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalCompra.ForeColor = System.Drawing.Color.Black;
            this.txtTotalCompra.Location = new System.Drawing.Point(18, 44);
            this.txtTotalCompra.Name = "txtTotalCompra";
            this.txtTotalCompra.Size = new System.Drawing.Size(139, 22);
            this.txtTotalCompra.TabIndex = 63;
            this.txtTotalCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelCtaCte
            // 
            this.panelCtaCte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(39)))), ((int)(((byte)(100)))));
            this.panelCtaCte.Controls.Add(this.lblEstadoActual);
            this.panelCtaCte.Controls.Add(this.txtDeuda);
            this.panelCtaCte.Controls.Add(this.txtTotalPagoEstAct);
            this.panelCtaCte.Controls.Add(this.txtTotalCompraEstAct);
            this.panelCtaCte.Controls.Add(this.lblttlpagos);
            this.panelCtaCte.Controls.Add(this.lblDuda);
            this.panelCtaCte.Controls.Add(this.lblttlcompras);
            this.panelCtaCte.Controls.Add(this.btnRegistrarpago);
            this.panelCtaCte.Controls.Add(this.btnRegistrarCompra);
            this.panelCtaCte.Controls.Add(this.lbltotalPago);
            this.panelCtaCte.Controls.Add(this.lbltotalCompra);
            this.panelCtaCte.Controls.Add(this.txtTotalPago);
            this.panelCtaCte.Controls.Add(this.txtTotalCompra);
            this.panelCtaCte.Controls.Add(this.lblCtaCte);
            this.panelCtaCte.Location = new System.Drawing.Point(392, 147);
            this.panelCtaCte.Name = "panelCtaCte";
            this.panelCtaCte.Size = new System.Drawing.Size(335, 194);
            this.panelCtaCte.TabIndex = 64;
            // 
            // lblEstadoActual
            // 
            this.lblEstadoActual.AutoSize = true;
            this.lblEstadoActual.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoActual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(109)))), ((int)(((byte)(190)))));
            this.lblEstadoActual.Location = new System.Drawing.Point(3, 107);
            this.lblEstadoActual.Name = "lblEstadoActual";
            this.lblEstadoActual.Size = new System.Drawing.Size(96, 19);
            this.lblEstadoActual.TabIndex = 73;
            this.lblEstadoActual.Text = "Estado Actual:";
            // 
            // txtDeuda
            // 
            this.txtDeuda.BackColor = System.Drawing.Color.White;
            this.txtDeuda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDeuda.Enabled = false;
            this.txtDeuda.Font = new System.Drawing.Font("Segoe UI Variable Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeuda.ForeColor = System.Drawing.Color.White;
            this.txtDeuda.Location = new System.Drawing.Point(195, 169);
            this.txtDeuda.Name = "txtDeuda";
            this.txtDeuda.Size = new System.Drawing.Size(115, 16);
            this.txtDeuda.TabIndex = 72;
            this.txtDeuda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTotalPagoEstAct
            // 
            this.txtTotalPagoEstAct.BackColor = System.Drawing.Color.White;
            this.txtTotalPagoEstAct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalPagoEstAct.Enabled = false;
            this.txtTotalPagoEstAct.Font = new System.Drawing.Font("Segoe UI Variable Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPagoEstAct.ForeColor = System.Drawing.Color.White;
            this.txtTotalPagoEstAct.Location = new System.Drawing.Point(195, 149);
            this.txtTotalPagoEstAct.Name = "txtTotalPagoEstAct";
            this.txtTotalPagoEstAct.Size = new System.Drawing.Size(115, 16);
            this.txtTotalPagoEstAct.TabIndex = 71;
            this.txtTotalPagoEstAct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTotalCompraEstAct
            // 
            this.txtTotalCompraEstAct.BackColor = System.Drawing.Color.White;
            this.txtTotalCompraEstAct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalCompraEstAct.Enabled = false;
            this.txtTotalCompraEstAct.Font = new System.Drawing.Font("Segoe UI Variable Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalCompraEstAct.ForeColor = System.Drawing.Color.White;
            this.txtTotalCompraEstAct.Location = new System.Drawing.Point(195, 129);
            this.txtTotalCompraEstAct.Name = "txtTotalCompraEstAct";
            this.txtTotalCompraEstAct.Size = new System.Drawing.Size(115, 16);
            this.txtTotalCompraEstAct.TabIndex = 62;
            this.txtTotalCompraEstAct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblttlpagos
            // 
            this.lblttlpagos.AutoSize = true;
            this.lblttlpagos.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblttlpagos.ForeColor = System.Drawing.Color.DarkGray;
            this.lblttlpagos.Location = new System.Drawing.Point(92, 147);
            this.lblttlpagos.Name = "lblttlpagos";
            this.lblttlpagos.Size = new System.Drawing.Size(101, 19);
            this.lblttlpagos.TabIndex = 70;
            this.lblttlpagos.Text = "Total en pagos:";
            // 
            // lblDuda
            // 
            this.lblDuda.AutoSize = true;
            this.lblDuda.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuda.ForeColor = System.Drawing.Color.DarkGray;
            this.lblDuda.Location = new System.Drawing.Point(141, 166);
            this.lblDuda.Name = "lblDuda";
            this.lblDuda.Size = new System.Drawing.Size(52, 19);
            this.lblDuda.TabIndex = 69;
            this.lblDuda.Text = "Deuda:";
            // 
            // lblttlcompras
            // 
            this.lblttlcompras.AutoSize = true;
            this.lblttlcompras.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblttlcompras.ForeColor = System.Drawing.Color.DarkGray;
            this.lblttlcompras.Location = new System.Drawing.Point(76, 128);
            this.lblttlcompras.Name = "lblttlcompras";
            this.lblttlcompras.Size = new System.Drawing.Size(117, 19);
            this.lblttlcompras.TabIndex = 68;
            this.lblttlcompras.Text = "Total en compras:";
            // 
            // btnRegistrarpago
            // 
            this.btnRegistrarpago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(89)))), ((int)(((byte)(160)))));
            this.btnRegistrarpago.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarpago.FlatAppearance.BorderSize = 0;
            this.btnRegistrarpago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarpago.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarpago.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarpago.Location = new System.Drawing.Point(184, 72);
            this.btnRegistrarpago.Name = "btnRegistrarpago";
            this.btnRegistrarpago.Size = new System.Drawing.Size(127, 28);
            this.btnRegistrarpago.TabIndex = 67;
            this.btnRegistrarpago.Text = "Registrar pago";
            this.btnRegistrarpago.UseVisualStyleBackColor = false;
            // 
            // btnRegistrarCompra
            // 
            this.btnRegistrarCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(89)))), ((int)(((byte)(160)))));
            this.btnRegistrarCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarCompra.FlatAppearance.BorderSize = 0;
            this.btnRegistrarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarCompra.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarCompra.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarCompra.Location = new System.Drawing.Point(18, 72);
            this.btnRegistrarCompra.Name = "btnRegistrarCompra";
            this.btnRegistrarCompra.Size = new System.Drawing.Size(139, 28);
            this.btnRegistrarCompra.TabIndex = 65;
            this.btnRegistrarCompra.Text = "Registrar compra";
            this.btnRegistrarCompra.UseVisualStyleBackColor = false;
            // 
            // lbltotalPago
            // 
            this.lbltotalPago.AutoSize = true;
            this.lbltotalPago.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalPago.ForeColor = System.Drawing.Color.White;
            this.lbltotalPago.Location = new System.Drawing.Point(180, 22);
            this.lbltotalPago.Name = "lbltotalPago";
            this.lbltotalPago.Size = new System.Drawing.Size(77, 19);
            this.lbltotalPago.TabIndex = 66;
            this.lbltotalPago.Text = "Total pago:";
            // 
            // lbltotalCompra
            // 
            this.lbltotalCompra.AutoSize = true;
            this.lbltotalCompra.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalCompra.ForeColor = System.Drawing.Color.White;
            this.lbltotalCompra.Location = new System.Drawing.Point(14, 22);
            this.lbltotalCompra.Name = "lbltotalCompra";
            this.lbltotalCompra.Size = new System.Drawing.Size(93, 19);
            this.lbltotalCompra.TabIndex = 65;
            this.lbltotalCompra.Text = "Total compra:";
            // 
            // txtTotalPago
            // 
            this.txtTotalPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtTotalPago.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalPago.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPago.ForeColor = System.Drawing.Color.Black;
            this.txtTotalPago.Location = new System.Drawing.Point(184, 44);
            this.txtTotalPago.Name = "txtTotalPago";
            this.txtTotalPago.Size = new System.Drawing.Size(127, 22);
            this.txtTotalPago.TabIndex = 64;
            this.txtTotalPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCtaCte
            // 
            this.lblCtaCte.AutoSize = true;
            this.lblCtaCte.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCtaCte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(109)))), ((int)(((byte)(190)))));
            this.lblCtaCte.Location = new System.Drawing.Point(3, 0);
            this.lblCtaCte.Name = "lblCtaCte";
            this.lblCtaCte.Size = new System.Drawing.Size(131, 19);
            this.lblCtaCte.TabIndex = 62;
            this.lblCtaCte.Text = "Cta. Cte. Proveedor:";
            // 
            // frmProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(29)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(749, 523);
            this.Controls.Add(this.panelCtaCte);
            this.Controls.Add(this.panelArt);
            this.Controls.Add(this.panelDetalle);
            this.Controls.Add(this.panelDatosContacto);
            this.Controls.Add(this.lblProveedores);
            this.Controls.Add(this.cmbProveedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProveedores";
            this.Text = "frmProveedores";
            this.panelDatosContacto.ResumeLayout(false);
            this.panelDatosContacto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            this.panelDetalle.ResumeLayout(false);
            this.panelDetalle.PerformLayout();
            this.panelArt.ResumeLayout(false);
            this.panelArt.PerformLayout();
            this.panelCtaCte.ResumeLayout(false);
            this.panelCtaCte.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblProveedores;
        private System.Windows.Forms.ComboBox cmbProveedor;
        private System.Windows.Forms.Panel panelDatosContacto;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.Label lblNombreAlt;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.Panel panelDetalle;
        private System.Windows.Forms.Label lblDescripcionDetalle;
        private System.Windows.Forms.Label lblPrecioVenta;
        private System.Windows.Forms.TextBox txtDescDetalle;
        private System.Windows.Forms.Label lblGanancia;
        private System.Windows.Forms.TextBox txtCodigoDetalle;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.TextBox txtCatDetalle;
        private System.Windows.Forms.Label lblCantStock;
        private System.Windows.Forms.TextBox txtSubCatDetalle;
        private System.Windows.Forms.Label lblProveedorDetalle;
        private System.Windows.Forms.TextBox txtProvDetalle;
        private System.Windows.Forms.TextBox txtStockDetalle;
        private System.Windows.Forms.Label lblSubCatDetalle;
        private System.Windows.Forms.TextBox txtCostoDetalle;
        private System.Windows.Forms.Label lblCategoriaDetalle;
        private System.Windows.Forms.TextBox txtGananciaDetalle;
        private System.Windows.Forms.Label lblCodigoDetalle;
        private System.Windows.Forms.TextBox txtPrecioVentaDetalle;
        private System.Windows.Forms.Label lblDetalle;
        private System.Windows.Forms.Label lblArticulos;
        private System.Windows.Forms.Panel panelArt;
        private System.Windows.Forms.TextBox txtTotalCompra;
        private System.Windows.Forms.Panel panelCtaCte;
        private System.Windows.Forms.TextBox txtTotalPago;
        private System.Windows.Forms.Label lblCtaCte;
        private System.Windows.Forms.Button btnRegistrarpago;
        private System.Windows.Forms.Button btnRegistrarCompra;
        private System.Windows.Forms.Label lbltotalPago;
        private System.Windows.Forms.Label lbltotalCompra;
        private System.Windows.Forms.TextBox txtTotalCompraEstAct;
        private System.Windows.Forms.Label lblttlpagos;
        private System.Windows.Forms.Label lblDuda;
        private System.Windows.Forms.Label lblttlcompras;
        private System.Windows.Forms.Label lblEstadoActual;
        private System.Windows.Forms.TextBox txtDeuda;
        private System.Windows.Forms.TextBox txtTotalPagoEstAct;
    }
}