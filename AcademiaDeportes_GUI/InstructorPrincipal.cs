using AcademiaDeportes_BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademiaDeportes_GUI
{
    public partial class InstructorPrincipal : Form
    {
        InstructorBL objInstructorBL = new InstructorBL();
        DataView dtv;
        public InstructorPrincipal()
        {
            InitializeComponent();
        }

        private void InstructorPrincipal_Load(object sender, EventArgs e)
        {
            CargarDatos("");
        }

        private void CargarDatos(String strFiltro)
        {

            // Construimos  el objeto Dataview dtv  en base al DataTable devuelto por el metodo ListarProducto
            // Y lo filtramos de acuerdo al parametro strFiltro
            dtv = new DataView(objInstructorBL.ListarInstructor());
            dtv.RowFilter = "apellido like '%" + strFiltro + "%'";
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
                InstructorAgregar objInstructorAgregar = new InstructorAgregar();
                objInstructorAgregar.ShowDialog();

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


                    InstructorActualizar objInstructorActualizar = new InstructorActualizar();
                    objInstructorActualizar.Id = datoInt;
                    objInstructorActualizar.ShowDialog();

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
                    if (objInstructorBL.EliminarInstructor(id) == true)
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
