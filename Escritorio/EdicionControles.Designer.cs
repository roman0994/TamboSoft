namespace Escritorio
{
    partial class EdicionControles
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
            this.components = new System.ComponentModel.Container();
            this.tlpControles = new System.Windows.Forms.TableLayoutPanel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gbAnimal = new System.Windows.Forms.GroupBox();
            this.cbAnimal = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbControl = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtGrasaSegundoControl = new System.Windows.Forms.TextBox();
            this.txtGrasaPrimerControl = new System.Windows.Forms.TextBox();
            this.txtSegundoControl = new System.Windows.Forms.TextBox();
            this.txtPrimerControl = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbFechaControl = new System.Windows.Forms.GroupBox();
            this.dtpFechaControl = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdControl = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tooltipControles = new System.Windows.Forms.ToolTip(this.components);
            this.tlpControles.SuspendLayout();
            this.gbAnimal.SuspendLayout();
            this.gbControl.SuspendLayout();
            this.gbFechaControl.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpControles
            // 
            this.tlpControles.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tlpControles.ColumnCount = 3;
            this.tlpControles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.64706F));
            this.tlpControles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.17647F));
            this.tlpControles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.17647F));
            this.tlpControles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpControles.Controls.Add(this.btnGuardar, 1, 5);
            this.tlpControles.Controls.Add(this.label1, 0, 0);
            this.tlpControles.Controls.Add(this.gbAnimal, 0, 2);
            this.tlpControles.Controls.Add(this.gbControl, 0, 3);
            this.tlpControles.Controls.Add(this.gbFechaControl, 0, 4);
            this.tlpControles.Controls.Add(this.groupBox1, 0, 1);
            this.tlpControles.Controls.Add(this.btnSalir, 2, 5);
            this.tlpControles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpControles.Location = new System.Drawing.Point(0, 0);
            this.tlpControles.Name = "tlpControles";
            this.tlpControles.RowCount = 6;
            this.tlpControles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tlpControles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tlpControles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tlpControles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44F));
            this.tlpControles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tlpControles.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpControles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpControles.Size = new System.Drawing.Size(800, 450);
            this.tlpControles.TabIndex = 0;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(148, 421);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tlpControles.SetColumnSpan(this.label1, 3);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(788, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Modifique los datos del control:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gbAnimal
            // 
            this.tlpControles.SetColumnSpan(this.gbAnimal, 3);
            this.gbAnimal.Controls.Add(this.cbAnimal);
            this.gbAnimal.Controls.Add(this.label3);
            this.gbAnimal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAnimal.Location = new System.Drawing.Point(6, 108);
            this.gbAnimal.Name = "gbAnimal";
            this.gbAnimal.Size = new System.Drawing.Size(788, 58);
            this.gbAnimal.TabIndex = 3;
            this.gbAnimal.TabStop = false;
            this.gbAnimal.Text = "Animal";
            // 
            // cbAnimal
            // 
            this.cbAnimal.FormattingEnabled = true;
            this.cbAnimal.Location = new System.Drawing.Point(191, 26);
            this.cbAnimal.Name = "cbAnimal";
            this.cbAnimal.Size = new System.Drawing.Size(201, 21);
            this.cbAnimal.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Seleccione el animal: *";
            // 
            // gbControl
            // 
            this.tlpControles.SetColumnSpan(this.gbControl, 3);
            this.gbControl.Controls.Add(this.label9);
            this.gbControl.Controls.Add(this.txtGrasaSegundoControl);
            this.gbControl.Controls.Add(this.txtGrasaPrimerControl);
            this.gbControl.Controls.Add(this.txtSegundoControl);
            this.gbControl.Controls.Add(this.txtPrimerControl);
            this.gbControl.Controls.Add(this.label7);
            this.gbControl.Controls.Add(this.label6);
            this.gbControl.Controls.Add(this.label5);
            this.gbControl.Controls.Add(this.label4);
            this.gbControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbControl.Location = new System.Drawing.Point(6, 175);
            this.gbControl.Name = "gbControl";
            this.gbControl.Size = new System.Drawing.Size(788, 170);
            this.gbControl.TabIndex = 4;
            this.gbControl.TabStop = false;
            this.gbControl.Text = "Datos Control";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(533, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "* Campos obligatorios.";
            // 
            // txtGrasaSegundoControl
            // 
            this.txtGrasaSegundoControl.Location = new System.Drawing.Point(191, 141);
            this.txtGrasaSegundoControl.Name = "txtGrasaSegundoControl";
            this.txtGrasaSegundoControl.Size = new System.Drawing.Size(200, 20);
            this.txtGrasaSegundoControl.TabIndex = 5;
            this.txtGrasaSegundoControl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKgGrasa_KeyPress);
            // 
            // txtGrasaPrimerControl
            // 
            this.txtGrasaPrimerControl.Location = new System.Drawing.Point(192, 68);
            this.txtGrasaPrimerControl.Name = "txtGrasaPrimerControl";
            this.txtGrasaPrimerControl.Size = new System.Drawing.Size(200, 20);
            this.txtGrasaPrimerControl.TabIndex = 4;
            this.txtGrasaPrimerControl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPorcentajeGrasa_KeyPress);
            // 
            // txtSegundoControl
            // 
            this.txtSegundoControl.Location = new System.Drawing.Point(191, 105);
            this.txtSegundoControl.Name = "txtSegundoControl";
            this.txtSegundoControl.Size = new System.Drawing.Size(200, 20);
            this.txtSegundoControl.TabIndex = 3;
            this.txtSegundoControl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSegundoControl_KeyPress);
            // 
            // txtPrimerControl
            // 
            this.txtPrimerControl.Location = new System.Drawing.Point(191, 24);
            this.txtPrimerControl.Name = "txtPrimerControl";
            this.txtPrimerControl.Size = new System.Drawing.Size(200, 20);
            this.txtPrimerControl.TabIndex = 2;
            this.txtPrimerControl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrimerControl_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Grasa segundo control: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Grasa primer control: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Segundo control: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Primer control: ";
            // 
            // gbFechaControl
            // 
            this.tlpControles.SetColumnSpan(this.gbFechaControl, 3);
            this.gbFechaControl.Controls.Add(this.dtpFechaControl);
            this.gbFechaControl.Controls.Add(this.label8);
            this.gbFechaControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbFechaControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFechaControl.Location = new System.Drawing.Point(6, 354);
            this.gbFechaControl.Name = "gbFechaControl";
            this.gbFechaControl.Size = new System.Drawing.Size(788, 58);
            this.gbFechaControl.TabIndex = 5;
            this.gbFechaControl.TabStop = false;
            this.gbFechaControl.Text = "Fecha Control";
            // 
            // dtpFechaControl
            // 
            this.dtpFechaControl.Location = new System.Drawing.Point(191, 20);
            this.dtpFechaControl.Name = "dtpFechaControl";
            this.dtpFechaControl.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaControl.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(28, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Seleccione la fecha: *";
            // 
            // groupBox1
            // 
            this.tlpControles.SetColumnSpan(this.groupBox1, 3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtIdControl);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(788, 58);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id Control:";
            // 
            // txtIdControl
            // 
            this.txtIdControl.Location = new System.Drawing.Point(191, 24);
            this.txtIdControl.Name = "txtIdControl";
            this.txtIdControl.ReadOnly = true;
            this.txtIdControl.Size = new System.Drawing.Size(200, 20);
            this.txtIdControl.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnSalir.Location = new System.Drawing.Point(597, 421);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // EdicionControles
            // 
            this.AcceptButton = this.btnGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.tlpControles);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EdicionControles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edición de Controles";
            this.tlpControles.ResumeLayout(false);
            this.tlpControles.PerformLayout();
            this.gbAnimal.ResumeLayout(false);
            this.gbAnimal.PerformLayout();
            this.gbControl.ResumeLayout(false);
            this.gbControl.PerformLayout();
            this.gbFechaControl.ResumeLayout(false);
            this.gbFechaControl.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TableLayoutPanel tlpControles;
        public System.Windows.Forms.Button btnGuardar;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.GroupBox gbAnimal;
        public System.Windows.Forms.ComboBox cbAnimal;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.GroupBox gbControl;
        public System.Windows.Forms.TextBox txtGrasaSegundoControl;
        public System.Windows.Forms.TextBox txtGrasaPrimerControl;
        public System.Windows.Forms.TextBox txtSegundoControl;
        public System.Windows.Forms.TextBox txtPrimerControl;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.GroupBox gbFechaControl;
        public System.Windows.Forms.DateTimePicker dtpFechaControl;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtIdControl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolTip tooltipControles;
        private System.Windows.Forms.Button btnSalir;
    }
}