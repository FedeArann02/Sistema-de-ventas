namespace Ventas_Hardware
{
    partial class PantallaPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaPrincipal));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.oPCIONESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mstripBarra = new System.Windows.Forms.MenuStrip();
            this.opciones = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesión = new System.Windows.Forms.ToolStripMenuItem();
            this.administrar = new System.Windows.Forms.ToolStripMenuItem();
            this.vendedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Cliente_alta_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Cliente_mod_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Proveedores_alta_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Proveedores_mod_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriasSubcategoríasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Categorias_alta_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.panBarraLateral = new System.Windows.Forms.Panel();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnListaCompras = new System.Windows.Forms.Button();
            this.btnRemitos = new System.Windows.Forms.Button();
            this.btnPresupuestos = new System.Windows.Forms.Button();
            this.btnProveedores = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnArticulos = new System.Windows.Forms.Button();
            this.lblInicio = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panContenedor = new System.Windows.Forms.Panel();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.mstripBarra.SuspendLayout();
            this.panBarraLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oPCIONESToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(132, 26);
            // 
            // oPCIONESToolStripMenuItem
            // 
            this.oPCIONESToolStripMenuItem.Name = "oPCIONESToolStripMenuItem";
            this.oPCIONESToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.oPCIONESToolStripMenuItem.Text = "OPCIONES";
            // 
            // mstripBarra
            // 
            this.mstripBarra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(38)))), ((int)(((byte)(65)))));
            this.mstripBarra.Font = new System.Drawing.Font("Segoe UI Variable Display", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mstripBarra.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opciones,
            this.administrar});
            this.mstripBarra.Location = new System.Drawing.Point(0, 0);
            this.mstripBarra.Name = "mstripBarra";
            this.mstripBarra.Size = new System.Drawing.Size(900, 27);
            this.mstripBarra.TabIndex = 1;
            // 
            // opciones
            // 
            this.opciones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesión});
            this.opciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(79)))), ((int)(((byte)(130)))));
            this.opciones.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(38)))), ((int)(((byte)(65)))));
            this.opciones.Name = "opciones";
            this.opciones.Size = new System.Drawing.Size(76, 23);
            this.opciones.Text = "opciones";
            // 
            // cerrarSesión
            // 
            this.cerrarSesión.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(38)))), ((int)(((byte)(65)))));
            this.cerrarSesión.ForeColor = System.Drawing.Color.White;
            this.cerrarSesión.Name = "cerrarSesión";
            this.cerrarSesión.Size = new System.Drawing.Size(180, 24);
            this.cerrarSesión.Text = "cerrar sesión";
            this.cerrarSesión.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
            // 
            // administrar
            // 
            this.administrar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vendedoresToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.proveedoresToolStripMenuItem,
            this.categoriasSubcategoríasToolStripMenuItem});
            this.administrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(79)))), ((int)(((byte)(130)))));
            this.administrar.Name = "administrar";
            this.administrar.Size = new System.Drawing.Size(90, 23);
            this.administrar.Text = "administrar";
            // 
            // vendedoresToolStripMenuItem
            // 
            this.vendedoresToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(38)))), ((int)(((byte)(65)))));
            this.vendedoresToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.vendedoresToolStripMenuItem.Name = "vendedoresToolStripMenuItem";
            this.vendedoresToolStripMenuItem.Size = new System.Drawing.Size(237, 24);
            this.vendedoresToolStripMenuItem.Text = "vendedores";
            this.vendedoresToolStripMenuItem.Click += new System.EventHandler(this.vendedoresToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(38)))), ((int)(((byte)(65)))));
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Cliente_alta_menu,
            this.Cliente_mod_menu});
            this.clientesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(237, 24);
            this.clientesToolStripMenuItem.Text = "clientes";
            // 
            // Cliente_alta_menu
            // 
            this.Cliente_alta_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(38)))), ((int)(((byte)(65)))));
            this.Cliente_alta_menu.ForeColor = System.Drawing.Color.White;
            this.Cliente_alta_menu.Name = "Cliente_alta_menu";
            this.Cliente_alta_menu.Size = new System.Drawing.Size(156, 24);
            this.Cliente_alta_menu.Text = "alta";
            this.Cliente_alta_menu.Click += new System.EventHandler(this.Cliente_alta_menu_Click);
            // 
            // Cliente_mod_menu
            // 
            this.Cliente_mod_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(38)))), ((int)(((byte)(65)))));
            this.Cliente_mod_menu.ForeColor = System.Drawing.Color.White;
            this.Cliente_mod_menu.Name = "Cliente_mod_menu";
            this.Cliente_mod_menu.Size = new System.Drawing.Size(156, 24);
            this.Cliente_mod_menu.Text = "modificación";
            this.Cliente_mod_menu.Click += new System.EventHandler(this.Cliente_mod_menu_Click);
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(38)))), ((int)(((byte)(65)))));
            this.proveedoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Proveedores_alta_menu,
            this.Proveedores_mod_menu});
            this.proveedoresToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(237, 24);
            this.proveedoresToolStripMenuItem.Text = "proveedores";
            // 
            // Proveedores_alta_menu
            // 
            this.Proveedores_alta_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(38)))), ((int)(((byte)(65)))));
            this.Proveedores_alta_menu.ForeColor = System.Drawing.Color.White;
            this.Proveedores_alta_menu.Name = "Proveedores_alta_menu";
            this.Proveedores_alta_menu.Size = new System.Drawing.Size(156, 24);
            this.Proveedores_alta_menu.Text = "alta";
            this.Proveedores_alta_menu.Click += new System.EventHandler(this.Proveedores_alta_menu_Click);
            // 
            // Proveedores_mod_menu
            // 
            this.Proveedores_mod_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(38)))), ((int)(((byte)(65)))));
            this.Proveedores_mod_menu.ForeColor = System.Drawing.Color.White;
            this.Proveedores_mod_menu.Name = "Proveedores_mod_menu";
            this.Proveedores_mod_menu.Size = new System.Drawing.Size(156, 24);
            this.Proveedores_mod_menu.Text = "modificación";
            this.Proveedores_mod_menu.Click += new System.EventHandler(this.Proveedores_mod_menu_Click);
            // 
            // categoriasSubcategoríasToolStripMenuItem
            // 
            this.categoriasSubcategoríasToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(38)))), ((int)(((byte)(65)))));
            this.categoriasSubcategoríasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Categorias_alta_menu});
            this.categoriasSubcategoríasToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.categoriasSubcategoríasToolStripMenuItem.Name = "categoriasSubcategoríasToolStripMenuItem";
            this.categoriasSubcategoríasToolStripMenuItem.Size = new System.Drawing.Size(237, 24);
            this.categoriasSubcategoríasToolStripMenuItem.Text = "Categorias/Subcategorías";
            // 
            // Categorias_alta_menu
            // 
            this.Categorias_alta_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(38)))), ((int)(((byte)(65)))));
            this.Categorias_alta_menu.ForeColor = System.Drawing.Color.White;
            this.Categorias_alta_menu.Name = "Categorias_alta_menu";
            this.Categorias_alta_menu.Size = new System.Drawing.Size(102, 24);
            this.Categorias_alta_menu.Text = "Alta";
            this.Categorias_alta_menu.Click += new System.EventHandler(this.Categorias_alta_menu_Click);
            // 
            // panBarraLateral
            // 
            this.panBarraLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(79)))), ((int)(((byte)(120)))));
            this.panBarraLateral.Controls.Add(this.btnProveedores);
            this.panBarraLateral.Controls.Add(this.btnPresupuestos);
            this.panBarraLateral.Controls.Add(this.btnReportes);
            this.panBarraLateral.Controls.Add(this.btnRemitos);
            this.panBarraLateral.Controls.Add(this.btnListaCompras);
            this.panBarraLateral.Controls.Add(this.btnClientes);
            this.panBarraLateral.Controls.Add(this.btnArticulos);
            this.panBarraLateral.Controls.Add(this.lblInicio);
            this.panBarraLateral.Controls.Add(this.pictureBox1);
            this.panBarraLateral.Controls.Add(this.pictureBox2);
            this.panBarraLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panBarraLateral.Location = new System.Drawing.Point(0, 27);
            this.panBarraLateral.Name = "panBarraLateral";
            this.panBarraLateral.Size = new System.Drawing.Size(151, 523);
            this.panBarraLateral.TabIndex = 19;
            // 
            // btnReportes
            // 
            this.btnReportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(79)))), ((int)(((byte)(130)))));
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.ForeColor = System.Drawing.Color.White;
            this.btnReportes.Location = new System.Drawing.Point(-1, 309);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(150, 30);
            this.btnReportes.TabIndex = 7;
            this.btnReportes.Text = "REPORTES";
            this.btnReportes.UseVisualStyleBackColor = false;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnListaCompras
            // 
            this.btnListaCompras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(79)))), ((int)(((byte)(130)))));
            this.btnListaCompras.FlatAppearance.BorderSize = 0;
            this.btnListaCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListaCompras.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListaCompras.ForeColor = System.Drawing.Color.White;
            this.btnListaCompras.Location = new System.Drawing.Point(-2, 381);
            this.btnListaCompras.Name = "btnListaCompras";
            this.btnListaCompras.Size = new System.Drawing.Size(150, 51);
            this.btnListaCompras.TabIndex = 8;
            this.btnListaCompras.Text = "LISTA DE\r\nCOMPRAS\r\n";
            this.btnListaCompras.UseVisualStyleBackColor = false;
            this.btnListaCompras.Click += new System.EventHandler(this.btnListaCompras_Click);
            // 
            // btnRemitos
            // 
            this.btnRemitos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(79)))), ((int)(((byte)(130)))));
            this.btnRemitos.FlatAppearance.BorderSize = 0;
            this.btnRemitos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemitos.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemitos.ForeColor = System.Drawing.Color.White;
            this.btnRemitos.Location = new System.Drawing.Point(-1, 273);
            this.btnRemitos.Name = "btnRemitos";
            this.btnRemitos.Size = new System.Drawing.Size(150, 30);
            this.btnRemitos.TabIndex = 6;
            this.btnRemitos.Text = "REMITOS";
            this.btnRemitos.UseVisualStyleBackColor = false;
            this.btnRemitos.Click += new System.EventHandler(this.btnRemitos_Click);
            // 
            // btnPresupuestos
            // 
            this.btnPresupuestos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(79)))), ((int)(((byte)(130)))));
            this.btnPresupuestos.FlatAppearance.BorderSize = 0;
            this.btnPresupuestos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPresupuestos.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPresupuestos.ForeColor = System.Drawing.Color.White;
            this.btnPresupuestos.Location = new System.Drawing.Point(1, 237);
            this.btnPresupuestos.Name = "btnPresupuestos";
            this.btnPresupuestos.Size = new System.Drawing.Size(150, 30);
            this.btnPresupuestos.TabIndex = 5;
            this.btnPresupuestos.Text = "PRESUPUESTOS";
            this.btnPresupuestos.UseVisualStyleBackColor = false;
            this.btnPresupuestos.Click += new System.EventHandler(this.btnPresupuestos_Click);
            // 
            // btnProveedores
            // 
            this.btnProveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(79)))), ((int)(((byte)(130)))));
            this.btnProveedores.FlatAppearance.BorderSize = 0;
            this.btnProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProveedores.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProveedores.ForeColor = System.Drawing.Color.White;
            this.btnProveedores.Location = new System.Drawing.Point(-1, 345);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Size = new System.Drawing.Size(150, 30);
            this.btnProveedores.TabIndex = 4;
            this.btnProveedores.Text = "PROVEEDORES";
            this.btnProveedores.UseVisualStyleBackColor = false;
            this.btnProveedores.Click += new System.EventHandler(this.btnProveedores_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(79)))), ((int)(((byte)(130)))));
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.Color.White;
            this.btnClientes.Location = new System.Drawing.Point(1, 201);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(150, 30);
            this.btnClientes.TabIndex = 3;
            this.btnClientes.Text = "CLIENTES";
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnArticulos
            // 
            this.btnArticulos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(79)))), ((int)(((byte)(130)))));
            this.btnArticulos.FlatAppearance.BorderSize = 0;
            this.btnArticulos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArticulos.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArticulos.ForeColor = System.Drawing.Color.White;
            this.btnArticulos.Location = new System.Drawing.Point(0, 165);
            this.btnArticulos.Name = "btnArticulos";
            this.btnArticulos.Size = new System.Drawing.Size(150, 30);
            this.btnArticulos.TabIndex = 2;
            this.btnArticulos.Text = "ARTICULOS";
            this.btnArticulos.UseVisualStyleBackColor = false;
            this.btnArticulos.Click += new System.EventHandler(this.btnArticulos_Click);
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblInicio.Location = new System.Drawing.Point(50, 110);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(53, 21);
            this.lblInicio.TabIndex = 1;
            this.lblInicio.Text = "Inicio";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(28, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 118);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panContenedor
            // 
            this.panContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panContenedor.Location = new System.Drawing.Point(151, 27);
            this.panContenedor.Name = "panContenedor";
            this.panContenedor.Size = new System.Drawing.Size(749, 523);
            this.panContenedor.TabIndex = 20;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(38)))), ((int)(((byte)(65)))));
            this.lblUser.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(705, 5);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(51, 16);
            this.lblUser.TabIndex = 21;
            this.lblUser.Text = "Usuario:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(38)))), ((int)(((byte)(65)))));
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI Variable Small", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(752, 5);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(66, 16);
            this.lblUsuario.TabIndex = 22;
            this.lblUsuario.Text = "lblUsuario";
            // 
            // PantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.panContenedor);
            this.Controls.Add(this.panBarraLateral);
            this.Controls.Add(this.mstripBarra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.mstripBarra;
            this.Name = "PantallaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.PantallaPrincipal_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.mstripBarra.ResumeLayout(false);
            this.mstripBarra.PerformLayout();
            this.panBarraLateral.ResumeLayout(false);
            this.panBarraLateral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem oPCIONESToolStripMenuItem;
        private System.Windows.Forms.MenuStrip mstripBarra;
        private System.Windows.Forms.ToolStripMenuItem opciones;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesión;
        private System.Windows.Forms.ToolStripMenuItem administrar;
        private System.Windows.Forms.ToolStripMenuItem vendedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Cliente_alta_menu;
        private System.Windows.Forms.ToolStripMenuItem Cliente_mod_menu;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Proveedores_alta_menu;
        private System.Windows.Forms.ToolStripMenuItem Proveedores_mod_menu;
        private System.Windows.Forms.Panel panBarraLateral;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnListaCompras;
        private System.Windows.Forms.Button btnRemitos;
        private System.Windows.Forms.Button btnPresupuestos;
        private System.Windows.Forms.Button btnProveedores;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnArticulos;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panContenedor;
        private System.Windows.Forms.ToolStripMenuItem categoriasSubcategoríasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Categorias_alta_menu;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblUsuario;
    }
}

