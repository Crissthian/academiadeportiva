using AcademiaDeportes_BE;
using AcademiaDeportes_BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademiaDeportes_GUI
{
    public partial class InstructorActualizar : Form
    {
        InstructorBL objInstructorBL = new InstructorBL();
        InstructorBE objInstructorBE = new InstructorBE();
        UbigeoBL ubigeoBL = new UbigeoBL();
        public InstructorActualizar()
        {
            InitializeComponent();
        }

        public Int16 Id { get; set; }

        private void InstructorActualizar_Load(object sender, EventArgs e)
        {
            try
            {

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






                objInstructorBE = objInstructorBL.ConsultarInstructor(this.Id);

                cboUbigeo.SelectedValue = Convert.ToUInt16(objInstructorBE.id_ubigeo);
                cboEspecialidad.SelectedValue = Convert.ToInt16(objInstructorBE.id);

                labelID.Text = objInstructorBE.id.ToString();
                nombreInput.Text = objInstructorBE.nombre.ToString();
                apellidoInput.Text = objInstructorBE.apellido.ToString();
                fechaNacimientoInput.Value = objInstructorBE.fecha_nacimiento;
                dniInput.Text = objInstructorBE.DNI.ToString();
                telefonoInput.Text = objInstructorBE.teléfono.ToString();
                emailInput.Text = objInstructorBE.correo.ToString();
                direccionInput.Text = objInstructorBE.direccion.ToString();
                fechaIngresoInput.Value = objInstructorBE.fecha_ingreso;



            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message + ex);
            }
        }
        private void btnGrabar_Click(object sender, EventArgs e)
        {

            try
            {
                objInstructorBE.nombre = nombreInput.Text.Trim();
                objInstructorBE.apellido = apellidoInput.Text.Trim();
                objInstructorBE.fecha_nacimiento = fechaNacimientoInput.Value;
                objInstructorBE.DNI = dniInput.Text.Trim();
                objInstructorBE.teléfono = telefonoInput.Text.Trim();
                objInstructorBE.especialidad = cboEspecialidad.Text.Trim();
                objInstructorBE.correo = emailInput.Text.Trim();
                objInstructorBE.direccion = direccionInput.Text.Trim();
                objInstructorBE.fecha_ingreso = fechaIngresoInput.Value;
                objInstructorBE.id_ubigeo = Convert.ToInt16(cboUbigeo.SelectedValue);

                if (objInstructorBL.ActualizarInstructor(objInstructorBE) == true)
                {
                    this.Close();
                }
                else
                {
                    throw new Exception("No se actualizó el registro, contactarse con TI");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dniInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void telefonoInput_TextChanged(object sender, EventArgs e)
        {

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
