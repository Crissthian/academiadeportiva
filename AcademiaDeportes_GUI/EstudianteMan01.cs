
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data; // Para los objetos DataTable, DataRow y DataView
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Agregar...
using AcademiaDeportes_BL;

namespace AcademiaDeportes_GUI
{
    public partial class EstudianteMan01 : Form
    {
        // Instancias
        EstudianteBL objEstudianteBL = new EstudianteBL();
        DataView dtv;

        public EstudianteMan01()
        {
            InitializeComponent();
        }

        private void ProductoMan01_Load(object sender, EventArgs e)
        {
            //  Invocamos al metodo CargarDatos pasandole una cadena vacia ,
            //  lo cual hara que se muestren todos los productos por defecto al 
            //momento de cargar el formulario

            CargarDatos("");

        }

        private void CargarDatos(String strFiltro)
        {

            // Construimos  el objeto Dataview dtv  en base al DataTable devuelto por el metodo ListarProducto
            // Y lo filtramos de acuerdo al parametro strFiltro
            dtv = new DataView(objEstudianteBL.ListarEstudiante());
            dtv.RowFilter = "nombre like '%" + strFiltro + "%'";
            dtgDatos.DataSource = dtv;
            lblRegistros.Text = dtgDatos.Rows.Count.ToString();

        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Pasaremos al metodo CargarDatos el texto que se va escribiendo
                // en la caja de texto 
                CargarDatos(txtFiltro.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                EstudianteMan02 objEstudianteMan02 = new EstudianteMan02();
                objEstudianteMan02.ShowDialog();

                CargarDatos(txtFiltro.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgDatos.CurrentRow.Cells[0].Value != DBNull.Value)
                {
                    String dato = dtgDatos.CurrentRow.Cells[0].Value.ToString();
                    Int16 datoInt = Convert.ToInt16(dato);


                    EstudianteMan03 objEstudianteMan03 = new EstudianteMan03();
                    objEstudianteMan03.Id = datoInt;
                    objEstudianteMan03.ShowDialog();

                    CargarDatos(txtFiltro.Text.Trim());
                }
                else
                {
                    MessageBox.Show("The selected cell contains no valid ID.");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Int16 id = Convert.ToInt16(dtgDatos.CurrentRow.Cells[0].Value);

                DialogResult vrpta = MessageBox.Show("¿Estas seguro de eliminar el registro?", "Confirmar",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (vrpta == DialogResult.Yes)
                {
                    if(objEstudianteBL.EliminarEstudiante(id)==true) 
                    {
                        CargarDatos(txtFiltro.Text);
                    }
                    else 
                    {
                        throw new Exception("No se puede eliminar el registro porque está vinculado a otra tabla");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
