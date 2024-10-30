namespace Ventas_Hardware
{
    partial class frmArtModificaciones
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
            this.panelDetalle = new System.Windows.Forms.Panel();
            this.lblPrecioVenta = new System.Windows.Forms.Label();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.txtSubCategoria = new System.Windows.Forms.TextBox();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.btnRecalcular = new System.Windows.Forms.Button();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.lblCant = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblGanancia = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.lblSubCat = new System.Windows.Forms.Label();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.txtGanancia = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblProveedor2 = new System.Windows.Forms.Label();
            this.lblSubCategoria2 = new System.Windows.Forms.Label();
            this.lblCategoria2 = new System.Windows.Forms.Label();
            this.cmbProveedor = new System.Windows.Forms.ComboBox();
            this.cmbSubcategoria = new System.Windows.Forms.ComboBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.txtAumentoCosto = new System.Windows.Forms.TextBox();
            this.txtAumentoGanancia = new System.Windows.Forms.TextBox();
            this.btnAplicarCosto = new System.Windows.Forms.Button();
            this.btnAplicarGanancia = new System.Windows.Forms.Button();
            this.lblAumentoCosto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblModificacion = new System.Windows.Forms.Label();
            this.panelDetalle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDetalle
            // 
            this.panelDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDetalle.Controls.Add(this.lblPrecioVenta);
            this.panelDetalle.Controls.Add(this.txtPrecioVenta);
            this.panelDetalle.Controls.Add(this.txtProveedor);
            this.panelDetalle.Controls.Add(this.txtSubCategoria);
            this.panelDetalle.Controls.Add(this.txtCategoria);
            this.panelDetalle.Controls.Add(this.btnRecalcular);
            this.panelDetalle.Controls.Add(this.txtStock);
            this.panelDetalle.Controls.Add(this.lblCant);
            this.panelDetalle.Controls.Add(this.btnBuscar);
            this.panelDetalle.Controls.Add(this.btnCancelar);
            this.panelDetalle.Controls.Add(this.btnGuardar);
            this.panelDetalle.Controls.Add(this.lblDescripcion);
            this.panelDetalle.Controls.Add(this.txtDescripcion);
            this.panelDetalle.Controls.Add(this.lblGanancia);
            this.panelDetalle.Controls.Add(this.txtCodigo);
            this.panelDetalle.Controls.Add(this.lbl);
            this.panelDetalle.Controls.Add(this.lblProveedor);
            this.panelDetalle.Controls.Add(this.lblSubCat);
            this.panelDetalle.Controls.Add(this.txtCosto);
            this.panelDetalle.Controls.Add(this.lblCategoria);
            this.panelDetalle.Controls.Add(this.txtGanancia);
            this.panelDetalle.Controls.Add(this.lblCodigo);
            this.panelDetalle.Location = new System.Drawing.Point(19, 49);
            this.panelDetalle.Name = "panelDetalle";
            this.panelDetalle.Size = new System.Drawing.Size(711, 233);
            this.panelDetalle.TabIndex = 33;
            // 
            // lblPrecioVenta
            // 
            this.lblPrecioVenta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrecioVenta.AutoSize = true;
            this.lblPrecioVenta.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioVenta.ForeColor = System.Drawing.Color.White;
            this.lblPrecioVenta.Location = new System.Drawing.Point(362, 180);
            this.lblPrecioVenta.Name = "lblPrecioVenta";
            this.lblPrecioVenta.Size = new System.Drawing.Size(93, 16);
            this.lblPrecioVenta.TabIndex = 43;
            this.lblPrecioVenta.Text = "Precio de venta:";
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrecioVenta.BackColor = System.Drawing.Color.White;
            this.txtPrecioVenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrecioVenta.Enabled = false;
            this.txtPrecioVenta.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioVenta.ForeColor = System.Drawing.Color.Black;
            this.txtPrecioVenta.Location = new System.Drawing.Point(365, 199);
            this.txtPrecioVenta.MaxLength = 27;
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.ReadOnly = true;
            this.txtPrecioVenta.Size = new System.Drawing.Size(91, 22);
            this.txtPrecioVenta.TabIndex = 42;
            this.txtPrecioVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtProveedor
            // 
            this.txtProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(34)))), ((int)(((byte)(100)))));
            this.txtProveedor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProveedor.Enabled = false;
            this.txtProveedor.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProveedor.ForeColor = System.Drawing.Color.White;
            this.txtProveedor.Location = new System.Drawing.Point(519, 105);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(174, 22);
            this.txtProveedor.TabIndex = 41;
            // 
            // txtSubCategoria
            // 
            this.txtSubCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSubCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(34)))), ((int)(((byte)(100)))));
            this.txtSubCategoria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSubCategoria.Enabled = false;
            this.txtSubCategoria.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubCategoria.ForeColor = System.Drawing.Color.White;
            this.txtSubCategoria.Location = new System.Drawing.Point(180, 105);
            this.txtSubCategoria.Name = "txtSubCategoria";
            this.txtSubCategoria.Size = new System.Drawing.Size(131, 22);
            this.txtSubCategoria.TabIndex = 40;
            // 
            // txtCategoria
            // 
            this.txtCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(34)))), ((int)(((byte)(100)))));
            this.txtCategoria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCategoria.Enabled = false;
            this.txtCategoria.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoria.ForeColor = System.Drawing.Color.White;
            this.txtCategoria.Location = new System.Drawing.Point(9, 105);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(141, 22);
            this.txtCategoria.TabIndex = 39;
            // 
            // btnRecalcular
            // 
            this.btnRecalcular.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRecalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(49)))), ((int)(((byte)(110)))));
            this.btnRecalcular.Enabled = false;
            this.btnRecalcular.FlatAppearance.BorderSize = 0;
            this.btnRecalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecalcular.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecalcular.ForeColor = System.Drawing.Color.White;
            this.btnRecalcular.Location = new System.Drawing.Point(258, 196);
            this.btnRecalcular.Name = "btnRecalcular";
            this.btnRecalcular.Size = new System.Drawing.Size(89, 28);
            this.btnRecalcular.TabIndex = 38;
            this.btnRecalcular.Text = "Recalcular";
            this.btnRecalcular.UseVisualStyleBackColor = false;
            this.btnRecalcular.Click += new System.EventHandler(this.btnRecalcular_Click);
            // 
            // txtStock
            // 
            this.txtStock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStock.BackColor = System.Drawing.Color.White;
            this.txtStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStock.Enabled = false;
            this.txtStock.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStock.ForeColor = System.Drawing.Color.Black;
            this.txtStock.Location = new System.Drawing.Point(326, 154);
            this.txtStock.MaxLength = 10;
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(130, 22);
            this.txtStock.TabIndex = 11;
            this.txtStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCant
            // 
            this.lblCant.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCant.AutoSize = true;
            this.lblCant.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCant.ForeColor = System.Drawing.Color.White;
            this.lblCant.Location = new System.Drawing.Point(323, 135);
            this.lblCant.Name = "lblCant";
            this.lblCant.Size = new System.Drawing.Size(110, 16);
            this.lblCant.TabIndex = 27;
            this.lblCant.Text = "Cantidad en Stock:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(49)))), ((int)(((byte)(110)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(202, 22);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(78, 28);
            this.btnBuscar.TabIndex = 36;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackColor = System.Drawing.Color.IndianRed;
            this.btnCancelar.Enabled = false;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(609, 148);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(84, 28);
            this.btnCancelar.TabIndex = 34;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnGuardar.Enabled = false;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(519, 148);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(78, 28);
            this.btnGuardar.TabIndex = 33;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.Color.White;
            this.lblDescripcion.Location = new System.Drawing.Point(6, 135);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(73, 16);
            this.lblDescripcion.TabIndex = 25;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.White;
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescripcion.Enabled = false;
            this.txtDescripcion.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.ForeColor = System.Drawing.Color.Black;
            this.txtDescripcion.Location = new System.Drawing.Point(9, 154);
            this.txtDescripcion.MaxLength = 500;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(302, 22);
            this.txtDescripcion.TabIndex = 9;
            // 
            // lblGanancia
            // 
            this.lblGanancia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGanancia.AutoSize = true;
            this.lblGanancia.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGanancia.ForeColor = System.Drawing.Color.White;
            this.lblGanancia.Location = new System.Drawing.Point(130, 180);
            this.lblGanancia.Name = "lblGanancia";
            this.lblGanancia.Size = new System.Drawing.Size(69, 16);
            this.lblGanancia.TabIndex = 29;
            this.lblGanancia.Text = "%Ganancia:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.White;
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodigo.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.ForeColor = System.Drawing.Color.Black;
            this.txtCodigo.Location = new System.Drawing.Point(9, 25);
            this.txtCodigo.MaxLength = 50;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(174, 22);
            this.txtCodigo.TabIndex = 6;
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.Color.White;
            this.lbl.Location = new System.Drawing.Point(8, 180);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(43, 16);
            this.lbl.TabIndex = 28;
            this.lbl.Text = "Costo:";
            // 
            // lblProveedor
            // 
            this.lblProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedor.ForeColor = System.Drawing.Color.DarkGray;
            this.lblProveedor.Location = new System.Drawing.Point(516, 86);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(63, 16);
            this.lblProveedor.TabIndex = 26;
            this.lblProveedor.Text = "Proveedor";
            // 
            // lblSubCat
            // 
            this.lblSubCat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubCat.AutoSize = true;
            this.lblSubCat.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubCat.ForeColor = System.Drawing.Color.DarkGray;
            this.lblSubCat.Location = new System.Drawing.Point(177, 85);
            this.lblSubCat.Name = "lblSubCat";
            this.lblSubCat.Size = new System.Drawing.Size(85, 16);
            this.lblSubCat.TabIndex = 24;
            this.lblSubCat.Text = "SubCategoría:";
            // 
            // txtCosto
            // 
            this.txtCosto.BackColor = System.Drawing.Color.White;
            this.txtCosto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCosto.Enabled = false;
            this.txtCosto.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCosto.ForeColor = System.Drawing.Color.Black;
            this.txtCosto.Location = new System.Drawing.Point(11, 199);
            this.txtCosto.MaxLength = 27;
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(102, 22);
            this.txtCosto.TabIndex = 12;
            this.txtCosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.ForeColor = System.Drawing.Color.DarkGray;
            this.lblCategoria.Location = new System.Drawing.Point(6, 85);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(64, 16);
            this.lblCategoria.TabIndex = 23;
            this.lblCategoria.Text = "Categoría:";
            // 
            // txtGanancia
            // 
            this.txtGanancia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGanancia.BackColor = System.Drawing.Color.White;
            this.txtGanancia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGanancia.Enabled = false;
            this.txtGanancia.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGanancia.ForeColor = System.Drawing.Color.Black;
            this.txtGanancia.Location = new System.Drawing.Point(133, 199);
            this.txtGanancia.MaxLength = 27;
            this.txtGanancia.Name = "txtGanancia";
            this.txtGanancia.Size = new System.Drawing.Size(105, 22);
            this.txtGanancia.TabIndex = 13;
            this.txtGanancia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.Color.White;
            this.lblCodigo.Location = new System.Drawing.Point(6, 5);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(50, 16);
            this.lblCodigo.TabIndex = 22;
            this.lblCodigo.Text = "Código:";
            // 
            // lblProveedor2
            // 
            this.lblProveedor2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblProveedor2.AutoSize = true;
            this.lblProveedor2.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedor2.ForeColor = System.Drawing.Color.White;
            this.lblProveedor2.Location = new System.Drawing.Point(88, 346);
            this.lblProveedor2.Name = "lblProveedor2";
            this.lblProveedor2.Size = new System.Drawing.Size(66, 16);
            this.lblProveedor2.TabIndex = 39;
            this.lblProveedor2.Text = "Proveedor:";
            // 
            // lblSubCategoria2
            // 
            this.lblSubCategoria2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubCategoria2.AutoSize = true;
            this.lblSubCategoria2.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubCategoria2.ForeColor = System.Drawing.Color.White;
            this.lblSubCategoria2.Location = new System.Drawing.Point(481, 345);
            this.lblSubCategoria2.Name = "lblSubCategoria2";
            this.lblSubCategoria2.Size = new System.Drawing.Size(85, 16);
            this.lblSubCategoria2.TabIndex = 38;
            this.lblSubCategoria2.Text = "SubCategoría:";
            // 
            // lblCategoria2
            // 
            this.lblCategoria2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCategoria2.AutoSize = true;
            this.lblCategoria2.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria2.ForeColor = System.Drawing.Color.White;
            this.lblCategoria2.Location = new System.Drawing.Point(291, 345);
            this.lblCategoria2.Name = "lblCategoria2";
            this.lblCategoria2.Size = new System.Drawing.Size(64, 16);
            this.lblCategoria2.TabIndex = 37;
            this.lblCategoria2.Text = "Categoría:";
            // 
            // cmbProveedor
            // 
            this.cmbProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmbProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbProveedor.Font = new System.Drawing.Font("Segoe UI Variable Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProveedor.FormattingEnabled = true;
            this.cmbProveedor.ItemHeight = 16;
            this.cmbProveedor.Location = new System.Drawing.Point(91, 364);
            this.cmbProveedor.Margin = new System.Windows.Forms.Padding(1);
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.Size = new System.Drawing.Size(186, 24);
            this.cmbProveedor.TabIndex = 36;
            // 
            // cmbSubcategoria
            // 
            this.cmbSubcategoria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSubcategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmbSubcategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubcategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSubcategoria.Font = new System.Drawing.Font("Segoe UI Variable Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSubcategoria.FormattingEnabled = true;
            this.cmbSubcategoria.Location = new System.Drawing.Point(484, 364);
            this.cmbSubcategoria.Margin = new System.Windows.Forms.Padding(1);
            this.cmbSubcategoria.Name = "cmbSubcategoria";
            this.cmbSubcategoria.Size = new System.Drawing.Size(174, 24);
            this.cmbSubcategoria.TabIndex = 35;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCategoria.Font = new System.Drawing.Font("Segoe UI Variable Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(294, 364);
            this.cmbCategoria.Margin = new System.Windows.Forms.Padding(1);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(174, 24);
            this.cmbCategoria.TabIndex = 34;
            this.cmbCategoria.SelectedIndexChanged += new System.EventHandler(this.cmbCategoria_SelectedIndexChanged);
            this.cmbCategoria.TextChanged += new System.EventHandler(this.cmbCategoria_TextChanged);
            // 
            // txtAumentoCosto
            // 
            this.txtAumentoCosto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAumentoCosto.BackColor = System.Drawing.Color.White;
            this.txtAumentoCosto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAumentoCosto.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAumentoCosto.ForeColor = System.Drawing.Color.Black;
            this.txtAumentoCosto.Location = new System.Drawing.Point(170, 418);
            this.txtAumentoCosto.MaxLength = 27;
            this.txtAumentoCosto.Name = "txtAumentoCosto";
            this.txtAumentoCosto.Size = new System.Drawing.Size(186, 22);
            this.txtAumentoCosto.TabIndex = 44;
            this.txtAumentoCosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAumentoGanancia
            // 
            this.txtAumentoGanancia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtAumentoGanancia.BackColor = System.Drawing.Color.White;
            this.txtAumentoGanancia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAumentoGanancia.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAumentoGanancia.ForeColor = System.Drawing.Color.Black;
            this.txtAumentoGanancia.Location = new System.Drawing.Point(393, 418);
            this.txtAumentoGanancia.MaxLength = 27;
            this.txtAumentoGanancia.Name = "txtAumentoGanancia";
            this.txtAumentoGanancia.Size = new System.Drawing.Size(214, 22);
            this.txtAumentoGanancia.TabIndex = 45;
            this.txtAumentoGanancia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAplicarCosto
            // 
            this.btnAplicarCosto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAplicarCosto.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAplicarCosto.FlatAppearance.BorderSize = 0;
            this.btnAplicarCosto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAplicarCosto.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAplicarCosto.ForeColor = System.Drawing.Color.White;
            this.btnAplicarCosto.Location = new System.Drawing.Point(224, 446);
            this.btnAplicarCosto.Name = "btnAplicarCosto";
            this.btnAplicarCosto.Size = new System.Drawing.Size(78, 28);
            this.btnAplicarCosto.TabIndex = 44;
            this.btnAplicarCosto.Text = "Aplicar";
            this.btnAplicarCosto.UseVisualStyleBackColor = false;
            this.btnAplicarCosto.Click += new System.EventHandler(this.btnAplicarCosto_Click);
            // 
            // btnAplicarGanancia
            // 
            this.btnAplicarGanancia.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAplicarGanancia.FlatAppearance.BorderSize = 0;
            this.btnAplicarGanancia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAplicarGanancia.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAplicarGanancia.ForeColor = System.Drawing.Color.White;
            this.btnAplicarGanancia.Location = new System.Drawing.Point(461, 446);
            this.btnAplicarGanancia.Name = "btnAplicarGanancia";
            this.btnAplicarGanancia.Size = new System.Drawing.Size(78, 28);
            this.btnAplicarGanancia.TabIndex = 46;
            this.btnAplicarGanancia.Text = "Aplicar";
            this.btnAplicarGanancia.UseVisualStyleBackColor = false;
            this.btnAplicarGanancia.Click += new System.EventHandler(this.btnAplicarGanancia_Click);
            // 
            // lblAumentoCosto
            // 
            this.lblAumentoCosto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAumentoCosto.AutoSize = true;
            this.lblAumentoCosto.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAumentoCosto.ForeColor = System.Drawing.Color.White;
            this.lblAumentoCosto.Location = new System.Drawing.Point(167, 399);
            this.lblAumentoCosto.Name = "lblAumentoCosto";
            this.lblAumentoCosto.Size = new System.Drawing.Size(195, 16);
            this.lblAumentoCosto.TabIndex = 47;
            this.lblAumentoCosto.Text = "% de aumento de COSTO a aplicar:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(390, 399);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 16);
            this.label1.TabIndex = 48;
            this.label1.Text = "% de aumento de GANANCIA a aplicar:";
            // 
            // lblModificacion
            // 
            this.lblModificacion.AutoSize = true;
            this.lblModificacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblModificacion.Font = new System.Drawing.Font("Segoe UI Variable Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(89)))), ((int)(((byte)(160)))));
            this.lblModificacion.Location = new System.Drawing.Point(12, 17);
            this.lblModificacion.Name = "lblModificacion";
            this.lblModificacion.Size = new System.Drawing.Size(270, 32);
            this.lblModificacion.TabIndex = 49;
            this.lblModificacion.Text = "Modificación Articulo:";
            // 
            // frmArtModificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(29)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(749, 499);
            this.Controls.Add(this.lblModificacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAumentoCosto);
            this.Controls.Add(this.btnAplicarGanancia);
            this.Controls.Add(this.btnAplicarCosto);
            this.Controls.Add(this.txtAumentoGanancia);
            this.Controls.Add(this.txtAumentoCosto);
            this.Controls.Add(this.lblProveedor2);
            this.Controls.Add(this.lblSubCategoria2);
            this.Controls.Add(this.lblCategoria2);
            this.Controls.Add(this.cmbProveedor);
            this.Controls.Add(this.cmbSubcategoria);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.panelDetalle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmArtModificaciones";
            this.Text = "frmArtModificaciones";
            this.panelDetalle.ResumeLayout(false);
            this.panelDetalle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelDetalle;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblGanancia;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblCant;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label lblSubCat;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.TextBox txtGanancia;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.TextBox txtSubCategoria;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.Button btnRecalcular;
        private System.Windows.Forms.Label lblPrecioVenta;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.Label lblProveedor2;
        private System.Windows.Forms.Label lblSubCategoria2;
        private System.Windows.Forms.Label lblCategoria2;
        private System.Windows.Forms.ComboBox cmbProveedor;
        private System.Windows.Forms.ComboBox cmbSubcategoria;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.TextBox txtAumentoCosto;
        private System.Windows.Forms.TextBox txtAumentoGanancia;
        private System.Windows.Forms.Button btnAplicarCosto;
        private System.Windows.Forms.Button btnAplicarGanancia;
        private System.Windows.Forms.Label lblAumentoCosto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblModificacion;
    }
}