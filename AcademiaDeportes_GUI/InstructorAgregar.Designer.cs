namespace AcademiaDeportes_GUI
{
    partial class InstructorAgregar
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
            btnCancelar = new Button();
            btnGrabar = new Button();
            direccionInput = new TextBox();
            emailInput = new TextBox();
            telefonoInput = new TextBox();
            dniInput = new TextBox();
            apellidoInput = new TextBox();
            nombreInput = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label7 = new Label();
            cboEspecialidad = new ComboBox();
            label13 = new Label();
            cboUbigeo = new ComboBox();
            fechaNacimientoInput = new DateTimePicker();
            label5 = new Label();
            fechaIngresoInput = new DateTimePicker();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(647, 397);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 50;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGrabar
            // 
            btnGrabar.Location = new Point(515, 397);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(75, 23);
            btnGrabar.TabIndex = 49;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = true;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // direccionInput
            // 
            direccionInput.Location = new Point(179, 275);
            direccionInput.Name = "direccionInput";
            direccionInput.Size = new Size(319, 23);
            direccionInput.TabIndex = 47;
            // 
            // emailInput
            // 
            emailInput.Location = new Point(179, 228);
            emailInput.Name = "emailInput";
            emailInput.Size = new Size(319, 23);
            emailInput.TabIndex = 46;
            // 
            // telefonoInput
            // 
            telefonoInput.Location = new Point(432, 148);
            telefonoInput.MaxLength = 9;
            telefonoInput.Name = "telefonoInput";
            telefonoInput.Size = new Size(137, 23);
            telefonoInput.TabIndex = 45;
            telefonoInput.KeyPress += telefonoInput_KeyPress;
            // 
            // dniInput
            // 
            dniInput.Location = new Point(193, 145);
            dniInput.MaxLength = 8;
            dniInput.Name = "dniInput";
            dniInput.Size = new Size(100, 23);
            dniInput.TabIndex = 43;
            dniInput.KeyPress += dniInput_KeyPress;
            // 
            // apellidoInput
            // 
            apellidoInput.Location = new Point(520, 44);
            apellidoInput.Name = "apellidoInput";
            apellidoInput.Size = new Size(252, 23);
            apellidoInput.TabIndex = 41;
            // 
            // nombreInput
            // 
            nombreInput.Location = new Point(193, 44);
            nombreInput.Name = "nombreInput";
            nombreInput.Size = new Size(242, 23);
            nombreInput.TabIndex = 40;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(105, 352);
            label10.Name = "label10";
            label10.Size = new Size(45, 15);
            label10.TabIndex = 37;
            label10.Text = "Ubigeo";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(106, 278);
            label9.Name = "label9";
            label9.Size = new Size(57, 15);
            label9.TabIndex = 36;
            label9.Text = "Dirección";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(358, 148);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 34;
            label6.Text = "Teléfono";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(105, 145);
            label4.Name = "label4";
            label4.Size = new Size(27, 15);
            label4.TabIndex = 32;
            label4.Text = "DNI";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(105, 98);
            label3.Name = "label3";
            label3.Size = new Size(119, 15);
            label3.TabIndex = 31;
            label3.Text = "Fecha de Nacimiento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(447, 47);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 29;
            label2.Text = "Apellido";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(105, 47);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 28;
            label1.Text = "Nombre";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(106, 232);
            label7.Name = "label7";
            label7.Size = new Size(36, 15);
            label7.TabIndex = 35;
            label7.Text = "Email";
            // 
            // cboEspecialidad
            // 
            cboEspecialidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEspecialidad.FormattingEnabled = true;
            cboEspecialidad.Location = new Point(179, 188);
            cboEspecialidad.Name = "cboEspecialidad";
            cboEspecialidad.Size = new Size(256, 23);
            cboEspecialidad.TabIndex = 56;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(105, 196);
            label13.Name = "label13";
            label13.Size = new Size(72, 15);
            label13.TabIndex = 55;
            label13.Text = "Especialidad";
            // 
            // cboUbigeo
            // 
            cboUbigeo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboUbigeo.FormattingEnabled = true;
            cboUbigeo.Location = new Point(179, 352);
            cboUbigeo.Name = "cboUbigeo";
            cboUbigeo.Size = new Size(256, 23);
            cboUbigeo.TabIndex = 57;
            // 
            // fechaNacimientoInput
            // 
            fechaNacimientoInput.Format = DateTimePickerFormat.Short;
            fechaNacimientoInput.Location = new Point(230, 98);
            fechaNacimientoInput.Name = "fechaNacimientoInput";
            fechaNacimientoInput.Size = new Size(83, 23);
            fechaNacimientoInput.TabIndex = 59;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(106, 314);
            label5.Name = "label5";
            label5.Size = new Size(96, 15);
            label5.TabIndex = 60;
            label5.Text = "Fecha de Ingreso";
            label5.Click += label5_Click;
            // 
            // fechaIngresoInput
            // 
            fechaIngresoInput.Format = DateTimePickerFormat.Short;
            fechaIngresoInput.Location = new Point(217, 314);
            fechaIngresoInput.Name = "fechaIngresoInput";
            fechaIngresoInput.Size = new Size(96, 23);
            fechaIngresoInput.TabIndex = 61;
            // 
            // InstructorAgregar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(fechaIngresoInput);
            Controls.Add(label5);
            Controls.Add(fechaNacimientoInput);
            Controls.Add(cboUbigeo);
            Controls.Add(cboEspecialidad);
            Controls.Add(label13);
            Controls.Add(btnCancelar);
            Controls.Add(btnGrabar);
            Controls.Add(direccionInput);
            Controls.Add(emailInput);
            Controls.Add(telefonoInput);
            Controls.Add(dniInput);
            Controls.Add(apellidoInput);
            Controls.Add(nombreInput);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label7);
            Name = "InstructorAgregar";
            Text = "Agregar nuevo instructor";
            Load += InstructorAgregar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnCancelar;
        private Button btnGrabar;
        private TextBox direccionInput;
        private TextBox emailInput;
        private TextBox telefonoInput;
        private TextBox dniInput;
        private TextBox apellidoInput;
        private TextBox nombreInput;
        private Label label10;
        private Label label9;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label7;
        private ComboBox cboEspecialidad;
        private Label label13;
        private ComboBox cboUbigeo;
        private DateTimePicker fechaNacimientoInput;
        private Label label5;
        private DateTimePicker fechaIngresoInput;
    }
}