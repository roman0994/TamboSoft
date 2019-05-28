namespace Escritorio
{
    partial class vpProduccionPorAnimal
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
            this.crvProduccion = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvProduccion
            // 
            this.crvProduccion.ActiveViewIndex = -1;
            this.crvProduccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvProduccion.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvProduccion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvProduccion.Location = new System.Drawing.Point(0, 0);
            this.crvProduccion.Name = "crvProduccion";
            this.crvProduccion.Size = new System.Drawing.Size(800, 450);
            this.crvProduccion.TabIndex = 0;
            // 
            // vpProduccionPorAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crvProduccion);
            this.Name = "vpProduccionPorAnimal";
            this.Text = "Reporte de Producción por Animal";
            this.Load += new System.EventHandler(this.vpProduccionPorAnimal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvProduccion;
    }
}