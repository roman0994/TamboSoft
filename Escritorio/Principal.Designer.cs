namespace Escritorio
{
    partial class Principal
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
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.btnVolver = new System.Windows.Forms.Button();
            this.txtTambo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otrosTambosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarTamboToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónControlesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoControlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.animalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónEventosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónAnimalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaEventosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaAnimalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.animalesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.controlesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.eventosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inseminadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteProduccionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteEventosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeTamboSoftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.toolStripContainer1.ContentPanel.Controls.Add(this.btnVolver);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.txtTambo);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.label1);
            this.toolStripContainer1.ContentPanel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(800, 426);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(800, 450);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menuStrip1);
            // 
            // btnVolver
            // 
            this.btnVolver.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnVolver.Location = new System.Drawing.Point(51, 116);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(181, 28);
            this.btnVolver.TabIndex = 3;
            this.btnVolver.Text = "Volver a seleccionar tambo";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // txtTambo
            // 
            this.txtTambo.BackColor = System.Drawing.SystemColors.Control;
            this.txtTambo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTambo.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtTambo.Enabled = false;
            this.txtTambo.Font = new System.Drawing.Font("Segoe UI Semibold", 40F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTambo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtTambo.Location = new System.Drawing.Point(447, 15);
            this.txtTambo.Name = "txtTambo";
            this.txtTambo.ReadOnly = true;
            this.txtTambo.Size = new System.Drawing.Size(339, 72);
            this.txtTambo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(45, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usted está gestionando el tambo:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.generalToolStripMenuItem,
            this.controlesToolStripMenuItem,
            this.animalesToolStripMenuItem,
            this.listadosToolStripMenuItem,
            this.reporteMenuItem,
            this.acercaDeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // generalToolStripMenuItem
            // 
            this.generalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datosToolStripMenuItem,
            this.otrosTambosToolStripMenuItem,
            this.personalToolStripMenuItem,
            this.cargarTamboToolStripMenuItem});
            this.generalToolStripMenuItem.Name = "generalToolStripMenuItem";
            this.generalToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.generalToolStripMenuItem.Text = "Tambos";
            // 
            // datosToolStripMenuItem
            // 
            this.datosToolStripMenuItem.Name = "datosToolStripMenuItem";
            this.datosToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.datosToolStripMenuItem.Text = "Datos Tambo Actual";
            this.datosToolStripMenuItem.Click += new System.EventHandler(this.datosToolStripMenuItem_Click);
            // 
            // otrosTambosToolStripMenuItem
            // 
            this.otrosTambosToolStripMenuItem.Name = "otrosTambosToolStripMenuItem";
            this.otrosTambosToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.otrosTambosToolStripMenuItem.Text = "Gestionar Otros Tambos";
            this.otrosTambosToolStripMenuItem.Click += new System.EventHandler(this.otrosTambosToolStripMenuItem_Click);
            // 
            // personalToolStripMenuItem
            // 
            this.personalToolStripMenuItem.Name = "personalToolStripMenuItem";
            this.personalToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.personalToolStripMenuItem.Text = "Personal";
            this.personalToolStripMenuItem.Click += new System.EventHandler(this.personalToolStripMenuItem_Click);
            // 
            // cargarTamboToolStripMenuItem
            // 
            this.cargarTamboToolStripMenuItem.Name = "cargarTamboToolStripMenuItem";
            this.cargarTamboToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.cargarTamboToolStripMenuItem.Text = "Cargar Tambo";
            this.cargarTamboToolStripMenuItem.Click += new System.EventHandler(this.cargarTamboToolStripMenuItem_Click);
            // 
            // controlesToolStripMenuItem
            // 
            this.controlesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestiónControlesToolStripMenuItem,
            this.nuevoControlToolStripMenuItem});
            this.controlesToolStripMenuItem.Name = "controlesToolStripMenuItem";
            this.controlesToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.controlesToolStripMenuItem.Text = "Controles";
            // 
            // gestiónControlesToolStripMenuItem
            // 
            this.gestiónControlesToolStripMenuItem.Name = "gestiónControlesToolStripMenuItem";
            this.gestiónControlesToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.gestiónControlesToolStripMenuItem.Text = "Gestión Controles";
            this.gestiónControlesToolStripMenuItem.Click += new System.EventHandler(this.gestiónControlesToolStripMenuItem_Click);
            // 
            // nuevoControlToolStripMenuItem
            // 
            this.nuevoControlToolStripMenuItem.Name = "nuevoControlToolStripMenuItem";
            this.nuevoControlToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.nuevoControlToolStripMenuItem.Text = "Cargar Controles";
            this.nuevoControlToolStripMenuItem.Click += new System.EventHandler(this.nuevoControlToolStripMenuItem_Click);
            // 
            // animalesToolStripMenuItem
            // 
            this.animalesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestiónEventosToolStripMenuItem,
            this.gestiónAnimalesToolStripMenuItem,
            this.altaEventosToolStripMenuItem,
            this.altaAnimalesToolStripMenuItem});
            this.animalesToolStripMenuItem.Name = "animalesToolStripMenuItem";
            this.animalesToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.animalesToolStripMenuItem.Text = "Animales";
            // 
            // gestiónEventosToolStripMenuItem
            // 
            this.gestiónEventosToolStripMenuItem.Name = "gestiónEventosToolStripMenuItem";
            this.gestiónEventosToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.gestiónEventosToolStripMenuItem.Text = "Gestión Eventos";
            this.gestiónEventosToolStripMenuItem.Click += new System.EventHandler(this.gestiónEventosToolStripMenuItem_Click);
            // 
            // gestiónAnimalesToolStripMenuItem
            // 
            this.gestiónAnimalesToolStripMenuItem.Name = "gestiónAnimalesToolStripMenuItem";
            this.gestiónAnimalesToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.gestiónAnimalesToolStripMenuItem.Text = "Gestión Animales";
            this.gestiónAnimalesToolStripMenuItem.Click += new System.EventHandler(this.gestiónAnimalesToolStripMenuItem_Click);
            // 
            // altaEventosToolStripMenuItem
            // 
            this.altaEventosToolStripMenuItem.Name = "altaEventosToolStripMenuItem";
            this.altaEventosToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.altaEventosToolStripMenuItem.Text = "Cargar Eventos";
            this.altaEventosToolStripMenuItem.Click += new System.EventHandler(this.altaEventosToolStripMenuItem_Click);
            // 
            // altaAnimalesToolStripMenuItem
            // 
            this.altaAnimalesToolStripMenuItem.Name = "altaAnimalesToolStripMenuItem";
            this.altaAnimalesToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.altaAnimalesToolStripMenuItem.Text = "Cargar Animales";
            this.altaAnimalesToolStripMenuItem.Click += new System.EventHandler(this.altaAnimalesToolStripMenuItem_Click);
            // 
            // listadosToolStripMenuItem
            // 
            this.listadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.animalesToolStripMenuItem1,
            this.controlesToolStripMenuItem1,
            this.eventosToolStripMenuItem,
            this.inseminadoresToolStripMenuItem});
            this.listadosToolStripMenuItem.Name = "listadosToolStripMenuItem";
            this.listadosToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.listadosToolStripMenuItem.Text = "Listados";
            // 
            // animalesToolStripMenuItem1
            // 
            this.animalesToolStripMenuItem1.Name = "animalesToolStripMenuItem1";
            this.animalesToolStripMenuItem1.Size = new System.Drawing.Size(151, 22);
            this.animalesToolStripMenuItem1.Text = "Animales";
            this.animalesToolStripMenuItem1.Click += new System.EventHandler(this.animalesToolStripMenuItem1_Click);
            // 
            // controlesToolStripMenuItem1
            // 
            this.controlesToolStripMenuItem1.Name = "controlesToolStripMenuItem1";
            this.controlesToolStripMenuItem1.Size = new System.Drawing.Size(151, 22);
            this.controlesToolStripMenuItem1.Text = "Controles";
            this.controlesToolStripMenuItem1.Click += new System.EventHandler(this.controlesToolStripMenuItem1_Click);
            // 
            // eventosToolStripMenuItem
            // 
            this.eventosToolStripMenuItem.Name = "eventosToolStripMenuItem";
            this.eventosToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.eventosToolStripMenuItem.Text = "Eventos";
            this.eventosToolStripMenuItem.Click += new System.EventHandler(this.eventosToolStripMenuItem_Click);
            // 
            // inseminadoresToolStripMenuItem
            // 
            this.inseminadoresToolStripMenuItem.Name = "inseminadoresToolStripMenuItem";
            this.inseminadoresToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.inseminadoresToolStripMenuItem.Text = "Inseminadores";
            this.inseminadoresToolStripMenuItem.Click += new System.EventHandler(this.inseminadoresToolStripMenuItem_Click);
            // 
            // reporteMenuItem
            // 
            this.reporteMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteProduccionToolStripMenuItem,
            this.reporteEventosToolStripMenuItem1});
            this.reporteMenuItem.Name = "reporteMenuItem";
            this.reporteMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reporteMenuItem.Text = "Reportes";
            // 
            // reporteProduccionToolStripMenuItem
            // 
            this.reporteProduccionToolStripMenuItem.Name = "reporteProduccionToolStripMenuItem";
            this.reporteProduccionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.reporteProduccionToolStripMenuItem.Text = "Producción";
            this.reporteProduccionToolStripMenuItem.Click += new System.EventHandler(this.reporteProduccionToolStripMenuItem_Click);
            // 
            // reporteEventosToolStripMenuItem1
            // 
            this.reporteEventosToolStripMenuItem1.Name = "reporteEventosToolStripMenuItem1";
            this.reporteEventosToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.reporteEventosToolStripMenuItem1.Text = "Eventos";
            this.reporteEventosToolStripMenuItem1.Click += new System.EventHandler(this.reporteEventosToolStripMenuItem1_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeTamboSoftToolStripMenuItem});
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            // 
            // acercaDeTamboSoftToolStripMenuItem
            // 
            this.acercaDeTamboSoftToolStripMenuItem.Name = "acercaDeTamboSoftToolStripMenuItem";
            this.acercaDeTamboSoftToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.acercaDeTamboSoftToolStripMenuItem.Text = "Acerca de TamboSoft";
            this.acercaDeTamboSoftToolStripMenuItem.Click += new System.EventHandler(this.acercaDeTamboSoftToolStripMenuItem_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStripContainer1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Principal";
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otrosTambosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controlesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónControlesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem animalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónEventosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónAnimalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem animalesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem controlesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem eventosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inseminadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteProduccionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaEventosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaAnimalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoControlToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTambo;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.ToolStripMenuItem personalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarTamboToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeTamboSoftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteEventosToolStripMenuItem1;
    }
}