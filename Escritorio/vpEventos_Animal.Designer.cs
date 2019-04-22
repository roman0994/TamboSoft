namespace Escritorio
{
    partial class vpEventos_Animal
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
            this.crvEvento_Animal = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvEvento_Animal
            // 
            this.crvEvento_Animal.ActiveViewIndex = -1;
            this.crvEvento_Animal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvEvento_Animal.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvEvento_Animal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvEvento_Animal.Location = new System.Drawing.Point(0, 0);
            this.crvEvento_Animal.Name = "crvEvento_Animal";
            this.crvEvento_Animal.Size = new System.Drawing.Size(800, 450);
            this.crvEvento_Animal.TabIndex = 0;
            // 
            // vpEventos_Animal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crvEvento_Animal);
            this.Name = "vpEventos_Animal";
            this.Text = "vpEventos_Animal";
            this.Load += new System.EventHandler(this.vpEventos_Animal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvEvento_Animal;
    }
}