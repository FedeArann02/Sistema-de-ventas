namespace Ventas_Hardware
{
    partial class frmClientes_alta
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
            this.lblAltaCliente = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
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
            this.panelDatosEncabezado = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblDatos = new System.Windows.Forms.Label();
            this.panelDatosEncabezado.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAltaCliente
            // 
            this.lblAltaCliente.AutoSize = true;
            this.lblAltaCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAltaCliente.Font = new System.Drawing.Font("Segoe UI Variable Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltaCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(89)))), ((int)(((byte)(160)))));
            this.lblAltaCliente.Location = new System.Drawing.Point(12, 9);
            this.lblAltaCliente.Name = "lblAltaCliente";
            this.lblAltaCliente.Size = new System.Drawing.Size(178, 32);
            this.lblAltaCliente.TabIndex = 51;
            this.lblAltaCliente.Text = "Alta de cliente";
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(653, 9);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(35, 30);
            this.btnSalir.TabIndex = 52;
            this.btnSalir.Text = "X";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.ForeColor = System.Drawing.Color.White;
            this.lblApellido.Location = new System.Drawing.Point(259, 26);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(54, 16);
            this.lblApellido.TabIndex = 76;
            this.lblApellido.Text = "Apellido:";
            // 
            // txtApellido
            // 
            this.txtApellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellido.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.ForeColor = System.Drawing.Color.Black;
            this.txtApellido.Location = new System.Drawing.Point(262, 45);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(137, 22);
            this.txtApellido.TabIndex = 75;
            this.txtApellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNombreAlt
            // 
            this.lblNombreAlt.AutoSize = true;
            this.lblNombreAlt.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreAlt.ForeColor = System.Drawing.Color.White;
            this.lblNombreAlt.Location = new System.Drawing.Point(24, 26);
            this.lblNombreAlt.Name = "lblNombreAlt";
            this.lblNombreAlt.Size = new System.Drawing.Size(55, 16);
            this.lblNombreAlt.TabIndex = 72;
            this.lblNombreAlt.Text = "Nombre:";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMail.ForeColor = System.Drawing.Color.White;
            this.lblMail.Location = new System.Drawing.Point(24, 84);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(39, 16);
            this.lblMail.TabIndex = 74;
            this.lblMail.Text = "Email:";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTel.ForeColor = System.Drawing.Color.White;
            this.lblTel.Location = new System.Drawing.Point(348, 84);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(56, 16);
            this.lblTel.TabIndex = 64;
            this.lblTel.Text = "Teléfono:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefono.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.ForeColor = System.Drawing.Color.Black;
            this.txtTelefono.Location = new System.Drawing.Point(351, 103);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(116, 22);
            this.txtTelefono.TabIndex = 63;
            this.txtTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.Black;
            this.txtNombre.Location = new System.Drawing.Point(27, 45);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(137, 22);
            this.txtNombre.TabIndex = 71;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDoc
            // 
            this.txtDoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtDoc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDoc.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoc.ForeColor = System.Drawing.Color.Black;
            this.txtDoc.Location = new System.Drawing.Point(474, 45);
            this.txtDoc.Name = "txtDoc";
            this.txtDoc.Size = new System.Drawing.Size(143, 22);
            this.txtDoc.TabIndex = 67;
            this.txtDoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDocumentacion
            // 
            this.lblDocumentacion.AutoSize = true;
            this.lblDocumentacion.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocumentacion.ForeColor = System.Drawing.Color.White;
            this.lblDocumentacion.Location = new System.Drawing.Point(471, 26);
            this.lblDocumentacion.Name = "lblDocumentacion";
            this.lblDocumentacion.Size = new System.Drawing.Size(93, 16);
            this.lblDocumentacion.TabIndex = 68;
            this.lblDocumentacion.Text = "DNI/CUIL/CUIT:";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.Location = new System.Drawing.Point(27, 103);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(280, 22);
            this.txtEmail.TabIndex = 73;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEntidad
            // 
            this.txtEntidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtEntidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEntidad.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEntidad.ForeColor = System.Drawing.Color.Black;
            this.txtEntidad.Location = new System.Drawing.Point(501, 103);
            this.txtEntidad.Name = "txtEntidad";
            this.txtEntidad.Size = new System.Drawing.Size(116, 22);
            this.txtEntidad.TabIndex = 65;
            this.txtEntidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblEmpresaEntidad
            // 
            this.lblEmpresaEntidad.AutoSize = true;
            this.lblEmpresaEntidad.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpresaEntidad.ForeColor = System.Drawing.Color.White;
            this.lblEmpresaEntidad.Location = new System.Drawing.Point(498, 84);
            this.lblEmpresaEntidad.Name = "lblEmpresaEntidad";
            this.lblEmpresaEntidad.Size = new System.Drawing.Size(110, 16);
            this.lblEmpresaEntidad.TabIndex = 66;
            this.lblEmpresaEntidad.Text = "Empresa o Entidad:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDireccion.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.ForeColor = System.Drawing.Color.Black;
            this.txtDireccion.Location = new System.Drawing.Point(27, 159);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(280, 22);
            this.txtDireccion.TabIndex = 69;
            this.txtDireccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.ForeColor = System.Drawing.Color.White;
            this.lblDireccion.Location = new System.Drawing.Point(24, 140);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(61, 16);
            this.lblDireccion.TabIndex = 70;
            this.lblDireccion.Text = "Dirección:";
            // 
            // panelDatosEncabezado
            // 
            this.panelDatosEncabezado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(39)))), ((int)(((byte)(100)))));
            this.panelDatosEncabezado.Controls.Add(this.btnGuardar);
            this.panelDatosEncabezado.Controls.Add(this.lblDatos);
            this.panelDatosEncabezado.Controls.Add(this.txtDoc);
            this.panelDatosEncabezado.Controls.Add(this.txtEntidad);
            this.panelDatosEncabezado.Controls.Add(this.lblEmpresaEntidad);
            this.panelDatosEncabezado.Controls.Add(this.lblMail);
            this.panelDatosEncabezado.Controls.Add(this.lblApellido);
            this.panelDatosEncabezado.Controls.Add(this.txtTelefono);
            this.panelDatosEncabezado.Controls.Add(this.lblTel);
            this.panelDatosEncabezado.Controls.Add(this.lblDocumentacion);
            this.panelDatosEncabezado.Controls.Add(this.txtApellido);
            this.panelDatosEncabezado.Controls.Add(this.txtEmail);
            this.panelDatosEncabezado.Controls.Add(this.txtNombre);
            this.panelDatosEncabezado.Controls.Add(this.lblNombreAlt);
            this.panelDatosEncabezado.Controls.Add(this.txtDireccion);
            this.panelDatosEncabezado.Controls.Add(this.lblDireccion);
            this.panelDatosEncabezado.Location = new System.Drawing.Point(30, 66);
            this.panelDatosEncabezado.Name = "panelDatosEncabezado";
            this.panelDatosEncabezado.Size = new System.Drawing.Size(641, 206);
            this.panelDatosEncabezado.TabIndex = 77;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(539, 153);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(78, 28);
            this.btnGuardar.TabIndex = 77;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(109)))), ((int)(((byte)(190)))));
            this.lblDatos.Location = new System.Drawing.Point(0, 0);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(108, 19);
            this.lblDatos.TabIndex = 60;
            this.lblDatos.Text = "Datos de cliente";
            // 
            // frmClientes_alta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(23)))), ((int)(((byte)(84)))));
            this.ClientSize = new System.Drawing.Size(700, 300);
            this.Controls.Add(this.panelDatosEncabezado);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblAltaCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmClientes_alta";
            this.Text = "frmClientes_alta";
            this.panelDatosEncabezado.ResumeLayout(false);
            this.panelDatosEncabezado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAltaCliente;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;
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
        private System.Windows.Forms.Panel panelDatosEncabezado;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.Button btnGuardar;
    }
}