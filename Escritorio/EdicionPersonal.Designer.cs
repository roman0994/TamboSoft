namespace Escritorio
{
    partial class EdicionPersonal
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.gbPersonal = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTambo = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtIdTambo = new System.Windows.Forms.TextBox();
            this.txtIdPersonal = new System.Windows.Forms.TextBox();
            this.cbLocalidad = new System.Windows.Forms.ComboBox();
            this.cbProvincia = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.epDni = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.gbPersonal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epDni)).BeginInit();
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
            this.tableLayoutPanel1.Controls.Add(this.btnGuardar, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnSalir, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.gbPersonal, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnGuardar
            // 
            this.btnGuardar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnGuardar.Location = new System.Drawing.Point(126, 420);
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
            this.btnSalir.Location = new System.Drawing.Point(523, 420);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // gbPersonal
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.gbPersonal, 4);
            this.gbPersonal.Controls.Add(this.label16);
            this.gbPersonal.Controls.Add(this.label15);
            this.gbPersonal.Controls.Add(this.label14);
            this.gbPersonal.Controls.Add(this.txtTambo);
            this.gbPersonal.Controls.Add(this.label13);
            this.gbPersonal.Controls.Add(this.label12);
            this.gbPersonal.Controls.Add(this.label11);
            this.gbPersonal.Controls.Add(this.txtDni);
            this.gbPersonal.Controls.Add(this.txtDireccion);
            this.gbPersonal.Controls.Add(this.txtTelefono);
            this.gbPersonal.Controls.Add(this.txtNombre);
            this.gbPersonal.Controls.Add(this.txtIdTambo);
            this.gbPersonal.Controls.Add(this.txtIdPersonal);
            this.gbPersonal.Controls.Add(this.cbLocalidad);
            this.gbPersonal.Controls.Add(this.cbProvincia);
            this.gbPersonal.Controls.Add(this.label10);
            this.gbPersonal.Controls.Add(this.label9);
            this.gbPersonal.Controls.Add(this.label8);
            this.gbPersonal.Controls.Add(this.label7);
            this.gbPersonal.Controls.Add(this.label6);
            this.gbPersonal.Controls.Add(this.label4);
            this.gbPersonal.Controls.Add(this.label3);
            this.gbPersonal.Controls.Add(this.label2);
            this.gbPersonal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPersonal.Location = new System.Drawing.Point(6, 49);
            this.gbPersonal.Name = "gbPersonal";
            this.gbPersonal.Size = new System.Drawing.Size(788, 362);
            this.gbPersonal.TabIndex = 2;
            this.gbPersonal.TabStop = false;
            this.gbPersonal.Text = "Datos Personal";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(338, 124);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(151, 13);
            this.label16.TabIndex = 24;
            this.label16.Text = "Sin el 0 ni el 15 y sin espacios.";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(337, 175);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(81, 13);
            this.label15.TabIndex = 23;
            this.label15.Text = "Ej. Libertad 443";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(338, 227);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(151, 13);
            this.label14.TabIndex = 22;
            this.label14.Text = "Debe tener entre 7 y 8 dígitos.";
            // 
            // txtTambo
            // 
            this.txtTambo.Location = new System.Drawing.Point(133, 29);
            this.txtTambo.Name = "txtTambo";
            this.txtTambo.ReadOnly = true;
            this.txtTambo.Size = new System.Drawing.Size(200, 20);
            this.txtTambo.TabIndex = 21;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(23, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "Tambo:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(383, 285);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(114, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "* Campos obligatorios. ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(380, 321);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(380, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "** Seleccionando una provincia, se cargarán sus localidades correspondientes.";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(132, 224);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(200, 20);
            this.txtDni.TabIndex = 7;
            this.txtDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDni_KeyPress);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(131, 172);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(200, 20);
            this.txtDireccion.TabIndex = 6;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(131, 121);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(200, 20);
            this.txtTelefono.TabIndex = 5;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(132, 71);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 20);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtIdTambo
            // 
            this.txtIdTambo.Location = new System.Drawing.Point(463, 29);
            this.txtIdTambo.Name = "txtIdTambo";
            this.txtIdTambo.ReadOnly = true;
            this.txtIdTambo.Size = new System.Drawing.Size(200, 20);
            this.txtIdTambo.TabIndex = 2;
            this.txtIdTambo.Visible = false;
            // 
            // txtIdPersonal
            // 
            this.txtIdPersonal.Location = new System.Drawing.Point(463, 71);
            this.txtIdPersonal.Name = "txtIdPersonal";
            this.txtIdPersonal.ReadOnly = true;
            this.txtIdPersonal.Size = new System.Drawing.Size(200, 20);
            this.txtIdPersonal.TabIndex = 1;
            this.txtIdPersonal.Visible = false;
            // 
            // cbLocalidad
            // 
            this.cbLocalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLocalidad.FormattingEnabled = true;
            this.cbLocalidad.Location = new System.Drawing.Point(132, 318);
            this.cbLocalidad.Name = "cbLocalidad";
            this.cbLocalidad.Size = new System.Drawing.Size(201, 21);
            this.cbLocalidad.TabIndex = 9;
            // 
            // cbProvincia
            // 
            this.cbProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProvincia.FormattingEnabled = true;
            this.cbProvincia.Location = new System.Drawing.Point(131, 278);
            this.cbProvincia.Name = "cbProvincia";
            this.cbProvincia.Size = new System.Drawing.Size(201, 21);
            this.cbProvincia.TabIndex = 8;
            this.cbProvincia.SelectedIndexChanged += new System.EventHandler(this.cbProvincia_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(22, 321);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Localidad: **";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(23, 281);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Provincia: *";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "DNI: *";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Dirección: *";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Teléfono:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nombre y apellido: *";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(380, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Cod. Tambo:";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(383, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID Personal:";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 4);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(788, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "Modifique los datos del personal:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // epDni
            // 
            this.epDni.ContainerControl = this;
            // 
            // EdicionPersonal
            // 
            this.AcceptButton = this.btnGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EdicionPersonal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edición de Personal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EdicionPersonal_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.gbPersonal.ResumeLayout(false);
            this.gbPersonal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epDni)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox gbPersonal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtDni;
        public System.Windows.Forms.TextBox txtDireccion;
        public System.Windows.Forms.TextBox txtTelefono;
        public System.Windows.Forms.TextBox txtNombre;
        public System.Windows.Forms.TextBox txtIdTambo;
        public System.Windows.Forms.TextBox txtIdPersonal;
        public System.Windows.Forms.ComboBox cbLocalidad;
        public System.Windows.Forms.ComboBox cbProvincia;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ErrorProvider epDni;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox txtTambo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
    }
}