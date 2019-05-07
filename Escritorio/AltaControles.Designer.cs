namespace Escritorio
{
    partial class AltaControles
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
            this.label1 = new System.Windows.Forms.Label();
            this.gbAnimal = new System.Windows.Forms.GroupBox();
            this.lbNombreAnimal = new System.Windows.Forms.Label();
            this.cbAnimal = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbControl = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtGrasaSegundoControl = new System.Windows.Forms.TextBox();
            this.txtGrasaPrimerControl = new System.Windows.Forms.TextBox();
            this.txtSegundoControl = new System.Windows.Forms.TextBox();
            this.txtPrimerControl = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbFecha = new System.Windows.Forms.GroupBox();
            this.dtpFechaControl = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tooltipControles = new System.Windows.Forms.ToolTip(this.components);
            this.tlpControles.SuspendLayout();
            this.gbAnimal.SuspendLayout();
            this.gbControl.SuspendLayout();
            this.gbFecha.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpControles
            // 
            this.tlpControles.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tlpControles.ColumnCount = 4;
            this.tlpControles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpControles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tlpControles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpControles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tlpControles.Controls.Add(this.label1, 0, 0);
            this.tlpControles.Controls.Add(this.gbAnimal, 0, 1);
            this.tlpControles.Controls.Add(this.gbControl, 0, 2);
            this.tlpControles.Controls.Add(this.gbFecha, 0, 3);
            this.tlpControles.Controls.Add(this.btnGuardar, 1, 4);
            this.tlpControles.Controls.Add(this.btnSalir, 3, 4);
            this.tlpControles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpControles.Location = new System.Drawing.Point(0, 0);
            this.tlpControles.Name = "tlpControles";
            this.tlpControles.RowCount = 5;
            this.tlpControles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpControles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.54964F));
            this.tlpControles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.69976F));
            this.tlpControles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpControles.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpControles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpControles.Size = new System.Drawing.Size(800, 450);
            this.tlpControles.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tlpControles.SetColumnSpan(this.label1, 4);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(788, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese los datos del nuevo control:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gbAnimal
            // 
            this.tlpControles.SetColumnSpan(this.gbAnimal, 4);
            this.gbAnimal.Controls.Add(this.lbNombreAnimal);
            this.gbAnimal.Controls.Add(this.cbAnimal);
            this.gbAnimal.Controls.Add(this.label2);
            this.gbAnimal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAnimal.Location = new System.Drawing.Point(6, 49);
            this.gbAnimal.Name = "gbAnimal";
            this.gbAnimal.Size = new System.Drawing.Size(788, 81);
            this.gbAnimal.TabIndex = 1;
            this.gbAnimal.TabStop = false;
            this.gbAnimal.Text = "Animal";
            // 
            // lbNombreAnimal
            // 
            this.lbNombreAnimal.AutoSize = true;
            this.lbNombreAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreAnimal.Location = new System.Drawing.Point(25, 54);
            this.lbNombreAnimal.Name = "lbNombreAnimal";
            this.lbNombreAnimal.Size = new System.Drawing.Size(0, 13);
            this.lbNombreAnimal.TabIndex = 2;
            // 
            // cbAnimal
            // 
            this.cbAnimal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAnimal.FormattingEnabled = true;
            this.cbAnimal.Location = new System.Drawing.Point(305, 28);
            this.cbAnimal.Name = "cbAnimal";
            this.cbAnimal.Size = new System.Drawing.Size(201, 21);
            this.cbAnimal.TabIndex = 1;
            this.cbAnimal.SelectionChangeCommitted += new System.EventHandler(this.cbAnimal_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Seleccione la caravana del animal a registrar el control: *";
            // 
            // gbControl
            // 
            this.tlpControles.SetColumnSpan(this.gbControl, 4);
            this.gbControl.Controls.Add(this.label12);
            this.gbControl.Controls.Add(this.label11);
            this.gbControl.Controls.Add(this.label10);
            this.gbControl.Controls.Add(this.label8);
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
            this.gbControl.Location = new System.Drawing.Point(6, 139);
            this.gbControl.Name = "gbControl";
            this.gbControl.Size = new System.Drawing.Size(788, 187);
            this.gbControl.TabIndex = 2;
            this.gbControl.TabStop = false;
            this.gbControl.Text = "Datos Control";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(449, 161);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(134, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "Formato de ingreso: XX,XX";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(449, 116);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(134, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Formato de ingreso: XX,XX";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(449, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Formato de ingreso: XX,XX";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(449, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Formato de ingreso: XX,XX";
            // 
            // txtGrasaSegundoControl
            // 
            this.txtGrasaSegundoControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtGrasaSegundoControl.Location = new System.Drawing.Point(233, 158);
            this.txtGrasaSegundoControl.Name = "txtGrasaSegundoControl";
            this.txtGrasaSegundoControl.Size = new System.Drawing.Size(210, 20);
            this.txtGrasaSegundoControl.TabIndex = 5;
            this.txtGrasaSegundoControl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKgGrasa_KeyPress);
            // 
            // txtGrasaPrimerControl
            // 
            this.txtGrasaPrimerControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtGrasaPrimerControl.Location = new System.Drawing.Point(233, 71);
            this.txtGrasaPrimerControl.Name = "txtGrasaPrimerControl";
            this.txtGrasaPrimerControl.Size = new System.Drawing.Size(210, 20);
            this.txtGrasaPrimerControl.TabIndex = 3;
            this.txtGrasaPrimerControl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPorcentajeGrasa_KeyPress);
            // 
            // txtSegundoControl
            // 
            this.txtSegundoControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSegundoControl.Location = new System.Drawing.Point(233, 113);
            this.txtSegundoControl.Name = "txtSegundoControl";
            this.txtSegundoControl.Size = new System.Drawing.Size(210, 20);
            this.txtSegundoControl.TabIndex = 4;
            this.txtSegundoControl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSegundoControl_KeyPress);
            // 
            // txtPrimerControl
            // 
            this.txtPrimerControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPrimerControl.Location = new System.Drawing.Point(233, 32);
            this.txtPrimerControl.Name = "txtPrimerControl";
            this.txtPrimerControl.Size = new System.Drawing.Size(210, 20);
            this.txtPrimerControl.TabIndex = 2;
            this.txtPrimerControl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrimerControl_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Grasa segundo control (en kg):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Grasa primer control (en kg): ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Segundo control (en litros) : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Primer control (en litros) : ";
            // 
            // gbFecha
            // 
            this.tlpControles.SetColumnSpan(this.gbFecha, 4);
            this.gbFecha.Controls.Add(this.dtpFechaControl);
            this.gbFecha.Controls.Add(this.label3);
            this.gbFecha.Controls.Add(this.label9);
            this.gbFecha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFecha.Location = new System.Drawing.Point(6, 335);
            this.gbFecha.Name = "gbFecha";
            this.gbFecha.Size = new System.Drawing.Size(788, 75);
            this.gbFecha.TabIndex = 3;
            this.gbFecha.TabStop = false;
            this.gbFecha.Text = "Fecha Control";
            // 
            // dtpFechaControl
            // 
            this.dtpFechaControl.Location = new System.Drawing.Point(233, 34);
            this.dtpFechaControl.Name = "dtpFechaControl";
            this.dtpFechaControl.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaControl.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Seleccione la fecha del control: *";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(671, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "* Campos obligatorios.";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(126, 419);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.Location = new System.Drawing.Point(523, 419);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // AltaControles
            // 
            this.AcceptButton = this.btnGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tlpControles);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AltaControles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carga de Controles";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AltaControles_FormClosing);
            this.tlpControles.ResumeLayout(false);
            this.tlpControles.PerformLayout();
            this.gbAnimal.ResumeLayout(false);
            this.gbAnimal.PerformLayout();
            this.gbControl.ResumeLayout(false);
            this.gbControl.PerformLayout();
            this.gbFecha.ResumeLayout(false);
            this.gbFecha.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpControles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbAnimal;
        private System.Windows.Forms.GroupBox gbControl;
        private System.Windows.Forms.GroupBox gbFecha;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ComboBox cbAnimal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFechaControl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGrasaSegundoControl;
        private System.Windows.Forms.TextBox txtGrasaPrimerControl;
        private System.Windows.Forms.TextBox txtSegundoControl;
        private System.Windows.Forms.TextBox txtPrimerControl;
        private System.Windows.Forms.ToolTip tooltipControles;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbNombreAnimal;
    }
}