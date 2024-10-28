namespace Ventas_Hardware.Formularios.Reportes
{
    partial class RemitoPorVendedor
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
            this.dgvRemXvendedor = new System.Windows.Forms.DataGridView();
            this.lblReporteRemito = new System.Windows.Forms.Label();
            this.cmbUsuarios = new System.Windows.Forms.ComboBox();
            this.lblVendedores = new System.Windows.Forms.Label();
            this.lblHasta = new System.Windows.Forms.Label();
            this.lblDesde = new System.Windows.Forms.Label();
            this.dateTimePickerHasta = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDesde = new System.Windows.Forms.DateTimePicker();
            this.cbxFiltroFecha = new System.Windows.Forms.CheckBox();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRemXvendedor)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRemXvendedor
            // 
            this.dgvRemXvendedor.AllowUserToAddRows = false;
            this.dgvRemXvendedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvRemXvendedor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRemXvendedor.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(39)))), ((int)(((byte)(100)))));
            this.dgvRemXvendedor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRemXvendedor.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvRemXvendedor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Variable Display", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRemXvendedor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRemXvendedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Variable Display", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRemXvendedor.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRemXvendedor.EnableHeadersVisualStyles = false;
            this.dgvRemXvendedor.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(39)))), ((int)(((byte)(100)))));
            this.dgvRemXvendedor.Location = new System.Drawing.Point(350, 79);
            this.dgvRemXvendedor.Name = "dgvRemXvendedor";
            this.dgvRemXvendedor.ReadOnly = true;
            this.dgvRemXvendedor.RowHeadersVisible = false;
            this.dgvRemXvendedor.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRemXvendedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRemXvendedor.Size = new System.Drawing.Size(384, 264);
            this.dgvRemXvendedor.TabIndex = 67;
            // 
            // lblReporteRemito
            // 
            this.lblReporteRemito.AutoSize = true;
            this.lblReporteRemito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblReporteRemito.Font = new System.Drawing.Font("Segoe UI Variable Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReporteRemito.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(89)))), ((int)(((byte)(160)))));
            this.lblReporteRemito.Location = new System.Drawing.Point(12, 17);
            this.lblReporteRemito.Name = "lblReporteRemito";
            this.lblReporteRemito.Size = new System.Drawing.Size(267, 32);
            this.lblReporteRemito.TabIndex = 70;
            this.lblReporteRemito.Text = "Remitos por vendedor";
            // 
            // cmbUsuarios
            // 
            this.cmbUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmbUsuarios.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUsuarios.FormattingEnabled = true;
            this.cmbUsuarios.Location = new System.Drawing.Point(27, 79);
            this.cmbUsuarios.Margin = new System.Windows.Forms.Padding(1);
            this.cmbUsuarios.Name = "cmbUsuarios";
            this.cmbUsuarios.Size = new System.Drawing.Size(202, 24);
            this.cmbUsuarios.TabIndex = 71;
            this.cmbUsuarios.SelectionChangeCommitted += new System.EventHandler(this.cmbUsuarios_SelectionChangeCommitted);
            // 
            // lblVendedores
            // 
            this.lblVendedores.AutoSize = true;
            this.lblVendedores.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendedores.ForeColor = System.Drawing.Color.White;
            this.lblVendedores.Location = new System.Drawing.Point(24, 62);
            this.lblVendedores.Name = "lblVendedores";
            this.lblVendedores.Size = new System.Drawing.Size(114, 16);
            this.lblVendedores.TabIndex = 88;
            this.lblVendedores.Text = "Vendedor / Usuario:";
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Enabled = false;
            this.lblHasta.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHasta.ForeColor = System.Drawing.Color.White;
            this.lblHasta.Location = new System.Drawing.Point(25, 255);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(41, 16);
            this.lblHasta.TabIndex = 92;
            this.lblHasta.Text = "Hasta:";
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Enabled = false;
            this.lblDesde.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesde.ForeColor = System.Drawing.Color.White;
            this.lblDesde.Location = new System.Drawing.Point(24, 199);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(42, 16);
            this.lblDesde.TabIndex = 91;
            this.lblDesde.Text = "Desde:";
            // 
            // dateTimePickerHasta
            // 
            this.dateTimePickerHasta.Enabled = false;
            this.dateTimePickerHasta.Font = new System.Drawing.Font("Segoe UI Variable Display", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerHasta.Location = new System.Drawing.Point(27, 274);
            this.dateTimePickerHasta.MaxDate = new System.DateTime(2059, 1, 25, 0, 0, 0, 0);
            this.dateTimePickerHasta.MinDate = new System.DateTime(2024, 1, 25, 0, 0, 0, 0);
            this.dateTimePickerHasta.Name = "dateTimePickerHasta";
            this.dateTimePickerHasta.Size = new System.Drawing.Size(111, 22);
            this.dateTimePickerHasta.TabIndex = 90;
            this.dateTimePickerHasta.ValueChanged += new System.EventHandler(this.dateTimePickerHasta_ValueChanged);
            // 
            // dateTimePickerDesde
            // 
            this.dateTimePickerDesde.CalendarMonthBackground = System.Drawing.Color.White;
            this.dateTimePickerDesde.CustomFormat = "";
            this.dateTimePickerDesde.Enabled = false;
            this.dateTimePickerDesde.Font = new System.Drawing.Font("Segoe UI Variable Display", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDesde.Location = new System.Drawing.Point(27, 218);
            this.dateTimePickerDesde.MaxDate = new System.DateTime(2059, 12, 25, 0, 0, 0, 0);
            this.dateTimePickerDesde.MinDate = new System.DateTime(2024, 1, 25, 0, 0, 0, 0);
            this.dateTimePickerDesde.Name = "dateTimePickerDesde";
            this.dateTimePickerDesde.Size = new System.Drawing.Size(111, 22);
            this.dateTimePickerDesde.TabIndex = 89;
            this.dateTimePickerDesde.Value = new System.DateTime(2024, 10, 28, 0, 0, 0, 0);
            this.dateTimePickerDesde.ValueChanged += new System.EventHandler(this.dateTimePickerDesde_ValueChanged);
            // 
            // cbxFiltroFecha
            // 
            this.cbxFiltroFecha.AutoSize = true;
            this.cbxFiltroFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxFiltroFecha.ForeColor = System.Drawing.Color.White;
            this.cbxFiltroFecha.Location = new System.Drawing.Point(28, 168);
            this.cbxFiltroFecha.Name = "cbxFiltroFecha";
            this.cbxFiltroFecha.Size = new System.Drawing.Size(56, 19);
            this.cbxFiltroFecha.TabIndex = 93;
            this.cbxFiltroFecha.Text = "Filtro:";
            this.cbxFiltroFecha.UseVisualStyleBackColor = true;
            this.cbxFiltroFecha.CheckedChanged += new System.EventHandler(this.cbxFiltroFecha_CheckedChanged);
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(699, 12);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(35, 30);
            this.btnSalir.TabIndex = 94;
            this.btnSalir.Text = "X";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // RemitoPorVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(49)))), ((int)(((byte)(110)))));
            this.ClientSize = new System.Drawing.Size(746, 370);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.cbxFiltroFecha);
            this.Controls.Add(this.lblHasta);
            this.Controls.Add(this.lblDesde);
            this.Controls.Add(this.dateTimePickerHasta);
            this.Controls.Add(this.dateTimePickerDesde);
            this.Controls.Add(this.lblVendedores);
            this.Controls.Add(this.cmbUsuarios);
            this.Controls.Add(this.lblReporteRemito);
            this.Controls.Add(this.dgvRemXvendedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RemitoPorVendedor";
            this.Opacity = 0.99D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RemitoPorVendedor";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRemXvendedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRemXvendedor;
        private System.Windows.Forms.Label lblReporteRemito;
        private System.Windows.Forms.ComboBox cmbUsuarios;
        private System.Windows.Forms.Label lblVendedores;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.DateTimePicker dateTimePickerHasta;
        private System.Windows.Forms.DateTimePicker dateTimePickerDesde;
        private System.Windows.Forms.CheckBox cbxFiltroFecha;
        private System.Windows.Forms.Button btnSalir;
    }
}