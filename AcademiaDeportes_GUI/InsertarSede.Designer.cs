namespace AcademiaDeportes_GUI
{
    partial class InsertarSede
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
            label1 = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            txtDirector = new TextBox();
            label10 = new Label();
            txtDireccion = new TextBox();
            label3 = new Label();
            label4 = new Label();
            numCapacidad = new NumericUpDown();
            btnGrabar = new Button();
            btnCerrar = new Button();
            cboUbigeo = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)numCapacidad).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(98, 93);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(158, 90);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(129, 23);
            txtNombre.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 148);
            label2.Name = "label2";
            label2.Size = new Size(118, 15);
            label2.TabIndex = 2;
            label2.Text = "Nombre del DIrector:";
            // 
            // txtDirector
            // 
            txtDirector.Location = new Point(158, 145);
            txtDirector.Name = "txtDirector";
            txtDirector.Size = new Size(150, 23);
            txtDirector.TabIndex = 3;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(62, 259);
            label10.Name = "label10";
            label10.Size = new Size(45, 15);
            label10.TabIndex = 10;
            label10.Text = "Distrito";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(158, 196);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(211, 23);
            txtDireccion.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(95, 196);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 13;
            label3.Text = "Dirección";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(493, 93);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 23;
            label4.Text = "Capacidad";
            // 
            // numCapacidad
            // 
            numCapacidad.Location = new Point(571, 88);
            numCapacidad.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            numCapacidad.Name = "numCapacidad";
            numCapacidad.Size = new Size(78, 23);
            numCapacidad.TabIndex = 24;
            // 
            // btnGrabar
            // 
            btnGrabar.Location = new Point(441, 328);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(75, 23);
            btnGrabar.TabIndex = 27;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = true;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(545, 328);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(75, 23);
            btnCerrar.TabIndex = 28;
            btnCerrar.Text = "Cancelar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // cboUbigeo
            // 
            cboUbigeo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboUbigeo.FormattingEnabled = true;
            cboUbigeo.Location = new Point(158, 259);
            cboUbigeo.Name = "cboUbigeo";
            cboUbigeo.Size = new Size(256, 23);
            cboUbigeo.TabIndex = 58;
            // 
            // InsertarSede
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(721, 379);
            Controls.Add(cboUbigeo);
            Controls.Add(btnCerrar);
            Controls.Add(btnGrabar);
            Controls.Add(numCapacidad);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtDireccion);
            Controls.Add(label10);
            Controls.Add(txtDirector);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "InsertarSede";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Insertar Nueva Sede";
            Load += InsertarSede_Load;
            ((System.ComponentModel.ISupportInitialize)numCapacidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private Label label2;
        private TextBox txtDirector;
        private Label label10;
        private TextBox txtDireccion;
        private Label label3;
        private Label label4;
        private NumericUpDown numCapacidad;
        private Button btnGrabar;
        private Button btnCerrar;
        private ComboBox cboUbigeo;
    }
}