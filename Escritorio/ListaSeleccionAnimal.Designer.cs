namespace Escritorio
{
    partial class ListaSeleccionAnimal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaSeleccionAnimal));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.tlpAnimales = new System.Windows.Forms.TableLayoutPanel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgvAnimales = new System.Windows.Forms.DataGridView();
            this.btn_seleccion = new System.Windows.Forms.DataGridViewButtonColumn();
            this.caravana = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_nacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_animal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado_animal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hba = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_raza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rp_madre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rp_padre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hba_madre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hba_padre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.habilitado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_tambo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_tambo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_raza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbRegresar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.lblBuscar = new System.Windows.Forms.ToolStripLabel();
            this.tstxtBuscar = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbActualizar = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.tlpAnimales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimales)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.tlpAnimales);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(845, 425);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(845, 450);
            this.toolStripContainer1.TabIndex = 1;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // tlpAnimales
            // 
            this.tlpAnimales.BackColor = System.Drawing.SystemColors.Control;
            this.tlpAnimales.ColumnCount = 2;
            this.tlpAnimales.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAnimales.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpAnimales.Controls.Add(this.btnSalir, 1, 1);
            this.tlpAnimales.Controls.Add(this.dgvAnimales, 0, 0);
            this.tlpAnimales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAnimales.Location = new System.Drawing.Point(0, 0);
            this.tlpAnimales.Name = "tlpAnimales";
            this.tlpAnimales.RowCount = 2;
            this.tlpAnimales.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAnimales.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpAnimales.Size = new System.Drawing.Size(845, 425);
            this.tlpAnimales.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.Location = new System.Drawing.Point(767, 399);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgvAnimales
            // 
            this.dgvAnimales.AllowUserToAddRows = false;
            this.dgvAnimales.AllowUserToDeleteRows = false;
            this.dgvAnimales.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvAnimales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnimales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btn_seleccion,
            this.caravana,
            this.fecha_nacimiento,
            this.edad,
            this.nombre_animal,
            this.estado_animal,
            this.hba,
            this.categoria,
            this.nombre_raza,
            this.rp_madre,
            this.rp_padre,
            this.hba_madre,
            this.hba_padre,
            this.rp,
            this.foto,
            this.habilitado,
            this.id_tambo,
            this.id_categoria,
            this.nombre_tambo,
            this.id_raza});
            this.tlpAnimales.SetColumnSpan(this.dgvAnimales, 2);
            this.dgvAnimales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAnimales.GridColor = System.Drawing.SystemColors.Control;
            this.dgvAnimales.Location = new System.Drawing.Point(3, 3);
            this.dgvAnimales.MultiSelect = false;
            this.dgvAnimales.Name = "dgvAnimales";
            this.dgvAnimales.ReadOnly = true;
            this.dgvAnimales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAnimales.Size = new System.Drawing.Size(839, 390);
            this.dgvAnimales.TabIndex = 1;
            this.dgvAnimales.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAnimales_CellContentClick);
            this.dgvAnimales.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvAnimales_DataBindingComplete);
            // 
            // btn_seleccion
            // 
            this.btn_seleccion.HeaderText = "*";
            this.btn_seleccion.Name = "btn_seleccion";
            this.btn_seleccion.ReadOnly = true;
            this.btn_seleccion.Text = "Seleccionar";
            this.btn_seleccion.UseColumnTextForButtonValue = true;
            this.btn_seleccion.Width = 70;
            // 
            // caravana
            // 
            this.caravana.DataPropertyName = "caravana";
            this.caravana.HeaderText = "Caravana";
            this.caravana.Name = "caravana";
            this.caravana.ReadOnly = true;
            // 
            // fecha_nacimiento
            // 
            this.fecha_nacimiento.DataPropertyName = "fecha_nacimiento";
            this.fecha_nacimiento.HeaderText = "Fecha de nacimiento";
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
            // nombre_animal
            // 
            this.nombre_animal.DataPropertyName = "nombre_animal";
            this.nombre_animal.HeaderText = "Nombre animal";
            this.nombre_animal.Name = "nombre_animal";
            this.nombre_animal.ReadOnly = true;
            // 
            // estado_animal
            // 
            this.estado_animal.DataPropertyName = "estado_animal";
            this.estado_animal.HeaderText = "Estado";
            this.estado_animal.Name = "estado_animal";
            this.estado_animal.ReadOnly = true;
            this.estado_animal.Width = 75;
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
            this.categoria.DataPropertyName = "descripcion";
            this.categoria.HeaderText = "Categoría";
            this.categoria.Name = "categoria";
            this.categoria.ReadOnly = true;
            this.categoria.Width = 70;
            // 
            // nombre_raza
            // 
            this.nombre_raza.DataPropertyName = "nombre_raza";
            this.nombre_raza.HeaderText = "Raza";
            this.nombre_raza.Name = "nombre_raza";
            this.nombre_raza.ReadOnly = true;
            // 
            // rp_madre
            // 
            this.rp_madre.DataPropertyName = "rp_madre";
            this.rp_madre.HeaderText = "Caravana Madre";
            this.rp_madre.Name = "rp_madre";
            this.rp_madre.ReadOnly = true;
            this.rp_madre.Width = 60;
            // 
            // rp_padre
            // 
            this.rp_padre.DataPropertyName = "rp_padre";
            this.rp_padre.HeaderText = "Caravana Padre";
            this.rp_padre.Name = "rp_padre";
            this.rp_padre.ReadOnly = true;
            this.rp_padre.Width = 60;
            // 
            // hba_madre
            // 
            this.hba_madre.DataPropertyName = "hba_madre";
            this.hba_madre.HeaderText = "HBA Madre";
            this.hba_madre.Name = "hba_madre";
            this.hba_madre.ReadOnly = true;
            this.hba_madre.Visible = false;
            this.hba_madre.Width = 50;
            // 
            // hba_padre
            // 
            this.hba_padre.DataPropertyName = "hba_padre";
            this.hba_padre.HeaderText = "HBA Padre";
            this.hba_padre.Name = "hba_padre";
            this.hba_padre.ReadOnly = true;
            this.hba_padre.Visible = false;
            this.hba_padre.Width = 50;
            // 
            // rp
            // 
            this.rp.DataPropertyName = "rp";
            this.rp.HeaderText = "RP";
            this.rp.Name = "rp";
            this.rp.ReadOnly = true;
            this.rp.Visible = false;
            this.rp.Width = 40;
            // 
            // foto
            // 
            this.foto.DataPropertyName = "foto";
            this.foto.HeaderText = "Foto";
            this.foto.Name = "foto";
            this.foto.ReadOnly = true;
            this.foto.Visible = false;
            // 
            // habilitado
            // 
            this.habilitado.DataPropertyName = "habilitado";
            this.habilitado.HeaderText = "Habilitado";
            this.habilitado.Name = "habilitado";
            this.habilitado.ReadOnly = true;
            this.habilitado.Visible = false;
            // 
            // id_tambo
            // 
            this.id_tambo.DataPropertyName = "id_tambo";
            this.id_tambo.HeaderText = "ID Tambo";
            this.id_tambo.Name = "id_tambo";
            this.id_tambo.ReadOnly = true;
            this.id_tambo.Visible = false;
            this.id_tambo.Width = 40;
            // 
            // id_categoria
            // 
            this.id_categoria.DataPropertyName = "id_categoria";
            this.id_categoria.HeaderText = "ID categoria";
            this.id_categoria.Name = "id_categoria";
            this.id_categoria.ReadOnly = true;
            this.id_categoria.Visible = false;
            // 
            // nombre_tambo
            // 
            this.nombre_tambo.DataPropertyName = "nombre_tambo";
            this.nombre_tambo.HeaderText = "Tambo";
            this.nombre_tambo.Name = "nombre_tambo";
            this.nombre_tambo.ReadOnly = true;
            this.nombre_tambo.Visible = false;
            // 
            // id_raza
            // 
            this.id_raza.DataPropertyName = "id_raza";
            this.id_raza.HeaderText = "ID Raza";
            this.id_raza.Name = "id_raza";
            this.id_raza.ReadOnly = true;
            this.id_raza.Visible = false;
            this.id_raza.Width = 40;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbRegresar,
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.lblBuscar,
            this.tstxtBuscar,
            this.toolStripSeparator3,
            this.tsbActualizar});
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(334, 25);
            this.toolStrip1.TabIndex = 0;
            // 
            // tsbRegresar
            // 
            this.tsbRegresar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRegresar.Image = ((System.Drawing.Image)(resources.GetObject("tsbRegresar.Image")));
            this.tsbRegresar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRegresar.Name = "tsbRegresar";
            this.tsbRegresar.Size = new System.Drawing.Size(23, 22);
            this.tsbRegresar.Text = "Regresar";
            this.tsbRegresar.Click += new System.EventHandler(this.tbsRegresar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // lblBuscar
            // 
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(116, 22);
            this.lblBuscar.Text = "Buscar por caravana:";
            // 
            // tstxtBuscar
            // 
            this.tstxtBuscar.BackColor = System.Drawing.SystemColors.Window;
            this.tstxtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tstxtBuscar.Name = "tstxtBuscar";
            this.tstxtBuscar.Size = new System.Drawing.Size(100, 25);
            this.tstxtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tstxtBuscar_KeyPress);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbActualizar
            // 
            this.tsbActualizar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.tsbActualizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbActualizar.Image = ((System.Drawing.Image)(resources.GetObject("tsbActualizar.Image")));
            this.tsbActualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbActualizar.Name = "tsbActualizar";
            this.tsbActualizar.Size = new System.Drawing.Size(63, 22);
            this.tsbActualizar.Text = "Actualizar";
            this.tsbActualizar.Click += new System.EventHandler(this.tbsActualizar_Click);
            // 
            // ListaSeleccionAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(845, 450);
            this.Controls.Add(this.toolStripContainer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListaSeleccionAnimal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selección de Animal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ListaSeleccionAnimal_FormClosing);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.tlpAnimales.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimales)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.TableLayoutPanel tlpAnimales;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgvAnimales;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbRegresar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel lblBuscar;
        private System.Windows.Forms.ToolStripTextBox tstxtBuscar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbActualizar;
        private System.Windows.Forms.DataGridViewButtonColumn btn_seleccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn caravana;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_nacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_animal;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado_animal;
        private System.Windows.Forms.DataGridViewTextBoxColumn hba;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_raza;
        private System.Windows.Forms.DataGridViewTextBoxColumn rp_madre;
        private System.Windows.Forms.DataGridViewTextBoxColumn rp_padre;
        private System.Windows.Forms.DataGridViewTextBoxColumn hba_madre;
        private System.Windows.Forms.DataGridViewTextBoxColumn hba_padre;
        private System.Windows.Forms.DataGridViewTextBoxColumn rp;
        private System.Windows.Forms.DataGridViewTextBoxColumn foto;
        private System.Windows.Forms.DataGridViewTextBoxColumn habilitado;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_tambo;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_tambo;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_raza;
    }
}