namespace Escritorio
{
    partial class ListadoControles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListadoControles));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgvControles = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbRegresar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbImprimir = new System.Windows.Forms.ToolStripButton();
            this.tsbExportar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.lblBuscar = new System.Windows.Forms.ToolStripLabel();
            this.tstxtBuscar = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbActualizar = new System.Windows.Forms.ToolStripButton();
            this.fecha_control = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_animal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_control = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.primer_control = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.segundo_control = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porcentaje_grasa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kg_grasa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_tambo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_tambo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvControles)).BeginInit();
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
            this.tableLayoutPanel1.Controls.Add(this.btnSalir, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.dgvControles, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 425);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.Location = new System.Drawing.Point(722, 399);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgvControles
            // 
            this.dgvControles.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvControles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvControles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fecha_control,
            this.rp,
            this.nombre_animal,
            this.id_control,
            this.primer_control,
            this.segundo_control,
            this.porcentaje_grasa,
            this.kg_grasa,
            this.id_tambo,
            this.nombre_tambo});
            this.tableLayoutPanel1.SetColumnSpan(this.dgvControles, 2);
            this.dgvControles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvControles.Location = new System.Drawing.Point(3, 3);
            this.dgvControles.MultiSelect = false;
            this.dgvControles.Name = "dgvControles";
            this.dgvControles.ReadOnly = true;
            this.dgvControles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvControles.Size = new System.Drawing.Size(794, 390);
            this.dgvControles.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbRegresar,
            this.toolStripSeparator1,
            this.tsbNuevo,
            this.tsbImprimir,
            this.tsbExportar,
            this.toolStripSeparator2,
            this.lblBuscar,
            this.tstxtBuscar,
            this.toolStripSeparator3,
            this.tsbActualizar});
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(392, 25);
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
            // tsbNuevo
            // 
            this.tsbNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNuevo.Image = ((System.Drawing.Image)(resources.GetObject("tsbNuevo.Image")));
            this.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(23, 22);
            this.tsbNuevo.Text = "Nuevo";
            this.tsbNuevo.Click += new System.EventHandler(this.tbsNuevo_Click);
            // 
            // tsbImprimir
            // 
            this.tsbImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbImprimir.Image = ((System.Drawing.Image)(resources.GetObject("tsbImprimir.Image")));
            this.tsbImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbImprimir.Name = "tsbImprimir";
            this.tsbImprimir.Size = new System.Drawing.Size(23, 22);
            this.tsbImprimir.Text = "Imprimir";
            // 
            // tsbExportar
            // 
            this.tsbExportar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbExportar.Image = ((System.Drawing.Image)(resources.GetObject("tsbExportar.Image")));
            this.tsbExportar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExportar.Name = "tsbExportar";
            this.tsbExportar.Size = new System.Drawing.Size(23, 22);
            this.tsbExportar.Text = "Exportar a Excel";
            this.tsbExportar.Click += new System.EventHandler(this.tbsExportar_Click);
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
            this.lblBuscar.Text = "Buscar por animal:";
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
            // tsbActualizar
            // 
            this.tsbActualizar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.tsbActualizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbActualizar.Image = ((System.Drawing.Image)(resources.GetObject("tsbActualizar.Image")));
            this.tsbActualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbActualizar.Name = "tsbActualizar";
            this.tsbActualizar.Size = new System.Drawing.Size(63, 22);
            this.tsbActualizar.Text = "Actualizar";
            this.tsbActualizar.Click += new System.EventHandler(this.tsbActualizar_Click);
            // 
            // fecha_control
            // 
            this.fecha_control.DataPropertyName = "fecha_control";
            this.fecha_control.HeaderText = "Fecha control";
            this.fecha_control.Name = "fecha_control";
            this.fecha_control.ReadOnly = true;
            // 
            // rp
            // 
            this.rp.DataPropertyName = "rp";
            this.rp.HeaderText = "RP Animal";
            this.rp.Name = "rp";
            this.rp.ReadOnly = true;
            this.rp.Width = 87;
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
            // primer_control
            // 
            this.primer_control.DataPropertyName = "primer_control";
            this.primer_control.HeaderText = "Primer control (lts)";
            this.primer_control.Name = "primer_control";
            this.primer_control.ReadOnly = true;
            this.primer_control.Width = 95;
            // 
            // segundo_control
            // 
            this.segundo_control.DataPropertyName = "segundo_control";
            this.segundo_control.HeaderText = "Segundo control (lts)";
            this.segundo_control.Name = "segundo_control";
            this.segundo_control.ReadOnly = true;
            this.segundo_control.Width = 95;
            // 
            // porcentaje_grasa
            // 
            this.porcentaje_grasa.DataPropertyName = "porcentaje_grasa";
            this.porcentaje_grasa.HeaderText = "% Grasa";
            this.porcentaje_grasa.Name = "porcentaje_grasa";
            this.porcentaje_grasa.ReadOnly = true;
            this.porcentaje_grasa.Width = 80;
            // 
            // kg_grasa
            // 
            this.kg_grasa.DataPropertyName = "kg_grasa";
            this.kg_grasa.HeaderText = "Kg Grasa";
            this.kg_grasa.Name = "kg_grasa";
            this.kg_grasa.ReadOnly = true;
            this.kg_grasa.Width = 80;
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
            // ListadoControles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStripContainer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListadoControles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controles";
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvControles)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgvControles;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbRegresar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbImprimir;
        private System.Windows.Forms.ToolStripButton tsbExportar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel lblBuscar;
        private System.Windows.Forms.ToolStripTextBox tstxtBuscar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbActualizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_control;
        private System.Windows.Forms.DataGridViewTextBoxColumn rp;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_animal;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_control;
        private System.Windows.Forms.DataGridViewTextBoxColumn primer_control;
        private System.Windows.Forms.DataGridViewTextBoxColumn segundo_control;
        private System.Windows.Forms.DataGridViewTextBoxColumn porcentaje_grasa;
        private System.Windows.Forms.DataGridViewTextBoxColumn kg_grasa;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_tambo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_tambo;
    }
}