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
            this.BarraSuperiorPresupuestos = new System.Windows.Forms.MenuStrip();
            this.altaPresupuestoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarPresupuestoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_contenedor = new System.Windows.Forms.Panel();
            this.BarraSuperiorPresupuestos.SuspendLayout();
            this.SuspendLayout();
            // 
            // BarraSuperiorPresupuestos
            // 
            this.BarraSuperiorPresupuestos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(79)))), ((int)(((byte)(120)))));
            this.BarraSuperiorPresupuestos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaPresupuestoToolStripMenuItem,
            this.buscarPresupuestoToolStripMenuItem});
            this.BarraSuperiorPresupuestos.Location = new System.Drawing.Point(0, 0);
            this.BarraSuperiorPresupuestos.Name = "BarraSuperiorPresupuestos";
            this.BarraSuperiorPresupuestos.Size = new System.Drawing.Size(733, 24);
            this.BarraSuperiorPresupuestos.TabIndex = 2;
            this.BarraSuperiorPresupuestos.Text = "menuStrip1";
            // 
            // altaPresupuestoToolStripMenuItem
            // 
            this.altaPresupuestoToolStripMenuItem.Name = "altaPresupuestoToolStripMenuItem";
            this.altaPresupuestoToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.altaPresupuestoToolStripMenuItem.Text = "Alta Presupuesto";
            this.altaPresupuestoToolStripMenuItem.Click += new System.EventHandler(this.altaPresupuestoToolStripMenuItem_Click);
            // 
            // buscarPresupuestoToolStripMenuItem
            // 
            this.buscarPresupuestoToolStripMenuItem.Name = "buscarPresupuestoToolStripMenuItem";
            this.buscarPresupuestoToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.buscarPresupuestoToolStripMenuItem.Text = "Buscar Presupuesto";
            this.buscarPresupuestoToolStripMenuItem.Click += new System.EventHandler(this.buscarPresupuestoToolStripMenuItem_Click);
            // 
            // panel_contenedor
            // 
            this.panel_contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_contenedor.Location = new System.Drawing.Point(0, 24);
            this.panel_contenedor.Name = "panel_contenedor";
            this.panel_contenedor.Size = new System.Drawing.Size(733, 460);
            this.panel_contenedor.TabIndex = 3;
            // 
            // frmPresupuestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(28)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(733, 484);
            this.Controls.Add(this.panel_contenedor);
            this.Controls.Add(this.BarraSuperiorPresupuestos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPresupuestos";
            this.Text = "frmPresupuestos";
            this.BarraSuperiorPresupuestos.ResumeLayout(false);
            this.BarraSuperiorPresupuestos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip BarraSuperiorPresupuestos;
        private System.Windows.Forms.ToolStripMenuItem altaPresupuestoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarPresupuestoToolStripMenuItem;
        private System.Windows.Forms.Panel panel_contenedor;
    }
}