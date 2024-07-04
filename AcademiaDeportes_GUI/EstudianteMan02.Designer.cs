namespace AcademiaDeportes_GUI
{
    partial class EstudianteMan02
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label9 = new Label();
            nombreInput = new TextBox();
            apellidoInput = new TextBox();
            fechaNacimientoInput = new DateTimePicker();
            dniInput = new TextBox();
            estadoInput = new CheckBox();
            telefonoInput = new TextBox();
            emailInput = new TextBox();
            direccionInput = new TextBox();
            sexoInput = new GroupBox();
            mujer = new RadioButton();
            hombre = new RadioButton();
            btnGrabar = new Button();
            btnCancelar = new Button();
            cboUbigeo = new ComboBox();
            label8 = new Label();
            sexoInput.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 49);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(411, 49);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(74, 110);
            label3.Name = "label3";
            label3.Size = new Size(119, 15);
            label3.TabIndex = 2;
            label3.Text = "Fecha de Nacimiento";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(330, 110);
            label4.Name = "label4";
            label4.Size = new Size(27, 15);
            label4.TabIndex = 3;
            label4.Text = "DNI";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(451, 304);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 4;
            label5.Text = "Estado";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(327, 150);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 5;
            label6.Text = "Teléfono";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(328, 201);
            label7.Name = "label7";
            label7.Size = new Size(36, 15);
            label7.TabIndex = 6;
            label7.Text = "Email";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(328, 247);
            label9.Name = "label9";
            label9.Size = new Size(57, 15);
            label9.TabIndex = 8;
            label9.Text = "Dirección";
            // 
            // nombreInput
            // 
            nombreInput.Location = new Point(131, 46);
            nombreInput.Name = "nombreInput";
            nombreInput.Size = new Size(264, 23);
            nombreInput.TabIndex = 12;
            // 
            // apellidoInput
            // 
            apellidoInput.Location = new Point(468, 46);
            apellidoInput.Name = "apellidoInput";
            apellidoInput.Size = new Size(282, 23);
            apellidoInput.TabIndex = 13;
            // 
            // fechaNacimientoInput
            // 
            fechaNacimientoInput.Format = DateTimePickerFormat.Short;
            fechaNacimientoInput.Location = new Point(199, 107);
            fechaNacimientoInput.Name = "fechaNacimientoInput";
            fechaNacimientoInput.Size = new Size(86, 23);
            fechaNacimientoInput.TabIndex = 14;
            // 
            // dniInput
            // 
            dniInput.Location = new Point(401, 107);
            dniInput.MaxLength = 8;
            dniInput.Name = "dniInput";
            dniInput.Size = new Size(137, 23);
            dniInput.TabIndex = 15;
            dniInput.KeyPress += dniInput_KeyPress;
            // 
            // estadoInput
            // 
            estadoInput.AutoSize = true;
            estadoInput.Location = new Point(532, 303);
            estadoInput.Name = "estadoInput";
            estadoInput.Size = new Size(60, 19);
            estadoInput.TabIndex = 16;
            estadoInput.Text = "Activo";
            estadoInput.UseVisualStyleBackColor = true;
            // 
            // telefonoInput
            // 
            telefonoInput.Location = new Point(401, 150);
            telefonoInput.MaxLength = 9;
            telefonoInput.Name = "telefonoInput";
            telefonoInput.Size = new Size(137, 23);
            telefonoInput.TabIndex = 17;
            telefonoInput.KeyPress += telefonoInput_KeyPress;
            // 
            // emailInput
            // 
            emailInput.Location = new Point(401, 197);
            emailInput.Name = "emailInput";
            emailInput.Size = new Size(349, 23);
            emailInput.TabIndex = 18;
            // 
            // direccionInput
            // 
            direccionInput.Location = new Point(401, 244);
            direccionInput.Name = "direccionInput";
            direccionInput.Size = new Size(349, 23);
            direccionInput.TabIndex = 20;
            // 
            // sexoInput
            // 
            sexoInput.Controls.Add(mujer);
            sexoInput.Controls.Add(hombre);
            sexoInput.Location = new Point(74, 150);
            sexoInput.Name = "sexoInput";
            sexoInput.Size = new Size(200, 100);
            sexoInput.TabIndex = 23;
            sexoInput.TabStop = false;
            sexoInput.Text = "Sexo";
            // 
            // mujer
            // 
            mujer.AutoSize = true;
            mujer.Location = new Point(18, 65);
            mujer.Name = "mujer";
            mujer.Size = new Size(56, 19);
            mujer.TabIndex = 1;
            mujer.TabStop = true;
            mujer.Text = "Mujer";
            mujer.UseVisualStyleBackColor = true;
            // 
            // hombre
            // 
            hombre.AutoSize = true;
            hombre.Location = new Point(18, 32);
            hombre.Name = "hombre";
            hombre.Size = new Size(69, 19);
            hombre.TabIndex = 0;
            hombre.TabStop = true;
            hombre.Text = "Hombre";
            hombre.UseVisualStyleBackColor = true;
            // 
            // btnGrabar
            // 
            btnGrabar.Location = new Point(484, 399);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(75, 23);
            btnGrabar.TabIndex = 24;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = true;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(616, 399);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 25;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // cboUbigeo
            // 
            cboUbigeo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboUbigeo.FormattingEnabled = true;
            cboUbigeo.Location = new Point(147, 299);
            cboUbigeo.Name = "cboUbigeo";
            cboUbigeo.Size = new Size(256, 23);
            cboUbigeo.TabIndex = 61;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(74, 299);
            label8.Name = "label8";
            label8.Size = new Size(48, 15);
            label8.TabIndex = 60;
            label8.Text = "Distrito:";
            // 
            // EstudianteMan02
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cboUbigeo);
            Controls.Add(label8);
            Controls.Add(btnCancelar);
            Controls.Add(btnGrabar);
            Controls.Add(sexoInput);
            Controls.Add(direccionInput);
            Controls.Add(emailInput);
            Controls.Add(telefonoInput);
            Controls.Add(estadoInput);
            Controls.Add(dniInput);
            Controls.Add(fechaNacimientoInput);
            Controls.Add(apellidoInput);
            Controls.Add(nombreInput);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EstudianteMan02";
            Text = "Inserta Nuevo Estudiante";
            Load += Form2_Load;
            sexoInput.ResumeLayout(false);
            sexoInput.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label9;
        private TextBox nombreInput;
        private TextBox apellidoInput;
        private DateTimePicker fechaNacimientoInput;
        private TextBox dniInput;
        private CheckBox estadoInput;
        private TextBox telefonoInput;
        private TextBox emailInput;
        private TextBox direccionInput;
        private GroupBox sexoInput;
        private RadioButton mujer;
        private RadioButton hombre;
        private Button btnGrabar;
        private Button btnCancelar;
        private ComboBox cboUbigeo;
        private Label label8;
    }
}