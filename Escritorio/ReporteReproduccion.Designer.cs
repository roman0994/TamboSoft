namespace Escritorio
{
    partial class ReporteReproduccion
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
            this.txtTambo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvPartos = new System.Windows.Forms.DataGridView();
            this.id_desc_evento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_animal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_evento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_evento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_subevento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_tambo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_tambo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_inseminador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_inseminador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado_evento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtCriasMuertas = new System.Windows.Forms.TextBox();
            this.txtCriasMacho = new System.Windows.Forms.TextBox();
            this.txtCriasHembra = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartos)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dgvPartos, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSalir, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnExportar, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox1, 2);
            this.groupBox1.Controls.Add(this.txtTambo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(794, 52);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tambo";
            // 
            // txtTambo
            // 
            this.txtTambo.Location = new System.Drawing.Point(240, 17);
            this.txtTambo.Name = "txtTambo";
            this.txtTambo.ReadOnly = true;
            this.txtTambo.Size = new System.Drawing.Size(200, 20);
            this.txtTambo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tambo a gestionar:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLimpiar);
            this.groupBox2.Controls.Add(this.btnBuscar);
            this.groupBox2.Controls.Add(this.dateTimePicker2);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 61);
            this.groupBox2.Name = "groupBox2";
            this.tableLayoutPanel1.SetRowSpan(this.groupBox2, 2);
            this.groupBox2.Size = new System.Drawing.Size(234, 351);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Intervalo de tiempo";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(155, 287);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(30, 287);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(30, 222);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(30, 133);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Fecha hasta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Fecha desde:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Seleccione el intervalo de fecha por el \r\ncuál desea buscar:";
            // 
            // dgvPartos
            // 
            this.dgvPartos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvPartos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPartos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_desc_evento,
            this.rp,
            this.nombre_animal,
            this.id_evento,
            this.id_desc,
            this.fecha_desc,
            this.nombre_evento,
            this.nombre_subevento,
            this.descripcion,
            this.id_tambo,
            this.nombre_tambo,
            this.id_inseminador,
            this.nombre_inseminador,
            this.estado_evento});
            this.dgvPartos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPartos.Location = new System.Drawing.Point(243, 61);
            this.dgvPartos.Name = "dgvPartos";
            this.dgvPartos.Size = new System.Drawing.Size(554, 268);
            this.dgvPartos.TabIndex = 4;
            // 
            // id_desc_evento
            // 
            this.id_desc_evento.DataPropertyName = "id_desc_evento";
            this.id_desc_evento.HeaderText = "ID Desc Evento";
            this.id_desc_evento.Name = "id_desc_evento";
            this.id_desc_evento.Visible = false;
            // 
            // rp
            // 
            this.rp.DataPropertyName = "rp";
            this.rp.HeaderText = "RP";
            this.rp.Name = "rp";
            this.rp.Width = 40;
            // 
            // nombre_animal
            // 
            this.nombre_animal.DataPropertyName = "nombre_animal";
            this.nombre_animal.HeaderText = "Animal";
            this.nombre_animal.Name = "nombre_animal";
            // 
            // id_evento
            // 
            this.id_evento.DataPropertyName = "id_evento";
            this.id_evento.HeaderText = "ID Evento";
            this.id_evento.Name = "id_evento";
            this.id_evento.Visible = false;
            // 
            // id_desc
            // 
            this.id_desc.DataPropertyName = "id_desc";
            this.id_desc.HeaderText = "ID Desc";
            this.id_desc.Name = "id_desc";
            this.id_desc.Visible = false;
            // 
            // fecha_desc
            // 
            this.fecha_desc.DataPropertyName = "fecha_desc";
            this.fecha_desc.HeaderText = "Fecha evento";
            this.fecha_desc.Name = "fecha_desc";
            // 
            // nombre_evento
            // 
            this.nombre_evento.DataPropertyName = "nombre_evento";
            this.nombre_evento.HeaderText = "Evento";
            this.nombre_evento.Name = "nombre_evento";
            // 
            // nombre_subevento
            // 
            this.nombre_subevento.DataPropertyName = "nombre_subevento";
            this.nombre_subevento.HeaderText = "Subevento";
            this.nombre_subevento.Name = "nombre_subevento";
            // 
            // descripcion
            // 
            this.descripcion.DataPropertyName = "descripcion";
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.Name = "descripcion";
            // 
            // id_tambo
            // 
            this.id_tambo.DataPropertyName = "id_tambo";
            this.id_tambo.HeaderText = "ID Tambo";
            this.id_tambo.Name = "id_tambo";
            this.id_tambo.Visible = false;
            // 
            // nombre_tambo
            // 
            this.nombre_tambo.DataPropertyName = "nombre_tambo";
            this.nombre_tambo.HeaderText = "Tambo";
            this.nombre_tambo.Name = "nombre_tambo";
            // 
            // id_inseminador
            // 
            this.id_inseminador.DataPropertyName = "id_inseminador";
            this.id_inseminador.HeaderText = "ID Inseminador";
            this.id_inseminador.Name = "id_inseminador";
            this.id_inseminador.Visible = false;
            // 
            // nombre_inseminador
            // 
            this.nombre_inseminador.DataPropertyName = "nombre_inseminador";
            this.nombre_inseminador.HeaderText = "Inseminador";
            this.nombre_inseminador.Name = "nombre_inseminador";
            this.nombre_inseminador.Visible = false;
            // 
            // estado_evento
            // 
            this.estado_evento.DataPropertyName = "estado_evento";
            this.estado_evento.HeaderText = "Estado evento";
            this.estado_evento.Name = "estado_evento";
            this.estado_evento.Visible = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnSalir.Location = new System.Drawing.Point(482, 418);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 29);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportar.Location = new System.Drawing.Point(162, 418);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(75, 27);
            this.btnExportar.TabIndex = 0;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtCriasMuertas);
            this.groupBox3.Controls.Add(this.txtCriasMacho);
            this.groupBox3.Controls.Add(this.txtCriasHembra);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(243, 335);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(554, 77);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Resúmenes";
            // 
            // txtCriasMuertas
            // 
            this.txtCriasMuertas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCriasMuertas.Location = new System.Drawing.Point(390, 37);
            this.txtCriasMuertas.Name = "txtCriasMuertas";
            this.txtCriasMuertas.ReadOnly = true;
            this.txtCriasMuertas.Size = new System.Drawing.Size(128, 13);
            this.txtCriasMuertas.TabIndex = 5;
            this.txtCriasMuertas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCriasMacho
            // 
            this.txtCriasMacho.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCriasMacho.Location = new System.Drawing.Point(209, 37);
            this.txtCriasMacho.Name = "txtCriasMacho";
            this.txtCriasMacho.ReadOnly = true;
            this.txtCriasMacho.Size = new System.Drawing.Size(123, 13);
            this.txtCriasMacho.TabIndex = 4;
            this.txtCriasMacho.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCriasHembra
            // 
            this.txtCriasHembra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCriasHembra.Location = new System.Drawing.Point(34, 38);
            this.txtCriasHembra.Name = "txtCriasHembra";
            this.txtCriasHembra.ReadOnly = true;
            this.txtCriasHembra.Size = new System.Drawing.Size(131, 13);
            this.txtCriasHembra.TabIndex = 3;
            this.txtCriasHembra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(387, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Cantidad de crías muertas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(206, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Cantidad de crías macho";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Cantidad de crías hembras";
            // 
            // ReporteReproduccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReporteReproduccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReporteReproduccion";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartos)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvPartos;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTambo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_desc_evento;
        private System.Windows.Forms.DataGridViewTextBoxColumn rp;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_animal;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_evento;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_evento;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_subevento;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_tambo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_tambo;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_inseminador;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_inseminador;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado_evento;
        private System.Windows.Forms.TextBox txtCriasMuertas;
        private System.Windows.Forms.TextBox txtCriasMacho;
        private System.Windows.Forms.TextBox txtCriasHembra;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLimpiar;
    }
}