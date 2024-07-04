using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AcademiaDeportes_ADO;
using AcademiaDeportes_BE;
using AcademiaDeportes_BL;

namespace AcademiaDeportes_GUI
{
    public partial class InstructorAgregar : Form
    {
        // Instancias...
        InstructorBL objInstructorBL = new InstructorBL();
        InstructorBE objInstructorBE = new InstructorBE();
        UbigeoBL ubigeoBL = new UbigeoBL();


        public InstructorAgregar()
        {
            InitializeComponent();
        }

        private void InstructorAgregar_Load(object sender, EventArgs e)
        {
            try
            {
                // Codifique
                // Cargamos los combos...
                DataTable dt = objInstructorBL.ListarInstructor();
                DataRow dr;//para agrregar la fila --seleccione--

                dr = dt.NewRow();//Creo una nueva fila
                dr["id"] = 0;
                dr["especialidad"] = "--Seleccione--";
                dt.Rows.InsertAt(dr, 0);//Inserto como primera fila de la tabla categorias
                cboEspecialidad.DataSource = dt;
                cboEspecialidad.ValueMember = "id";
                cboEspecialidad.DisplayMember = "especialidad";



                dt = ubigeoBL.ListarUbigeo();//Creo una nueva fila
                dr = dt.NewRow();
                dr["id_ubigeo"] = 0;
                dr["distrito"] = "--Seleccione--";
                dt.Rows.InsertAt(dr, 0);//Inserto como primera fila de la tabla categorias
                cboUbigeo.DataSource = dt;
                cboUbigeo.ValueMember = "id_ubigeo";
                cboUbigeo.DisplayMember = "distrito";



            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {

            objInstructorBE.nombre = nombreInput.Text.Trim();
            objInstructorBE.apellido = apellidoInput.Text.Trim();
            objInstructorBE.especialidad = cboEspecialidad.Text.Trim();
            objInstructorBE.DNI = dniInput.Text.Trim();
            objInstructorBE.id_ubigeo = Convert.ToInt16(cboUbigeo.SelectedValue);
            objInstructorBE.direccion = direccionInput.Text.Trim();
            objInstructorBE.teléfono = telefonoInput.Text.Trim();
            objInstructorBE.correo = emailInput.Text.Trim();
            objInstructorBE.fecha_nacimiento = fechaNacimientoInput.Value;
            objInstructorBE.fecha_ingreso = fechaIngresoInput.Value;

            try
            {
                if (nombreInput.Text.Trim() == "" && apellidoInput.Text.Trim() == "" && dniInput.Text.Trim() == "" && cboEspecialidad.Text.Trim() == "")
                {
                    throw new Exception("Faltan algunos datos obligatorios.");
                }

                // Invocamos al metodo Insertar
                if (objInstructorBL.InsertarInstructor(objInstructorBE) == true)
                {
                    this.Close();
                }
                else
                {
                    throw new Exception("No se inserto el registro, contactarse con TI.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message + ex);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dniInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void telefonoInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}

