﻿namespace Escritorio
{
    partial class GestionEventos
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
            this.tblEventos = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbBuscar = new System.Windows.Forms.ComboBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgvEventos = new System.Windows.Forms.DataGridView();
            this.rp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_desc_evento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_evento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_animal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_evento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_subevento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_tambo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_tambo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_inseminador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_inseminador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado_evento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tblEventos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventos)).BeginInit();
            this.SuspendLayout();
            // 
            // tblEventos
            // 
            this.tblEventos.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tblEventos.ColumnCount = 3;
            this.tblEventos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.tblEventos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tblEventos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tblEventos.Controls.Add(this.label1, 0, 0);
            this.tblEventos.Controls.Add(this.cbBuscar, 0, 1);
            this.tblEventos.Controls.Add(this.txtBuscar, 1, 1);
            this.tblEventos.Controls.Add(this.btnEliminar, 0, 3);
            this.tblEventos.Controls.Add(this.dgvEventos, 0, 2);
            this.tblEventos.Controls.Add(this.btnExportar, 1, 3);
            this.tblEventos.Controls.Add(this.btnSalir, 2, 3);
            this.tblEventos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblEventos.Location = new System.Drawing.Point(0, 0);
            this.tblEventos.Name = "tblEventos";
            this.tblEventos.RowCount = 4;
            this.tblEventos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tblEventos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tblEventos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tblEventos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblEventos.Size = new System.Drawing.Size(800, 450);
            this.tblEventos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tblEventos.SetColumnSpan(this.label1, 4);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(788, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "A continuación, se presenta la posibilidad de buscar un evento según el parámetro" +
    " requerido por el usuario, además para editar o eliminar debe seleccionar un reg" +
    "istro ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbBuscar
            // 
            this.cbBuscar.FormattingEnabled = true;
            this.cbBuscar.Location = new System.Drawing.Point(6, 41);
            this.cbBuscar.Name = "cbBuscar";
            this.cbBuscar.Size = new System.Drawing.Size(200, 21);
            this.cbBuscar.TabIndex = 1;
            this.cbBuscar.Text = "Buscar por:";
            this.cbBuscar.SelectedIndexChanged += new System.EventHandler(this.cbBuscar_SelectedIndexChanged);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(271, 41);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(200, 20);
            this.txtBuscar.TabIndex = 2;
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
            this.txtBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyUp);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(96, 418);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 26);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dgvEventos
            // 
            this.dgvEventos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEventos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rp,
            this.id_desc_evento,
            this.id_evento,
            this.id_desc,
            this.fecha_desc,
            this.nombre_animal,
            this.nombre_evento,
            this.nombre_subevento,
            this.descripcion,
            this.id_tambo,
            this.nombre_tambo,
            this.id_inseminador,
            this.nombre_inseminador,
            this.estado_evento});
            this.tblEventos.SetColumnSpan(this.dgvEventos, 3);
            this.dgvEventos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEventos.Location = new System.Drawing.Point(6, 72);
            this.dgvEventos.MultiSelect = false;
            this.dgvEventos.Name = "dgvEventos";
            this.dgvEventos.ReadOnly = true;
            this.dgvEventos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEventos.Size = new System.Drawing.Size(788, 337);
            this.dgvEventos.TabIndex = 3;
            // 
            // rp
            // 
            this.rp.DataPropertyName = "rp";
            this.rp.HeaderText = "RP Animal";
            this.rp.Name = "rp";
            this.rp.ReadOnly = true;
            this.rp.Width = 80;
            // 
            // id_desc_evento
            // 
            this.id_desc_evento.DataPropertyName = "id_desc_evento";
            this.id_desc_evento.HeaderText = "ID";
            this.id_desc_evento.Name = "id_desc_evento";
            this.id_desc_evento.ReadOnly = true;
            this.id_desc_evento.Visible = false;
            // 
            // id_evento
            // 
            this.id_evento.DataPropertyName = "id_evento";
            this.id_evento.HeaderText = "ID Evento";
            this.id_evento.Name = "id_evento";
            this.id_evento.ReadOnly = true;
            this.id_evento.Visible = false;
            // 
            // id_desc
            // 
            this.id_desc.DataPropertyName = "id_desc";
            this.id_desc.HeaderText = "ID Descripcion";
            this.id_desc.Name = "id_desc";
            this.id_desc.ReadOnly = true;
            this.id_desc.Visible = false;
            // 
            // fecha_desc
            // 
            this.fecha_desc.DataPropertyName = "fecha_desc";
            this.fecha_desc.HeaderText = "Fecha";
            this.fecha_desc.Name = "fecha_desc";
            this.fecha_desc.ReadOnly = true;
            // 
            // nombre_animal
            // 
            this.nombre_animal.DataPropertyName = "nombre_animal";
            this.nombre_animal.HeaderText = "Animal";
            this.nombre_animal.Name = "nombre_animal";
            this.nombre_animal.ReadOnly = true;
            // 
            // nombre_evento
            // 
            this.nombre_evento.DataPropertyName = "nombre_evento";
            this.nombre_evento.HeaderText = "Evento";
            this.nombre_evento.Name = "nombre_evento";
            this.nombre_evento.ReadOnly = true;
            // 
            // nombre_subevento
            // 
            this.nombre_subevento.DataPropertyName = "nombre_subevento";
            this.nombre_subevento.HeaderText = "Subevento";
            this.nombre_subevento.Name = "nombre_subevento";
            this.nombre_subevento.ReadOnly = true;
            // 
            // descripcion
            // 
            this.descripcion.DataPropertyName = "descripcion";
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
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
            this.nombre_inseminador.HeaderText = "Inseminador";
            this.nombre_inseminador.Name = "nombre_inseminador";
            this.nombre_inseminador.ReadOnly = true;
            this.nombre_inseminador.Visible = false;
            // 
            // estado_evento
            // 
            this.estado_evento.DataPropertyName = "estado_evento";
            this.estado_evento.HeaderText = "Estado";
            this.estado_evento.Name = "estado_evento";
            this.estado_evento.ReadOnly = true;
            this.estado_evento.Visible = false;
            // 
            // btnExportar
            // 
            this.btnExportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnExportar.Location = new System.Drawing.Point(361, 418);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(75, 26);
            this.btnExportar.TabIndex = 5;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.Location = new System.Drawing.Point(627, 418);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 26);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // GestionEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tblEventos);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GestionEventos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de Eventos";
            this.tblEventos.ResumeLayout(false);
            this.tblEventos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblEventos;
        private System.Windows.Forms.ComboBox cbBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvEventos;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rp;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_desc_evento;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_evento;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_animal;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_evento;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_subevento;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_tambo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_tambo;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_inseminador;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_inseminador;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado_evento;
    }
}