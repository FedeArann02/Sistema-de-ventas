namespace Ventas_Hardware
{
    partial class frmCliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelDatosEncabezado = new System.Windows.Forms.Panel();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblDatosCliente = new System.Windows.Forms.Label();
            this.lblNombreAlt = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDoc = new System.Windows.Forms.TextBox();
            this.lblDocumentacion = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtEntidad = new System.Windows.Forms.TextBox();
            this.lblEmpresaEntidad = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.cmbNombres = new System.Windows.Forms.ComboBox();
            this.lbNombreBuscar = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblDocBuscar = new System.Windows.Forms.Label();
            this.lblClientes = new System.Windows.Forms.Label();
            this.dgvRemPres = new System.Windows.Forms.DataGridView();
            this.panelRemitos_Presupuestos = new System.Windows.Forms.Panel();
            this.dgvRemPresDetalle = new System.Windows.Forms.DataGridView();
            this.C_CodArt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_PrecioUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Pxcant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbRemPres = new System.Windows.Forms.ComboBox();
            this.lblVer = new System.Windows.Forms.Label();
            this.lblDetalle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCompras = new System.Windows.Forms.Label();
            this.txtCompras = new System.Windows.Forms.TextBox();
            this.lblPagos = new System.Windows.Forms.Label();
            this.txtPagos = new System.Windows.Forms.TextBox();
            this.lblDeuda = new System.Windows.Forms.Label();
            this.txtDeudas = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnPagar = new System.Windows.Forms.Button();
            this.panelRegistrarPagos = new System.Windows.Forms.Panel();
            this.lblRegistrarPagos = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.panelDatosEncabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRemPres)).BeginInit();
            this.panelRemitos_Presupuestos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRemPresDetalle)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelRegistrarPagos.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDatosEncabezado
            // 
            this.panelDatosEncabezado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(39)))), ((int)(((byte)(100)))));
            this.panelDatosEncabezado.Controls.Add(this.lblApellido);
            this.panelDatosEncabezado.Controls.Add(this.txtApellido);
            this.panelDatosEncabezado.Controls.Add(this.lblDatosCliente);
            this.panelDatosEncabezado.Controls.Add(this.lblNombreAlt);
            this.panelDatosEncabezado.Controls.Add(this.lblMail);
            this.panelDatosEncabezado.Controls.Add(this.lblTel);
            this.panelDatosEncabezado.Controls.Add(this.txtTelefono);
            this.panelDatosEncabezado.Controls.Add(this.txtNombre);
            this.panelDatosEncabezado.Controls.Add(this.txtDoc);
            this.panelDatosEncabezado.Controls.Add(this.lblDocumentacion);
            this.panelDatosEncabezado.Controls.Add(this.txtEmail);
            this.panelDatosEncabezado.Controls.Add(this.txtEntidad);
            this.panelDatosEncabezado.Controls.Add(this.lblEmpresaEntidad);
            this.panelDatosEncabezado.Controls.Add(this.txtDireccion);
            this.panelDatosEncabezado.Controls.Add(this.lblDireccion);
            this.panelDatosEncabezado.Location = new System.Drawing.Point(21, 69);
            this.panelDatosEncabezado.Name = "panelDatosEncabezado";
            this.panelDatosEncabezado.Size = new System.Drawing.Size(706, 120);
            this.panelDatosEncabezado.TabIndex = 52;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.ForeColor = System.Drawing.Color.White;
            this.lblApellido.Location = new System.Drawing.Point(158, 21);
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
            this.txtApellido.Location = new System.Drawing.Point(161, 40);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(137, 22);
            this.txtApellido.TabIndex = 61;
            this.txtApellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDatosCliente
            // 
            this.lblDatosCliente.AutoSize = true;
            this.lblDatosCliente.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(109)))), ((int)(((byte)(190)))));
            this.lblDatosCliente.Location = new System.Drawing.Point(0, 0);
            this.lblDatosCliente.Name = "lblDatosCliente";
            this.lblDatosCliente.Size = new System.Drawing.Size(115, 19);
            this.lblDatosCliente.TabIndex = 60;
            this.lblDatosCliente.Text = "Datos del cliente:";
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
            this.lblMail.Location = new System.Drawing.Point(71, 67);
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
            this.lblTel.Location = new System.Drawing.Point(460, 21);
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
            this.txtTelefono.Location = new System.Drawing.Point(463, 40);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(106, 22);
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
            this.txtNombre.Size = new System.Drawing.Size(137, 22);
            this.txtNombre.TabIndex = 43;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDoc
            // 
            this.txtDoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtDoc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDoc.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoc.ForeColor = System.Drawing.Color.Black;
            this.txtDoc.Location = new System.Drawing.Point(309, 40);
            this.txtDoc.Name = "txtDoc";
            this.txtDoc.Size = new System.Drawing.Size(143, 22);
            this.txtDoc.TabIndex = 37;
            this.txtDoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDocumentacion
            // 
            this.lblDocumentacion.AutoSize = true;
            this.lblDocumentacion.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocumentacion.ForeColor = System.Drawing.Color.White;
            this.lblDocumentacion.Location = new System.Drawing.Point(306, 21);
            this.lblDocumentacion.Name = "lblDocumentacion";
            this.lblDocumentacion.Size = new System.Drawing.Size(93, 16);
            this.lblDocumentacion.TabIndex = 38;
            this.lblDocumentacion.Text = "DNI/CUIL/CUIT:";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.Location = new System.Drawing.Point(74, 86);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(280, 22);
            this.txtEmail.TabIndex = 47;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEntidad
            // 
            this.txtEntidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtEntidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEntidad.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEntidad.ForeColor = System.Drawing.Color.Black;
            this.txtEntidad.Location = new System.Drawing.Point(580, 40);
            this.txtEntidad.Name = "txtEntidad";
            this.txtEntidad.Size = new System.Drawing.Size(116, 22);
            this.txtEntidad.TabIndex = 35;
            this.txtEntidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblEmpresaEntidad
            // 
            this.lblEmpresaEntidad.AutoSize = true;
            this.lblEmpresaEntidad.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpresaEntidad.ForeColor = System.Drawing.Color.White;
            this.lblEmpresaEntidad.Location = new System.Drawing.Point(577, 21);
            this.lblEmpresaEntidad.Name = "lblEmpresaEntidad";
            this.lblEmpresaEntidad.Size = new System.Drawing.Size(110, 16);
            this.lblEmpresaEntidad.TabIndex = 36;
            this.lblEmpresaEntidad.Text = "Empresa o Entidad:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDireccion.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.ForeColor = System.Drawing.Color.Black;
            this.txtDireccion.Location = new System.Drawing.Point(365, 86);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(271, 22);
            this.txtDireccion.TabIndex = 41;
            this.txtDireccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.ForeColor = System.Drawing.Color.White;
            this.lblDireccion.Location = new System.Drawing.Point(362, 67);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(61, 16);
            this.lblDireccion.TabIndex = 42;
            this.lblDireccion.Text = "Dirección:";
            // 
            // cmbNombres
            // 
            this.cmbNombres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmbNombres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbNombres.Font = new System.Drawing.Font("Segoe UI Variable Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNombres.FormattingEnabled = true;
            this.cmbNombres.Location = new System.Drawing.Point(145, 24);
            this.cmbNombres.Margin = new System.Windows.Forms.Padding(1);
            this.cmbNombres.Name = "cmbNombres";
            this.cmbNombres.Size = new System.Drawing.Size(174, 24);
            this.cmbNombres.TabIndex = 56;
            // 
            // lbNombreBuscar
            // 
            this.lbNombreBuscar.AutoSize = true;
            this.lbNombreBuscar.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreBuscar.ForeColor = System.Drawing.Color.White;
            this.lbNombreBuscar.Location = new System.Drawing.Point(142, 5);
            this.lbNombreBuscar.Name = "lbNombreBuscar";
            this.lbNombreBuscar.Size = new System.Drawing.Size(55, 16);
            this.lbNombreBuscar.TabIndex = 55;
            this.lbNombreBuscar.Text = "Nombre:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(341, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(143, 22);
            this.textBox1.TabIndex = 63;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDocBuscar
            // 
            this.lblDocBuscar.AutoSize = true;
            this.lblDocBuscar.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocBuscar.ForeColor = System.Drawing.Color.White;
            this.lblDocBuscar.Location = new System.Drawing.Point(338, 7);
            this.lblDocBuscar.Name = "lblDocBuscar";
            this.lblDocBuscar.Size = new System.Drawing.Size(93, 16);
            this.lblDocBuscar.TabIndex = 64;
            this.lblDocBuscar.Text = "DNI/CUIL/CUIT:";
            // 
            // lblClientes
            // 
            this.lblClientes.AutoSize = true;
            this.lblClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClientes.Font = new System.Drawing.Font("Segoe UI Variable Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(89)))), ((int)(((byte)(160)))));
            this.lblClientes.Location = new System.Drawing.Point(12, 17);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(112, 32);
            this.lblClientes.TabIndex = 65;
            this.lblClientes.Text = "Clientes:";
            // 
            // dgvRemPres
            // 
            this.dgvRemPres.AllowUserToAddRows = false;
            this.dgvRemPres.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(39)))), ((int)(((byte)(100)))));
            this.dgvRemPres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRemPres.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvRemPres.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI Variable Display", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.NullValue = null;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRemPres.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvRemPres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI Variable Display", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRemPres.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvRemPres.EnableHeadersVisualStyles = false;
            this.dgvRemPres.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(39)))), ((int)(((byte)(100)))));
            this.dgvRemPres.Location = new System.Drawing.Point(12, 55);
            this.dgvRemPres.Name = "dgvRemPres";
            this.dgvRemPres.ReadOnly = true;
            this.dgvRemPres.RowHeadersVisible = false;
            this.dgvRemPres.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRemPres.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRemPres.Size = new System.Drawing.Size(163, 136);
            this.dgvRemPres.TabIndex = 66;
            // 
            // panelRemitos_Presupuestos
            // 
            this.panelRemitos_Presupuestos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(39)))), ((int)(((byte)(100)))));
            this.panelRemitos_Presupuestos.Controls.Add(this.lblDetalle);
            this.panelRemitos_Presupuestos.Controls.Add(this.lblVer);
            this.panelRemitos_Presupuestos.Controls.Add(this.cmbRemPres);
            this.panelRemitos_Presupuestos.Controls.Add(this.dgvRemPresDetalle);
            this.panelRemitos_Presupuestos.Controls.Add(this.dgvRemPres);
            this.panelRemitos_Presupuestos.Location = new System.Drawing.Point(21, 311);
            this.panelRemitos_Presupuestos.Name = "panelRemitos_Presupuestos";
            this.panelRemitos_Presupuestos.Size = new System.Drawing.Size(706, 200);
            this.panelRemitos_Presupuestos.TabIndex = 63;
            // 
            // dgvRemPresDetalle
            // 
            this.dgvRemPresDetalle.AllowUserToAddRows = false;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.IndianRed;
            this.dgvRemPresDetalle.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvRemPresDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRemPresDetalle.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(39)))), ((int)(((byte)(100)))));
            this.dgvRemPresDetalle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRemPresDetalle.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRemPresDetalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvRemPresDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRemPresDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.C_CodArt,
            this.C_Descripcion,
            this.C_PrecioUnit,
            this.C_Cantidad,
            this.C_Pxcant});
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRemPresDetalle.DefaultCellStyle = dataGridViewCellStyle17;
            this.dgvRemPresDetalle.EnableHeadersVisualStyles = false;
            this.dgvRemPresDetalle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(99)))), ((int)(((byte)(170)))));
            this.dgvRemPresDetalle.Location = new System.Drawing.Point(181, 27);
            this.dgvRemPresDetalle.Name = "dgvRemPresDetalle";
            this.dgvRemPresDetalle.ReadOnly = true;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(89)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRemPresDetalle.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvRemPresDetalle.RowHeadersVisible = false;
            this.dgvRemPresDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRemPresDetalle.Size = new System.Drawing.Size(515, 164);
            this.dgvRemPresDetalle.TabIndex = 67;
            // 
            // C_CodArt
            // 
            this.C_CodArt.HeaderText = "Cod. Art.";
            this.C_CodArt.Name = "C_CodArt";
            this.C_CodArt.ReadOnly = true;
            // 
            // C_Descripcion
            // 
            this.C_Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.C_Descripcion.HeaderText = "Descripción";
            this.C_Descripcion.Name = "C_Descripcion";
            this.C_Descripcion.ReadOnly = true;
            // 
            // C_PrecioUnit
            // 
            this.C_PrecioUnit.HeaderText = "P. Unit.";
            this.C_PrecioUnit.Name = "C_PrecioUnit";
            this.C_PrecioUnit.ReadOnly = true;
            // 
            // C_Cantidad
            // 
            this.C_Cantidad.HeaderText = "Cantidad";
            this.C_Cantidad.Name = "C_Cantidad";
            this.C_Cantidad.ReadOnly = true;
            this.C_Cantidad.Width = 55;
            // 
            // C_Pxcant
            // 
            this.C_Pxcant.HeaderText = "P. x Cant.";
            this.C_Pxcant.Name = "C_Pxcant";
            this.C_Pxcant.ReadOnly = true;
            this.C_Pxcant.Width = 150;
            // 
            // cmbRemPres
            // 
            this.cmbRemPres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmbRemPres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbRemPres.Font = new System.Drawing.Font("Segoe UI Variable Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRemPres.FormattingEnabled = true;
            this.cmbRemPres.Items.AddRange(new object[] {
            "REMITOS",
            "PRESUPUESTOS"});
            this.cmbRemPres.Location = new System.Drawing.Point(12, 27);
            this.cmbRemPres.Margin = new System.Windows.Forms.Padding(1);
            this.cmbRemPres.Name = "cmbRemPres";
            this.cmbRemPres.Size = new System.Drawing.Size(163, 24);
            this.cmbRemPres.TabIndex = 66;
            // 
            // lblVer
            // 
            this.lblVer.AutoSize = true;
            this.lblVer.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVer.ForeColor = System.Drawing.Color.White;
            this.lblVer.Location = new System.Drawing.Point(10, 5);
            this.lblVer.Name = "lblVer";
            this.lblVer.Size = new System.Drawing.Size(28, 16);
            this.lblVer.TabIndex = 63;
            this.lblVer.Text = "Ver:";
            // 
            // lblDetalle
            // 
            this.lblDetalle.AutoSize = true;
            this.lblDetalle.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalle.ForeColor = System.Drawing.Color.White;
            this.lblDetalle.Location = new System.Drawing.Point(178, 5);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Size = new System.Drawing.Size(47, 16);
            this.lblDetalle.TabIndex = 68;
            this.lblDetalle.Text = "Detalle:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(39)))), ((int)(((byte)(100)))));
            this.panel1.Controls.Add(this.btnPagar);
            this.panel1.Controls.Add(this.lblDeuda);
            this.panel1.Controls.Add(this.txtDeudas);
            this.panel1.Controls.Add(this.lblPagos);
            this.panel1.Controls.Add(this.txtPagos);
            this.panel1.Controls.Add(this.lblCompras);
            this.panel1.Controls.Add(this.txtCompras);
            this.panel1.Location = new System.Drawing.Point(21, 195);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(443, 110);
            this.panel1.TabIndex = 69;
            // 
            // lblCompras
            // 
            this.lblCompras.AutoSize = true;
            this.lblCompras.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompras.ForeColor = System.Drawing.Color.White;
            this.lblCompras.Location = new System.Drawing.Point(10, 12);
            this.lblCompras.Name = "lblCompras";
            this.lblCompras.Size = new System.Drawing.Size(60, 16);
            this.lblCompras.TabIndex = 64;
            this.lblCompras.Text = "Compras:";
            // 
            // txtCompras
            // 
            this.txtCompras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtCompras.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCompras.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompras.ForeColor = System.Drawing.Color.Black;
            this.txtCompras.Location = new System.Drawing.Point(13, 31);
            this.txtCompras.Name = "txtCompras";
            this.txtCompras.Size = new System.Drawing.Size(119, 22);
            this.txtCompras.TabIndex = 63;
            this.txtCompras.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPagos
            // 
            this.lblPagos.AutoSize = true;
            this.lblPagos.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagos.ForeColor = System.Drawing.Color.White;
            this.lblPagos.Location = new System.Drawing.Point(158, 12);
            this.lblPagos.Name = "lblPagos";
            this.lblPagos.Size = new System.Drawing.Size(42, 16);
            this.lblPagos.TabIndex = 66;
            this.lblPagos.Text = "Pagos:";
            // 
            // txtPagos
            // 
            this.txtPagos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtPagos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPagos.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPagos.ForeColor = System.Drawing.Color.Black;
            this.txtPagos.Location = new System.Drawing.Point(161, 31);
            this.txtPagos.Name = "txtPagos";
            this.txtPagos.Size = new System.Drawing.Size(122, 22);
            this.txtPagos.TabIndex = 65;
            this.txtPagos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDeuda
            // 
            this.lblDeuda.AutoSize = true;
            this.lblDeuda.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeuda.ForeColor = System.Drawing.Color.White;
            this.lblDeuda.Location = new System.Drawing.Point(306, 12);
            this.lblDeuda.Name = "lblDeuda";
            this.lblDeuda.Size = new System.Drawing.Size(44, 16);
            this.lblDeuda.TabIndex = 68;
            this.lblDeuda.Text = "Deuda:";
            // 
            // txtDeudas
            // 
            this.txtDeudas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtDeudas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDeudas.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeudas.ForeColor = System.Drawing.Color.Black;
            this.txtDeudas.Location = new System.Drawing.Point(309, 31);
            this.txtDeudas.Name = "txtDeudas";
            this.txtDeudas.Size = new System.Drawing.Size(122, 22);
            this.txtDeudas.TabIndex = 67;
            this.txtDeudas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.IndianRed;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(649, 20);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(78, 28);
            this.btnLimpiar.TabIndex = 71;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(553, 20);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(78, 28);
            this.btnBuscar.TabIndex = 70;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // btnPagar
            // 
            this.btnPagar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnPagar.FlatAppearance.BorderSize = 0;
            this.btnPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagar.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagar.ForeColor = System.Drawing.Color.White;
            this.btnPagar.Location = new System.Drawing.Point(353, 68);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(78, 28);
            this.btnPagar.TabIndex = 72;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = false;
            // 
            // panelRegistrarPagos
            // 
            this.panelRegistrarPagos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(39)))), ((int)(((byte)(100)))));
            this.panelRegistrarPagos.Controls.Add(this.btnRegistrar);
            this.panelRegistrarPagos.Controls.Add(this.label4);
            this.panelRegistrarPagos.Controls.Add(this.dateTimePicker1);
            this.panelRegistrarPagos.Controls.Add(this.textBox5);
            this.panelRegistrarPagos.Controls.Add(this.lblRegistrarPagos);
            this.panelRegistrarPagos.Enabled = false;
            this.panelRegistrarPagos.Location = new System.Drawing.Point(470, 195);
            this.panelRegistrarPagos.Name = "panelRegistrarPagos";
            this.panelRegistrarPagos.Size = new System.Drawing.Size(257, 110);
            this.panelRegistrarPagos.TabIndex = 73;
            // 
            // lblRegistrarPagos
            // 
            this.lblRegistrarPagos.AutoSize = true;
            this.lblRegistrarPagos.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrarPagos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(109)))), ((int)(((byte)(190)))));
            this.lblRegistrarPagos.Location = new System.Drawing.Point(0, 0);
            this.lblRegistrarPagos.Name = "lblRegistrarPagos";
            this.lblRegistrarPagos.Size = new System.Drawing.Size(108, 19);
            this.lblRegistrarPagos.TabIndex = 63;
            this.lblRegistrarPagos.Text = "Registrar pagos:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(14, 31);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(224, 20);
            this.dateTimePicker1.TabIndex = 64;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(11, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 74;
            this.label4.Text = "Nombre:";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.Color.Black;
            this.textBox5.Location = new System.Drawing.Point(14, 74);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(122, 22);
            this.textBox5.TabIndex = 73;
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(142, 68);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(96, 28);
            this.btnRegistrar.TabIndex = 73;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(29)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(749, 523);
            this.Controls.Add(this.panelRegistrarPagos);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelRemitos_Presupuestos);
            this.Controls.Add(this.lblClientes);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblDocBuscar);
            this.Controls.Add(this.cmbNombres);
            this.Controls.Add(this.lbNombreBuscar);
            this.Controls.Add(this.panelDatosEncabezado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCliente";
            this.Text = "frmCliente";
            this.panelDatosEncabezado.ResumeLayout(false);
            this.panelDatosEncabezado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRemPres)).EndInit();
            this.panelRemitos_Presupuestos.ResumeLayout(false);
            this.panelRemitos_Presupuestos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRemPresDetalle)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelRegistrarPagos.ResumeLayout(false);
            this.panelRegistrarPagos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelDatosEncabezado;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblDatosCliente;
        private System.Windows.Forms.Label lblNombreAlt;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDoc;
        private System.Windows.Forms.Label lblDocumentacion;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtEntidad;
        private System.Windows.Forms.Label lblEmpresaEntidad;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.ComboBox cmbNombres;
        private System.Windows.Forms.Label lbNombreBuscar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblDocBuscar;
        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.DataGridView dgvRemPres;
        private System.Windows.Forms.Panel panelRemitos_Presupuestos;
        private System.Windows.Forms.Label lblVer;
        private System.Windows.Forms.ComboBox cmbRemPres;
        private System.Windows.Forms.DataGridView dgvRemPresDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_CodArt;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_PrecioUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Pxcant;
        private System.Windows.Forms.Label lblDetalle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDeuda;
        private System.Windows.Forms.TextBox txtDeudas;
        private System.Windows.Forms.Label lblPagos;
        private System.Windows.Forms.TextBox txtPagos;
        private System.Windows.Forms.Label lblCompras;
        private System.Windows.Forms.TextBox txtCompras;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Panel panelRegistrarPagos;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblRegistrarPagos;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox5;
    }
}