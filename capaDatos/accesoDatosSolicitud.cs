using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using capaEntidades;


namespace capaDatos
{
    public class accesoDatosSolicitud
    {
        SqlConnection cnx;
        Solicitud s = new Solicitud();
        Conexion cn = new Conexion();
        SqlCommand sl = null;
        int indicador = 0;
        SqlDataReader dr = null;
        List<Solicitud> listaSolicitud = null;
      

      

        
        public int insertarSolicitud(Solicitud s)
        {

            try
            {

                cnx = cn.conectar();
                
                sl = new SqlCommand("pr_solicitud", cnx);
                sl.Parameters.AddWithValue("@b", 1);
                sl.Parameters.AddWithValue("@idsolicitud", "");
                sl.Parameters.AddWithValue("@aula", s.aula);
                sl.Parameters.AddWithValue("@nivel", s.nivel);
                sl.Parameters.AddWithValue("@fechasolicitud", s.fechasolicitud);
                sl.Parameters.AddWithValue("@fechauso", s.fechauso);
                sl.Parameters.AddWithValue("@horainicio", s.horainicio);
                sl.Parameters.AddWithValue("@horafinal", s.horafin);
                sl.Parameters.AddWithValue("@carrera", s.carrera);
                sl.Parameters.AddWithValue("@asignatura", s.asignatura);
                sl.Parameters.AddWithValue("@idrecursos", s.id_recursos);
                sl.Parameters.AddWithValue("@idusuario", s.id_usuario);

                


                sl.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                sl.ExecuteNonQuery();
                indicador = 1;

            }
            catch (Exception e)
            {
                e.Message.ToString();
                indicador = 0;
            }
            finally
            {
                sl.Connection.Close();
            }

            return indicador;


        }

        public int eliminarSolicitud(int idsolicitud)
        {


            try
            {
                cnx = cn.conectar();
                sl = new SqlCommand("pr_solicitud", cnx);
                sl.Parameters.AddWithValue("@b", 2);
                sl.Parameters.AddWithValue("@idsolicitud", idsolicitud);
                sl.Parameters.AddWithValue("@aula", "");
                sl.Parameters.AddWithValue("@nivel", "");
                sl.Parameters.AddWithValue("@fechasolicitud","");
                sl.Parameters.AddWithValue("@fechauso", "");
                sl.Parameters.AddWithValue("@horainicio", "");
                sl.Parameters.AddWithValue("@horafinal", "");
                sl.Parameters.AddWithValue("@carrera", "");
                sl.Parameters.AddWithValue("@asignatura", "");
                sl.Parameters.AddWithValue("@idrecursos", "");
                sl.Parameters.AddWithValue("@idusuario", "");



                sl.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                sl.ExecuteNonQuery();
                indicador = 1;

            }
            catch (Exception e)
            {
                e.Message.ToString();
                indicador = 0;
            }

            finally
            {
                sl.Connection.Close();
            }

            return indicador;
        }

        public List<Solicitud> listarSolicitud()
        {
            try
            {
                cnx = cn.conectar();
                sl = new SqlCommand("pr_solicitud", cnx);
                sl.Parameters.AddWithValue("@b", 3);
                sl.Parameters.AddWithValue("@idsolicitud","");
                sl.Parameters.AddWithValue("@aula", "");
                sl.Parameters.AddWithValue("@nivel", "");
                sl.Parameters.AddWithValue("@fechasolicitud", "");
                sl.Parameters.AddWithValue("@fechauso", "");
                sl.Parameters.AddWithValue("@horainicio", "");
                sl.Parameters.AddWithValue("@horafinal", "");
                sl.Parameters.AddWithValue("@carrera", "");
                sl.Parameters.AddWithValue("@asignatura", "");
                sl.Parameters.AddWithValue("@idrecursos", "");
                sl.Parameters.AddWithValue("@idusuario", "");

                sl.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = sl.ExecuteReader();
                listaSolicitud = new List<Solicitud>();

                while (dr.Read())
                {
                    Solicitud so = new Solicitud();
                    so.id_solicitud= Convert.ToInt32(dr["slt_Id"].ToString());
                    so.aula = dr["slt_Aula"].ToString();
                    so.nivel = dr["slt_Nivel"].ToString();
                    so.fechasolicitud = Convert.ToDateTime(dr["slt_FechaSolicitud"].ToString());
                    so.fechauso = Convert.ToDateTime(dr["slt_FechaUso"].ToString());
                    so.horainicio = Convert.ToDateTime(dr["slt_HoraInicio"].ToString());
                    so.horafin = Convert.ToDateTime(dr["slt_HoraFin"].ToString());
                    so.carrera = dr["slt_Carrera"].ToString();
                    so.asignatura = dr["slt_Asignatura"].ToString();
                    so.id_recursos = Convert.ToInt32(dr["rcs_Id"].ToString());
                    so.id_usuario = Convert.ToInt32(dr["usr_Id"].ToString());

                    listaSolicitud.Add(so);
                }

            }
            catch (Exception e)
            {
                e.Message.ToString();
                listaSolicitud = null;
            }

            finally
            {
                sl.Connection.Close();

            }

            return listaSolicitud;
        }

        public int editarSolicitud(Solicitud s)
        {
            try
            {

                cnx = cn.conectar();
                sl = new SqlCommand("pr_solicitud", cnx);
                sl.Parameters.AddWithValue("@b", 4);
                sl.Parameters.AddWithValue("@idsolicitud",s.id_solicitud);
                sl.Parameters.AddWithValue("@aula", s.aula);
                sl.Parameters.AddWithValue("@nivel", s.nivel);
                sl.Parameters.AddWithValue("@fechasolicitud", s.fechasolicitud);
                sl.Parameters.AddWithValue("@fechauso", s.fechauso);
                sl.Parameters.AddWithValue("@horainicio", s.horainicio);
                sl.Parameters.AddWithValue("@horafinal", s.horafin);
                sl.Parameters.AddWithValue("@carrera", s.carrera);
                sl.Parameters.AddWithValue("@asignatura", s.asignatura);
                sl.Parameters.AddWithValue("@idrecursos", s.id_recursos);
                sl.Parameters.AddWithValue("@idusuario", s.id_usuario);



                sl.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                sl.ExecuteNonQuery();
                indicador = 1;


            }
            catch (Exception e)
            {
                e.Message.ToString();
                indicador = 0;


            }
            finally
            {
                sl.Connection.Close();
            }
            return indicador;
        }

        public List<Solicitud> buscarSolicitud(int dato)
        {
            try
            {
                cnx = cn.conectar();
                sl = new SqlCommand("pr_solicitud", cnx);
                sl.Parameters.AddWithValue("@b", 5);
                sl.Parameters.AddWithValue("@idsolicitud", "");
                sl.Parameters.AddWithValue("@aula", "");
                sl.Parameters.AddWithValue("@nivel", "");
                sl.Parameters.AddWithValue("@fechasolicitud", "");
                sl.Parameters.AddWithValue("@fechauso", "");
                sl.Parameters.AddWithValue("@horainicio", "");
                sl.Parameters.AddWithValue("@horafinal", "");
                sl.Parameters.AddWithValue("@carrera", "");
                sl.Parameters.AddWithValue("@asignatura", "");
                sl.Parameters.AddWithValue("@idrecursos", "");
                sl.Parameters.AddWithValue( "@idusuario", dato);

                sl.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = sl.ExecuteReader();
                listaSolicitud = new List<Solicitud>();

                while (dr.Read())
                {
                    
                    s.id_solicitud = Convert.ToInt32(dr["slt_Id"].ToString());
                    s.aula = dr["slt_Aula"].ToString();
                    s.nivel = dr["slt_Nivel"].ToString();
                    s.fechasolicitud = Convert.ToDateTime(dr["slt_FechaSolicitud"].ToString());
                    s.fechauso = Convert.ToDateTime(dr["slt_FechaUso"].ToString());
                    s.horainicio = Convert.ToDateTime(dr["slt_HoraInicio"].ToString());
                    s.horafin = Convert.ToDateTime(dr["slt_HoraFin"].ToString());
                    s.carrera = dr["slt_Carrera"].ToString();
                    s.asignatura = dr["slt_Asignatura"].ToString();
                    s.id_recursos = Convert.ToInt32(dr["rcs_Id"].ToString());
                    s.id_usuario = Convert.ToInt32(dr["usr_Id"].ToString());

                    listaSolicitud.Add(s);

                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                listaSolicitud = null;

            }
            finally
            {
                sl.Connection.Close();

            }

            return listaSolicitud;
        }
    }
}
