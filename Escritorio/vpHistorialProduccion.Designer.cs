namespace Escritorio
{
    partial class vpHistorialProduccion
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
            this.crvHistorialProduccion = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvHistorialProduccion
            // 
            this.crvHistorialProduccion.ActiveViewIndex = -1;
            this.crvHistorialProduccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvHistorialProduccion.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvHistorialProduccion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvHistorialProduccion.Location = new System.Drawing.Point(0, 0);
            this.crvHistorialProduccion.Name = "crvHistorialProduccion";
            this.crvHistorialProduccion.Size = new System.Drawing.Size(800, 450);
            this.crvHistorialProduccion.TabIndex = 0;
            // 
            // vpHistorialProduccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crvHistorialProduccion);
            this.Name = "vpHistorialProduccion";
            this.Text = "Historial de Producción";
            this.Load += new System.EventHandler(this.vpHistorialProduccion_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvHistorialProduccion;
    }
}