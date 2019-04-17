namespace Escritorio
{
    partial class ReporteProduccion
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
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbAnimal = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpDia = new System.Windows.Forms.DateTimePicker();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cbMes = new System.Windows.Forms.ComboBox();
            this.cbAño = new System.Windows.Forms.ComboBox();
            this.cbBuscar = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvProduccion = new System.Windows.Forms.DataGridView();
            this.rp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_animal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_control = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.litrostotales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grasatotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_tambo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduccion)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.btnExportar, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnSalir, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dgvProduccion, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(869, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnExportar
            // 
            this.btnExportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportar.Location = new System.Drawing.Point(182, 423);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(75, 23);
            this.btnExportar.TabIndex = 0;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnSalir.Location = new System.Drawing.Point(527, 423);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 24);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // groupBox1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox1, 2);
            this.groupBox1.Controls.Add(this.cbAnimal);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(863, 78);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Animal";
            // 
            // cbAnimal
            // 
            this.cbAnimal.FormattingEnabled = true;
            this.cbAnimal.Location = new System.Drawing.Point(217, 33);
            this.cbAnimal.Name = "cbAnimal";
            this.cbAnimal.Size = new System.Drawing.Size(232, 21);
            this.cbAnimal.TabIndex = 1;
            this.cbAnimal.SelectedIndexChanged += new System.EventHandler(this.cbAnimal_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione el animal a filtrar:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpDia);
            this.groupBox2.Controls.Add(this.btnLimpiar);
            this.groupBox2.Controls.Add(this.btnBuscar);
            this.groupBox2.Controls.Add(this.cbMes);
            this.groupBox2.Controls.Add(this.cbAño);
            this.groupBox2.Controls.Add(this.cbBuscar);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(254, 330);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fecha reporte";
            // 
            // dtpDia
            // 
            this.dtpDia.Location = new System.Drawing.Point(22, 168);
            this.dtpDia.Name = "dtpDia";
            this.dtpDia.Size = new System.Drawing.Size(200, 20);
            this.dtpDia.TabIndex = 6;
            this.dtpDia.Visible = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(132, 265);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(22, 265);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cbMes
            // 
            this.cbMes.FormattingEnabled = true;
            this.cbMes.Location = new System.Drawing.Point(22, 206);
            this.cbMes.Name = "cbMes";
            this.cbMes.Size = new System.Drawing.Size(121, 21);
            this.cbMes.TabIndex = 3;
            this.cbMes.Visible = false;
            this.cbMes.SelectedIndexChanged += new System.EventHandler(this.cbMes_SelectedIndexChanged);
            // 
            // cbAño
            // 
            this.cbAño.FormattingEnabled = true;
            this.cbAño.Location = new System.Drawing.Point(22, 126);
            this.cbAño.Name = "cbAño";
            this.cbAño.Size = new System.Drawing.Size(121, 21);
            this.cbAño.TabIndex = 2;
            this.cbAño.Visible = false;
            this.cbAño.SelectedIndexChanged += new System.EventHandler(this.cbAño_SelectedIndexChanged);
            // 
            // cbBuscar
            // 
            this.cbBuscar.FormattingEnabled = true;
            this.cbBuscar.Location = new System.Drawing.Point(22, 85);
            this.cbBuscar.Name = "cbBuscar";
            this.cbBuscar.Size = new System.Drawing.Size(121, 21);
            this.cbBuscar.TabIndex = 1;
            this.cbBuscar.Text = "Buscar por:";
            this.cbBuscar.SelectedIndexChanged += new System.EventHandler(this.cbBuscar_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Seleccione el parámetro por el \r\ncuál desea buscar:\r\n";
            // 
            // dgvProduccion
            // 
            this.dgvProduccion.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvProduccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduccion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rp,
            this.nombre_animal,
            this.fecha_control,
            this.litrostotales,
            this.grasatotal,
            this.nombre_tambo});
            this.dgvProduccion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProduccion.Location = new System.Drawing.Point(263, 87);
            this.dgvProduccion.Name = "dgvProduccion";
            this.dgvProduccion.ReadOnly = true;
            this.dgvProduccion.Size = new System.Drawing.Size(603, 330);
            this.dgvProduccion.TabIndex = 4;
            // 
            // rp
            // 
            this.rp.DataPropertyName = "rp";
            this.rp.HeaderText = "RP Animal";
            this.rp.Name = "rp";
            this.rp.ReadOnly = true;
            this.rp.Width = 80;
            // 
            // nombre_animal
            // 
            this.nombre_animal.DataPropertyName = "nombre_animal";
            this.nombre_animal.HeaderText = "Animal";
            this.nombre_animal.Name = "nombre_animal";
            this.nombre_animal.ReadOnly = true;
            // 
            // fecha_control
            // 
            this.fecha_control.DataPropertyName = "fecha_control";
            this.fecha_control.HeaderText = "Fecha control";
            this.fecha_control.Name = "fecha_control";
            this.fecha_control.ReadOnly = true;
            // 
            // litrostotales
            // 
            this.litrostotales.DataPropertyName = "litrostotales";
            this.litrostotales.HeaderText = "Litros totales ordeñe";
            this.litrostotales.Name = "litrostotales";
            this.litrostotales.ReadOnly = true;
            this.litrostotales.Width = 90;
            // 
            // grasatotal
            // 
            this.grasatotal.DataPropertyName = "grasatotal";
            this.grasatotal.HeaderText = "Kg grasa total";
            this.grasatotal.Name = "grasatotal";
            this.grasatotal.ReadOnly = true;
            this.grasatotal.Width = 90;
            // 
            // nombre_tambo
            // 
            this.nombre_tambo.DataPropertyName = "nombre_tambo";
            this.nombre_tambo.HeaderText = "Tambo";
            this.nombre_tambo.Name = "nombre_tambo";
            this.nombre_tambo.ReadOnly = true;
            // 
            // ReporteProduccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(869, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ReporteProduccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de Producción Lechera";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduccion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvProduccion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbAnimal;
        private System.Windows.Forms.ComboBox cbMes;
        private System.Windows.Forms.ComboBox cbAño;
        private System.Windows.Forms.ComboBox cbBuscar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DateTimePicker dtpDia;
        private System.Windows.Forms.DataGridViewTextBoxColumn rp;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_animal;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_control;
        private System.Windows.Forms.DataGridViewTextBoxColumn litrostotales;
        private System.Windows.Forms.DataGridViewTextBoxColumn grasatotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_tambo;
    }
}