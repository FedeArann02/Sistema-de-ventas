namespace Ventas_Hardware.Formularios.Administracion.Categoria_Subcat
{
    partial class frmCategorias
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
            this.lblAltaCat = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblNuevaCat = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvCategorias = new System.Windows.Forms.DataGridView();
            this.txtNuevaCategoria = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAltaCat
            // 
            this.lblAltaCat.AutoSize = true;
            this.lblAltaCat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAltaCat.Font = new System.Drawing.Font("Segoe UI Variable Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltaCat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(89)))), ((int)(((byte)(160)))));
            this.lblAltaCat.Location = new System.Drawing.Point(12, 9);
            this.lblAltaCat.Name = "lblAltaCat";
            this.lblAltaCat.Size = new System.Drawing.Size(225, 32);
            this.lblAltaCat.TabIndex = 56;
            this.lblAltaCat.Text = "Alta de Categorías";
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(637, 9);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(35, 30);
            this.btnSalir.TabIndex = 57;
            this.btnSalir.Text = "X";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblNuevaCat
            // 
            this.lblNuevaCat.AutoSize = true;
            this.lblNuevaCat.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevaCat.ForeColor = System.Drawing.Color.White;
            this.lblNuevaCat.Location = new System.Drawing.Point(430, 70);
            this.lblNuevaCat.Name = "lblNuevaCat";
            this.lblNuevaCat.Size = new System.Drawing.Size(98, 16);
            this.lblNuevaCat.TabIndex = 61;
            this.lblNuevaCat.Text = "Nueva categoría:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(551, 118);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(78, 28);
            this.btnAgregar.TabIndex = 60;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvCategorias
            // 
            this.dgvCategorias.AllowUserToAddRows = false;
            this.dgvCategorias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCategorias.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(39)))), ((int)(((byte)(100)))));
            this.dgvCategorias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCategorias.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvCategorias.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Variable Display", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCategorias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Variable Display", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCategorias.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCategorias.EnableHeadersVisualStyles = false;
            this.dgvCategorias.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(39)))), ((int)(((byte)(100)))));
            this.dgvCategorias.Location = new System.Drawing.Point(18, 71);
            this.dgvCategorias.Name = "dgvCategorias";
            this.dgvCategorias.ReadOnly = true;
            this.dgvCategorias.RowHeadersVisible = false;
            this.dgvCategorias.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCategorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategorias.Size = new System.Drawing.Size(368, 143);
            this.dgvCategorias.TabIndex = 59;
            // 
            // txtNuevaCategoria
            // 
            this.txtNuevaCategoria.BackColor = System.Drawing.Color.White;
            this.txtNuevaCategoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNuevaCategoria.Font = new System.Drawing.Font("Segoe UI Variable Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNuevaCategoria.ForeColor = System.Drawing.Color.Black;
            this.txtNuevaCategoria.Location = new System.Drawing.Point(433, 89);
            this.txtNuevaCategoria.Name = "txtNuevaCategoria";
            this.txtNuevaCategoria.Size = new System.Drawing.Size(196, 23);
            this.txtNuevaCategoria.TabIndex = 58;
            this.txtNuevaCategoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(23)))), ((int)(((byte)(84)))));
            this.ClientSize = new System.Drawing.Size(684, 226);
            this.Controls.Add(this.lblNuevaCat);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvCategorias);
            this.Controls.Add(this.txtNuevaCategoria);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblAltaCat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCategorias";
            this.Text = "frmCategorias";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAltaCat;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblNuevaCat;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvCategorias;
        private System.Windows.Forms.TextBox txtNuevaCategoria;
    }
}