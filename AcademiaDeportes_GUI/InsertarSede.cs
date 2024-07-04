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
    public partial class InsertarSede : Form
    {

        SedesBL objSedesBL = new SedesBL();
        SedesBE objSedesBE = new SedesBE();
        UbigeoBL ubigeoBL = new UbigeoBL();


        public InsertarSede()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            
            objSedesBE.nombre = txtNombre.Text.Trim();
            objSedesBE.director = txtDirector.Text.Trim();
            objSedesBE.direccion = txtDireccion.Text.Trim();
            objSedesBE.capacidad = Convert.ToInt16(numCapacidad.Value);
            objSedesBE.id_ubigeo = Convert.ToInt16(cboUbigeo.SelectedValue);

            if (objSedesBL.InsertarSede(objSedesBE) == true)
            {
                this.Close();
            }
            else
            {
                throw new Exception("No se inserto el registro, contactar con soporte");

            }

        }

        private void InsertarSede_Load(object sender, EventArgs e)
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
    }
}
