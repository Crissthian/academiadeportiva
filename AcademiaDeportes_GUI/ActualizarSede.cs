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
    public partial class ActualizarSede : Form
    {
        SedesBE objSedesBE = new SedesBE();
        SedesBL objSedesBL = new SedesBL();
        UbigeoBL ubigeoBL = new UbigeoBL();
        public ActualizarSede()
        {
            InitializeComponent();
        }
        public Int16 Id { get; set; }

        private void ActualizarSede_Load(object sender, EventArgs e)
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


               

                objSedesBE = objSedesBL.consultarSede(this.Id);

               
                lblCodigo.Text = objSedesBE.id.ToString();
                txtUpdNombre.Text = objSedesBE.nombre.ToString();
                txtUpdDirector.Text= objSedesBE.director.ToString();
                txtUpdDireccion.Text = objSedesBE.direccion.ToString();
                updCapacidad.Value = Convert.ToInt16(objSedesBE.capacidad);
                cboUbigeo.SelectedValue = Convert.ToInt16(objSedesBE.id_ubigeo);



            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message + ex);
            }

        }




        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                objSedesBE.nombre = txtUpdNombre.Text.Trim();
                objSedesBE.director= txtUpdDirector.Text.Trim();
                objSedesBE.direccion = txtUpdDireccion.Text.Trim();
                objSedesBE.capacidad = Convert.ToInt16(updCapacidad.Value);
                objSedesBE.id_ubigeo= Convert.ToInt16(cboUbigeo.SelectedValue);

                if(objSedesBL.ActualizarSede(objSedesBE) == true)
                {
                    this.Close();

                }
                else
                {
                    throw new Exception("No se actualizó el registro, contactar con soporte");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        
        }
    }
}
