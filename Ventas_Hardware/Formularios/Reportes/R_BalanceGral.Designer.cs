namespace Ventas_Hardware.Formularios.Reportes
{
    partial class R_BalanceGral
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
            this.lblPROX = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPROX
            // 
            this.lblPROX.AutoSize = true;
            this.lblPROX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPROX.Font = new System.Drawing.Font("Segoe UI Variable Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPROX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(89)))), ((int)(((byte)(160)))));
            this.lblPROX.Location = new System.Drawing.Point(276, 214);
            this.lblPROX.Name = "lblPROX";
            this.lblPROX.Size = new System.Drawing.Size(181, 32);
            this.lblPROX.TabIndex = 79;
            this.lblPROX.Text = "Proximamente";
            // 
            // R_BalanceGral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(29)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(733, 460);
            this.Controls.Add(this.lblPROX);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "R_BalanceGral";
            this.Text = "R_BalanceGral";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPROX;
    }
}