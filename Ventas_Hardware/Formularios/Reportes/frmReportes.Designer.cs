namespace Ventas_Hardware
{
    partial class frmReportes
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
            this.BarraSuperiorArt = new System.Windows.Forms.MenuStrip();
            this.presupuestosTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.RemitosTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.IngEgrVariosTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.balanceGeneralTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_contenedor = new System.Windows.Forms.Panel();
            this.BarraSuperiorArt.SuspendLayout();
            this.SuspendLayout();
            // 
            // BarraSuperiorArt
            // 
            this.BarraSuperiorArt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(79)))), ((int)(((byte)(120)))));
            this.BarraSuperiorArt.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.presupuestosTSM,
            this.RemitosTSM,
            this.IngEgrVariosTSM,
            this.balanceGeneralTSM});
            this.BarraSuperiorArt.Location = new System.Drawing.Point(0, 0);
            this.BarraSuperiorArt.Name = "BarraSuperiorArt";
            this.BarraSuperiorArt.Size = new System.Drawing.Size(733, 24);
            this.BarraSuperiorArt.TabIndex = 1;
            this.BarraSuperiorArt.Text = "menuStrip1";
            // 
            // presupuestosTSM
            // 
            this.presupuestosTSM.Name = "presupuestosTSM";
            this.presupuestosTSM.Size = new System.Drawing.Size(89, 20);
            this.presupuestosTSM.Text = "Presupuestos";
            this.presupuestosTSM.Click += new System.EventHandler(this.presupuestosTSM_Click);
            // 
            // RemitosTSM
            // 
            this.RemitosTSM.Name = "RemitosTSM";
            this.RemitosTSM.Size = new System.Drawing.Size(62, 20);
            this.RemitosTSM.Text = "Remitos";
            this.RemitosTSM.Click += new System.EventHandler(this.RemitosTSM_Click);
            // 
            // IngEgrVariosTSM
            // 
            this.IngEgrVariosTSM.Name = "IngEgrVariosTSM";
            this.IngEgrVariosTSM.Size = new System.Drawing.Size(142, 20);
            this.IngEgrVariosTSM.Text = "Ingresos/Egresos varios";
            this.IngEgrVariosTSM.Click += new System.EventHandler(this.IngEgrVariosTSM_Click);
            // 
            // balanceGeneralTSM
            // 
            this.balanceGeneralTSM.Name = "balanceGeneralTSM";
            this.balanceGeneralTSM.Size = new System.Drawing.Size(102, 20);
            this.balanceGeneralTSM.Text = "Balance general";
            this.balanceGeneralTSM.Click += new System.EventHandler(this.balanceGeneralTSM_Click);
            // 
            // panel_contenedor
            // 
            this.panel_contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_contenedor.Location = new System.Drawing.Point(0, 24);
            this.panel_contenedor.Name = "panel_contenedor";
            this.panel_contenedor.Size = new System.Drawing.Size(733, 460);
            this.panel_contenedor.TabIndex = 2;
            // 
            // frmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(733, 484);
            this.Controls.Add(this.panel_contenedor);
            this.Controls.Add(this.BarraSuperiorArt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReportes";
            this.Text = "frmReportes";
            this.BarraSuperiorArt.ResumeLayout(false);
            this.BarraSuperiorArt.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip BarraSuperiorArt;
        private System.Windows.Forms.ToolStripMenuItem presupuestosTSM;
        private System.Windows.Forms.ToolStripMenuItem RemitosTSM;
        private System.Windows.Forms.ToolStripMenuItem IngEgrVariosTSM;
        private System.Windows.Forms.ToolStripMenuItem balanceGeneralTSM;
        private System.Windows.Forms.Panel panel_contenedor;
    }
}