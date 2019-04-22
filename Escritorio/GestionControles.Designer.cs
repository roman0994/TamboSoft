namespace Escritorio
{
    partial class GestionControles
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
            this.tlpControles = new System.Windows.Forms.TableLayoutPanel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvControles = new System.Windows.Forms.DataGridView();
            this.fecha_control = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caravana = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_animal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_control = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_tambo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.primer_control = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grasa_primercontrol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.segundo_control = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grasa_segundocontrol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_tambo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kg_grasa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porcentaje_grasa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tlpControles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvControles)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpControles
            // 
            this.tlpControles.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tlpControles.ColumnCount = 3;
            this.tlpControles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.tlpControles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlpControles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlpControles.Controls.Add(this.btnEliminar, 0, 3);
            this.tlpControles.Controls.Add(this.btnEditar, 1, 3);
            this.tlpControles.Controls.Add(this.btnSalir, 2, 3);
            this.tlpControles.Controls.Add(this.label1, 0, 0);
            this.tlpControles.Controls.Add(this.dgvControles, 0, 2);
            this.tlpControles.Controls.Add(this.txtBuscar, 1, 1);
            this.tlpControles.Controls.Add(this.label2, 0, 1);
            this.tlpControles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpControles.Location = new System.Drawing.Point(0, 0);
            this.tlpControles.Name = "tlpControles";
            this.tlpControles.RowCount = 4;
            this.tlpControles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tlpControles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tlpControles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tlpControles.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpControles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpControles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpControles.Size = new System.Drawing.Size(800, 450);
            this.tlpControles.TabIndex = 0;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(96, 415);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 29);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnEditar.Location = new System.Drawing.Point(361, 415);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 29);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnSalir.Location = new System.Drawing.Point(627, 415);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 29);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tlpControles.SetColumnSpan(this.label1, 3);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(788, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "A continuación, se presenta la posibilidad de buscar un control según el parámetr" +
    "o requerido por el usuario, además para editar o eliminar debe seleccionar un re" +
    "gistro ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvControles
            // 
            this.dgvControles.AllowUserToAddRows = false;
            this.dgvControles.AllowUserToDeleteRows = false;
            this.dgvControles.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvControles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvControles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fecha_control,
            this.rp,
            this.caravana,
            this.nombre_animal,
            this.id_control,
            this.id_tambo,
            this.primer_control,
            this.grasa_primercontrol,
            this.segundo_control,
            this.grasa_segundocontrol,
            this.nombre_tambo,
            this.kg_grasa,
            this.porcentaje_grasa});
            this.tlpControles.SetColumnSpan(this.dgvControles, 3);
            this.dgvControles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvControles.Location = new System.Drawing.Point(6, 72);
            this.dgvControles.MultiSelect = false;
            this.dgvControles.Name = "dgvControles";
            this.dgvControles.ReadOnly = true;
            this.dgvControles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvControles.Size = new System.Drawing.Size(788, 334);
            this.dgvControles.TabIndex = 5;
            // 
            // fecha_control
            // 
            this.fecha_control.DataPropertyName = "fecha_control";
            this.fecha_control.HeaderText = "Fecha Control";
            this.fecha_control.Name = "fecha_control";
            this.fecha_control.ReadOnly = true;
            // 
            // rp
            // 
            this.rp.DataPropertyName = "rp";
            this.rp.HeaderText = "Rp";
            this.rp.Name = "rp";
            this.rp.ReadOnly = true;
            this.rp.Visible = false;
            // 
            // caravana
            // 
            this.caravana.DataPropertyName = "caravana";
            this.caravana.HeaderText = "Caravana";
            this.caravana.Name = "caravana";
            this.caravana.ReadOnly = true;
            this.caravana.Width = 87;
            // 
            // nombre_animal
            // 
            this.nombre_animal.DataPropertyName = "nombre_animal";
            this.nombre_animal.HeaderText = "Animal";
            this.nombre_animal.Name = "nombre_animal";
            this.nombre_animal.ReadOnly = true;
            this.nombre_animal.Width = 110;
            // 
            // id_control
            // 
            this.id_control.DataPropertyName = "id_control";
            this.id_control.HeaderText = "ID Control";
            this.id_control.Name = "id_control";
            this.id_control.ReadOnly = true;
            this.id_control.Visible = false;
            // 
            // id_tambo
            // 
            this.id_tambo.DataPropertyName = "id_tambo";
            this.id_tambo.HeaderText = "ID Tambo";
            this.id_tambo.Name = "id_tambo";
            this.id_tambo.ReadOnly = true;
            this.id_tambo.Visible = false;
            // 
            // primer_control
            // 
            this.primer_control.DataPropertyName = "primer_control";
            this.primer_control.HeaderText = "Primer Control (lts)";
            this.primer_control.Name = "primer_control";
            this.primer_control.ReadOnly = true;
            this.primer_control.Width = 95;
            // 
            // grasa_primercontrol
            // 
            this.grasa_primercontrol.DataPropertyName = "grasa_primercontrol";
            this.grasa_primercontrol.HeaderText = "Grasa Primer Control";
            this.grasa_primercontrol.Name = "grasa_primercontrol";
            this.grasa_primercontrol.ReadOnly = true;
            this.grasa_primercontrol.Width = 80;
            // 
            // segundo_control
            // 
            this.segundo_control.DataPropertyName = "segundo_control";
            this.segundo_control.HeaderText = "Segundo Control (lts)";
            this.segundo_control.Name = "segundo_control";
            this.segundo_control.ReadOnly = true;
            this.segundo_control.Width = 95;
            // 
            // grasa_segundocontrol
            // 
            this.grasa_segundocontrol.DataPropertyName = "grasa_segundocontrol";
            this.grasa_segundocontrol.HeaderText = "Grasa Segundo Control";
            this.grasa_segundocontrol.Name = "grasa_segundocontrol";
            this.grasa_segundocontrol.ReadOnly = true;
            this.grasa_segundocontrol.Width = 80;
            // 
            // nombre_tambo
            // 
            this.nombre_tambo.DataPropertyName = "nombre_tambo";
            this.nombre_tambo.HeaderText = "Tambo";
            this.nombre_tambo.Name = "nombre_tambo";
            this.nombre_tambo.ReadOnly = true;
            // 
            // kg_grasa
            // 
            this.kg_grasa.DataPropertyName = "kg_grasa";
            this.kg_grasa.HeaderText = "Kg Grasa";
            this.kg_grasa.Name = "kg_grasa";
            this.kg_grasa.ReadOnly = true;
            this.kg_grasa.Visible = false;
            // 
            // porcentaje_grasa
            // 
            this.porcentaje_grasa.DataPropertyName = "porcentaje_grasa";
            this.porcentaje_grasa.HeaderText = "% Grasa";
            this.porcentaje_grasa.Name = "porcentaje_grasa";
            this.porcentaje_grasa.ReadOnly = true;
            this.porcentaje_grasa.Visible = false;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(6, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "Buscar por nombre de animal:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GestionControles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tlpControles);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GestionControles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Controles";
            this.Activated += new System.EventHandler(this.GestionControles_Activated);
            this.tlpControles.ResumeLayout(false);
            this.tlpControles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvControles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpControles;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvControles;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_control;
        private System.Windows.Forms.DataGridViewTextBoxColumn rp;
        private System.Windows.Forms.DataGridViewTextBoxColumn caravana;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_animal;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_control;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_tambo;
        private System.Windows.Forms.DataGridViewTextBoxColumn primer_control;
        private System.Windows.Forms.DataGridViewTextBoxColumn grasa_primercontrol;
        private System.Windows.Forms.DataGridViewTextBoxColumn segundo_control;
        private System.Windows.Forms.DataGridViewTextBoxColumn grasa_segundocontrol;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_tambo;
        private System.Windows.Forms.DataGridViewTextBoxColumn kg_grasa;
        private System.Windows.Forms.DataGridViewTextBoxColumn porcentaje_grasa;
    }
}