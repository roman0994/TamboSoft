namespace Escritorio
{
    partial class ListadoEventos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListadoEventos));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvEventos = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbsRegresar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tbsNuevo = new System.Windows.Forms.ToolStripButton();
            this.tbsImprimir = new System.Windows.Forms.ToolStripButton();
            this.tbsExportar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.lblBuscar = new System.Windows.Forms.ToolStripLabel();
            this.tstxtBuscar = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.rp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_desc_evento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_evento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_animal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_evento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_subevento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_inseminador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_inseminador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_tambo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_tambo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado_evento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventos)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.tableLayoutPanel1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(800, 425);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(800, 450);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.dgvEventos, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSalir, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 425);
            this.tableLayoutPanel1.TabIndex = 0;
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
            this.id_inseminador,
            this.nombre_inseminador,
            this.id_tambo,
            this.nombre_tambo,
            this.estado_evento});
            this.tableLayoutPanel1.SetColumnSpan(this.dgvEventos, 2);
            this.dgvEventos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEventos.Location = new System.Drawing.Point(3, 3);
            this.dgvEventos.MultiSelect = false;
            this.dgvEventos.Name = "dgvEventos";
            this.dgvEventos.ReadOnly = true;
            this.dgvEventos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEventos.Size = new System.Drawing.Size(794, 390);
            this.dgvEventos.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.Location = new System.Drawing.Point(722, 399);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbsRegresar,
            this.toolStripSeparator1,
            this.tbsNuevo,
            this.tbsImprimir,
            this.tbsExportar,
            this.toolStripSeparator2,
            this.lblBuscar,
            this.tstxtBuscar,
            this.toolStripSeparator3,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(392, 25);
            this.toolStrip1.TabIndex = 0;
            // 
            // tbsRegresar
            // 
            this.tbsRegresar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbsRegresar.Image = ((System.Drawing.Image)(resources.GetObject("tbsRegresar.Image")));
            this.tbsRegresar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbsRegresar.Name = "tbsRegresar";
            this.tbsRegresar.Size = new System.Drawing.Size(23, 22);
            this.tbsRegresar.Text = "Regresar";
            this.tbsRegresar.Click += new System.EventHandler(this.tbsRegresar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tbsNuevo
            // 
            this.tbsNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbsNuevo.Image = ((System.Drawing.Image)(resources.GetObject("tbsNuevo.Image")));
            this.tbsNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbsNuevo.Name = "tbsNuevo";
            this.tbsNuevo.Size = new System.Drawing.Size(23, 22);
            this.tbsNuevo.Text = "Nuevo";
            this.tbsNuevo.Click += new System.EventHandler(this.tbsNuevo_Click);
            // 
            // tbsImprimir
            // 
            this.tbsImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbsImprimir.Image = ((System.Drawing.Image)(resources.GetObject("tbsImprimir.Image")));
            this.tbsImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbsImprimir.Name = "tbsImprimir";
            this.tbsImprimir.Size = new System.Drawing.Size(23, 22);
            this.tbsImprimir.Text = "Imprimir";
            // 
            // tbsExportar
            // 
            this.tbsExportar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbsExportar.Image = ((System.Drawing.Image)(resources.GetObject("tbsExportar.Image")));
            this.tbsExportar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbsExportar.Name = "tbsExportar";
            this.tbsExportar.Size = new System.Drawing.Size(23, 22);
            this.tbsExportar.Text = "Exportar a Excel";
            this.tbsExportar.Click += new System.EventHandler(this.tbsExportar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // lblBuscar
            // 
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(105, 22);
            this.lblBuscar.Text = "Buscar por evento:";
            // 
            // tstxtBuscar
            // 
            this.tstxtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tstxtBuscar.Name = "tstxtBuscar";
            this.tstxtBuscar.Size = new System.Drawing.Size(100, 25);
            this.tstxtBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tstxtBuscar_KeyUp);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(63, 22);
            this.toolStripButton1.Text = "Actualizar";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
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
            this.fecha_desc.Width = 80;
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
            this.descripcion.HeaderText = "Descripcion";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
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
            // estado_evento
            // 
            this.estado_evento.DataPropertyName = "estado_evento";
            this.estado_evento.HeaderText = "Estado";
            this.estado_evento.Name = "estado_evento";
            this.estado_evento.ReadOnly = true;
            // 
            // ListadoEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStripContainer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListadoEventos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eventos";
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventos)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvEventos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tbsRegresar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tbsNuevo;
        private System.Windows.Forms.ToolStripButton tbsImprimir;
        private System.Windows.Forms.ToolStripButton tbsExportar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel lblBuscar;
        private System.Windows.Forms.ToolStripTextBox tstxtBuscar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rp;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_desc_evento;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_evento;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_animal;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_evento;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_subevento;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_inseminador;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_inseminador;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_tambo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_tambo;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado_evento;
    }
}