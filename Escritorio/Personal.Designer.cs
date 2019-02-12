namespace Escritorio
{
    partial class Personal
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
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.gbTambo = new System.Windows.Forms.GroupBox();
            this.txtTambo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbPersonal = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvPersonal = new System.Windows.Forms.DataGridView();
            this.id_tambo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_inseminador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_inseminador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado_inseminador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_localidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_localidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_tambo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbTambo.SuspendLayout();
            this.gbPersonal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonal)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btnEliminar, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnNuevo, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.gbTambo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gbPersonal, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSalir, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnModificar, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminar.Location = new System.Drawing.Point(63, 412);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 32);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnNuevo.Location = new System.Drawing.Point(262, 412);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 32);
            this.btnNuevo.TabIndex = 4;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // gbTambo
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.gbTambo, 4);
            this.gbTambo.Controls.Add(this.txtTambo);
            this.gbTambo.Controls.Add(this.label1);
            this.gbTambo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbTambo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTambo.Location = new System.Drawing.Point(6, 6);
            this.gbTambo.Name = "gbTambo";
            this.gbTambo.Size = new System.Drawing.Size(788, 94);
            this.gbTambo.TabIndex = 3;
            this.gbTambo.TabStop = false;
            this.gbTambo.Text = "Tambo";
            // 
            // txtTambo
            // 
            this.txtTambo.Location = new System.Drawing.Point(240, 41);
            this.txtTambo.Name = "txtTambo";
            this.txtTambo.ReadOnly = true;
            this.txtTambo.Size = new System.Drawing.Size(200, 20);
            this.txtTambo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Personal correspondiente al tambo:";
            // 
            // gbPersonal
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.gbPersonal, 4);
            this.gbPersonal.Controls.Add(this.label2);
            this.gbPersonal.Controls.Add(this.dgvPersonal);
            this.gbPersonal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPersonal.Location = new System.Drawing.Point(6, 109);
            this.gbPersonal.Name = "gbPersonal";
            this.gbPersonal.Size = new System.Drawing.Size(788, 294);
            this.gbPersonal.TabIndex = 4;
            this.gbPersonal.TabStop = false;
            this.gbPersonal.Text = "Personal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(299, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Para editar o eliminar, debe seleccionar un registro de la tabla:\r\n";
            // 
            // dgvPersonal
            // 
            this.dgvPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_tambo,
            this.id_inseminador,
            this.nombre_inseminador,
            this.estado_inseminador,
            this.telefono,
            this.direccion,
            this.dni,
            this.id_localidad,
            this.nombre_localidad,
            this.nombre_tambo});
            this.dgvPersonal.Location = new System.Drawing.Point(34, 68);
            this.dgvPersonal.MultiSelect = false;
            this.dgvPersonal.Name = "dgvPersonal";
            this.dgvPersonal.ReadOnly = true;
            this.dgvPersonal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersonal.Size = new System.Drawing.Size(731, 212);
            this.dgvPersonal.TabIndex = 2;
            // 
            // id_tambo
            // 
            this.id_tambo.DataPropertyName = "id_tambo";
            this.id_tambo.HeaderText = "ID Tambo";
            this.id_tambo.Name = "id_tambo";
            this.id_tambo.ReadOnly = true;
            this.id_tambo.Visible = false;
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
            this.nombre_inseminador.Width = 185;
            // 
            // estado_inseminador
            // 
            this.estado_inseminador.DataPropertyName = "estado_inseminador";
            this.estado_inseminador.HeaderText = "Estado";
            this.estado_inseminador.Name = "estado_inseminador";
            this.estado_inseminador.ReadOnly = true;
            this.estado_inseminador.Visible = false;
            // 
            // telefono
            // 
            this.telefono.DataPropertyName = "telefono";
            this.telefono.HeaderText = "Teléfono";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            // 
            // direccion
            // 
            this.direccion.DataPropertyName = "direccion";
            this.direccion.HeaderText = "Dirección";
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            // 
            // dni
            // 
            this.dni.DataPropertyName = "dni";
            this.dni.HeaderText = "DNI";
            this.dni.Name = "dni";
            this.dni.ReadOnly = true;
            // 
            // id_localidad
            // 
            this.id_localidad.DataPropertyName = "id_localidad";
            this.id_localidad.HeaderText = "ID Localidad";
            this.id_localidad.Name = "id_localidad";
            this.id_localidad.ReadOnly = true;
            this.id_localidad.Visible = false;
            // 
            // nombre_localidad
            // 
            this.nombre_localidad.DataPropertyName = "nombre_localidad";
            this.nombre_localidad.HeaderText = "Localidad";
            this.nombre_localidad.Name = "nombre_localidad";
            this.nombre_localidad.ReadOnly = true;
            // 
            // nombre_tambo
            // 
            this.nombre_tambo.DataPropertyName = "nombre_tambo";
            this.nombre_tambo.HeaderText = "Tambo";
            this.nombre_tambo.Name = "nombre_tambo";
            this.nombre_tambo.ReadOnly = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.Location = new System.Drawing.Point(661, 412);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 32);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnModificar.Location = new System.Drawing.Point(461, 412);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 32);
            this.btnModificar.TabIndex = 5;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // Personal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Personal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personal";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.gbTambo.ResumeLayout(false);
            this.gbTambo.PerformLayout();
            this.gbPersonal.ResumeLayout(false);
            this.gbPersonal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox gbTambo;
        private System.Windows.Forms.GroupBox gbPersonal;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPersonal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTambo;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_tambo;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_inseminador;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_inseminador;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado_inseminador;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_localidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_localidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_tambo;
    }
}