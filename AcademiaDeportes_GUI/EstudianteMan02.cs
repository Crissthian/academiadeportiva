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
    public partial class EstudianteMan02 : Form


    {
        EstudianteBL objEstudianteBL = new EstudianteBL();
        EstudianteBE objEstudianteBE = new EstudianteBE();
        UbigeoBL ubigeoBL = new UbigeoBL();


        public EstudianteMan02()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
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
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void btnGrabar_Click(object sender, EventArgs e)
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

            if (objEstudianteBL.InsertarEstudiante(objEstudianteBE) == true)
            {
                this.Close();
            }
            else
            {
                throw new Exception("No se inserto el registro, contactarse con TI.");

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

        private void telefonoInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
