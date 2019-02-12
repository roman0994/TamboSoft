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
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.chkHabilitado = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtFoto = new System.Windows.Forms.TextBox();
            this.cbRaza = new System.Windows.Forms.ComboBox();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.txtHBA = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTambo = new System.Windows.Forms.TextBox();
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
            this.txtHBAMadre.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtHBAMadre.Location = new System.Drawing.Point(120, 60);
            this.txtHBAMadre.Name = "txtHBAMadre";
            this.txtHBAMadre.Size = new System.Drawing.Size(200, 20);
            this.txtHBAMadre.TabIndex = 11;
            this.txtHBAMadre.Text = "Código numérico";
            this.txtHBAMadre.Enter += new System.EventHandler(this.txtHBAMadre_Enter);
            this.txtHBAMadre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHBAMadre_KeyPress);
            this.txtHBAMadre.Leave += new System.EventHandler(this.txtHBAMadre_Leave);
            // 
            // txtRPMadre
            // 
            this.txtRPMadre.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtRPMadre.Location = new System.Drawing.Point(120, 24);
            this.txtRPMadre.Name = "txtRPMadre";
            this.txtRPMadre.Size = new System.Drawing.Size(200, 20);
            this.txtRPMadre.TabIndex = 10;
            this.txtRPMadre.Text = "Código numérico";
            this.txtRPMadre.Enter += new System.EventHandler(this.txtRPMadre_Enter);
            this.txtRPMadre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRPMadre_KeyPress);
            this.txtRPMadre.Leave += new System.EventHandler(this.txtRPMadre_Leave);
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
            this.txtHBAPadre.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtHBAPadre.Location = new System.Drawing.Point(120, 57);
            this.txtHBAPadre.Name = "txtHBAPadre";
            this.txtHBAPadre.Size = new System.Drawing.Size(200, 20);
            this.txtHBAPadre.TabIndex = 13;
            this.txtHBAPadre.Text = "Código numérico";
            this.txtHBAPadre.Enter += new System.EventHandler(this.txtHBAPadre_Enter);
            this.txtHBAPadre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHBAPadre_KeyPress);
            this.txtHBAPadre.Leave += new System.EventHandler(this.txtHBAPadre_Leave);
            // 
            // txtRPPadre
            // 
            this.txtRPPadre.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtRPPadre.Location = new System.Drawing.Point(120, 24);
            this.txtRPPadre.Name = "txtRPPadre";
            this.txtRPPadre.Size = new System.Drawing.Size(200, 20);
            this.txtRPPadre.TabIndex = 12;
            this.txtRPPadre.Text = "Código numérico";
            this.txtRPPadre.Enter += new System.EventHandler(this.txtRPPadre_Enter);
            this.txtRPPadre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRPPadre_KeyPress);
            this.txtRPPadre.Leave += new System.EventHandler(this.txtRPPadre_Leave);
            // 
            // gbAnimal
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.gbAnimal, 4);
            this.gbAnimal.Controls.Add(this.txtTambo);
            this.gbAnimal.Controls.Add(this.cbEstado);
            this.gbAnimal.Controls.Add(this.label18);
            this.gbAnimal.Controls.Add(this.label17);
            this.gbAnimal.Controls.Add(this.chkHabilitado);
            this.gbAnimal.Controls.Add(this.label16);
            this.gbAnimal.Controls.Add(this.label15);
            this.gbAnimal.Controls.Add(this.txtFoto);
            this.gbAnimal.Controls.Add(this.cbRaza);
            this.gbAnimal.Controls.Add(this.dtpFechaNacimiento);
            this.gbAnimal.Controls.Add(this.cbCategoria);
            this.gbAnimal.Controls.Add(this.cbSexo);
            this.gbAnimal.Controls.Add(this.txtHBA);
            this.gbAnimal.Controls.Add(this.txtNombre);
            this.gbAnimal.Controls.Add(this.txtEdad);
            this.gbAnimal.Controls.Add(this.label14);
            this.gbAnimal.Controls.Add(this.label13);
            this.gbAnimal.Controls.Add(this.label12);
            this.gbAnimal.Controls.Add(this.label8);
            this.gbAnimal.Controls.Add(this.label7);
            this.gbAnimal.Controls.Add(this.label6);
            this.gbAnimal.Controls.Add(this.label5);
            this.gbAnimal.Controls.Add(this.label4);
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
            // cbEstado
            // 
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(484, 72);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(201, 21);
            this.cbEstado.TabIndex = 26;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(419, 112);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(57, 13);
            this.label18.TabIndex = 25;
            this.label18.Text = "Habilitado:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(419, 75);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(43, 13);
            this.label17.TabIndex = 24;
            this.label17.Text = "Estado:";
            // 
            // chkHabilitado
            // 
            this.chkHabilitado.AutoSize = true;
            this.chkHabilitado.Checked = true;
            this.chkHabilitado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHabilitado.Location = new System.Drawing.Point(484, 112);
            this.chkHabilitado.Name = "chkHabilitado";
            this.chkHabilitado.Size = new System.Drawing.Size(15, 14);
            this.chkHabilitado.TabIndex = 22;
            this.chkHabilitado.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(536, 262);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(111, 13);
            this.label16.TabIndex = 21;
            this.label16.Text = "* Campos obligatorios.";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(21, 262);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(370, 13);
            this.label15.TabIndex = 20;
            this.label15.Text = "** Para seleccionar el sexo, primero debe elegir la categoría correspondiente.";
            // 
            // txtFoto
            // 
            this.txtFoto.Location = new System.Drawing.Point(484, 34);
            this.txtFoto.Name = "txtFoto";
            this.txtFoto.Size = new System.Drawing.Size(200, 20);
            this.txtFoto.TabIndex = 7;
            // 
            // cbRaza
            // 
            this.cbRaza.FormattingEnabled = true;
            this.cbRaza.Location = new System.Drawing.Point(484, 226);
            this.cbRaza.Name = "cbRaza";
            this.cbRaza.Size = new System.Drawing.Size(200, 21);
            this.cbRaza.TabIndex = 9;
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(134, 34);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaNacimiento.TabIndex = 1;
            // 
            // cbCategoria
            // 
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(134, 190);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(200, 21);
            this.cbCategoria.TabIndex = 5;
            this.cbCategoria.SelectedIndexChanged += new System.EventHandler(this.cbCategoria_SelectedIndexChanged);
            // 
            // cbSexo
            // 
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Location = new System.Drawing.Point(134, 226);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(200, 21);
            this.cbSexo.TabIndex = 6;
            // 
            // txtHBA
            // 
            this.txtHBA.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtHBA.Location = new System.Drawing.Point(134, 151);
            this.txtHBA.Name = "txtHBA";
            this.txtHBA.Size = new System.Drawing.Size(200, 20);
            this.txtHBA.TabIndex = 4;
            this.txtHBA.Text = "Código numérico";
            this.txtHBA.Enter += new System.EventHandler(this.txtHBA_Enter);
            this.txtHBA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHBA_KeyPress);
            this.txtHBA.Leave += new System.EventHandler(this.txtHBA_Leave);
            // 
            // txtNombre
            // 
            this.txtNombre.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtNombre.Location = new System.Drawing.Point(134, 109);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 20);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.Text = "Nombre del animal";
            this.txtNombre.Enter += new System.EventHandler(this.txtNombre_Enter);
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            this.txtNombre.Leave += new System.EventHandler(this.txtNombre_Leave);
            // 
            // txtEdad
            // 
            this.txtEdad.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtEdad.Location = new System.Drawing.Point(134, 72);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(200, 20);
            this.txtEdad.TabIndex = 2;
            this.txtEdad.Text = "Edad del animal";
            this.txtEdad.Enter += new System.EventHandler(this.txtEdad_Enter);
            this.txtEdad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEdad_KeyPress);
            this.txtEdad.Leave += new System.EventHandler(this.txtEdad_Leave);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(419, 40);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 13);
            this.label14.TabIndex = 8;
            this.label14.Text = "Foto:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(419, 193);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 13);
            this.label13.TabIndex = 7;
            this.label13.Text = "Tambo: *";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(21, 229);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Sexo: **";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(419, 229);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Raza: *";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 193);
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
            this.label5.Location = new System.Drawing.Point(21, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nombre: *";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Edad: *";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Fecha Nacimiento:";
            // 
            // txtTambo
            // 
            this.txtTambo.Location = new System.Drawing.Point(484, 190);
            this.txtTambo.Name = "txtTambo";
            this.txtTambo.ReadOnly = true;
            this.txtTambo.Size = new System.Drawing.Size(200, 20);
            this.txtTambo.TabIndex = 27;
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
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtFoto;
        private System.Windows.Forms.ComboBox cbRaza;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.TextBox txtHBA;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.CheckBox chkHabilitado;
        private System.Windows.Forms.TextBox txtTambo;
    }
}