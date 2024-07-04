namespace AcademiaDeportes_GUI
{
    partial class Principal
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
            menuStrip1 = new MenuStrip();
            mantenimientosToolStripMenuItem = new ToolStripMenuItem();
            estudiantesToolStripMenuItem1 = new ToolStripMenuItem();
            instructoresToolStripMenuItem = new ToolStripMenuItem();
            sedesToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            salirDelSistemaToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            lblStatus = new ToolStripStatusLabel();
            lblUsuario = new ToolStripStatusLabel();
            consultasToolStripMenuItem = new ToolStripMenuItem();
            listadosToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { mantenimientosToolStripMenuItem, consultasToolStripMenuItem, listadosToolStripMenuItem, salirToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1039, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // mantenimientosToolStripMenuItem
            // 
            mantenimientosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { estudiantesToolStripMenuItem1, instructoresToolStripMenuItem, sedesToolStripMenuItem });
            mantenimientosToolStripMenuItem.Image = Properties.Resources.seleccionar;
            mantenimientosToolStripMenuItem.Name = "mantenimientosToolStripMenuItem";
            mantenimientosToolStripMenuItem.Size = new Size(122, 20);
            mantenimientosToolStripMenuItem.Text = "Mantenimientos";
            // 
            // estudiantesToolStripMenuItem1
            // 
            estudiantesToolStripMenuItem1.Image = Properties.Resources.estudiantes;
            estudiantesToolStripMenuItem1.Name = "estudiantesToolStripMenuItem1";
            estudiantesToolStripMenuItem1.Size = new Size(180, 22);
            estudiantesToolStripMenuItem1.Text = "Estudiantes";
            estudiantesToolStripMenuItem1.Click += estudiantesToolStripMenuItem1_Click;
            // 
            // instructoresToolStripMenuItem
            // 
            instructoresToolStripMenuItem.Image = Properties.Resources.instructores;
            instructoresToolStripMenuItem.Name = "instructoresToolStripMenuItem";
            instructoresToolStripMenuItem.Size = new Size(180, 22);
            instructoresToolStripMenuItem.Text = "Instructores";
            instructoresToolStripMenuItem.Click += instructoresToolStripMenuItem_Click;
            // 
            // sedesToolStripMenuItem
            // 
            sedesToolStripMenuItem.Image = Properties.Resources.sedes;
            sedesToolStripMenuItem.Name = "sedesToolStripMenuItem";
            sedesToolStripMenuItem.Size = new Size(180, 22);
            sedesToolStripMenuItem.Text = "Sedes";
            sedesToolStripMenuItem.Click += sedesToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salirDelSistemaToolStripMenuItem });
            salirToolStripMenuItem.Image = Properties.Resources.salir;
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(57, 20);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // salirDelSistemaToolStripMenuItem
            // 
            salirDelSistemaToolStripMenuItem.Name = "salirDelSistemaToolStripMenuItem";
            salirDelSistemaToolStripMenuItem.Size = new Size(180, 22);
            salirDelSistemaToolStripMenuItem.Text = "Salir del sistema";
            salirDelSistemaToolStripMenuItem.Click += salirDelSistemaToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblStatus, lblUsuario });
            statusStrip1.Location = new Point(0, 520);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1039, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            lblStatus.BackColor = SystemColors.ActiveCaptionText;
            lblStatus.ForeColor = SystemColors.ButtonHighlight;
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(50, 17);
            lblStatus.Text = "Usuario:";
            lblStatus.Click += lbl1_Click;
            // 
            // lblUsuario
            // 
            lblUsuario.BackColor = SystemColors.ActiveCaption;
            lblUsuario.ForeColor = SystemColors.ButtonHighlight;
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(19, 17);
            lblUsuario.Text = "....";
            // 
            // consultasToolStripMenuItem
            // 
            consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            consultasToolStripMenuItem.Size = new Size(71, 20);
            consultasToolStripMenuItem.Text = "Consultas";
            // 
            // listadosToolStripMenuItem
            // 
            listadosToolStripMenuItem.Name = "listadosToolStripMenuItem";
            listadosToolStripMenuItem.Size = new Size(62, 20);
            listadosToolStripMenuItem.Text = "Listados";
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.imgFondo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1039, 542);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            DoubleBuffered = true;
            MainMenuStrip = menuStrip1;
            Name = "Principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Principal MDI";
            WindowState = FormWindowState.Maximized;
            FormClosing += Principal_FormClosing;
            FormClosed += Principal_FormClosed;
            Load += Principal_Load;
            Resize += Principal_Resize;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mantenimientosToolStripMenuItem;
        private ToolStripMenuItem instructoresToolStripMenuItem;
        private ToolStripMenuItem sedesToolStripMenuItem;
        private ToolStripMenuItem estudiantesToolStripMenuItem1;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem salirDelSistemaToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblStatus;
        private ToolStripStatusLabel lblUsuario;
        private ToolStripMenuItem consultasToolStripMenuItem;
        private ToolStripMenuItem listadosToolStripMenuItem;
    }
}