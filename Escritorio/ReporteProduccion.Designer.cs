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
            this.txtTambo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvControles = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.fecha_control = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_animal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.primer_control = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grasa_primercontrol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.segundo_control = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grasa_segundocontrol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_tambo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_control = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porcentaje_grasa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kg_grasa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_tambo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvControles)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.btnExportar, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnSalir, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dgvControles, 1, 1);
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
            // btnExportar
            // 
            this.btnExportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportar.Location = new System.Drawing.Point(162, 419);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(75, 25);
            this.btnExportar.TabIndex = 0;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnSalir.Location = new System.Drawing.Point(482, 419);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 25);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // groupBox1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox1, 2);
            this.groupBox1.Controls.Add(this.txtTambo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(788, 75);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tambo";
            // 
            // txtTambo
            // 
            this.txtTambo.Location = new System.Drawing.Point(215, 35);
            this.txtTambo.Name = "txtTambo";
            this.txtTambo.ReadOnly = true;
            this.txtTambo.Size = new System.Drawing.Size(200, 20);
            this.txtTambo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tambo a gestionar:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBuscar);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dateTimePicker2);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(6, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(231, 320);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fecha reporte";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Seleccione el intervalo de fecha por el \r\ncuál desea buscar:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(22, 123);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(22, 199);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha desde:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Fecha hasta:";
            // 
            // dgvControles
            // 
            this.dgvControles.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvControles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvControles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fecha_control,
            this.rp,
            this.nombre_animal,
            this.primer_control,
            this.grasa_primercontrol,
            this.segundo_control,
            this.grasa_segundocontrol,
            this.nombre_tambo,
            this.id_control,
            this.porcentaje_grasa,
            this.kg_grasa,
            this.id_tambo});
            this.dgvControles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvControles.Location = new System.Drawing.Point(243, 87);
            this.dgvControles.Name = "dgvControles";
            this.dgvControles.Size = new System.Drawing.Size(551, 323);
            this.dgvControles.TabIndex = 4;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(22, 244);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // fecha_control
            // 
            this.fecha_control.DataPropertyName = "fecha_control";
            this.fecha_control.HeaderText = "Fecha Control";
            this.fecha_control.Name = "fecha_control";
            this.fecha_control.Width = 90;
            // 
            // rp
            // 
            this.rp.DataPropertyName = "rp";
            this.rp.HeaderText = "RP";
            this.rp.Name = "rp";
            this.rp.Width = 45;
            // 
            // nombre_animal
            // 
            this.nombre_animal.DataPropertyName = "nombre_animal";
            this.nombre_animal.HeaderText = "Animal";
            this.nombre_animal.Name = "nombre_animal";
            this.nombre_animal.Width = 80;
            // 
            // primer_control
            // 
            this.primer_control.DataPropertyName = "primer_control";
            this.primer_control.HeaderText = "Primer ordeñe";
            this.primer_control.Name = "primer_control";
            this.primer_control.Width = 60;
            // 
            // grasa_primercontrol
            // 
            this.grasa_primercontrol.DataPropertyName = "grasa_primercontrol";
            this.grasa_primercontrol.HeaderText = "Grasa primer ordeñe";
            this.grasa_primercontrol.Name = "grasa_primercontrol";
            this.grasa_primercontrol.Width = 60;
            // 
            // segundo_control
            // 
            this.segundo_control.DataPropertyName = "segundo_control";
            this.segundo_control.HeaderText = "Segundo ordeñe";
            this.segundo_control.Name = "segundo_control";
            this.segundo_control.Width = 60;
            // 
            // grasa_segundocontrol
            // 
            this.grasa_segundocontrol.DataPropertyName = "grasa_segundocontrol";
            this.grasa_segundocontrol.HeaderText = "Grasa segundo ordeñe";
            this.grasa_segundocontrol.Name = "grasa_segundocontrol";
            this.grasa_segundocontrol.Width = 60;
            // 
            // nombre_tambo
            // 
            this.nombre_tambo.DataPropertyName = "nombre_tambo";
            this.nombre_tambo.HeaderText = "Tambo";
            this.nombre_tambo.Name = "nombre_tambo";
            this.nombre_tambo.Width = 70;
            // 
            // id_control
            // 
            this.id_control.DataPropertyName = "id_control";
            this.id_control.HeaderText = "ID Control";
            this.id_control.Name = "id_control";
            this.id_control.Visible = false;
            // 
            // porcentaje_grasa
            // 
            this.porcentaje_grasa.DataPropertyName = "porcentaje_grasa";
            this.porcentaje_grasa.HeaderText = "% Grasa";
            this.porcentaje_grasa.Name = "porcentaje_grasa";
            this.porcentaje_grasa.Visible = false;
            // 
            // kg_grasa
            // 
            this.kg_grasa.DataPropertyName = "kg_grasa";
            this.kg_grasa.HeaderText = "Kg Grasa";
            this.kg_grasa.Name = "kg_grasa";
            this.kg_grasa.Visible = false;
            // 
            // id_tambo
            // 
            this.id_tambo.DataPropertyName = "id_tambo";
            this.id_tambo.HeaderText = "ID Tambo";
            this.id_tambo.Name = "id_tambo";
            this.id_tambo.Visible = false;
            // 
            // ReporteProduccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ReporteProduccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de Producción";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvControles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTambo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dgvControles;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_control;
        private System.Windows.Forms.DataGridViewTextBoxColumn rp;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_animal;
        private System.Windows.Forms.DataGridViewTextBoxColumn primer_control;
        private System.Windows.Forms.DataGridViewTextBoxColumn grasa_primercontrol;
        private System.Windows.Forms.DataGridViewTextBoxColumn segundo_control;
        private System.Windows.Forms.DataGridViewTextBoxColumn grasa_segundocontrol;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_tambo;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_control;
        private System.Windows.Forms.DataGridViewTextBoxColumn porcentaje_grasa;
        private System.Windows.Forms.DataGridViewTextBoxColumn kg_grasa;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_tambo;
    }
}