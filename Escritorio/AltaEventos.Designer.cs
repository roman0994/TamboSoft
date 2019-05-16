namespace Escritorio
{
    partial class AltaEventos
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
            this.tlpEventos = new System.Windows.Forms.TableLayoutPanel();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.gbFecha = new System.Windows.Forms.GroupBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.gbEvento = new System.Windows.Forms.GroupBox();
            this.btnCria2 = new System.Windows.Forms.Button();
            this.btnCria = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbEventos = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.gbAnimal = new System.Windows.Forms.GroupBox();
            this.lbError = new System.Windows.Forms.Label();
            this.lbEstadoAnimal = new System.Windows.Forms.Label();
            this.lbNombreAnimal = new System.Windows.Forms.Label();
            this.lbCaravana = new System.Windows.Forms.Label();
            this.lbCategoriaAnimal = new System.Windows.Forms.Label();
            this.btnBuscarAnimal = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.gbTambo = new System.Windows.Forms.GroupBox();
            this.txtTambo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tlpEventos.SuspendLayout();
            this.gbFecha.SuspendLayout();
            this.gbEvento.SuspendLayout();
            this.gbAnimal.SuspendLayout();
            this.gbTambo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpEventos
            // 
            this.tlpEventos.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tlpEventos.ColumnCount = 4;
            this.tlpEventos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpEventos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tlpEventos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpEventos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tlpEventos.Controls.Add(this.btnLimpiar, 2, 4);
            this.tlpEventos.Controls.Add(this.label7, 0, 0);
            this.tlpEventos.Controls.Add(this.gbFecha, 0, 1);
            this.tlpEventos.Controls.Add(this.gbEvento, 0, 2);
            this.tlpEventos.Controls.Add(this.btnGuardar, 1, 4);
            this.tlpEventos.Controls.Add(this.btnSalir, 3, 4);
            this.tlpEventos.Controls.Add(this.gbAnimal, 2, 1);
            this.tlpEventos.Controls.Add(this.gbTambo, 0, 3);
            this.tlpEventos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpEventos.Location = new System.Drawing.Point(0, 0);
            this.tlpEventos.Name = "tlpEventos";
            this.tlpEventos.RowCount = 5;
            this.tlpEventos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpEventos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.76029F));
            this.tlpEventos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.87893F));
            this.tlpEventos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.70702F));
            this.tlpEventos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpEventos.Size = new System.Drawing.Size(800, 450);
            this.tlpEventos.TabIndex = 0;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.Crimson;
            this.btnLimpiar.Location = new System.Drawing.Point(403, 419);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(111, 23);
            this.btnLimpiar.TabIndex = 2;
            this.btnLimpiar.Text = "Limpiar sin guardar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Visible = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.tlpEventos.SetColumnSpan(this.label7, 4);
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(6, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(788, 40);
            this.label7.TabIndex = 0;
            this.label7.Text = "Ingrese los datos del evento:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gbFecha
            // 
            this.tlpEventos.SetColumnSpan(this.gbFecha, 2);
            this.gbFecha.Controls.Add(this.dtpFecha);
            this.gbFecha.Controls.Add(this.label8);
            this.gbFecha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFecha.Location = new System.Drawing.Point(6, 49);
            this.gbFecha.Name = "gbFecha";
            this.gbFecha.Size = new System.Drawing.Size(388, 86);
            this.gbFecha.TabIndex = 1;
            this.gbFecha.TabStop = false;
            this.gbFecha.Text = "Fecha";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(172, 31);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(157, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Seleccione la fecha del evento:";
            // 
            // gbEvento
            // 
            this.tlpEventos.SetColumnSpan(this.gbEvento, 4);
            this.gbEvento.Controls.Add(this.btnCria2);
            this.gbEvento.Controls.Add(this.btnCria);
            this.gbEvento.Controls.Add(this.label4);
            this.gbEvento.Controls.Add(this.label3);
            this.gbEvento.Controls.Add(this.label2);
            this.gbEvento.Controls.Add(this.label1);
            this.gbEvento.Controls.Add(this.comboBox4);
            this.gbEvento.Controls.Add(this.comboBox3);
            this.gbEvento.Controls.Add(this.comboBox2);
            this.gbEvento.Controls.Add(this.comboBox1);
            this.gbEvento.Controls.Add(this.lbEventos);
            this.gbEvento.Controls.Add(this.label6);
            this.gbEvento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEvento.Location = new System.Drawing.Point(6, 144);
            this.gbEvento.Name = "gbEvento";
            this.gbEvento.Size = new System.Drawing.Size(788, 196);
            this.gbEvento.TabIndex = 3;
            this.gbEvento.TabStop = false;
            this.gbEvento.Text = "Evento";
            this.gbEvento.Visible = false;
            // 
            // btnCria2
            // 
            this.btnCria2.Location = new System.Drawing.Point(654, 164);
            this.btnCria2.Name = "btnCria2";
            this.btnCria2.Size = new System.Drawing.Size(115, 23);
            this.btnCria2.TabIndex = 11;
            this.btnCria2.Text = "Agregar cría 2";
            this.btnCria2.UseVisualStyleBackColor = true;
            this.btnCria2.Visible = false;
            this.btnCria2.Click += new System.EventHandler(this.btnCria2_Click);
            // 
            // btnCria
            // 
            this.btnCria.Location = new System.Drawing.Point(528, 162);
            this.btnCria.Name = "btnCria";
            this.btnCria.Size = new System.Drawing.Size(106, 23);
            this.btnCria.TabIndex = 10;
            this.btnCria.Text = "Agregar cría";
            this.btnCria.UseVisualStyleBackColor = true;
            this.btnCria.Visible = false;
            this.btnCria.Click += new System.EventHandler(this.btnCria_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(258, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "label4";
            this.label4.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(258, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(258, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(258, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // comboBox4
            // 
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(433, 164);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(201, 21);
            this.comboBox4.TabIndex = 7;
            this.comboBox4.Visible = false;
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(433, 123);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(201, 21);
            this.comboBox3.TabIndex = 6;
            this.comboBox3.Visible = false;
            this.comboBox3.SelectionChangeCommitted += new System.EventHandler(this.comboBox3_SelectionChangeCommitted);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(433, 81);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(201, 21);
            this.comboBox2.TabIndex = 5;
            this.comboBox2.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(433, 41);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(201, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.Visible = false;
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // lbEventos
            // 
            this.lbEventos.FormattingEnabled = true;
            this.lbEventos.Location = new System.Drawing.Point(21, 32);
            this.lbEventos.Name = "lbEventos";
            this.lbEventos.Size = new System.Drawing.Size(120, 160);
            this.lbEventos.TabIndex = 3;
            this.lbEventos.Visible = false;
            this.lbEventos.SelectedIndexChanged += new System.EventHandler(this.lbEventos_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Seleccione el evento:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(126, 419);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 10;
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
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // gbAnimal
            // 
            this.tlpEventos.SetColumnSpan(this.gbAnimal, 2);
            this.gbAnimal.Controls.Add(this.lbError);
            this.gbAnimal.Controls.Add(this.lbEstadoAnimal);
            this.gbAnimal.Controls.Add(this.lbNombreAnimal);
            this.gbAnimal.Controls.Add(this.lbCaravana);
            this.gbAnimal.Controls.Add(this.lbCategoriaAnimal);
            this.gbAnimal.Controls.Add(this.btnBuscarAnimal);
            this.gbAnimal.Controls.Add(this.label5);
            this.gbAnimal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAnimal.Location = new System.Drawing.Point(403, 49);
            this.gbAnimal.Name = "gbAnimal";
            this.gbAnimal.Size = new System.Drawing.Size(391, 86);
            this.gbAnimal.TabIndex = 8;
            this.gbAnimal.TabStop = false;
            this.gbAnimal.Text = "Animal";
            this.gbAnimal.Enter += new System.EventHandler(this.gbAnimal_Enter);
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.Location = new System.Drawing.Point(6, 54);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(0, 13);
            this.lbError.TabIndex = 6;
            // 
            // lbEstadoAnimal
            // 
            this.lbEstadoAnimal.AutoSize = true;
            this.lbEstadoAnimal.Location = new System.Drawing.Point(234, 54);
            this.lbEstadoAnimal.Name = "lbEstadoAnimal";
            this.lbEstadoAnimal.Size = new System.Drawing.Size(0, 13);
            this.lbEstadoAnimal.TabIndex = 5;
            // 
            // lbNombreAnimal
            // 
            this.lbNombreAnimal.AutoSize = true;
            this.lbNombreAnimal.Location = new System.Drawing.Point(234, 20);
            this.lbNombreAnimal.Name = "lbNombreAnimal";
            this.lbNombreAnimal.Size = new System.Drawing.Size(0, 13);
            this.lbNombreAnimal.TabIndex = 4;
            // 
            // lbCaravana
            // 
            this.lbCaravana.AutoSize = true;
            this.lbCaravana.Location = new System.Drawing.Point(137, 54);
            this.lbCaravana.Name = "lbCaravana";
            this.lbCaravana.Size = new System.Drawing.Size(0, 13);
            this.lbCaravana.TabIndex = 3;
            // 
            // lbCategoriaAnimal
            // 
            this.lbCategoriaAnimal.AutoSize = true;
            this.lbCategoriaAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategoriaAnimal.Location = new System.Drawing.Point(234, 38);
            this.lbCategoriaAnimal.Name = "lbCategoriaAnimal";
            this.lbCategoriaAnimal.Size = new System.Drawing.Size(0, 13);
            this.lbCategoriaAnimal.TabIndex = 2;
            // 
            // btnBuscarAnimal
            // 
            this.btnBuscarAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarAnimal.Location = new System.Drawing.Point(120, 15);
            this.btnBuscarAnimal.Name = "btnBuscarAnimal";
            this.btnBuscarAnimal.Size = new System.Drawing.Size(108, 23);
            this.btnBuscarAnimal.TabIndex = 1;
            this.btnBuscarAnimal.Text = "Buscar animal";
            this.btnBuscarAnimal.UseVisualStyleBackColor = true;
            this.btnBuscarAnimal.Click += new System.EventHandler(this.btnBuscarAnimal_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Seleccione el animal: *";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // gbTambo
            // 
            this.tlpEventos.SetColumnSpan(this.gbTambo, 4);
            this.gbTambo.Controls.Add(this.txtTambo);
            this.gbTambo.Controls.Add(this.label9);
            this.gbTambo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbTambo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTambo.Location = new System.Drawing.Point(6, 349);
            this.gbTambo.Name = "gbTambo";
            this.gbTambo.Size = new System.Drawing.Size(788, 61);
            this.gbTambo.TabIndex = 12;
            this.gbTambo.TabStop = false;
            this.gbTambo.Text = "Tambo";
            // 
            // txtTambo
            // 
            this.txtTambo.Location = new System.Drawing.Point(93, 23);
            this.txtTambo.Name = "txtTambo";
            this.txtTambo.ReadOnly = true;
            this.txtTambo.Size = new System.Drawing.Size(200, 20);
            this.txtTambo.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(18, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Tambo:";
            // 
            // AltaEventos
            // 
            this.AcceptButton = this.btnGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tlpEventos);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AltaEventos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carga de Eventos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AltaEventos_FormClosing);
            this.tlpEventos.ResumeLayout(false);
            this.tlpEventos.PerformLayout();
            this.gbFecha.ResumeLayout(false);
            this.gbFecha.PerformLayout();
            this.gbEvento.ResumeLayout(false);
            this.gbEvento.PerformLayout();
            this.gbAnimal.ResumeLayout(false);
            this.gbAnimal.PerformLayout();
            this.gbTambo.ResumeLayout(false);
            this.gbTambo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpEventos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gbFecha;
        private System.Windows.Forms.GroupBox gbEvento;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox gbAnimal;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox lbEventos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox gbTambo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTambo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBuscarAnimal;
        private System.Windows.Forms.Label lbEstadoAnimal;
        private System.Windows.Forms.Label lbNombreAnimal;
        private System.Windows.Forms.Label lbCaravana;
        private System.Windows.Forms.Label lbCategoriaAnimal;
        private System.Windows.Forms.Label lbError;
        private System.Windows.Forms.Button btnCria2;
        private System.Windows.Forms.Button btnCria;
        private System.Windows.Forms.Button btnLimpiar;
    }
}