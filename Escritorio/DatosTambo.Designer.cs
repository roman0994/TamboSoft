namespace Escritorio
{
    partial class DatosTambo
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
            this.gbTambo = new System.Windows.Forms.GroupBox();
            this.txtTambo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbDatosTambo = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtProvincia = new System.Windows.Forms.TextBox();
            this.txtLocalidad = new System.Windows.Forms.TextBox();
            this.txtSuperficie = new System.Windows.Forms.TextBox();
            this.txtNombreTambo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnNuevoTambo = new System.Windows.Forms.Button();
            this.btnModificarDatos = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbTambo.SuspendLayout();
            this.gbDatosTambo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.gbTambo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gbDatosTambo, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSalir, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnNuevoTambo, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnModificarDatos, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // gbTambo
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.gbTambo, 3);
            this.gbTambo.Controls.Add(this.txtTambo);
            this.gbTambo.Controls.Add(this.label1);
            this.gbTambo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbTambo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTambo.Location = new System.Drawing.Point(6, 18);
            this.gbTambo.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.gbTambo.Name = "gbTambo";
            this.gbTambo.Padding = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.gbTambo.Size = new System.Drawing.Size(788, 84);
            this.gbTambo.TabIndex = 0;
            this.gbTambo.TabStop = false;
            this.gbTambo.Text = "Tambo";
            // 
            // txtTambo
            // 
            this.txtTambo.Location = new System.Drawing.Point(233, 36);
            this.txtTambo.Name = "txtTambo";
            this.txtTambo.ReadOnly = true;
            this.txtTambo.Size = new System.Drawing.Size(200, 20);
            this.txtTambo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datos correspondientes al tambo:";
            // 
            // gbDatosTambo
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.gbDatosTambo, 3);
            this.gbDatosTambo.Controls.Add(this.btnEliminar);
            this.gbDatosTambo.Controls.Add(this.txtProvincia);
            this.gbDatosTambo.Controls.Add(this.txtLocalidad);
            this.gbDatosTambo.Controls.Add(this.txtSuperficie);
            this.gbDatosTambo.Controls.Add(this.txtNombreTambo);
            this.gbDatosTambo.Controls.Add(this.label6);
            this.gbDatosTambo.Controls.Add(this.label5);
            this.gbDatosTambo.Controls.Add(this.label3);
            this.gbDatosTambo.Controls.Add(this.label2);
            this.gbDatosTambo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDatosTambo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatosTambo.Location = new System.Drawing.Point(6, 111);
            this.gbDatosTambo.Name = "gbDatosTambo";
            this.gbDatosTambo.Size = new System.Drawing.Size(788, 300);
            this.gbDatosTambo.TabIndex = 1;
            this.gbDatosTambo.TabStop = false;
            this.gbDatosTambo.Text = "Datos tambo";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminar.Location = new System.Drawing.Point(558, 141);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(105, 56);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar tambo y salir";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtProvincia
            // 
            this.txtProvincia.Location = new System.Drawing.Point(176, 200);
            this.txtProvincia.Name = "txtProvincia";
            this.txtProvincia.ReadOnly = true;
            this.txtProvincia.Size = new System.Drawing.Size(200, 20);
            this.txtProvincia.TabIndex = 6;
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.Location = new System.Drawing.Point(176, 149);
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.ReadOnly = true;
            this.txtLocalidad.Size = new System.Drawing.Size(200, 20);
            this.txtLocalidad.TabIndex = 5;
            // 
            // txtSuperficie
            // 
            this.txtSuperficie.Location = new System.Drawing.Point(176, 97);
            this.txtSuperficie.Name = "txtSuperficie";
            this.txtSuperficie.ReadOnly = true;
            this.txtSuperficie.Size = new System.Drawing.Size(200, 20);
            this.txtSuperficie.TabIndex = 3;
            // 
            // txtNombreTambo
            // 
            this.txtNombreTambo.Location = new System.Drawing.Point(176, 48);
            this.txtNombreTambo.Name = "txtNombreTambo";
            this.txtNombreTambo.ReadOnly = true;
            this.txtNombreTambo.Size = new System.Drawing.Size(200, 20);
            this.txtNombreTambo.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Provincia:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Localidad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Superficie:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre:";
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.Location = new System.Drawing.Point(627, 420);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 24);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnNuevoTambo
            // 
            this.btnNuevoTambo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnNuevoTambo.Location = new System.Drawing.Point(83, 420);
            this.btnNuevoTambo.Name = "btnNuevoTambo";
            this.btnNuevoTambo.Size = new System.Drawing.Size(101, 24);
            this.btnNuevoTambo.TabIndex = 11;
            this.btnNuevoTambo.Text = "Nuevo tambo";
            this.btnNuevoTambo.UseVisualStyleBackColor = true;
            this.btnNuevoTambo.Click += new System.EventHandler(this.btnNuevoTambo_Click);
            // 
            // btnModificarDatos
            // 
            this.btnModificarDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnModificarDatos.Location = new System.Drawing.Point(349, 420);
            this.btnModificarDatos.Name = "btnModificarDatos";
            this.btnModificarDatos.Size = new System.Drawing.Size(100, 24);
            this.btnModificarDatos.TabIndex = 10;
            this.btnModificarDatos.Text = "Modificar datos";
            this.btnModificarDatos.UseVisualStyleBackColor = true;
            this.btnModificarDatos.Click += new System.EventHandler(this.btnModificarDatos_Click);
            // 
            // DatosTambo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DatosTambo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos Tambo";
            this.Activated += new System.EventHandler(this.DatosTambo_Activated);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.gbTambo.ResumeLayout(false);
            this.gbTambo.PerformLayout();
            this.gbDatosTambo.ResumeLayout(false);
            this.gbDatosTambo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox gbTambo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbDatosTambo;
        private System.Windows.Forms.TextBox txtProvincia;
        private System.Windows.Forms.TextBox txtLocalidad;
        private System.Windows.Forms.TextBox txtSuperficie;
        private System.Windows.Forms.TextBox txtNombreTambo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnModificarDatos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnNuevoTambo;
        private System.Windows.Forms.TextBox txtTambo;
        private System.Windows.Forms.Button btnEliminar;
    }
}