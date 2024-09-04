namespace Ventas_Hardware
{
    partial class frmPresupuestos
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
            this.btnBuscarPresupuesto = new System.Windows.Forms.Button();
            this.btnAltaPresupuesto = new System.Windows.Forms.Button();
            this.panel_contenedor = new System.Windows.Forms.Panel();
            this.panelBarraSuperiorArt.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBarraSuperiorArt
            // 
            this.panelBarraSuperiorArt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(79)))), ((int)(((byte)(140)))));
            this.panelBarraSuperiorArt.Controls.Add(this.btnBuscarPresupuesto);
            this.panelBarraSuperiorArt.Controls.Add(this.btnAltaPresupuesto);
            this.panelBarraSuperiorArt.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarraSuperiorArt.Location = new System.Drawing.Point(0, 0);
            this.panelBarraSuperiorArt.Name = "panelBarraSuperiorArt";
            this.panelBarraSuperiorArt.Size = new System.Drawing.Size(749, 24);
            this.panelBarraSuperiorArt.TabIndex = 1;
            // 
            // btnBuscarPresupuesto
            // 
            this.btnBuscarPresupuesto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(89)))), ((int)(((byte)(160)))));
            this.btnBuscarPresupuesto.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBuscarPresupuesto.FlatAppearance.BorderSize = 0;
            this.btnBuscarPresupuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarPresupuesto.Font = new System.Drawing.Font("Segoe UI Variable Display", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarPresupuesto.ForeColor = System.Drawing.Color.White;
            this.btnBuscarPresupuesto.Location = new System.Drawing.Point(112, 0);
            this.btnBuscarPresupuesto.Name = "btnBuscarPresupuesto";
            this.btnBuscarPresupuesto.Size = new System.Drawing.Size(118, 24);
            this.btnBuscarPresupuesto.TabIndex = 1;
            this.btnBuscarPresupuesto.Text = "Buscar Presupuesto";
            this.btnBuscarPresupuesto.UseVisualStyleBackColor = false;
            this.btnBuscarPresupuesto.Click += new System.EventHandler(this.btnBuscarPresupuesto_Click);
            // 
            // btnAltaPresupuesto
            // 
            this.btnAltaPresupuesto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(89)))), ((int)(((byte)(160)))));
            this.btnAltaPresupuesto.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAltaPresupuesto.FlatAppearance.BorderSize = 0;
            this.btnAltaPresupuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltaPresupuesto.Font = new System.Drawing.Font("Segoe UI Variable Display", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltaPresupuesto.ForeColor = System.Drawing.Color.White;
            this.btnAltaPresupuesto.Location = new System.Drawing.Point(0, 0);
            this.btnAltaPresupuesto.Name = "btnAltaPresupuesto";
            this.btnAltaPresupuesto.Size = new System.Drawing.Size(112, 24);
            this.btnAltaPresupuesto.TabIndex = 0;
            this.btnAltaPresupuesto.Text = "Alta Presupuesto";
            this.btnAltaPresupuesto.UseVisualStyleBackColor = false;
            this.btnAltaPresupuesto.Click += new System.EventHandler(this.btnAltaPresupuesto_Click);
            // 
            // panel_contenedor
            // 
            this.panel_contenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel_contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_contenedor.Location = new System.Drawing.Point(0, 24);
            this.panel_contenedor.Name = "panel_contenedor";
            this.panel_contenedor.Size = new System.Drawing.Size(749, 499);
            this.panel_contenedor.TabIndex = 4;
            // 
            // frmPresupuestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(28)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(749, 523);
            this.Controls.Add(this.panel_contenedor);
            this.Controls.Add(this.panelBarraSuperiorArt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPresupuestos";
            this.Text = "frmPresupuestos";
            this.panelBarraSuperiorArt.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelBarraSuperiorArt;
        private System.Windows.Forms.Button btnBuscarPresupuesto;
        private System.Windows.Forms.Button btnAltaPresupuesto;
        private System.Windows.Forms.Panel panel_contenedor;
    }
}