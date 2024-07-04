namespace AcademiaDeportes_GUI
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void MostrarFormulario<T>() where T : Form, new()
        {
            var frm = MdiChildren.OfType<T>().FirstOrDefault();
            if (frm == null)
            {
                frm = new T
                {
                    MdiParent = this
                };
                ActiveMdiChild?.Close();
                frm.Show();
            }
            else
            {
                frm.BringToFront();
            }
        }

        private void estudiantesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MostrarFormulario<EstudianteMan01>();
        }

        private void sedesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarFormulario<SedeLeer>();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Está seguro que desea salir?",
                "Seguro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Principal_Resize(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void instructoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarFormulario<InstructorPrincipal>();
        }

        private void salirDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbl1_Click(object sender, EventArgs e)
        {
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            //manejando seguridad por niveles

            if (clsCredenciales.Nivel == 1) //administrador
            {
                mantenimientosToolStripMenuItem.Visible = true;
                consultasToolStripMenuItem.Visible = true;
                listadosToolStripMenuItem.Visible = true;
                salirDelSistemaToolStripMenuItem.Visible = true;
            }
            else if (clsCredenciales.Nivel == 2)
            {
                //Restringir el acceso a consultas
                mantenimientosToolStripMenuItem.Visible = true;
                consultasToolStripMenuItem.Visible = false;
                listadosToolStripMenuItem.Visible = true;
                salirDelSistemaToolStripMenuItem.Visible = true;
            }

            this.lblUsuario.Text = clsCredenciales.Usuario;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }
    }
}