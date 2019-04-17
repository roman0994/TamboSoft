namespace Escritorio
{
    partial class vpEventos
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
            this.crvEventos = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvEventos
            // 
            this.crvEventos.ActiveViewIndex = -1;
            this.crvEventos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvEventos.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvEventos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvEventos.Location = new System.Drawing.Point(0, 0);
            this.crvEventos.Name = "crvEventos";
            this.crvEventos.Size = new System.Drawing.Size(800, 450);
            this.crvEventos.TabIndex = 0;
            // 
            // vpEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crvEventos);
            this.Name = "vpEventos";
            this.Text = "Vista Previa Eventos";
            this.Load += new System.EventHandler(this.vpEventos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvEventos;
    }
}