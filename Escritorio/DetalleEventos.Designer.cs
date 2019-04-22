namespace Escritorio
{
    partial class DetalleEventos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDetalles = new System.Windows.Forms.DataGridView();
            this.nombre_subevento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_evento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_subevento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_desc_evento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_inseminador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_inseminador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_tambo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_tambo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_animal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_evento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado_evento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(575, 205);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox1, 2);
            this.groupBox1.Controls.Add(this.dgvDetalles);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.tableLayoutPanel1.SetRowSpan(this.groupBox1, 2);
            this.groupBox1.Size = new System.Drawing.Size(569, 199);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalles del evento";
            // 
            // dgvDetalles
            // 
            this.dgvDetalles.AllowUserToAddRows = false;
            this.dgvDetalles.AllowUserToDeleteRows = false;
            this.dgvDetalles.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre_subevento,
            this.descripcion,
            this.rp,
            this.id_evento,
            this.id_subevento,
            this.id_desc_evento,
            this.id_inseminador,
            this.nombre_inseminador,
            this.id_tambo,
            this.nombre_tambo,
            this.fecha_desc,
            this.nombre_animal,
            this.nombre_evento,
            this.id_desc,
            this.estado_evento});
            this.dgvDetalles.Location = new System.Drawing.Point(9, 19);
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.ReadOnly = true;
            this.dgvDetalles.Size = new System.Drawing.Size(549, 171);
            this.dgvDetalles.TabIndex = 0;
            // 
            // nombre_subevento
            // 
            this.nombre_subevento.DataPropertyName = "nombre_subevento";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.nombre_subevento.DefaultCellStyle = dataGridViewCellStyle1;
            this.nombre_subevento.HeaderText = "Subevento";
            this.nombre_subevento.MinimumWidth = 10;
            this.nombre_subevento.Name = "nombre_subevento";
            this.nombre_subevento.ReadOnly = true;
            // 
            // descripcion
            // 
            this.descripcion.DataPropertyName = "descripcion";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.descripcion.DefaultCellStyle = dataGridViewCellStyle2;
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.MinimumWidth = 10;
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // rp
            // 
            this.rp.DataPropertyName = "rp";
            this.rp.HeaderText = "RP";
            this.rp.Name = "rp";
            this.rp.ReadOnly = true;
            this.rp.Visible = false;
            // 
            // id_evento
            // 
            this.id_evento.DataPropertyName = "id_evento";
            this.id_evento.HeaderText = "ID Evento";
            this.id_evento.Name = "id_evento";
            this.id_evento.ReadOnly = true;
            this.id_evento.Visible = false;
            // 
            // id_subevento
            // 
            this.id_subevento.DataPropertyName = "id_subevento";
            this.id_subevento.HeaderText = "ID Subevento";
            this.id_subevento.Name = "id_subevento";
            this.id_subevento.ReadOnly = true;
            this.id_subevento.Visible = false;
            // 
            // id_desc_evento
            // 
            this.id_desc_evento.DataPropertyName = "id_desc_evento";
            this.id_desc_evento.HeaderText = "ID Desc Evento";
            this.id_desc_evento.Name = "id_desc_evento";
            this.id_desc_evento.ReadOnly = true;
            this.id_desc_evento.Visible = false;
            // 
            // id_inseminador
            // 
            this.id_inseminador.DataPropertyName = "id_inseminador";
            this.id_inseminador.HeaderText = "ID Inseminador";
            this.id_inseminador.Name = "id_inseminador";
            this.id_inseminador.ReadOnly = true;
            this.id_inseminador.Visible = false;
            // 
            // nombre_inseminador
            // 
            this.nombre_inseminador.DataPropertyName = "nombre_inseminador";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.nombre_inseminador.DefaultCellStyle = dataGridViewCellStyle3;
            this.nombre_inseminador.HeaderText = "Inseminador";
            this.nombre_inseminador.MinimumWidth = 10;
            this.nombre_inseminador.Name = "nombre_inseminador";
            this.nombre_inseminador.ReadOnly = true;
            // 
            // id_tambo
            // 
            this.id_tambo.DataPropertyName = "id_tambo";
            this.id_tambo.HeaderText = "ID Tambo";
            this.id_tambo.Name = "id_tambo";
            this.id_tambo.ReadOnly = true;
            this.id_tambo.Visible = false;
            // 
            // nombre_tambo
            // 
            this.nombre_tambo.DataPropertyName = "nombre_tambo";
            this.nombre_tambo.HeaderText = "Tambo";
            this.nombre_tambo.Name = "nombre_tambo";
            this.nombre_tambo.ReadOnly = true;
            this.nombre_tambo.Visible = false;
            // 
            // fecha_desc
            // 
            this.fecha_desc.DataPropertyName = "fecha_desc";
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.fecha_desc.DefaultCellStyle = dataGridViewCellStyle4;
            this.fecha_desc.HeaderText = "Fecha";
            this.fecha_desc.MinimumWidth = 10;
            this.fecha_desc.Name = "fecha_desc";
            this.fecha_desc.ReadOnly = true;
            this.fecha_desc.Width = 95;
            // 
            // nombre_animal
            // 
            this.nombre_animal.DataPropertyName = "nombre_animal";
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.nombre_animal.DefaultCellStyle = dataGridViewCellStyle5;
            this.nombre_animal.HeaderText = "Animal";
            this.nombre_animal.MinimumWidth = 10;
            this.nombre_animal.Name = "nombre_animal";
            this.nombre_animal.ReadOnly = true;
            this.nombre_animal.Width = 90;
            // 
            // nombre_evento
            // 
            this.nombre_evento.DataPropertyName = "nombre_evento";
            this.nombre_evento.HeaderText = "Evento";
            this.nombre_evento.Name = "nombre_evento";
            this.nombre_evento.ReadOnly = true;
            this.nombre_evento.Visible = false;
            // 
            // id_desc
            // 
            this.id_desc.DataPropertyName = "id_desc";
            this.id_desc.HeaderText = "ID Desc";
            this.id_desc.Name = "id_desc";
            this.id_desc.ReadOnly = true;
            this.id_desc.Visible = false;
            // 
            // estado_evento
            // 
            this.estado_evento.DataPropertyName = "estado_evento";
            this.estado_evento.HeaderText = "Estado";
            this.estado_evento.Name = "estado_evento";
            this.estado_evento.ReadOnly = true;
            this.estado_evento.Visible = false;
            // 
            // DetalleEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 205);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DetalleEventos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.DataGridView dgvDetalles;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_subevento;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn rp;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_evento;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_subevento;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_desc_evento;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_inseminador;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_inseminador;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_tambo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_tambo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_animal;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_evento;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado_evento;
    }
}