namespace Escritorio
{
    partial class AbmEvento
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
            this.label7 = new System.Windows.Forms.Label();
            this.gbFecha = new System.Windows.Forms.GroupBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lbFechaEvento = new System.Windows.Forms.Label();
            this.gbEvento = new System.Windows.Forms.GroupBox();
            this.cbEventos = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbSeleccioneEvento = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.gbAnimal = new System.Windows.Forms.GroupBox();
            this.lbCaravana = new System.Windows.Forms.Label();
            this.lbError = new System.Windows.Forms.Label();
            this.lbEstadoAnimal = new System.Windows.Forms.Label();
            this.btnBuscarAnimal = new System.Windows.Forms.Button();
            this.lbCategoriaAnimal = new System.Windows.Forms.Label();
            this.lbNombreAnimal = new System.Windows.Forms.Label();
            this.gbTambo = new System.Windows.Forms.GroupBox();
            this.txtTambo = new System.Windows.Forms.TextBox();
            this.gbDescripciones = new System.Windows.Forms.GroupBox();
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
            this.tlpEventos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.48933F));
            this.tlpEventos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.32246F));
            this.tlpEventos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpEventos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tlpEventos.Controls.Add(this.label7, 0, 0);
            this.tlpEventos.Controls.Add(this.gbFecha, 0, 1);
            this.tlpEventos.Controls.Add(this.gbEvento, 0, 2);
            this.tlpEventos.Controls.Add(this.btnGuardar, 1, 4);
            this.tlpEventos.Controls.Add(this.btnSalir, 3, 4);
            this.tlpEventos.Controls.Add(this.gbAnimal, 2, 1);
            this.tlpEventos.Controls.Add(this.gbTambo, 0, 3);
            this.tlpEventos.Controls.Add(this.gbDescripciones, 1, 2);
            this.tlpEventos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpEventos.Location = new System.Drawing.Point(0, 0);
            this.tlpEventos.Name = "tlpEventos";
            this.tlpEventos.RowCount = 5;
            this.tlpEventos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpEventos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.63438F));
            this.tlpEventos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.00484F));
            this.tlpEventos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.70702F));
            this.tlpEventos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpEventos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpEventos.Size = new System.Drawing.Size(800, 450);
            this.tlpEventos.TabIndex = 1;
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
            this.gbFecha.Controls.Add(this.lbFechaEvento);
            this.gbFecha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFecha.Location = new System.Drawing.Point(6, 49);
            this.gbFecha.Name = "gbFecha";
            this.gbFecha.Size = new System.Drawing.Size(387, 102);
            this.gbFecha.TabIndex = 1;
            this.gbFecha.TabStop = false;
            this.gbFecha.Text = "Fecha";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(21, 47);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 1;
            // 
            // lbFechaEvento
            // 
            this.lbFechaEvento.AutoSize = true;
            this.lbFechaEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFechaEvento.Location = new System.Drawing.Point(9, 31);
            this.lbFechaEvento.Name = "lbFechaEvento";
            this.lbFechaEvento.Size = new System.Drawing.Size(157, 13);
            this.lbFechaEvento.TabIndex = 0;
            this.lbFechaEvento.Text = "Seleccione la fecha del evento:";
            // 
            // gbEvento
            // 
            this.tlpEventos.SetColumnSpan(this.gbEvento, 2);
            this.gbEvento.Controls.Add(this.cbEventos);
            this.gbEvento.Controls.Add(this.comboBox1);
            this.gbEvento.Controls.Add(this.lbSeleccioneEvento);
            this.gbEvento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEvento.Location = new System.Drawing.Point(6, 160);
            this.gbEvento.Name = "gbEvento";
            this.gbEvento.Size = new System.Drawing.Size(387, 180);
            this.gbEvento.TabIndex = 3;
            this.gbEvento.TabStop = false;
            this.gbEvento.Text = "Evento";
            this.gbEvento.Visible = false;
            // 
            // cbEventos
            // 
            this.cbEventos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEventos.FormattingEnabled = true;
            this.cbEventos.Location = new System.Drawing.Point(12, 41);
            this.cbEventos.Name = "cbEventos";
            this.cbEventos.Size = new System.Drawing.Size(121, 21);
            this.cbEventos.TabIndex = 5;
            this.cbEventos.SelectionChangeCommitted += new System.EventHandler(this.cbEventos_SelectionChangeCommitted);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(433, 41);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(201, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // lbSeleccioneEvento
            // 
            this.lbSeleccioneEvento.AutoSize = true;
            this.lbSeleccioneEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSeleccioneEvento.Location = new System.Drawing.Point(9, 16);
            this.lbSeleccioneEvento.Name = "lbSeleccioneEvento";
            this.lbSeleccioneEvento.Size = new System.Drawing.Size(110, 13);
            this.lbSeleccioneEvento.TabIndex = 0;
            this.lbSeleccioneEvento.Text = "Seleccione el evento:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(248, 419);
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
            this.btnSalir.Location = new System.Drawing.Point(522, 419);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(67, 23);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // gbAnimal
            // 
            this.tlpEventos.SetColumnSpan(this.gbAnimal, 2);
            this.gbAnimal.Controls.Add(this.lbCaravana);
            this.gbAnimal.Controls.Add(this.lbError);
            this.gbAnimal.Controls.Add(this.lbEstadoAnimal);
            this.gbAnimal.Controls.Add(this.btnBuscarAnimal);
            this.gbAnimal.Controls.Add(this.lbCategoriaAnimal);
            this.gbAnimal.Controls.Add(this.lbNombreAnimal);
            this.gbAnimal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAnimal.Location = new System.Drawing.Point(402, 49);
            this.gbAnimal.Name = "gbAnimal";
            this.gbAnimal.Size = new System.Drawing.Size(392, 102);
            this.gbAnimal.TabIndex = 8;
            this.gbAnimal.TabStop = false;
            this.gbAnimal.Text = "Animal";
            // 
            // lbCaravana
            // 
            this.lbCaravana.AutoSize = true;
            this.lbCaravana.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lbCaravana.Location = new System.Drawing.Point(127, 15);
            this.lbCaravana.Name = "lbCaravana";
            this.lbCaravana.Size = new System.Drawing.Size(0, 13);
            this.lbCaravana.TabIndex = 9;
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lbError.Location = new System.Drawing.Point(10, 83);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(0, 13);
            this.lbError.TabIndex = 8;
            // 
            // lbEstadoAnimal
            // 
            this.lbEstadoAnimal.AutoSize = true;
            this.lbEstadoAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lbEstadoAnimal.Location = new System.Drawing.Point(127, 38);
            this.lbEstadoAnimal.Name = "lbEstadoAnimal";
            this.lbEstadoAnimal.Size = new System.Drawing.Size(0, 13);
            this.lbEstadoAnimal.TabIndex = 7;
            // 
            // btnBuscarAnimal
            // 
            this.btnBuscarAnimal.Location = new System.Drawing.Point(10, 19);
            this.btnBuscarAnimal.Name = "btnBuscarAnimal";
            this.btnBuscarAnimal.Size = new System.Drawing.Size(110, 23);
            this.btnBuscarAnimal.TabIndex = 6;
            this.btnBuscarAnimal.Text = "Buscar animal";
            this.btnBuscarAnimal.UseVisualStyleBackColor = true;
            this.btnBuscarAnimal.Click += new System.EventHandler(this.btnBuscarAnimal_Click);
            // 
            // lbCategoriaAnimal
            // 
            this.lbCategoriaAnimal.AutoSize = true;
            this.lbCategoriaAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lbCategoriaAnimal.Location = new System.Drawing.Point(127, 60);
            this.lbCategoriaAnimal.Name = "lbCategoriaAnimal";
            this.lbCategoriaAnimal.Size = new System.Drawing.Size(0, 13);
            this.lbCategoriaAnimal.TabIndex = 5;
            // 
            // lbNombreAnimal
            // 
            this.lbNombreAnimal.AutoSize = true;
            this.lbNombreAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreAnimal.Location = new System.Drawing.Point(264, 15);
            this.lbNombreAnimal.Name = "lbNombreAnimal";
            this.lbNombreAnimal.Size = new System.Drawing.Size(0, 13);
            this.lbNombreAnimal.TabIndex = 4;
            // 
            // gbTambo
            // 
            this.tlpEventos.SetColumnSpan(this.gbTambo, 4);
            this.gbTambo.Controls.Add(this.txtTambo);
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
            this.txtTambo.Location = new System.Drawing.Point(21, 19);
            this.txtTambo.Name = "txtTambo";
            this.txtTambo.ReadOnly = true;
            this.txtTambo.Size = new System.Drawing.Size(200, 20);
            this.txtTambo.TabIndex = 1;
            // 
            // gbDescripciones
            // 
            this.tlpEventos.SetColumnSpan(this.gbDescripciones, 2);
            this.gbDescripciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.gbDescripciones.Location = new System.Drawing.Point(402, 160);
            this.gbDescripciones.Name = "gbDescripciones";
            this.gbDescripciones.Size = new System.Drawing.Size(391, 180);
            this.gbDescripciones.TabIndex = 13;
            this.gbDescripciones.TabStop = false;
            this.gbDescripciones.Text = "Descripciones";
            this.gbDescripciones.Visible = false;
            // 
            // AbmEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tlpEventos);
            this.Name = "AbmEvento";
            this.Text = "AbmEvento";
            this.Load += new System.EventHandler(this.AbmEvento_Load);
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
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lbFechaEvento;
        private System.Windows.Forms.GroupBox gbEvento;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbSeleccioneEvento;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox gbAnimal;
        private System.Windows.Forms.Label lbNombreAnimal;
        private System.Windows.Forms.GroupBox gbTambo;
        private System.Windows.Forms.TextBox txtTambo;
        private System.Windows.Forms.GroupBox gbDescripciones;
        private System.Windows.Forms.ComboBox cbEventos;
        private System.Windows.Forms.Label lbCategoriaAnimal;
        private System.Windows.Forms.Button btnBuscarAnimal;
        private System.Windows.Forms.Label lbEstadoAnimal;
        private System.Windows.Forms.Label lbError;
        private System.Windows.Forms.Label lbCaravana;
    }
}