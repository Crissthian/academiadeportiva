using AcademiaDeportes_BE;
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
    public partial class EstudianteMan03 : Form
    {
        EstudianteBL objEstudianteBL = new EstudianteBL();
        EstudianteBE objEstudianteBE = new EstudianteBE();
        UbigeoBL ubigeoBL = new UbigeoBL();


        public EstudianteMan03()
        {
            InitializeComponent();
        }

        public Int16 Id { get; set; }

        private void EstudianteMan03_Load(object sender, EventArgs e)
        {
            try
            {

                DataTable dt = ubigeoBL.ListarUbigeo();
                DataRow dr;//para agrregar la fila --seleccione--


                dt = ubigeoBL.ListarUbigeo();//Creo una nueva fila
                dr = dt.NewRow();
                dr["id_ubigeo"] = 0;
                dr["distrito"] = "--Seleccione--";
                dt.Rows.InsertAt(dr, 0);//Inserto como primera fila de la tabla categorias
                cboUbigeo.DataSource = dt;
                cboUbigeo.ValueMember = "id_ubigeo";
                cboUbigeo.DisplayMember = "distrito";



                objEstudianteBE = objEstudianteBL.ConsultarEstudiante(this.Id);

                labelID.Text = objEstudianteBE.id.ToString();
                nombreInput.Text = objEstudianteBE.nombre.ToString();
                apellidoInput.Text = objEstudianteBE.apellido.ToString();
                fechaNacimientoInput.Value = objEstudianteBE.fecha_nacimiento;
                dniInput.Text = objEstudianteBE.dni.ToString();
                estadoInput.Checked = Convert.ToBoolean(objEstudianteBE.estado);
                telefonoInput.Text = objEstudianteBE.telefono.ToString();
                emailInput.Text = objEstudianteBE.email.ToString();
                if (objEstudianteBE.sexo == "M")
                {
                    hombre.Checked = true;
                }
                else
                {
                    mujer.Checked = true;
                }
                direccionInput.Text = objEstudianteBE.direccion.ToString();
                cboUbigeo.SelectedValue = Convert.ToUInt16(objEstudianteBE.id_ubigeo);


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
                objEstudianteBE.nombre = nombreInput.Text.Trim();
                objEstudianteBE.apellido = apellidoInput.Text.Trim();
                objEstudianteBE.fecha_nacimiento = fechaNacimientoInput.Value;
                objEstudianteBE.dni = dniInput.Text.Trim();
                objEstudianteBE.estado = estadoInput.Checked;
                objEstudianteBE.telefono = telefonoInput.Text.Trim();
                objEstudianteBE.email = emailInput.Text.Trim();
                if (hombre.Checked == true)
                {
                    objEstudianteBE.sexo = "M";
                }
                else if (mujer.Checked == true)
                {
                    objEstudianteBE.sexo = "F";
                }
                else
                {
                    throw new Exception("Debe seleccionar un sexo");
                }
                objEstudianteBE.direccion = direccionInput.Text.Trim();
                objEstudianteBE.id_ubigeo = Convert.ToInt16(cboUbigeo.SelectedValue);

                if (objEstudianteBL.ActualizarEstudiante(objEstudianteBE) == true)
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

        private void dniInput_TextChanged(object sender, EventArgs e)
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
