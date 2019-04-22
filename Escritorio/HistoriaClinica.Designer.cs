namespace Escritorio
{
    partial class HistoriaClinica
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
            this.dgvHistorialClinico = new System.Windows.Forms.DataGridView();
            this.fecha_desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Caravana = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_animal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_evento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_tambo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.verdetalle = new System.Windows.Forms.DataGridViewLinkColumn();
            this.id_evento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialClinico)).BeginInit();
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(808, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnImprimir);
            this.groupBox1.Controls.Add(this.dgvHistorialClinico);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(802, 444);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Historial de eventos";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(663, 399);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 1;
            this.btnImprimir.Text = "Exportar";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // dgvHistorialClinico
            // 
            this.dgvHistorialClinico.AllowUserToAddRows = false;
            this.dgvHistorialClinico.AllowUserToDeleteRows = false;
            this.dgvHistorialClinico.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvHistorialClinico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorialClinico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fecha_desc,
            this.rp,
            this.Caravana,
            this.nombre_animal,
            this.nombre_evento,
            this.nombre_tambo,
            this.verdetalle,
            this.id_evento});
            this.dgvHistorialClinico.Location = new System.Drawing.Point(23, 34);
            this.dgvHistorialClinico.MultiSelect = false;
            this.dgvHistorialClinico.Name = "dgvHistorialClinico";
            this.dgvHistorialClinico.ReadOnly = true;
            this.dgvHistorialClinico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistorialClinico.Size = new System.Drawing.Size(760, 345);
            this.dgvHistorialClinico.TabIndex = 0;
            this.dgvHistorialClinico.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHistorialClinico_CellContentClick);
            // 
            // fecha_desc
            // 
            this.fecha_desc.DataPropertyName = "fecha_desc";
            this.fecha_desc.Frozen = true;
            this.fecha_desc.HeaderText = "Fecha";
            this.fecha_desc.Name = "fecha_desc";
            this.fecha_desc.ReadOnly = true;
            this.fecha_desc.Width = 90;
            // 
            // rp
            // 
            this.rp.DataPropertyName = "rp";
            this.rp.Frozen = true;
            this.rp.HeaderText = "RP";
            this.rp.Name = "rp";
            this.rp.ReadOnly = true;
            this.rp.Width = 50;
            // 
            // Caravana
            // 
            this.Caravana.DataPropertyName = "caravana";
            this.Caravana.Frozen = true;
            this.Caravana.HeaderText = "caravana";
            this.Caravana.Name = "Caravana";
            this.Caravana.ReadOnly = true;
            // 
            // nombre_animal
            // 
            this.nombre_animal.DataPropertyName = "nombre_animal";
            this.nombre_animal.Frozen = true;
            this.nombre_animal.HeaderText = "Animal";
            this.nombre_animal.Name = "nombre_animal";
            this.nombre_animal.ReadOnly = true;
            // 
            // nombre_evento
            // 
            this.nombre_evento.DataPropertyName = "nombre_evento";
            this.nombre_evento.Frozen = true;
            this.nombre_evento.HeaderText = "Evento";
            this.nombre_evento.Name = "nombre_evento";
            this.nombre_evento.ReadOnly = true;
            this.nombre_evento.Width = 80;
            // 
            // nombre_tambo
            // 
            this.nombre_tambo.DataPropertyName = "nombre_tambo";
            this.nombre_tambo.Frozen = true;
            this.nombre_tambo.HeaderText = "Tambo";
            this.nombre_tambo.Name = "nombre_tambo";
            this.nombre_tambo.ReadOnly = true;
            // 
            // verdetalle
            // 
            this.verdetalle.Frozen = true;
            this.verdetalle.HeaderText = "Ver detalle";
            this.verdetalle.Name = "verdetalle";
            this.verdetalle.ReadOnly = true;
            this.verdetalle.Text = "Ver detalle";
            this.verdetalle.UseColumnTextForLinkValue = true;
            // 
            // id_evento
            // 
            this.id_evento.DataPropertyName = "id_evento";
            this.id_evento.HeaderText = "ID Evento";
            this.id_evento.Name = "id_evento";
            this.id_evento.ReadOnly = true;
            this.id_evento.Visible = false;
            // 
            // HistoriaClinica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(808, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HistoriaClinica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historia Clínica";
            this.Load += new System.EventHandler(this.HistoriaClinica_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialClinico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.DataGridView dgvHistorialClinico;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn rp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Caravana;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_animal;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_evento;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_tambo;
        private System.Windows.Forms.DataGridViewLinkColumn verdetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_evento;
    }
}