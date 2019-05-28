namespace Escritorio
{
    partial class vpHistoriaClinica
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
            this.crvHistoriaClinica = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvHistoriaClinica
            // 
            this.crvHistoriaClinica.ActiveViewIndex = -1;
            this.crvHistoriaClinica.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvHistoriaClinica.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvHistoriaClinica.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvHistoriaClinica.Location = new System.Drawing.Point(0, 0);
            this.crvHistoriaClinica.Name = "crvHistoriaClinica";
            this.crvHistoriaClinica.Size = new System.Drawing.Size(800, 450);
            this.crvHistoriaClinica.TabIndex = 0;
            // 
            // vpHistoriaClinica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crvHistoriaClinica);
            this.Name = "vpHistoriaClinica";
            this.Text = "Historia Clínica";
            this.Load += new System.EventHandler(this.vpHistoriaClinica_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvHistoriaClinica;
    }
}