namespace Ventas_Hardware
{
    partial class frmArtConsultas
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
            this.cmbDescripcion = new System.Windows.Forms.ComboBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.cmbSubcategoria = new System.Windows.Forms.ComboBox();
            this.cmbProveedor = new System.Windows.Forms.ComboBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.txtCodigoDetalle = new System.Windows.Forms.TextBox();
            this.txtCatDetalle = new System.Windows.Forms.TextBox();
            this.txtSubCatDetalle = new System.Windows.Forms.TextBox();
            this.txtDescDetalle = new System.Windows.Forms.TextBox();
            this.txtProvDetalle = new System.Windows.Forms.TextBox();
            this.txtStockDetalle = new System.Windows.Forms.TextBox();
            this.txtCostoDetalle = new System.Windows.Forms.TextBox();
            this.txtGananciaDetalle = new System.Windows.Forms.TextBox();
            this.txtPrecioVentaDetalle = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblSubCat = new System.Windows.Forms.Label();
            this.lblDescrip = new System.Windows.Forms.Label();
            this.lblProovedor = new System.Windows.Forms.Label();
            this.lblCodigoDetalle = new System.Windows.Forms.Label();
            this.lblCategoriaDetalle = new System.Windows.Forms.Label();
            this.lblSubCatDetalle = new System.Windows.Forms.Label();
            this.lblDescripcionDetalle = new System.Windows.Forms.Label();
            this.lblProveedorDetalle = new System.Windows.Forms.Label();
            this.lblCantStock = new System.Windows.Forms.Label();
            this.lblCosto = new System.Windows.Forms.Label();
            this.lblGanancia = new System.Windows.Forms.Label();
            this.lblPrecioVenta = new System.Windows.Forms.Label();
            this.panelDetalle = new System.Windows.Forms.Panel();
            this.lblDetalle = new System.Windows.Forms.Label();
            this.lblConsulta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.panelDetalle.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbDescripcion
            // 
            this.cmbDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmbDescripcion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbDescripcion.Font = new System.Drawing.Font("Segoe UI Variable Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDescripcion.FormattingEnabled = true;
            this.cmbDescripcion.Location = new System.Drawing.Point(28, 76);
            this.cmbDescripcion.Margin = new System.Windows.Forms.Padding(1);
            this.cmbDescripcion.Name = "cmbDescripcion";
            this.cmbDescripcion.Size = new System.Drawing.Size(315, 24);
            this.cmbDescripcion.TabIndex = 0;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmbCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCategoria.Font = new System.Drawing.Font("Segoe UI Variable Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(358, 76);
            this.cmbCategoria.Margin = new System.Windows.Forms.Padding(1);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(174, 24);
            this.cmbCategoria.TabIndex = 1;
            this.cmbCategoria.TextChanged += new System.EventHandler(this.cmbCategoria_TextChanged);
            // 
            // cmbSubcategoria
            // 
            this.cmbSubcategoria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSubcategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmbSubcategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSubcategoria.Font = new System.Drawing.Font("Segoe UI Variable Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSubcategoria.FormattingEnabled = true;
            this.cmbSubcategoria.Location = new System.Drawing.Point(548, 76);
            this.cmbSubcategoria.Margin = new System.Windows.Forms.Padding(1);
            this.cmbSubcategoria.Name = "cmbSubcategoria";
            this.cmbSubcategoria.Size = new System.Drawing.Size(174, 24);
            this.cmbSubcategoria.TabIndex = 2;
            // 
            // cmbProveedor
            // 
            this.cmbProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmbProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbProveedor.Font = new System.Drawing.Font("Segoe UI Variable Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProveedor.FormattingEnabled = true;
            this.cmbProveedor.ItemHeight = 16;
            this.cmbProveedor.Location = new System.Drawing.Point(28, 126);
            this.cmbProveedor.Margin = new System.Windows.Forms.Padding(1);
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.Size = new System.Drawing.Size(186, 24);
            this.cmbProveedor.TabIndex = 3;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodigo.BackColor = System.Drawing.Color.White;
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigo.Font = new System.Drawing.Font("Segoe UI Variable Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.ForeColor = System.Drawing.Color.Black;
            this.txtCodigo.Location = new System.Drawing.Point(230, 127);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(133, 23);
            this.txtCodigo.TabIndex = 4;
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.AllowUserToAddRows = false;
            this.dgvArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.dgvArticulos.Location = new System.Drawing.Point(28, 159);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.ReadOnly = true;
            this.dgvArticulos.RowHeadersVisible = false;
            this.dgvArticulos.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(694, 152);
            this.dgvArticulos.TabIndex = 5;
            this.dgvArticulos.Visible = false;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // txtCodigoDetalle
            // 
            this.txtCodigoDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCodigoDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(34)))), ((int)(((byte)(100)))));
            this.txtCodigoDetalle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodigoDetalle.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoDetalle.ForeColor = System.Drawing.Color.White;
            this.txtCodigoDetalle.Location = new System.Drawing.Point(9, 46);
            this.txtCodigoDetalle.Name = "txtCodigoDetalle";
            this.txtCodigoDetalle.ReadOnly = true;
            this.txtCodigoDetalle.Size = new System.Drawing.Size(174, 22);
            this.txtCodigoDetalle.TabIndex = 6;
            this.txtCodigoDetalle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCatDetalle
            // 
            this.txtCatDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCatDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(34)))), ((int)(((byte)(100)))));
            this.txtCatDetalle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCatDetalle.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCatDetalle.ForeColor = System.Drawing.Color.White;
            this.txtCatDetalle.Location = new System.Drawing.Point(241, 46);
            this.txtCatDetalle.Name = "txtCatDetalle";
            this.txtCatDetalle.ReadOnly = true;
            this.txtCatDetalle.Size = new System.Drawing.Size(203, 22);
            this.txtCatDetalle.TabIndex = 7;
            this.txtCatDetalle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSubCatDetalle
            // 
            this.txtSubCatDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSubCatDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(34)))), ((int)(((byte)(100)))));
            this.txtSubCatDetalle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSubCatDetalle.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubCatDetalle.ForeColor = System.Drawing.Color.White;
            this.txtSubCatDetalle.Location = new System.Drawing.Point(513, 46);
            this.txtSubCatDetalle.Name = "txtSubCatDetalle";
            this.txtSubCatDetalle.ReadOnly = true;
            this.txtSubCatDetalle.Size = new System.Drawing.Size(190, 22);
            this.txtSubCatDetalle.TabIndex = 8;
            // 
            // txtDescDetalle
            // 
            this.txtDescDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(34)))), ((int)(((byte)(100)))));
            this.txtDescDetalle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescDetalle.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescDetalle.ForeColor = System.Drawing.Color.White;
            this.txtDescDetalle.Location = new System.Drawing.Point(9, 95);
            this.txtDescDetalle.Name = "txtDescDetalle";
            this.txtDescDetalle.ReadOnly = true;
            this.txtDescDetalle.Size = new System.Drawing.Size(435, 22);
            this.txtDescDetalle.TabIndex = 9;
            this.txtDescDetalle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtProvDetalle
            // 
            this.txtProvDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProvDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(34)))), ((int)(((byte)(100)))));
            this.txtProvDetalle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProvDetalle.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProvDetalle.ForeColor = System.Drawing.Color.White;
            this.txtProvDetalle.Location = new System.Drawing.Point(513, 95);
            this.txtProvDetalle.Name = "txtProvDetalle";
            this.txtProvDetalle.ReadOnly = true;
            this.txtProvDetalle.Size = new System.Drawing.Size(190, 22);
            this.txtProvDetalle.TabIndex = 10;
            // 
            // txtStockDetalle
            // 
            this.txtStockDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtStockDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(34)))), ((int)(((byte)(100)))));
            this.txtStockDetalle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStockDetalle.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockDetalle.ForeColor = System.Drawing.Color.White;
            this.txtStockDetalle.Location = new System.Drawing.Point(9, 143);
            this.txtStockDetalle.Name = "txtStockDetalle";
            this.txtStockDetalle.ReadOnly = true;
            this.txtStockDetalle.Size = new System.Drawing.Size(102, 22);
            this.txtStockDetalle.TabIndex = 11;
            this.txtStockDetalle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtStockDetalle.TextChanged += new System.EventHandler(this.txtStockDetalle_TextChanged);
            // 
            // txtCostoDetalle
            // 
            this.txtCostoDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCostoDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(34)))), ((int)(((byte)(100)))));
            this.txtCostoDetalle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCostoDetalle.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCostoDetalle.ForeColor = System.Drawing.Color.White;
            this.txtCostoDetalle.Location = new System.Drawing.Point(133, 143);
            this.txtCostoDetalle.Name = "txtCostoDetalle";
            this.txtCostoDetalle.ReadOnly = true;
            this.txtCostoDetalle.Size = new System.Drawing.Size(102, 22);
            this.txtCostoDetalle.TabIndex = 12;
            this.txtCostoDetalle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGananciaDetalle
            // 
            this.txtGananciaDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGananciaDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(34)))), ((int)(((byte)(100)))));
            this.txtGananciaDetalle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGananciaDetalle.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGananciaDetalle.ForeColor = System.Drawing.Color.White;
            this.txtGananciaDetalle.Location = new System.Drawing.Point(255, 143);
            this.txtGananciaDetalle.Name = "txtGananciaDetalle";
            this.txtGananciaDetalle.ReadOnly = true;
            this.txtGananciaDetalle.Size = new System.Drawing.Size(105, 22);
            this.txtGananciaDetalle.TabIndex = 13;
            this.txtGananciaDetalle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPrecioVentaDetalle
            // 
            this.txtPrecioVentaDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrecioVentaDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(34)))), ((int)(((byte)(100)))));
            this.txtPrecioVentaDetalle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrecioVentaDetalle.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioVentaDetalle.ForeColor = System.Drawing.Color.White;
            this.txtPrecioVentaDetalle.Location = new System.Drawing.Point(581, 143);
            this.txtPrecioVentaDetalle.Name = "txtPrecioVentaDetalle";
            this.txtPrecioVentaDetalle.ReadOnly = true;
            this.txtPrecioVentaDetalle.Size = new System.Drawing.Size(122, 22);
            this.txtPrecioVentaDetalle.TabIndex = 14;
            this.txtPrecioVentaDetalle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(548, 123);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(78, 28);
            this.btnBuscar.TabIndex = 15;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiar.BackColor = System.Drawing.Color.IndianRed;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(644, 123);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(78, 28);
            this.btnLimpiar.TabIndex = 16;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblCodigo
            // 
            this.lblCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.Color.White;
            this.lblCodigo.Location = new System.Drawing.Point(227, 108);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(50, 16);
            this.lblCodigo.TabIndex = 17;
            this.lblCodigo.Text = "Código:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.ForeColor = System.Drawing.Color.White;
            this.lblCategoria.Location = new System.Drawing.Point(355, 57);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(64, 16);
            this.lblCategoria.TabIndex = 18;
            this.lblCategoria.Text = "Categoría:";
            // 
            // lblSubCat
            // 
            this.lblSubCat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubCat.AutoSize = true;
            this.lblSubCat.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubCat.ForeColor = System.Drawing.Color.White;
            this.lblSubCat.Location = new System.Drawing.Point(545, 57);
            this.lblSubCat.Name = "lblSubCat";
            this.lblSubCat.Size = new System.Drawing.Size(85, 16);
            this.lblSubCat.TabIndex = 19;
            this.lblSubCat.Text = "SubCategoría:";
            // 
            // lblDescrip
            // 
            this.lblDescrip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDescrip.AutoSize = true;
            this.lblDescrip.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescrip.ForeColor = System.Drawing.Color.White;
            this.lblDescrip.Location = new System.Drawing.Point(25, 57);
            this.lblDescrip.Name = "lblDescrip";
            this.lblDescrip.Size = new System.Drawing.Size(73, 16);
            this.lblDescrip.TabIndex = 20;
            this.lblDescrip.Text = "Descripción:";
            // 
            // lblProovedor
            // 
            this.lblProovedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblProovedor.AutoSize = true;
            this.lblProovedor.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProovedor.ForeColor = System.Drawing.Color.White;
            this.lblProovedor.Location = new System.Drawing.Point(25, 108);
            this.lblProovedor.Name = "lblProovedor";
            this.lblProovedor.Size = new System.Drawing.Size(66, 16);
            this.lblProovedor.TabIndex = 21;
            this.lblProovedor.Text = "Proveedor:";
            // 
            // lblCodigoDetalle
            // 
            this.lblCodigoDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCodigoDetalle.AutoSize = true;
            this.lblCodigoDetalle.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoDetalle.ForeColor = System.Drawing.Color.DarkGray;
            this.lblCodigoDetalle.Location = new System.Drawing.Point(6, 26);
            this.lblCodigoDetalle.Name = "lblCodigoDetalle";
            this.lblCodigoDetalle.Size = new System.Drawing.Size(50, 16);
            this.lblCodigoDetalle.TabIndex = 22;
            this.lblCodigoDetalle.Text = "Código:";
            // 
            // lblCategoriaDetalle
            // 
            this.lblCategoriaDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCategoriaDetalle.AutoSize = true;
            this.lblCategoriaDetalle.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriaDetalle.ForeColor = System.Drawing.Color.DarkGray;
            this.lblCategoriaDetalle.Location = new System.Drawing.Point(238, 26);
            this.lblCategoriaDetalle.Name = "lblCategoriaDetalle";
            this.lblCategoriaDetalle.Size = new System.Drawing.Size(64, 16);
            this.lblCategoriaDetalle.TabIndex = 23;
            this.lblCategoriaDetalle.Text = "Categoría:";
            // 
            // lblSubCatDetalle
            // 
            this.lblSubCatDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubCatDetalle.AutoSize = true;
            this.lblSubCatDetalle.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubCatDetalle.ForeColor = System.Drawing.Color.DarkGray;
            this.lblSubCatDetalle.Location = new System.Drawing.Point(510, 26);
            this.lblSubCatDetalle.Name = "lblSubCatDetalle";
            this.lblSubCatDetalle.Size = new System.Drawing.Size(85, 16);
            this.lblSubCatDetalle.TabIndex = 24;
            this.lblSubCatDetalle.Text = "SubCategoría:";
            // 
            // lblDescripcionDetalle
            // 
            this.lblDescripcionDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDescripcionDetalle.AutoSize = true;
            this.lblDescripcionDetalle.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionDetalle.ForeColor = System.Drawing.Color.DarkGray;
            this.lblDescripcionDetalle.Location = new System.Drawing.Point(6, 76);
            this.lblDescripcionDetalle.Name = "lblDescripcionDetalle";
            this.lblDescripcionDetalle.Size = new System.Drawing.Size(73, 16);
            this.lblDescripcionDetalle.TabIndex = 25;
            this.lblDescripcionDetalle.Text = "Descripción:";
            // 
            // lblProveedorDetalle
            // 
            this.lblProveedorDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProveedorDetalle.AutoSize = true;
            this.lblProveedorDetalle.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedorDetalle.ForeColor = System.Drawing.Color.DarkGray;
            this.lblProveedorDetalle.Location = new System.Drawing.Point(510, 76);
            this.lblProveedorDetalle.Name = "lblProveedorDetalle";
            this.lblProveedorDetalle.Size = new System.Drawing.Size(63, 16);
            this.lblProveedorDetalle.TabIndex = 26;
            this.lblProveedorDetalle.Text = "Proveedor";
            // 
            // lblCantStock
            // 
            this.lblCantStock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCantStock.AutoSize = true;
            this.lblCantStock.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantStock.ForeColor = System.Drawing.Color.DarkGray;
            this.lblCantStock.Location = new System.Drawing.Point(6, 124);
            this.lblCantStock.Name = "lblCantStock";
            this.lblCantStock.Size = new System.Drawing.Size(110, 16);
            this.lblCantStock.TabIndex = 27;
            this.lblCantStock.Text = "Cantidad en Stock:";
            // 
            // lblCosto
            // 
            this.lblCosto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCosto.AutoSize = true;
            this.lblCosto.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCosto.ForeColor = System.Drawing.Color.DarkGray;
            this.lblCosto.Location = new System.Drawing.Point(130, 124);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(43, 16);
            this.lblCosto.TabIndex = 28;
            this.lblCosto.Text = "Costo:";
            // 
            // lblGanancia
            // 
            this.lblGanancia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGanancia.AutoSize = true;
            this.lblGanancia.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGanancia.ForeColor = System.Drawing.Color.DarkGray;
            this.lblGanancia.Location = new System.Drawing.Point(252, 124);
            this.lblGanancia.Name = "lblGanancia";
            this.lblGanancia.Size = new System.Drawing.Size(69, 16);
            this.lblGanancia.TabIndex = 29;
            this.lblGanancia.Text = "%Ganancia:";
            // 
            // lblPrecioVenta
            // 
            this.lblPrecioVenta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrecioVenta.AutoSize = true;
            this.lblPrecioVenta.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioVenta.ForeColor = System.Drawing.Color.DarkGray;
            this.lblPrecioVenta.Location = new System.Drawing.Point(578, 124);
            this.lblPrecioVenta.Name = "lblPrecioVenta";
            this.lblPrecioVenta.Size = new System.Drawing.Size(93, 16);
            this.lblPrecioVenta.TabIndex = 30;
            this.lblPrecioVenta.Text = "Precio de venta:";
            // 
            // panelDetalle
            // 
            this.panelDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.panelDetalle.Location = new System.Drawing.Point(19, 317);
            this.panelDetalle.Name = "panelDetalle";
            this.panelDetalle.Size = new System.Drawing.Size(711, 169);
            this.panelDetalle.TabIndex = 31;
            this.panelDetalle.Visible = false;
            // 
            // lblDetalle
            // 
            this.lblDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDetalle.AutoSize = true;
            this.lblDetalle.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(109)))), ((int)(((byte)(190)))));
            this.lblDetalle.Location = new System.Drawing.Point(2, 2);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Size = new System.Drawing.Size(125, 19);
            this.lblDetalle.TabIndex = 60;
            this.lblDetalle.Text = "Detalle de artículo:";
            // 
            // lblConsulta
            // 
            this.lblConsulta.AutoSize = true;
            this.lblConsulta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblConsulta.Font = new System.Drawing.Font("Segoe UI Variable Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsulta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(89)))), ((int)(((byte)(160)))));
            this.lblConsulta.Location = new System.Drawing.Point(12, 17);
            this.lblConsulta.Name = "lblConsulta";
            this.lblConsulta.Size = new System.Drawing.Size(220, 32);
            this.lblConsulta.TabIndex = 50;
            this.lblConsulta.Text = "Consulta Articulo:";
            // 
            // frmArtConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(29)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(749, 499);
            this.Controls.Add(this.lblConsulta);
            this.Controls.Add(this.lblProovedor);
            this.Controls.Add(this.lblDescrip);
            this.Controls.Add(this.lblSubCat);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgvArticulos);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.cmbProveedor);
            this.Controls.Add(this.cmbSubcategoria);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.cmbDescripcion);
            this.Controls.Add(this.panelDetalle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmArtConsultas";
            this.Text = "frmArtConsultas";
            this.Load += new System.EventHandler(this.frmArtConsultas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            this.panelDetalle.ResumeLayout(false);
            this.panelDetalle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDescripcion;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.ComboBox cmbSubcategoria;
        private System.Windows.Forms.ComboBox cmbProveedor;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.TextBox txtCodigoDetalle;
        private System.Windows.Forms.TextBox txtCatDetalle;
        private System.Windows.Forms.TextBox txtSubCatDetalle;
        private System.Windows.Forms.TextBox txtDescDetalle;
        private System.Windows.Forms.TextBox txtProvDetalle;
        private System.Windows.Forms.TextBox txtStockDetalle;
        private System.Windows.Forms.TextBox txtCostoDetalle;
        private System.Windows.Forms.TextBox txtGananciaDetalle;
        private System.Windows.Forms.TextBox txtPrecioVentaDetalle;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblSubCat;
        private System.Windows.Forms.Label lblDescrip;
        private System.Windows.Forms.Label lblProovedor;
        private System.Windows.Forms.Label lblCodigoDetalle;
        private System.Windows.Forms.Label lblCategoriaDetalle;
        private System.Windows.Forms.Label lblSubCatDetalle;
        private System.Windows.Forms.Label lblDescripcionDetalle;
        private System.Windows.Forms.Label lblProveedorDetalle;
        private System.Windows.Forms.Label lblCantStock;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.Label lblGanancia;
        private System.Windows.Forms.Label lblPrecioVenta;
        private System.Windows.Forms.Panel panelDetalle;
        private System.Windows.Forms.Label lblConsulta;
        private System.Windows.Forms.Label lblDetalle;
    }
}