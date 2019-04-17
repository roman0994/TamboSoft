namespace Escritorio
{
    partial class vpReproduccion
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
            this.crvReproduccion = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvReproduccion
            // 
            this.crvReproduccion.ActiveViewIndex = -1;
            this.crvReproduccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvReproduccion.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvReproduccion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvReproduccion.Location = new System.Drawing.Point(0, 0);
            this.crvReproduccion.Name = "crvReproduccion";
            this.crvReproduccion.Size = new System.Drawing.Size(800, 450);
            this.crvReproduccion.TabIndex = 0;
            // 
            // vpReproduccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crvReproduccion);
            this.Name = "vpReproduccion";
            this.Text = "Vista Previa Reproducción";
            this.Load += new System.EventHandler(this.vpReproduccion_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvReproduccion;
    }
}