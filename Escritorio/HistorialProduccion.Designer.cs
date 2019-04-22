namespace Escritorio
{
    partial class HistorialProduccion
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.dgvHistorialProduccion = new System.Windows.Forms.DataGridView();
            this.fecha_control = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caravana = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_animal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_control = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.primer_control = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grasa_primercontrol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.segundo_control = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grasa_segundocontrol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_tambo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porcentaje_grasa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kg_grasa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_tambo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialProduccion)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(843, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnImprimir);
            this.groupBox1.Controls.Add(this.dgvHistorialProduccion);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(837, 444);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Historial de producción lechera";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(741, 403);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 1;
            this.btnImprimir.Text = "Exportar";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // dgvHistorialProduccion
            // 
            this.dgvHistorialProduccion.AllowUserToAddRows = false;
            this.dgvHistorialProduccion.AllowUserToDeleteRows = false;
            this.dgvHistorialProduccion.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvHistorialProduccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorialProduccion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fecha_control,
            this.caravana,
            this.rp,
            this.nombre_animal,
            this.id_control,
            this.primer_control,
            this.grasa_primercontrol,
            this.segundo_control,
            this.grasa_segundocontrol,
            this.id_tambo,
            this.porcentaje_grasa,
            this.kg_grasa,
            this.nombre_tambo});
            this.dgvHistorialProduccion.Location = new System.Drawing.Point(20, 28);
            this.dgvHistorialProduccion.MultiSelect = false;
            this.dgvHistorialProduccion.Name = "dgvHistorialProduccion";
            this.dgvHistorialProduccion.ReadOnly = true;
            this.dgvHistorialProduccion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistorialProduccion.Size = new System.Drawing.Size(796, 357);
            this.dgvHistorialProduccion.TabIndex = 0;
            // 
            // fecha_control
            // 
            this.fecha_control.DataPropertyName = "fecha_control";
            this.fecha_control.Frozen = true;
            this.fecha_control.HeaderText = "Fecha control";
            this.fecha_control.Name = "fecha_control";
            this.fecha_control.ReadOnly = true;
            // 
            // caravana
            // 
            this.caravana.DataPropertyName = "caravana";
            this.caravana.Frozen = true;
            this.caravana.HeaderText = "Caravana";
            this.caravana.Name = "caravana";
            this.caravana.ReadOnly = true;
            // 
            // rp
            // 
            this.rp.DataPropertyName = "rp";
            this.rp.HeaderText = "RP";
            this.rp.Name = "rp";
            this.rp.ReadOnly = true;
            this.rp.Width = 60;
            // 
            // nombre_animal
            // 
            this.nombre_animal.DataPropertyName = "nombre_animal";
            this.nombre_animal.HeaderText = "Animal";
            this.nombre_animal.Name = "nombre_animal";
            this.nombre_animal.ReadOnly = true;
            // 
            // id_control
            // 
            this.id_control.DataPropertyName = "id_control";
            this.id_control.HeaderText = "ID Control";
            this.id_control.Name = "id_control";
            this.id_control.ReadOnly = true;
            this.id_control.Visible = false;
            // 
            // primer_control
            // 
            this.primer_control.DataPropertyName = "primer_control";
            this.primer_control.HeaderText = "Primer control (lts)";
            this.primer_control.Name = "primer_control";
            this.primer_control.ReadOnly = true;
            // 
            // grasa_primercontrol
            // 
            this.grasa_primercontrol.DataPropertyName = "grasa_primercontrol";
            this.grasa_primercontrol.HeaderText = "Grasa primer control";
            this.grasa_primercontrol.Name = "grasa_primercontrol";
            this.grasa_primercontrol.ReadOnly = true;
            // 
            // segundo_control
            // 
            this.segundo_control.DataPropertyName = "segundo_control";
            this.segundo_control.HeaderText = "Segundo control (lts)";
            this.segundo_control.Name = "segundo_control";
            this.segundo_control.ReadOnly = true;
            // 
            // grasa_segundocontrol
            // 
            this.grasa_segundocontrol.DataPropertyName = "grasa_segundocontrol";
            this.grasa_segundocontrol.HeaderText = "Grasa segundo control";
            this.grasa_segundocontrol.Name = "grasa_segundocontrol";
            this.grasa_segundocontrol.ReadOnly = true;
            // 
            // id_tambo
            // 
            this.id_tambo.DataPropertyName = "id_tambo";
            this.id_tambo.HeaderText = "ID Tambo";
            this.id_tambo.Name = "id_tambo";
            this.id_tambo.ReadOnly = true;
            this.id_tambo.Visible = false;
            // 
            // porcentaje_grasa
            // 
            this.porcentaje_grasa.DataPropertyName = "porcentaje_grasa";
            this.porcentaje_grasa.HeaderText = "Porcentaje Grasa";
            this.porcentaje_grasa.Name = "porcentaje_grasa";
            this.porcentaje_grasa.ReadOnly = true;
            this.porcentaje_grasa.Visible = false;
            // 
            // kg_grasa
            // 
            this.kg_grasa.DataPropertyName = "kg_grasa";
            this.kg_grasa.HeaderText = "Kg Grasa";
            this.kg_grasa.Name = "kg_grasa";
            this.kg_grasa.ReadOnly = true;
            this.kg_grasa.Visible = false;
            // 
            // nombre_tambo
            // 
            this.nombre_tambo.DataPropertyName = "nombre_tambo";
            this.nombre_tambo.HeaderText = "Tambo";
            this.nombre_tambo.Name = "nombre_tambo";
            this.nombre_tambo.ReadOnly = true;
            // 
            // HistorialProduccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(843, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HistorialProduccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historial de Producción";
            this.Load += new System.EventHandler(this.HistorialProduccion_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialProduccion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.DataGridView dgvHistorialProduccion;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_control;
        private System.Windows.Forms.DataGridViewTextBoxColumn caravana;
        private System.Windows.Forms.DataGridViewTextBoxColumn rp;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_animal;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_control;
        private System.Windows.Forms.DataGridViewTextBoxColumn primer_control;
        private System.Windows.Forms.DataGridViewTextBoxColumn grasa_primercontrol;
        private System.Windows.Forms.DataGridViewTextBoxColumn segundo_control;
        private System.Windows.Forms.DataGridViewTextBoxColumn grasa_segundocontrol;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_tambo;
        private System.Windows.Forms.DataGridViewTextBoxColumn porcentaje_grasa;
        private System.Windows.Forms.DataGridViewTextBoxColumn kg_grasa;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_tambo;
    }
}