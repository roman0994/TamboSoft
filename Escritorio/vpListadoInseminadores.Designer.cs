namespace Escritorio
{
    partial class vpListadoInseminadores
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
            this.crvInseminadores = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvInseminadores
            // 
            this.crvInseminadores.ActiveViewIndex = -1;
            this.crvInseminadores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvInseminadores.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvInseminadores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvInseminadores.Location = new System.Drawing.Point(0, 0);
            this.crvInseminadores.Name = "crvInseminadores";
            this.crvInseminadores.Size = new System.Drawing.Size(800, 450);
            this.crvInseminadores.TabIndex = 0;
            this.crvInseminadores.Load += new System.EventHandler(this.crvInseminadores_Load);
            // 
            // vpListadoInseminadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crvInseminadores);
            this.Name = "vpListadoInseminadores";
            this.Text = "Listado Inseminadores";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvInseminadores;
    }
}