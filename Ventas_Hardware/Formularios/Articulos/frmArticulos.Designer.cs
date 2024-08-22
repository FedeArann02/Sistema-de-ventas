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
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BarraSuperiorArt = new System.Windows.Forms.MenuStrip();
            this.contenedor = new System.Windows.Forms.Panel();
            this.BarraSuperiorArt.SuspendLayout();
            this.SuspendLayout();
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            this.consultasToolStripMenuItem.Click += new System.EventHandler(this.consultasToolStripMenuItem_Click);
            // 
            // altasToolStripMenuItem
            // 
            this.altasToolStripMenuItem.Name = "altasToolStripMenuItem";
            this.altasToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.altasToolStripMenuItem.Text = "Altas";
            this.altasToolStripMenuItem.Click += new System.EventHandler(this.altasToolStripMenuItem_Click);
            // 
            // modificacionesToolStripMenuItem
            // 
            this.modificacionesToolStripMenuItem.Name = "modificacionesToolStripMenuItem";
            this.modificacionesToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.modificacionesToolStripMenuItem.Text = "Modificaciones";
            this.modificacionesToolStripMenuItem.Click += new System.EventHandler(this.modificacionesToolStripMenuItem_Click);
            // 
            // BarraSuperiorArt
            // 
            this.BarraSuperiorArt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(79)))), ((int)(((byte)(120)))));
            this.BarraSuperiorArt.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultasToolStripMenuItem,
            this.altasToolStripMenuItem,
            this.modificacionesToolStripMenuItem});
            this.BarraSuperiorArt.Location = new System.Drawing.Point(0, 0);
            this.BarraSuperiorArt.Name = "BarraSuperiorArt";
            this.BarraSuperiorArt.Size = new System.Drawing.Size(733, 24);
            this.BarraSuperiorArt.TabIndex = 0;
            this.BarraSuperiorArt.Text = "menuStrip1";
            // 
            // contenedor
            // 
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor.Location = new System.Drawing.Point(0, 24);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(733, 460);
            this.contenedor.TabIndex = 1;
            // 
            // frmArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(28)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(733, 484);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.BarraSuperiorArt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.BarraSuperiorArt;
            this.Name = "frmArticulos";
            this.Text = "frmArticulos";
            this.BarraSuperiorArt.ResumeLayout(false);
            this.BarraSuperiorArt.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificacionesToolStripMenuItem;
        private System.Windows.Forms.MenuStrip BarraSuperiorArt;
        private System.Windows.Forms.Panel contenedor;
    }
}