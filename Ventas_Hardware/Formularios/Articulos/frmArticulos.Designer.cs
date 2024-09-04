namespace Ventas_Hardware
{
    partial class frmArticulos
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
            this.panelBarraSuperiorArt = new System.Windows.Forms.Panel();
            this.btnModificaciones_Art = new System.Windows.Forms.Button();
            this.btnAltas_Art = new System.Windows.Forms.Button();
            this.btnConsultas_Art = new System.Windows.Forms.Button();
            this.contenedor = new System.Windows.Forms.Panel();
            this.panelBarraSuperiorArt.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBarraSuperiorArt
            // 
            this.panelBarraSuperiorArt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(79)))), ((int)(((byte)(140)))));
            this.panelBarraSuperiorArt.Controls.Add(this.btnModificaciones_Art);
            this.panelBarraSuperiorArt.Controls.Add(this.btnAltas_Art);
            this.panelBarraSuperiorArt.Controls.Add(this.btnConsultas_Art);
            this.panelBarraSuperiorArt.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarraSuperiorArt.Location = new System.Drawing.Point(0, 0);
            this.panelBarraSuperiorArt.Name = "panelBarraSuperiorArt";
            this.panelBarraSuperiorArt.Size = new System.Drawing.Size(749, 24);
            this.panelBarraSuperiorArt.TabIndex = 0;
            // 
            // btnModificaciones_Art
            // 
            this.btnModificaciones_Art.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(89)))), ((int)(((byte)(160)))));
            this.btnModificaciones_Art.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnModificaciones_Art.FlatAppearance.BorderSize = 0;
            this.btnModificaciones_Art.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificaciones_Art.Font = new System.Drawing.Font("Segoe UI Variable Display", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificaciones_Art.ForeColor = System.Drawing.Color.White;
            this.btnModificaciones_Art.Location = new System.Drawing.Point(164, 0);
            this.btnModificaciones_Art.Name = "btnModificaciones_Art";
            this.btnModificaciones_Art.Size = new System.Drawing.Size(96, 24);
            this.btnModificaciones_Art.TabIndex = 2;
            this.btnModificaciones_Art.Text = "Modificaciones";
            this.btnModificaciones_Art.UseVisualStyleBackColor = false;
            this.btnModificaciones_Art.Click += new System.EventHandler(this.btnModificaciones_Art_Click);
            // 
            // btnAltas_Art
            // 
            this.btnAltas_Art.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(89)))), ((int)(((byte)(160)))));
            this.btnAltas_Art.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAltas_Art.FlatAppearance.BorderSize = 0;
            this.btnAltas_Art.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltas_Art.Font = new System.Drawing.Font("Segoe UI Variable Display", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltas_Art.ForeColor = System.Drawing.Color.White;
            this.btnAltas_Art.Location = new System.Drawing.Point(82, 0);
            this.btnAltas_Art.Name = "btnAltas_Art";
            this.btnAltas_Art.Size = new System.Drawing.Size(82, 24);
            this.btnAltas_Art.TabIndex = 1;
            this.btnAltas_Art.Text = "Altas";
            this.btnAltas_Art.UseVisualStyleBackColor = false;
            this.btnAltas_Art.Click += new System.EventHandler(this.btnAltas_Art_Click);
            // 
            // btnConsultas_Art
            // 
            this.btnConsultas_Art.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(89)))), ((int)(((byte)(160)))));
            this.btnConsultas_Art.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnConsultas_Art.FlatAppearance.BorderSize = 0;
            this.btnConsultas_Art.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultas_Art.Font = new System.Drawing.Font("Segoe UI Variable Display", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultas_Art.ForeColor = System.Drawing.Color.White;
            this.btnConsultas_Art.Location = new System.Drawing.Point(0, 0);
            this.btnConsultas_Art.Name = "btnConsultas_Art";
            this.btnConsultas_Art.Size = new System.Drawing.Size(82, 24);
            this.btnConsultas_Art.TabIndex = 0;
            this.btnConsultas_Art.Text = "Consultas";
            this.btnConsultas_Art.UseVisualStyleBackColor = false;
            this.btnConsultas_Art.Click += new System.EventHandler(this.btnConsultas_Art_Click);
            // 
            // contenedor
            // 
            this.contenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(29)))), ((int)(((byte)(90)))));
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor.Location = new System.Drawing.Point(0, 24);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(749, 499);
            this.contenedor.TabIndex = 2;
            // 
            // frmArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(28)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(749, 523);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.panelBarraSuperiorArt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmArticulos";
            this.Text = "frmArticulos";
            this.panelBarraSuperiorArt.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelBarraSuperiorArt;
        private System.Windows.Forms.Button btnModificaciones_Art;
        private System.Windows.Forms.Button btnAltas_Art;
        private System.Windows.Forms.Button btnConsultas_Art;
        private System.Windows.Forms.Panel contenedor;
    }
}