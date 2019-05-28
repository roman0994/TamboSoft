namespace Escritorio
{
    partial class vpListadoControles
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
            this.crvControles = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvControles
            // 
            this.crvControles.ActiveViewIndex = -1;
            this.crvControles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvControles.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvControles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvControles.Location = new System.Drawing.Point(0, 0);
            this.crvControles.Name = "crvControles";
            this.crvControles.Size = new System.Drawing.Size(800, 450);
            this.crvControles.TabIndex = 0;
            // 
            // vpListadoControles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crvControles);
            this.Name = "vpListadoControles";
            this.Text = "Listado Controles";
            this.Load += new System.EventHandler(this.vpListadoControles_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvControles;
    }
}