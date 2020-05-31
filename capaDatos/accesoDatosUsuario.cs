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
    public class accesoDatosUsuario
    {
        SqlConnection cnx;
        Usuarios u = new Usuarios();
        Conexion cn = new Conexion();
        SqlCommand us = null;
        int indicador = 0;
        SqlDataReader dr = null;
        List<Usuarios> listaUsuario = null;

        public int insertarUsuario(Usuarios u)
        {

            try
            {

                cnx = cn.conectar();
                us = new SqlCommand("usuario", cnx);
                us.Parameters.AddWithValue("@b", 1);
                us.Parameters.AddWithValue("@id_usuario", "");
                us.Parameters.AddWithValue("@cedula", u.cedula);
                us.Parameters.AddWithValue("@nombres", u.nombres);
                us.Parameters.AddWithValue("@apellidos", u.apellidos);
                us.Parameters.AddWithValue("@email", u.email);
      


                us.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                us.ExecuteNonQuery();
                indicador = 1;

            }
            catch (Exception e)
            {
                e.Message.ToString();
                indicador = 0;
            }
            finally
            {
                us.Connection.Close();
            }

            return indicador;


        }

        public int eliminarUsuario(int idrecurso)
        {


            try
            {
                cnx = cn.conectar();
                us = new SqlCommand("usuario", cnx);
                us.Parameters.AddWithValue("@b", 2);
                us.Parameters.AddWithValue("@id_usuario", u.id_usuario);
                us.Parameters.AddWithValue("@cedula", "");
                us.Parameters.AddWithValue("@nombres", "");
                us.Parameters.AddWithValue("@apellidos", "");
                us.Parameters.AddWithValue("@email","");



                us.CommandType = CommandType.StoredProcedure;
                cnx.Open();
               us.ExecuteNonQuery();
                indicador = 1;

            }
            catch (Exception e)
            {
                e.Message.ToString();
                indicador = 0;
            }

            finally
            {
                us.Connection.Close();
            }

            return indicador;
        }

        public List<Usuarios> listarUsuarios()
        {
            try
            {
                cnx = cn.conectar();
                us = new SqlCommand("usuarios", cnx);
                us.Parameters.AddWithValue("@b", 3);
                us.Parameters.AddWithValue("@idusuario","");
                us.Parameters.AddWithValue("@cedula", "");
                us.Parameters.AddWithValue("@nombres", "");
                us.Parameters.AddWithValue("@apellidos", "");
                us.Parameters.AddWithValue("@email", "");
                us.Parameters.AddWithValue("@telefono", "");

                us.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = us.ExecuteReader();
                listaUsuario = new List<Usuarios>();

                while (dr.Read())
                {
                    Usuarios us = new Usuarios();
                    us.id_usuario = Convert.ToInt32(dr["usr_Id"].ToString());
                    us.cedula = dr["usr_Cedula"].ToString();
                    us.nombres = dr["usr_Nombres"].ToString();
                    us.apellidos = dr["usr_Apellidos"].ToString();
                    us.email = dr["usr_Email"].ToString();
                    us.telefono = dr["usr_Telefono"].ToString();

                    listaUsuario.Add(us);
                }

            }
            catch (Exception e)
            {
                e.Message.ToString();
                listaUsuario = null;
            }

            finally
            {
                us.Connection.Close();

            }

            return listaUsuario;
        }

        public int editarUsuario(Usuarios u)
        {
            try
            {

                cnx = cn.conectar();
                us = new SqlCommand("solicitud", cnx);
                us.Parameters.AddWithValue("@b", 4);
                us.Parameters.AddWithValue("@id_usuario", "");
                us.Parameters.AddWithValue("@cedula", "");
                us.Parameters.AddWithValue("@nombres", "");
                us.Parameters.AddWithValue("@apellidos", "");
                us.Parameters.AddWithValue("@email", "");


                us.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                us.ExecuteNonQuery();
                indicador = 1;


            }
            catch (Exception e)
            {
                e.Message.ToString();
                indicador = 0;


            }
            finally
            {
                us.Connection.Close();
            }
            return indicador;
        }

        public List<Usuarios> buscarSolicitud(string dato)
        {
            try
            {
                cnx = cn.conectar();
                us = new SqlCommand("usuario", cnx);
                us.Parameters.AddWithValue("@b", 5);
                us.Parameters.AddWithValue("@id_usuario", "");
                us.Parameters.AddWithValue("@cedula", dato);
                us.Parameters.AddWithValue("@nombres", "");
                us.Parameters.AddWithValue("@apellidos", "");
                us.Parameters.AddWithValue("@email", "");


               us.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = us.ExecuteReader();
                listaUsuario = new List<Usuarios>();

                while (dr.Read())
                {
                    u.id_usuario = Convert.ToInt32(dr["id_usuario"].ToString());
                    u.cedula = dr["cedula"].ToString();
                    u.nombres = dr["nombres"].ToString();
                    u.apellidos = dr["apellidos"].ToString();
                    u.email = dr["email"].ToString();

                    listaUsuario.Add(u);

                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                listaUsuario = null;

            }
            finally
            {
                us.Connection.Close();

            }

            return listaUsuario;
        }

    }
}
