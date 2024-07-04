namespace AcademiaDeportes_GUI
{
    partial class ActualizarSede
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
            label6 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label10 = new Label();
            txtUpdNombre = new TextBox();
            txtUpdDireccion = new TextBox();
            txtUpdDirector = new TextBox();
            btnGrabar = new Button();
            btnCancelar = new Button();
            updCapacidad = new NumericUpDown();
            lblCodigo = new Label();
            cboUbigeo = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)updCapacidad).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(206, 116);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 36);
            label6.Name = "label6";
            label6.Size = new Size(74, 15);
            label6.TabIndex = 30;
            label6.Text = "Código Sede";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(139, 168);
            label2.Name = "label2";
            label2.Size = new Size(118, 15);
            label2.TabIndex = 31;
            label2.Text = "Nombre del DIrector:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(200, 214);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 32;
            label3.Text = "Dirección";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(506, 116);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 33;
            label4.Text = "Capacidad";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(209, 265);
            label10.Name = "label10";
            label10.Size = new Size(48, 15);
            label10.TabIndex = 34;
            label10.Text = "Distrito:";
            // 
            // txtUpdNombre
            // 
            txtUpdNombre.Location = new Point(263, 116);
            txtUpdNombre.Name = "txtUpdNombre";
            txtUpdNombre.Size = new Size(129, 23);
            txtUpdNombre.TabIndex = 39;
            // 
            // txtUpdDireccion
            // 
            txtUpdDireccion.Location = new Point(263, 209);
            txtUpdDireccion.Name = "txtUpdDireccion";
            txtUpdDireccion.Size = new Size(129, 23);
            txtUpdDireccion.TabIndex = 40;
            // 
            // txtUpdDirector
            // 
            txtUpdDirector.Location = new Point(263, 165);
            txtUpdDirector.Name = "txtUpdDirector";
            txtUpdDirector.Size = new Size(129, 23);
            txtUpdDirector.TabIndex = 41;
            // 
            // btnGrabar
            // 
            btnGrabar.Location = new Point(447, 354);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(75, 23);
            btnGrabar.TabIndex = 43;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = true;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(552, 354);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 44;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // updCapacidad
            // 
            updCapacidad.Location = new Point(575, 114);
            updCapacidad.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            updCapacidad.Name = "updCapacidad";
            updCapacidad.Size = new Size(78, 23);
            updCapacidad.TabIndex = 38;
            // 
            // lblCodigo
            // 
            lblCodigo.BorderStyle = BorderStyle.FixedSingle;
            lblCodigo.Location = new Point(92, 35);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(70, 23);
            lblCodigo.TabIndex = 45;
            // 
            // cboUbigeo
            // 
            cboUbigeo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboUbigeo.FormattingEnabled = true;
            cboUbigeo.Location = new Point(263, 262);
            cboUbigeo.Name = "cboUbigeo";
            cboUbigeo.Size = new Size(256, 23);
            cboUbigeo.TabIndex = 59;
            // 
            // ActualizarSede
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(872, 401);
            Controls.Add(cboUbigeo);
            Controls.Add(lblCodigo);
            Controls.Add(btnCancelar);
            Controls.Add(btnGrabar);
            Controls.Add(txtUpdDirector);
            Controls.Add(txtUpdDireccion);
            Controls.Add(txtUpdNombre);
            Controls.Add(updCapacidad);
            Controls.Add(label10);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ActualizarSede";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Actualizar Sede";
            Load += ActualizarSede_Load;
            ((System.ComponentModel.ISupportInitialize)updCapacidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label6;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label10;
        private TextBox txtUpdNombre;
        private TextBox txtUpdDireccion;
        private TextBox txtUpdDirector;
        private Button btnGrabar;
        private Button btnCancelar;
        private NumericUpDown updCapacidad;
        private Label lblCodigo;
        private ComboBox cboUbigeo;
    }
}