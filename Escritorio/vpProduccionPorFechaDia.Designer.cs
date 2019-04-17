namespace Escritorio
{
    partial class vpProduccionPorFechaDia
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
            this.crvProduccionPorDia = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvProduccionPorDia
            // 
            this.crvProduccionPorDia.ActiveViewIndex = -1;
            this.crvProduccionPorDia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvProduccionPorDia.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvProduccionPorDia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvProduccionPorDia.Location = new System.Drawing.Point(0, 0);
            this.crvProduccionPorDia.Name = "crvProduccionPorDia";
            this.crvProduccionPorDia.Size = new System.Drawing.Size(800, 450);
            this.crvProduccionPorDia.TabIndex = 0;
            // 
            // vpProduccionPorFechaDia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crvProduccionPorDia);
            this.Name = "vpProduccionPorFechaDia";
            this.Text = "Vista Previa Producción Por Fecha";
            this.Load += new System.EventHandler(this.vpProduccionPorFecha_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvProduccionPorDia;
    }
}