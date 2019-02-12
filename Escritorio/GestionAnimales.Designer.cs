﻿namespace Escritorio
{
    partial class GestionAnimales
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
            this.btnEditar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgvAnimales = new System.Windows.Forms.DataGridView();
            this.rp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.habilitado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_nacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_animal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hba = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rp_madre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rp_padre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hba_madre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hba_padre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_tambo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_tambo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_raza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_raza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbBuscar = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimales)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnEditar.Location = new System.Drawing.Point(362, 421);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 25);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.cbBuscar, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSalir, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtBuscar, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnEliminar, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnEditar, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.dgvAnimales, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.Location = new System.Drawing.Point(628, 421);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 25);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(270, 38);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(200, 20);
            this.txtBuscar.TabIndex = 2;
            this.txtBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 3);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(792, 30);
            this.label1.TabIndex = 7;
            this.label1.Text = "A continuación, se presenta la posibilidad de buscar un animal según el parámetro" +
    " requerido por el usuario, además para editar o eliminar debe seleccionar un ani" +
    "mal ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(96, 421);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 25);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dgvAnimales
            // 
            this.dgvAnimales.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvAnimales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnimales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rp,
            this.habilitado,
            this.fecha_nacimiento,
            this.edad,
            this.foto,
            this.nombre_animal,
            this.estado,
            this.hba,
            this.categoria,
            this.sexo,
            this.rp_madre,
            this.rp_padre,
            this.hba_madre,
            this.hba_padre,
            this.id_tambo,
            this.nombre_tambo,
            this.id_raza,
            this.nombre_raza});
            this.tableLayoutPanel1.SetColumnSpan(this.dgvAnimales, 3);
            this.dgvAnimales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAnimales.Location = new System.Drawing.Point(4, 68);
            this.dgvAnimales.MultiSelect = false;
            this.dgvAnimales.Name = "dgvAnimales";
            this.dgvAnimales.ReadOnly = true;
            this.dgvAnimales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAnimales.Size = new System.Drawing.Size(792, 346);
            this.dgvAnimales.TabIndex = 8;
            // 
            // rp
            // 
            this.rp.DataPropertyName = "rp";
            this.rp.HeaderText = "RP";
            this.rp.Name = "rp";
            this.rp.ReadOnly = true;
            this.rp.Width = 40;
            // 
            // habilitado
            // 
            this.habilitado.DataPropertyName = "habilitado";
            this.habilitado.HeaderText = "Habilitado";
            this.habilitado.Name = "habilitado";
            this.habilitado.ReadOnly = true;
            this.habilitado.Visible = false;
            // 
            // fecha_nacimiento
            // 
            this.fecha_nacimiento.DataPropertyName = "fecha_nacimiento";
            this.fecha_nacimiento.HeaderText = "Fecha de Nacimiento";
            this.fecha_nacimiento.Name = "fecha_nacimiento";
            this.fecha_nacimiento.ReadOnly = true;
            this.fecha_nacimiento.Width = 75;
            // 
            // edad
            // 
            this.edad.DataPropertyName = "edad";
            this.edad.HeaderText = "Edad";
            this.edad.Name = "edad";
            this.edad.ReadOnly = true;
            this.edad.Width = 40;
            // 
            // foto
            // 
            this.foto.DataPropertyName = "foto";
            this.foto.HeaderText = "Foto";
            this.foto.Name = "foto";
            this.foto.ReadOnly = true;
            // 
            // nombre_animal
            // 
            this.nombre_animal.DataPropertyName = "nombre_animal";
            this.nombre_animal.HeaderText = "Nombre Animal";
            this.nombre_animal.Name = "nombre_animal";
            this.nombre_animal.ReadOnly = true;
            // 
            // estado
            // 
            this.estado.DataPropertyName = "estado";
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            this.estado.Width = 75;
            // 
            // hba
            // 
            this.hba.DataPropertyName = "hba";
            this.hba.HeaderText = "HBA";
            this.hba.Name = "hba";
            this.hba.ReadOnly = true;
            this.hba.Width = 40;
            // 
            // categoria
            // 
            this.categoria.DataPropertyName = "categoria";
            this.categoria.HeaderText = "Categoria";
            this.categoria.Name = "categoria";
            this.categoria.ReadOnly = true;
            this.categoria.Width = 70;
            // 
            // sexo
            // 
            this.sexo.DataPropertyName = "sexo";
            this.sexo.HeaderText = "Sexo";
            this.sexo.Name = "sexo";
            this.sexo.ReadOnly = true;
            this.sexo.Width = 60;
            // 
            // rp_madre
            // 
            this.rp_madre.DataPropertyName = "rp_madre";
            this.rp_madre.HeaderText = "RP Madre";
            this.rp_madre.Name = "rp_madre";
            this.rp_madre.ReadOnly = true;
            this.rp_madre.Width = 50;
            // 
            // rp_padre
            // 
            this.rp_padre.DataPropertyName = "rp_padre";
            this.rp_padre.HeaderText = "RP Padre";
            this.rp_padre.Name = "rp_padre";
            this.rp_padre.ReadOnly = true;
            this.rp_padre.Width = 50;
            // 
            // hba_madre
            // 
            this.hba_madre.DataPropertyName = "hba_madre";
            this.hba_madre.HeaderText = "HBA Madre";
            this.hba_madre.Name = "hba_madre";
            this.hba_madre.ReadOnly = true;
            this.hba_madre.Width = 50;
            // 
            // hba_padre
            // 
            this.hba_padre.DataPropertyName = "hba_padre";
            this.hba_padre.HeaderText = "HBA Padre";
            this.hba_padre.Name = "hba_padre";
            this.hba_padre.ReadOnly = true;
            // 
            // id_tambo
            // 
            this.id_tambo.DataPropertyName = "id_tambo";
            this.id_tambo.HeaderText = "ID Tambo";
            this.id_tambo.Name = "id_tambo";
            this.id_tambo.ReadOnly = true;
            this.id_tambo.Visible = false;
            this.id_tambo.Width = 50;
            // 
            // nombre_tambo
            // 
            this.nombre_tambo.DataPropertyName = "nombre_tambo";
            this.nombre_tambo.HeaderText = "Tambo";
            this.nombre_tambo.Name = "nombre_tambo";
            this.nombre_tambo.ReadOnly = true;
            // 
            // id_raza
            // 
            this.id_raza.DataPropertyName = "id_raza";
            this.id_raza.HeaderText = "ID Raza";
            this.id_raza.Name = "id_raza";
            this.id_raza.ReadOnly = true;
            this.id_raza.Visible = false;
            // 
            // nombre_raza
            // 
            this.nombre_raza.DataPropertyName = "nombre_raza";
            this.nombre_raza.HeaderText = "Raza";
            this.nombre_raza.Name = "nombre_raza";
            this.nombre_raza.ReadOnly = true;
            // 
            // cbBuscar
            // 
            this.cbBuscar.FormattingEnabled = true;
            this.cbBuscar.Location = new System.Drawing.Point(4, 38);
            this.cbBuscar.Name = "cbBuscar";
            this.cbBuscar.Size = new System.Drawing.Size(200, 21);
            this.cbBuscar.TabIndex = 1;
            this.cbBuscar.Text = "Buscar por:";
            this.cbBuscar.SelectedIndexChanged += new System.EventHandler(this.cbBuscar_SelectedIndexChanged);
            // 
            // GestionAnimales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GestionAnimales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión Animales";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvAnimales;
        public System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn rp;
        private System.Windows.Forms.DataGridViewTextBoxColumn habilitado;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_nacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn foto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_animal;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn hba;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn rp_madre;
        private System.Windows.Forms.DataGridViewTextBoxColumn rp_padre;
        private System.Windows.Forms.DataGridViewTextBoxColumn hba_madre;
        private System.Windows.Forms.DataGridViewTextBoxColumn hba_padre;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_tambo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_tambo;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_raza;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_raza;
        private System.Windows.Forms.ComboBox cbBuscar;
    }
}