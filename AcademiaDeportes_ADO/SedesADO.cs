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
    public class SedesADO
    {
        //Conexiones
        ConexionADO MiConexion =  new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;

        public DataTable ListarSedes()
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_ListarSedes";
                cmd.Parameters.Clear();

                DataSet dts = new DataSet();
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "Sedes");
                return dts.Tables["Sedes"];

            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public SedesBE consultarSede(Int16 id )
        {
            try
            {
                SedesBE objSedesBE = new SedesBE();

                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_ConsultarSede";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);

                cnx.Open();
                dtr = cmd.ExecuteReader();

                if(dtr.HasRows == true)
                {
                    dtr.Read();
                    objSedesBE.id = Convert.ToInt16(dtr["id"]);
                    objSedesBE.nombre = dtr["nombre"].ToString();
                    objSedesBE.capacidad = Convert.ToInt16(dtr["capacidad"]);
                    objSedesBE.director = dtr["director"].ToString();
                    objSedesBE.id_ubigeo = Convert.ToInt16(dtr["id_ubigeo"]);
                    objSedesBE.direccion = dtr["direccion"].ToString();

                }
                else
                {
                    objSedesBE.id = 0;
                }
                dtr.Close();
                return objSedesBE;

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


        public Boolean InsertarSede(SedesBE objSedesBE)
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_InsertarSede";
                cmd.Parameters.Clear();


                
                cmd.Parameters.AddWithValue("@nombre", objSedesBE.nombre);
                cmd.Parameters.AddWithValue("@capacidad", objSedesBE.capacidad);
                cmd.Parameters.AddWithValue("@director", objSedesBE.director);
                cmd.Parameters.AddWithValue("@id_ubigeo", objSedesBE.id_ubigeo);
                cmd.Parameters.AddWithValue("@direccion", objSedesBE.direccion);
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


        public Boolean ActualizarSede(SedesBE objSedesBE)
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_ActualizarSede";
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@id", objSedesBE.id);
                cmd.Parameters.AddWithValue("@nombre", objSedesBE.nombre);
                cmd.Parameters.AddWithValue("@capacidad", objSedesBE.capacidad);
                cmd.Parameters.AddWithValue("@director", objSedesBE.director);
                cmd.Parameters.AddWithValue("@id_ubigeo", objSedesBE.id_ubigeo);
                cmd.Parameters.AddWithValue("@direccion", objSedesBE.direccion);

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


        public Boolean EliminarSede(Int16 id)
        {
            try
            {
                //Codifique
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_EliminarSede";
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


    } // ANTEPENULTIMO

} //FIN DE TODO
