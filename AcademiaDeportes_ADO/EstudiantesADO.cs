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
    public class EstudiantesADO
    {
        // Instancias.....
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;

        public DataTable ListarEstudiante()
        {
            try 
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_ListarEstudiantes";
                cmd.Parameters.Clear();

                DataSet dts = new DataSet();
                SqlDataAdapter ada = new SqlDataAdapter(cmd);

                ada.Fill(dts, "Estudiantes");
                return dts.Tables["Estudiantes"];
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public EstudianteBE ConsultarEstudiante(Int16 id)
        {
            try 
            { 
                EstudianteBE objEstudianteBE = new EstudianteBE();
                
                cnx.ConnectionString= MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_ConsultarEstudiante";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);

                cnx.Open();
                dtr = cmd.ExecuteReader();

                if (dtr.HasRows == true)
                {
                    dtr.Read();
                    objEstudianteBE.id = Convert.ToInt16(dtr["id"]);
                    objEstudianteBE.nombre = dtr["nombre"].ToString();
                    objEstudianteBE.apellido = dtr["apellido"].ToString();
                    objEstudianteBE.fecha_nacimiento = Convert.ToDateTime(dtr["fecha_nacimiento"]);
                    objEstudianteBE.dni = dtr["dni"].ToString();
                    objEstudianteBE.estado = Convert.ToBoolean(dtr["estado"]);
                    objEstudianteBE.telefono = dtr["telefono"].ToString();
                    objEstudianteBE.email = dtr["email"].ToString();
                    objEstudianteBE.sexo = dtr["sexo"].ToString();
                    objEstudianteBE.direccion = dtr["direccion"].ToString();
                    objEstudianteBE.id_ubigeo = Convert.ToInt16(dtr["id_ubigeo"]);
                }
                else 
                {
                    objEstudianteBE.id = 0;
                }
                dtr.Close();
                return objEstudianteBE;
                
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

        public Boolean InsertarEstudiante(EstudianteBE objEstudianteBE) 
        {
            try
            {
                //Codifique
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_InsertarEstudiante";
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@nombre", objEstudianteBE.nombre);
                cmd.Parameters.AddWithValue("@apellido", objEstudianteBE.apellido);
                cmd.Parameters.AddWithValue("@fecha_nacimiento", objEstudianteBE.fecha_nacimiento);
                cmd.Parameters.AddWithValue("@dni", objEstudianteBE.dni);
                cmd.Parameters.AddWithValue("@estado", objEstudianteBE.estado);
                cmd.Parameters.AddWithValue("@telefono", objEstudianteBE.telefono);
                cmd.Parameters.AddWithValue("@email", objEstudianteBE.email);
                cmd.Parameters.AddWithValue("@sexo", objEstudianteBE.sexo);
                cmd.Parameters.AddWithValue("@direccion", objEstudianteBE.direccion);
                cmd.Parameters.AddWithValue("@id_ubigeo", objEstudianteBE.id_ubigeo);
                cnx.Open();
                cmd.ExecuteNonQuery();
                return true;

            }
            catch (SqlException x)
            {
                throw new Exception(x.Message);
                return false;
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }

            }
        }


        public Boolean ActualizarEstudiante(EstudianteBE objEstudianteBE) 
        {
            try
            {
                //Codifique
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_ActualizarEstudiante";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", objEstudianteBE.id);
                cmd.Parameters.AddWithValue("@nombre", objEstudianteBE.nombre);
                cmd.Parameters.AddWithValue("@apellido", objEstudianteBE.apellido);
                cmd.Parameters.AddWithValue("@fecha_nacimiento", objEstudianteBE.fecha_nacimiento);
                cmd.Parameters.AddWithValue("@dni", objEstudianteBE.dni);
                cmd.Parameters.AddWithValue("@estado", objEstudianteBE.estado);
                cmd.Parameters.AddWithValue("@telefono", objEstudianteBE.telefono);
                cmd.Parameters.AddWithValue("@email", objEstudianteBE.email);
                cmd.Parameters.AddWithValue("@sexo", objEstudianteBE.sexo);
                cmd.Parameters.AddWithValue("@direccion", objEstudianteBE.direccion);
                cmd.Parameters.AddWithValue("@id_ubigeo", objEstudianteBE.id_ubigeo);
                cnx.Open();
                cmd.ExecuteNonQuery();
                return true;

            }
            catch (SqlException x)
            {
                throw new Exception(x.Message);
                return false;
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }

            }
        }
        public Boolean EliminarEstudiante(Int16 id) 
        {
            try
            {
                //Codifique
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_EliminarEstudiante";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);

                cnx.Open();
                cmd.ExecuteNonQuery();
                return true;

            }
            catch (SqlException x)
            {
                throw new Exception(x.Message);
                return false;
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
