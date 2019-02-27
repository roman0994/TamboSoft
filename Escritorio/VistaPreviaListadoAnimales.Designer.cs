namespace Escritorio
{
    partial class VistaPreviaListadoAnimales
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
            this.crvAnimales = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.ReporteListadoAnimales1 = new Escritorio.ReporteListadoAnimales();
            this.SuspendLayout();
            // 
            // crvAnimales
            // 
            this.crvAnimales.ActiveViewIndex = 0;
            this.crvAnimales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvAnimales.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvAnimales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvAnimales.Location = new System.Drawing.Point(0, 0);
            this.crvAnimales.Name = "crvAnimales";
            this.crvAnimales.ReportSource = this.ReporteListadoAnimales1;
            this.crvAnimales.Size = new System.Drawing.Size(800, 450);
            this.crvAnimales.TabIndex = 0;
            // 
            // VistaPreviaListadoAnimales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crvAnimales);
            this.Name = "VistaPreviaListadoAnimales";
            this.Text = "Vista Previa Listado Animales";
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crvAnimales;
        private ReporteListadoAnimales ReporteListadoAnimales1;
    }
}