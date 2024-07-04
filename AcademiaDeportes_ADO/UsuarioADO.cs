using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using AcademiaDeportes_BE;


namespace AcademiaDeportes_ADO
{
    public class UsuarioADO
    {
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;
        
        public UsuarioBE ConsultarUsuario(String strLogin)
        {
            UsuarioBE objUsuarioBE = new UsuarioBE();
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_ConsultarUsuario";
            // Agregamos el parametro...
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@login_Usuario", strLogin);
            try
            {
                cnx.Open();
                dtr = cmd.ExecuteReader();
                if (dtr.HasRows == true)
                {
                    dtr.Read();
                    objUsuarioBE.id_usuario = Convert.ToInt16(dtr["id_usuario"]);
                    objUsuarioBE.login_usuario  = dtr["login_usuario"].ToString();
                    objUsuarioBE.password_usuario  = dtr["password_usuario"].ToString();
                    objUsuarioBE.nivel_usuario = Convert.ToInt16 (dtr["nivel_usuario"]);
                    objUsuarioBE.fecha_registro  = Convert.ToDateTime(dtr["fecha_registro"]);
                    objUsuarioBE.usu_registro  = dtr["usu_registro"].ToString ();
                    objUsuarioBE.estado_usuario = Convert.ToBoolean(dtr["estado_usuario"]);
                }
                dtr.Close();
                return objUsuarioBE;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }

            }

        }
    }
}
