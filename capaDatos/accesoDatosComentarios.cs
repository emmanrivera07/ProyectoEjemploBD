using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using capaEntidades;

namespace capaDatos
{
    public class accesoDatosComentarios
    {
        SqlConnection cnx;
       Comentarios c= new Comentarios();
        
        Conexion cn = new Conexion();
        SqlCommand cm = null;
        int indicador = 0;
        SqlDataReader dr = null;
        List<Comentarios> listaComentarios = null;
        
        public int insertarComentarios(Comentarios co)
        {
            try
            {

                 cnx = cn.conectar();
                cm = new SqlCommand("comentar", cnx);
                cm.Parameters.AddWithValue("@b", 1);
                cm.Parameters.AddWithValue("@idcomentario", "");
                cm.Parameters.AddWithValue("@nombres", co.nombre);
                cm.Parameters.AddWithValue("@correo", co.correo);
                cm.Parameters.AddWithValue("@telefono", co.telefono);
                cm.Parameters.AddWithValue("@mensaje", co.mensaje);


                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                cm.ExecuteNonQuery();
                indicador = 1;

            }catch(Exception e){
                e.Message.ToString();
                indicador = 0;
            }
            finally
            {
                cm.Connection.Close();
            }

            return indicador;
        }
        
        public List<Comentarios> listarComentarios()
        {
            try
            {
                cnx = cn.conectar();
                cm = new SqlCommand("comentar", cnx);
                cm.Parameters.AddWithValue("@b", 3);
                cm.Parameters.AddWithValue("@idcomentario", "");
                cm.Parameters.AddWithValue("@nombres", "");
                cm.Parameters.AddWithValue("@correo","");
                cm.Parameters.AddWithValue("@telefono", "");
                cm.Parameters.AddWithValue("@mensaje","");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaComentarios = new List<Comentarios >();

                while (dr.Read())
                {
                    Comentarios co = new Comentarios();
                    co.id_comentarios = Convert.ToInt32(dr["cmt_Id"].ToString());
                    co.nombre = dr["cmt_Nombres"].ToString();
                    co.correo = dr["cmt_Correo"].ToString();
                    co.telefono = dr["cmt_Telefono"].ToString();
                    co.mensaje = dr["cmt_Mensaje"].ToString();
                    listaComentarios.Add(co);
                }

            }
            catch(Exception e)
            {
                e.Message.ToString();
                listaComentarios = null;
            }

            finally
            {
                cm.Connection.Close();

            }

            return listaComentarios;
        }


        public int eliminarComentarios(int idcomentario)
        {


            try
            {
                cnx = cn.conectar();
                cm = new SqlCommand("comentar", cnx);
                cm.Parameters.AddWithValue("@b", 2);
                cm.Parameters.AddWithValue("@idcomentario", idcomentario);
                cm.Parameters.AddWithValue("@nombres","");
                cm.Parameters.AddWithValue("@correo", "");
                cm.Parameters.AddWithValue("@telefono", "");
                cm.Parameters.AddWithValue("@mensaje", "");


                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                cm.ExecuteNonQuery();
                indicador = 1;

            }
            catch(Exception e)
            {
                e.Message.ToString();
                indicador = 0;
            }

            finally
            {
                cm.Connection.Close();
            }

            return indicador;
        }

        public int editarComentarios(Comentarios co)
        {
            try { 

            cnx = cn.conectar();
            cm = new SqlCommand("comentar", cnx);
            cm.Parameters.AddWithValue("@b", 4);
            cm.Parameters.AddWithValue("@idcomentario", co.id_comentarios);
            cm.Parameters.AddWithValue("@nombres", co.nombre);
            cm.Parameters.AddWithValue("@correo", co.correo);
            cm.Parameters.AddWithValue("@telefono", co.telefono);
            cm.Parameters.AddWithValue("@mensaje", co.mensaje);


            cm.CommandType = CommandType.StoredProcedure;
            cnx.Open();
            cm.ExecuteNonQuery();
            indicador = 1;

            
            }
            catch(Exception e)
            {
                e.Message.ToString();
                indicador = 0;


            }
            finally
            {
                cm.Connection.Close();
            }
            return indicador;
        }

        public  List<Comentarios> buscarComentarios(string dato)
        {
            try { 
                cnx = cn.conectar();
                cm = new SqlCommand("comentar", cnx);
                cm.Parameters.AddWithValue("@b", 5);
                cm.Parameters.AddWithValue("@idcomentario", "");
                cm.Parameters.AddWithValue("@nombres", dato);
                cm.Parameters.AddWithValue("@correo", "");
                cm.Parameters.AddWithValue("@telefono", "");
                cm.Parameters.AddWithValue("@mensaje",dato);


                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaComentarios = new List<Comentarios>();

                while (dr.Read())
                {
                    
                    c.id_comentarios = Convert.ToInt32(dr["cmt_Id"].ToString());
                    c.nombre = dr["cmt_Nombres"].ToString();
                    c.correo = dr["cmt_Correo"].ToString();
                    c.telefono = dr["cmt_Telefono"].ToString();
                    c.mensaje = dr["cmt_Mensaje"].ToString();
                    listaComentarios.Add(c);


                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                listaComentarios = null;

            }
            finally
            {
                cm.Connection.Close();

            }

            return listaComentarios ;
        }

    }
}
