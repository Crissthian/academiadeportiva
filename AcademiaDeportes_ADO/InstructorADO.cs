using AcademiaDeportes_BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaDeportes_ADO
{
    public class InstructorADO
    {
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;

        

        public InstructorBE ConsultarInstructor(Int16 id)
        {
            try
            {
                InstructorBE objInstructorBE = new InstructorBE();

                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_ConsultarInstructor";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);

                cnx.Open();
                dtr = cmd.ExecuteReader();

                if (dtr.HasRows == true)
                {
                    dtr.Read();
                    objInstructorBE.id = Convert.ToInt16(dtr["id"]);
                    objInstructorBE.nombre = dtr["nombre"].ToString();
                    objInstructorBE.apellido = dtr["apellido"].ToString();
                    objInstructorBE.especialidad = dtr["especialidad"].ToString();
                    objInstructorBE.DNI = dtr["dni"].ToString();
                    objInstructorBE.id_ubigeo = Convert.ToInt16(dtr["id_ubigeo"]);
                    objInstructorBE.direccion = dtr["direccion"].ToString();
                    objInstructorBE.teléfono = dtr["teléfono"].ToString();
                    objInstructorBE.correo = dtr["correo"].ToString();
                    objInstructorBE.fecha_nacimiento = Convert.ToDateTime(dtr["fecha_nacimiento"]);
                    objInstructorBE.fecha_ingreso = Convert.ToDateTime(dtr["fecha_ingreso"]);

                }
                else
                {
                    objInstructorBE.id = 0;
                }
                dtr.Close();
                return objInstructorBE;

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


        public Boolean InsertarInstructor(InstructorBE objInstructorBE)
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_InsertarInstructor";
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@nombre", objInstructorBE.nombre);
                cmd.Parameters.AddWithValue("@apellido", objInstructorBE.apellido);
                cmd.Parameters.AddWithValue("@especialidad", objInstructorBE.especialidad);
                cmd.Parameters.AddWithValue("@dni", objInstructorBE.DNI);
                cmd.Parameters.AddWithValue("@id_ubigeo", objInstructorBE.id_ubigeo);
                cmd.Parameters.AddWithValue("@direccion", objInstructorBE.direccion);
                cmd.Parameters.AddWithValue("@telefono", objInstructorBE.teléfono);
                cmd.Parameters.AddWithValue("@correo", objInstructorBE.correo);
                cmd.Parameters.AddWithValue("@fecha_nacimiento", objInstructorBE.fecha_nacimiento);
                cmd.Parameters.AddWithValue("@fecha_ingreso", objInstructorBE.fecha_ingreso);

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

        public DataTable ListarInstructor()
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_ListarInstructores";
                cmd.Parameters.Clear();

                DataSet dts = new DataSet();
                SqlDataAdapter ada = new SqlDataAdapter(cmd);

                ada.Fill(dts, "Instructores");
                return dts.Tables["Instructores"];
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool ActualizarInstructor(InstructorBE objInstructorBE)
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_ActualizarInstructor";
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@id", objInstructorBE.id);
                cmd.Parameters.AddWithValue("@nombre", objInstructorBE.nombre);
                cmd.Parameters.AddWithValue("@apellido", objInstructorBE.apellido);
                cmd.Parameters.AddWithValue("@especialidad", objInstructorBE.especialidad);
                cmd.Parameters.AddWithValue("@dni", objInstructorBE.DNI);
                cmd.Parameters.AddWithValue("@id_ubigeo", objInstructorBE.id_ubigeo);
                cmd.Parameters.AddWithValue("@direccion", objInstructorBE.direccion);
                cmd.Parameters.AddWithValue("@telefono", objInstructorBE.teléfono);
                cmd.Parameters.AddWithValue("@correo", objInstructorBE.correo);
                cmd.Parameters.AddWithValue("@fecha_nacimiento", objInstructorBE.fecha_nacimiento);
                cmd.Parameters.AddWithValue("@fecha_ingreso", objInstructorBE.fecha_ingreso);

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

        public bool EliminarInstructor(Int16 id)
        {
            try
            {
                //Codifique
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_EliminarInstructor";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idInstructor", id);

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
