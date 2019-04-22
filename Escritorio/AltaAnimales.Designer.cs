namespace Escritorio
{
    partial class AltaAnimales
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gbMadre = new System.Windows.Forms.GroupBox();
            this.txtHBAMadre = new System.Windows.Forms.TextBox();
            this.txtRPMadre = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbPadre = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtHBAPadre = new System.Windows.Forms.TextBox();
            this.txtRPPadre = new System.Windows.Forms.TextBox();
            this.gbAnimal = new System.Windows.Forms.GroupBox();
            this.txtCaravana = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTambo = new System.Windows.Forms.TextBox();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cbRaza = new System.Windows.Forms.ComboBox();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.txtHBA = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbUltCaravana = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbMadre.SuspendLayout();
            this.gbPadre.SuspendLayout();
            this.gbAnimal.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.Controls.Add(this.btnGuardar, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnSalir, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gbMadre, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.gbPadre, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.gbAnimal, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 480);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(126, 450);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.Location = new System.Drawing.Point(523, 450);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 15;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 4);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(794, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese los datos del nuevo animal:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gbMadre
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.gbMadre, 2);
            this.gbMadre.Controls.Add(this.txtHBAMadre);
            this.gbMadre.Controls.Add(this.txtRPMadre);
            this.gbMadre.Controls.Add(this.label9);
            this.gbMadre.Controls.Add(this.label2);
            this.gbMadre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbMadre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMadre.Location = new System.Drawing.Point(6, 338);
            this.gbMadre.Name = "gbMadre";
            this.gbMadre.Size = new System.Drawing.Size(388, 103);
            this.gbMadre.TabIndex = 28;
            this.gbMadre.TabStop = false;
            this.gbMadre.Text = "Datos Madre";
            // 
            // txtHBAMadre
            // 
            this.txtHBAMadre.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtHBAMadre.Location = new System.Drawing.Point(120, 60);
            this.txtHBAMadre.Name = "txtHBAMadre";
            this.txtHBAMadre.Size = new System.Drawing.Size(200, 20);
            this.txtHBAMadre.TabIndex = 11;
            this.txtHBAMadre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHBAMadre_KeyPress);
            // 
            // txtRPMadre
            // 
            this.txtRPMadre.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtRPMadre.Location = new System.Drawing.Point(120, 24);
            this.txtRPMadre.Name = "txtRPMadre";
            this.txtRPMadre.Size = new System.Drawing.Size(200, 20);
            this.txtRPMadre.TabIndex = 10;
            this.txtRPMadre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRPMadre_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(21, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "HBA:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "RP:";
            // 
            // gbPadre
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.gbPadre, 2);
            this.gbPadre.Controls.Add(this.label11);
            this.gbPadre.Controls.Add(this.label10);
            this.gbPadre.Controls.Add(this.txtHBAPadre);
            this.gbPadre.Controls.Add(this.txtRPPadre);
            this.gbPadre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbPadre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPadre.Location = new System.Drawing.Point(403, 338);
            this.gbPadre.Name = "gbPadre";
            this.gbPadre.Size = new System.Drawing.Size(391, 103);
            this.gbPadre.TabIndex = 29;
            this.gbPadre.TabStop = false;
            this.gbPadre.Text = "Datos Padre";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(19, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "HBA:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(19, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "RP:";
            // 
            // txtHBAPadre
            // 
            this.txtHBAPadre.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtHBAPadre.Location = new System.Drawing.Point(120, 57);
            this.txtHBAPadre.Name = "txtHBAPadre";
            this.txtHBAPadre.Size = new System.Drawing.Size(200, 20);
            this.txtHBAPadre.TabIndex = 13;
            this.txtHBAPadre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHBAPadre_KeyPress);
            // 
            // txtRPPadre
            // 
            this.txtRPPadre.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtRPPadre.Location = new System.Drawing.Point(120, 24);
            this.txtRPPadre.Name = "txtRPPadre";
            this.txtRPPadre.Size = new System.Drawing.Size(200, 20);
            this.txtRPPadre.TabIndex = 12;
            this.txtRPPadre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRPPadre_KeyPress);
            // 
            // gbAnimal
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.gbAnimal, 4);
            this.gbAnimal.Controls.Add(this.lbUltCaravana);
            this.gbAnimal.Controls.Add(this.txtCaravana);
            this.gbAnimal.Controls.Add(this.label12);
            this.gbAnimal.Controls.Add(this.txtTambo);
            this.gbAnimal.Controls.Add(this.cbEstado);
            this.gbAnimal.Controls.Add(this.label17);
            this.gbAnimal.Controls.Add(this.label16);
            this.gbAnimal.Controls.Add(this.cbRaza);
            this.gbAnimal.Controls.Add(this.dtpFechaNacimiento);
            this.gbAnimal.Controls.Add(this.cbCategoria);
            this.gbAnimal.Controls.Add(this.txtHBA);
            this.gbAnimal.Controls.Add(this.txtNombre);
            this.gbAnimal.Controls.Add(this.label13);
            this.gbAnimal.Controls.Add(this.label8);
            this.gbAnimal.Controls.Add(this.label7);
            this.gbAnimal.Controls.Add(this.label6);
            this.gbAnimal.Controls.Add(this.label5);
            this.gbAnimal.Controls.Add(this.label3);
            this.gbAnimal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAnimal.Location = new System.Drawing.Point(6, 52);
            this.gbAnimal.Name = "gbAnimal";
            this.gbAnimal.Size = new System.Drawing.Size(788, 277);
            this.gbAnimal.TabIndex = 30;
            this.gbAnimal.TabStop = false;
            this.gbAnimal.Text = "Datos Animal";
            // 
            // txtCaravana
            // 
            this.txtCaravana.Location = new System.Drawing.Point(485, 100);
            this.txtCaravana.Name = "txtCaravana";
            this.txtCaravana.Size = new System.Drawing.Size(201, 20);
            this.txtCaravana.TabIndex = 29;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(416, 100);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "Caravana: *";
            // 
            // txtTambo
            // 
            this.txtTambo.Location = new System.Drawing.Point(485, 148);
            this.txtTambo.Name = "txtTambo";
            this.txtTambo.ReadOnly = true;
            this.txtTambo.Size = new System.Drawing.Size(200, 20);
            this.txtTambo.TabIndex = 27;
            // 
            // cbEstado
            // 
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(485, 49);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(201, 21);
            this.cbEstado.TabIndex = 26;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(420, 52);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(43, 13);
            this.label17.TabIndex = 24;
            this.label17.Text = "Estado:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(21, 240);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(111, 13);
            this.label16.TabIndex = 21;
            this.label16.Text = "* Campos obligatorios.";
            // 
            // cbRaza
            // 
            this.cbRaza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRaza.FormattingEnabled = true;
            this.cbRaza.Location = new System.Drawing.Point(484, 190);
            this.cbRaza.Name = "cbRaza";
            this.cbRaza.Size = new System.Drawing.Size(200, 21);
            this.cbRaza.TabIndex = 9;
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(134, 45);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaNacimiento.TabIndex = 1;
            // 
            // cbCategoria
            // 
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(134, 190);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(200, 21);
            this.cbCategoria.TabIndex = 5;
            // 
            // txtHBA
            // 
            this.txtHBA.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtHBA.Location = new System.Drawing.Point(134, 148);
            this.txtHBA.Name = "txtHBA";
            this.txtHBA.Size = new System.Drawing.Size(200, 20);
            this.txtHBA.TabIndex = 4;
            this.txtHBA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHBA_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNombre.Location = new System.Drawing.Point(134, 100);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 20);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(419, 151);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 13);
            this.label13.TabIndex = 7;
            this.label13.Text = "Tambo: *";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(420, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Raza: *";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Categoría: *";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "HBA: *";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nombre: *";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Fecha Nacimiento:";
            // 
            // lbUltCaravana
            // 
            this.lbUltCaravana.AutoSize = true;
            this.lbUltCaravana.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUltCaravana.Location = new System.Drawing.Point(419, 132);
            this.lbUltCaravana.Name = "lbUltCaravana";
            this.lbUltCaravana.Size = new System.Drawing.Size(0, 13);
            this.lbUltCaravana.TabIndex = 30;
            // 
            // AltaAnimales
            // 
            this.AcceptButton = this.btnGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 519);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(816, 519);
            this.Name = "AltaAnimales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carga de Animales";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AltaAnimales_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.gbMadre.ResumeLayout(false);
            this.gbMadre.PerformLayout();
            this.gbPadre.ResumeLayout(false);
            this.gbPadre.PerformLayout();
            this.gbAnimal.ResumeLayout(false);
            this.gbAnimal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbMadre;
        private System.Windows.Forms.TextBox txtHBAMadre;
        private System.Windows.Forms.TextBox txtRPMadre;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbPadre;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtHBAPadre;
        private System.Windows.Forms.TextBox txtRPPadre;
        private System.Windows.Forms.GroupBox gbAnimal;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cbRaza;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.TextBox txtHBA;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtTambo;
        private System.Windows.Forms.TextBox txtCaravana;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbUltCaravana;
    }
}