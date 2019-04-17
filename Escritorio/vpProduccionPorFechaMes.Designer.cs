namespace Escritorio
{
    partial class vpProduccionPorFechaMes
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
            this.crvProduccionPorMes = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvProduccionPorMes
            // 
            this.crvProduccionPorMes.ActiveViewIndex = -1;
            this.crvProduccionPorMes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvProduccionPorMes.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvProduccionPorMes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvProduccionPorMes.Location = new System.Drawing.Point(0, 0);
            this.crvProduccionPorMes.Name = "crvProduccionPorMes";
            this.crvProduccionPorMes.Size = new System.Drawing.Size(800, 450);
            this.crvProduccionPorMes.TabIndex = 0;
            // 
            // vpProduccionPorFechaMes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crvProduccionPorMes);
            this.Name = "vpProduccionPorFechaMes";
            this.Text = "Vista Previa Producción Mensual";
            this.Load += new System.EventHandler(this.vpProduccionPorFechaMes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvProduccionPorMes;
    }
}