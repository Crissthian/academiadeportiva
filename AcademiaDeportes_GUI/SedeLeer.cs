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
    public partial class SedeLeer : Form
    {
        SedesBL objSedesBL = new SedesBL();
        DataView dtv;


        public SedeLeer()
        {
            InitializeComponent();
        }

        private void SedeLeer_Load(object sender, EventArgs e)
        {
            cargarDatosSedes("");
        }

        public void cargarDatosSedes(String filtro)
        {
            dtv = new DataView(objSedesBL.ListarSedes());
            dtv.RowFilter = "nombre like '%" + filtro + "%'";
            dtgSedes.DataSource = dtv;
            lblTotalSedes.Text = dtgSedes.Rows.Count.ToString();
        }

        private void txtFiltroSede_TextChanged(object sender, EventArgs e)
        {
            try
            {
                cargarDatosSedes(txtFiltroSede.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void btnAgregarSede_Click(object sender, EventArgs e)
        {
            try
            {
                InsertarSede objInsertarSede = new InsertarSede();
                objInsertarSede.ShowDialog();

                cargarDatosSedes(txtFiltroSede.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizarSede_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgSedes.CurrentRow.Cells[0].Value != DBNull.Value)
                {
                    String dato = dtgSedes.CurrentRow.Cells[0].Value.ToString();
                    Int16 datoInt = Convert.ToInt16(dato);

                    ActualizarSede actualizarSede = new ActualizarSede();
                    actualizarSede.Id = datoInt;
                    actualizarSede.ShowDialog();
                    cargarDatosSedes(txtFiltroSede.Text.Trim());
                }
                else
                {
                    MessageBox.Show("Seleccione una celda");

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);

            }
        }

        private void btnEliminarSede_Click(object sender, EventArgs e)
        {
            try
            {
                Int16 id = Convert.ToInt16(dtgSedes.CurrentRow.Cells[0].Value);
                DialogResult respuesta = MessageBox.Show("¿Esta seguro que desea eliminar la Sede?", "Confirmar",
                      MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    if (objSedesBL.EliminarSede(id) == true)
                    {
                        cargarDatosSedes(txtFiltroSede.Text);
                    }
                    else
                    {
                        throw new Exception("No se puede eliminar la sede consultar a soporte");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }
    }
}
