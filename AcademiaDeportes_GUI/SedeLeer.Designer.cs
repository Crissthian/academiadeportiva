namespace AcademiaDeportes_GUI
{
    partial class SedeLeer
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
            txtFiltroSede = new TextBox();
            dtgSedes = new DataGridView();
            btnAgregarSede = new Button();
            btnActualizarSede = new Button();
            button1 = new Button();
            label2 = new Label();
            lblTotalSedes = new Label();
            btnEliminarSede = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgSedes).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 26);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 0;
            label1.Text = "Buscar Sede";
            // 
            // txtFiltroSede
            // 
            txtFiltroSede.Location = new Point(143, 26);
            txtFiltroSede.Name = "txtFiltroSede";
            txtFiltroSede.Size = new Size(283, 23);
            txtFiltroSede.TabIndex = 1;
            txtFiltroSede.TextChanged += txtFiltroSede_TextChanged;
            // 
            // dtgSedes
            // 
            dtgSedes.AllowUserToAddRows = false;
            dtgSedes.AllowUserToDeleteRows = false;
            dtgSedes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgSedes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgSedes.Location = new Point(143, 81);
            dtgSedes.Name = "dtgSedes";
            dtgSedes.ReadOnly = true;
            dtgSedes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgSedes.Size = new Size(833, 322);
            dtgSedes.TabIndex = 2;
            // 
            // btnAgregarSede
            // 
            btnAgregarSede.Location = new Point(581, 494);
            btnAgregarSede.Name = "btnAgregarSede";
            btnAgregarSede.Size = new Size(104, 33);
            btnAgregarSede.TabIndex = 3;
            btnAgregarSede.Text = "Agregar";
            btnAgregarSede.UseVisualStyleBackColor = true;
            btnAgregarSede.Click += btnAgregarSede_Click;
            // 
            // btnActualizarSede
            // 
            btnActualizarSede.Location = new Point(691, 494);
            btnActualizarSede.Name = "btnActualizarSede";
            btnActualizarSede.Size = new Size(98, 33);
            btnActualizarSede.TabIndex = 4;
            btnActualizarSede.Text = "Actualizar";
            btnActualizarSede.UseVisualStyleBackColor = true;
            btnActualizarSede.Click += btnActualizarSede_Click;
            // 
            // button1
            // 
            button1.Location = new Point(899, 494);
            button1.Name = "button1";
            button1.Size = new Size(98, 33);
            button1.TabIndex = 5;
            button1.Text = "Cerrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(791, 432);
            label2.Name = "label2";
            label2.Size = new Size(102, 15);
            label2.TabIndex = 6;
            label2.Text = "Total de Registros:";
            // 
            // lblTotalSedes
            // 
            lblTotalSedes.BorderStyle = BorderStyle.FixedSingle;
            lblTotalSedes.Location = new Point(899, 428);
            lblTotalSedes.Name = "lblTotalSedes";
            lblTotalSedes.Size = new Size(84, 22);
            lblTotalSedes.TabIndex = 8;
            lblTotalSedes.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnEliminarSede
            // 
            btnEliminarSede.Location = new Point(795, 494);
            btnEliminarSede.Name = "btnEliminarSede";
            btnEliminarSede.Size = new Size(98, 33);
            btnEliminarSede.TabIndex = 9;
            btnEliminarSede.Text = "Eliminar";
            btnEliminarSede.UseVisualStyleBackColor = true;
            btnEliminarSede.Click += btnEliminarSede_Click;
            // 
            // SedeLeer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1060, 558);
            Controls.Add(btnEliminarSede);
            Controls.Add(lblTotalSedes);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(btnActualizarSede);
            Controls.Add(btnAgregarSede);
            Controls.Add(dtgSedes);
            Controls.Add(txtFiltroSede);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SedeLeer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Listar Sedes";
            Load += SedeLeer_Load;
            ((System.ComponentModel.ISupportInitialize)dtgSedes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFiltroSede;
        private DataGridView dtgSedes;
        private Button btnAgregarSede;
        private Button btnActualizarSede;
        private Button button1;
        private Label label2;
        private Label lblTotalSedes;
        private Button btnEliminarSede;
    }
}