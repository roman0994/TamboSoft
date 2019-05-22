namespace Escritorio
{
    partial class ListadoModifSincronizacion
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvSincronizacion = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.Agregar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.caravana = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_animal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado_animal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSincronizacion)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dgvSincronizacion, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button1, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dgvSincronizacion
            // 
            this.dgvSincronizacion.AllowUserToAddRows = false;
            this.dgvSincronizacion.AllowUserToDeleteRows = false;
            this.dgvSincronizacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSincronizacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Agregar,
            this.caravana,
            this.nombre_animal,
            this.estado_animal});
            this.tableLayoutPanel1.SetColumnSpan(this.dgvSincronizacion, 2);
            this.dgvSincronizacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSincronizacion.Location = new System.Drawing.Point(3, 87);
            this.dgvSincronizacion.Name = "dgvSincronizacion";
            this.dgvSincronizacion.ReadOnly = true;
            this.dgvSincronizacion.Size = new System.Drawing.Size(794, 330);
            this.dgvSincronizacion.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(403, 423);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Agregar
            // 
            this.Agregar.HeaderText = "Agregar";
            this.Agregar.Name = "Agregar";
            this.Agregar.ReadOnly = true;
            // 
            // caravana
            // 
            this.caravana.HeaderText = "Caravana";
            this.caravana.Name = "caravana";
            this.caravana.ReadOnly = true;
            // 
            // nombre_animal
            // 
            this.nombre_animal.DataPropertyName = "nombre_animal";
            this.nombre_animal.HeaderText = "Nombre";
            this.nombre_animal.Name = "nombre_animal";
            this.nombre_animal.ReadOnly = true;
            // 
            // estado_animal
            // 
            this.estado_animal.DataPropertyName = "estado_animal";
            this.estado_animal.HeaderText = "Estado";
            this.estado_animal.Name = "estado_animal";
            this.estado_animal.ReadOnly = true;
            // 
            // ListadoModifSincronizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListadoModifSincronizacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sincronización";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSincronizacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvSincronizacion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Agregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn caravana;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_animal;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado_animal;
    }
}