namespace AcademiaDeportes_GUI
{
    partial class EstudianteMan03
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
            sexoInput = new GroupBox();
            mujer = new RadioButton();
            hombre = new RadioButton();
            direccionInput = new TextBox();
            emailInput = new TextBox();
            telefonoInput = new TextBox();
            estadoInput = new CheckBox();
            dniInput = new TextBox();
            fechaNacimientoInput = new DateTimePicker();
            apellidoInput = new TextBox();
            nombreInput = new TextBox();
            label9 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            labelID = new Label();
            label8 = new Label();
            cboUbigeo = new ComboBox();
            label13 = new Label();
            sexoInput.SuspendLayout();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(619, 390);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 49;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGrabar
            // 
            btnGrabar.Location = new Point(487, 390);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(75, 23);
            btnGrabar.TabIndex = 48;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = true;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // sexoInput
            // 
            sexoInput.Controls.Add(mujer);
            sexoInput.Controls.Add(hombre);
            sexoInput.Location = new Point(46, 184);
            sexoInput.Name = "sexoInput";
            sexoInput.Size = new Size(200, 100);
            sexoInput.TabIndex = 47;
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
            // direccionInput
            // 
            direccionInput.Location = new Point(441, 241);
            direccionInput.Name = "direccionInput";
            direccionInput.Size = new Size(319, 23);
            direccionInput.TabIndex = 45;
            // 
            // emailInput
            // 
            emailInput.Location = new Point(441, 194);
            emailInput.Name = "emailInput";
            emailInput.Size = new Size(319, 23);
            emailInput.TabIndex = 44;
            // 
            // telefonoInput
            // 
            telefonoInput.Location = new Point(441, 147);
            telefonoInput.MaxLength = 9;
            telefonoInput.Name = "telefonoInput";
            telefonoInput.Size = new Size(137, 23);
            telefonoInput.TabIndex = 43;
            telefonoInput.KeyPress += telefonoInput_KeyPress;
            // 
            // estadoInput
            // 
            estadoInput.AutoSize = true;
            estadoInput.Location = new Point(127, 295);
            estadoInput.Name = "estadoInput";
            estadoInput.Size = new Size(60, 19);
            estadoInput.TabIndex = 42;
            estadoInput.Text = "Activo";
            estadoInput.UseVisualStyleBackColor = true;
            // 
            // dniInput
            // 
            dniInput.Location = new Point(134, 144);
            dniInput.MaxLength = 8;
            dniInput.Name = "dniInput";
            dniInput.Size = new Size(100, 23);
            dniInput.TabIndex = 41;
            dniInput.TextChanged += dniInput_TextChanged;
            dniInput.KeyPress += dniInput_KeyPress;
            // 
            // fechaNacimientoInput
            // 
            fechaNacimientoInput.Format = DateTimePickerFormat.Short;
            fechaNacimientoInput.Location = new Point(171, 104);
            fechaNacimientoInput.Name = "fechaNacimientoInput";
            fechaNacimientoInput.Size = new Size(92, 23);
            fechaNacimientoInput.TabIndex = 40;
            // 
            // apellidoInput
            // 
            apellidoInput.Location = new Point(441, 63);
            apellidoInput.Name = "apellidoInput";
            apellidoInput.Size = new Size(313, 23);
            apellidoInput.TabIndex = 39;
            // 
            // nombreInput
            // 
            nombreInput.Location = new Point(103, 63);
            nombreInput.Name = "nombreInput";
            nombreInput.Size = new Size(250, 23);
            nombreInput.TabIndex = 38;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(368, 244);
            label9.Name = "label9";
            label9.Size = new Size(57, 15);
            label9.TabIndex = 34;
            label9.Text = "Dirección";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(368, 198);
            label7.Name = "label7";
            label7.Size = new Size(36, 15);
            label7.TabIndex = 33;
            label7.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(367, 147);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 32;
            label6.Text = "Teléfono";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(46, 296);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 31;
            label5.Text = "Estado";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 144);
            label4.Name = "label4";
            label4.Size = new Size(27, 15);
            label4.TabIndex = 30;
            label4.Text = "DNI";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 107);
            label3.Name = "label3";
            label3.Size = new Size(119, 15);
            label3.TabIndex = 29;
            label3.Text = "Fecha de Nacimiento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(368, 66);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 28;
            label2.Text = "Apellido";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 66);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 27;
            label1.Text = "Nombre";
            // 
            // labelID
            // 
            labelID.BorderStyle = BorderStyle.FixedSingle;
            labelID.Location = new Point(673, 16);
            labelID.Name = "labelID";
            labelID.Size = new Size(70, 23);
            labelID.TabIndex = 52;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(646, 17);
            label8.Name = "label8";
            label8.Size = new Size(21, 15);
            label8.TabIndex = 51;
            label8.Text = "ID:";
            // 
            // cboUbigeo
            // 
            cboUbigeo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboUbigeo.FormattingEnabled = true;
            cboUbigeo.Location = new Point(441, 288);
            cboUbigeo.Name = "cboUbigeo";
            cboUbigeo.Size = new Size(256, 23);
            cboUbigeo.TabIndex = 61;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(371, 296);
            label13.Name = "label13";
            label13.Size = new Size(48, 15);
            label13.TabIndex = 60;
            label13.Text = "Distrito:";
            // 
            // EstudianteMan03
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cboUbigeo);
            Controls.Add(label13);
            Controls.Add(labelID);
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
            Name = "EstudianteMan03";
            Text = "Actualizar Estudiante";
            Load += EstudianteMan03_Load;
            sexoInput.ResumeLayout(false);
            sexoInput.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnCancelar;
        private Button btnGrabar;
        private GroupBox sexoInput;
        private RadioButton mujer;
        private RadioButton hombre;
        private TextBox direccionInput;
        private TextBox emailInput;
        private TextBox telefonoInput;
        private CheckBox estadoInput;
        private TextBox dniInput;
        private DateTimePicker fechaNacimientoInput;
        private TextBox apellidoInput;
        private TextBox nombreInput;
        private Label label9;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label labelID;
        private Label label8;
        private ComboBox cboUbigeo;
        private Label label13;
    }
}