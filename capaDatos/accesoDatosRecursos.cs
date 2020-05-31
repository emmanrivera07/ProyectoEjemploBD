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
    public class accesoDatosRecursos
    {
        SqlConnection cnx;
        Recursos r = new Recursos();
        Conexion cn = new Conexion();
        SqlCommand rc = null;
        int indicador = 0;
        SqlDataReader dr = null;
        List<Recursos> listaRecursos = null;

        public int insertarRecursos(Recursos r)
        {

            try
            {

                cnx = cn.conectar();
                rc = new SqlCommand("prerecursos", cnx);
                rc.Parameters.AddWithValue("@b", 1);
                rc.Parameters.AddWithValue("@idrecursos", "");
                rc.Parameters.AddWithValue("@nombrerecursos", r.nombre);
                rc.Parameters.AddWithValue("@codigo", r.codigo);
                rc.Parameters.AddWithValue("@descripcion", r.descripcion);



                rc.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                rc.ExecuteNonQuery();
                indicador = 1;

            }
            catch (Exception e)
            {
                e.Message.ToString();
                indicador = 0;
            }
            finally
            {
                rc.Connection.Close();
            }

            return indicador;


        }

        public int eliminarRecursos(int idrecurso)
        {


            try
            {
                cnx = cn.conectar();
                rc = new SqlCommand("prerecursos", cnx);
                rc.Parameters.AddWithValue("@b", 2);
                rc.Parameters.AddWithValue("@idrecursos", idrecurso);
                rc.Parameters.AddWithValue("@nombrerecursos", "");
                rc.Parameters.AddWithValue("@codigo", "");
                rc.Parameters.AddWithValue("@descripcion", "");
             


                rc.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                rc.ExecuteNonQuery();
                indicador = 1;

            }
            catch (Exception e)
            {
                e.Message.ToString();
                indicador = 0;
            }

            finally
            {
                rc.Connection.Close();
            }

            return indicador;
        }

        public List<Recursos> listarRecursos()
        {
            try
            {
                cnx = cn.conectar();
                rc = new SqlCommand("prerecursos", cnx);
                rc.Parameters.AddWithValue("@b", 3);
                rc.Parameters.AddWithValue("@idrecursos", "");
                rc.Parameters.AddWithValue("@nombrerecursos", "");
                rc.Parameters.AddWithValue("@codigo", "");
                rc.Parameters.AddWithValue("@descripcion", "");
                

                rc.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = rc.ExecuteReader();
                listaRecursos = new List<Recursos>();

                while (dr.Read())
                {
                    Recursos R = new Recursos();
                    R.id_recursos = Convert.ToInt32(dr["rcs_Id"].ToString());
                    R.nombre = dr["rcs_Nombre"].ToString();
                    R.codigo = dr["rcs_Codigo"].ToString();
                    R.descripcion = dr["rcs_Descripcion"].ToString();
                    
                    listaRecursos.Add(R);
                }

            }
            catch (Exception e)
            {
                e.Message.ToString();
                listaRecursos = null;
            }

            finally
            {
                rc.Connection.Close();

            }

            return listaRecursos;
        }

        public int editarRecursos(Recursos r)
        {
            try
            {

                cnx = cn.conectar();
                rc = new SqlCommand("prerecursos", cnx);
                rc.Parameters.AddWithValue("@b", 4);
                rc.Parameters.AddWithValue("@idrecursos", r.id_recursos);
                rc.Parameters.AddWithValue("@nombrerecursos", r.nombre);
                rc.Parameters.AddWithValue("@codigo", r.codigo);
                rc.Parameters.AddWithValue("@descripcion", r.descripcion);
                


                rc.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                rc.ExecuteNonQuery();
                indicador = 1;


            }
            catch (Exception e)
            {
                e.Message.ToString();
                indicador = 0;


            }
            finally
            {
                rc.Connection.Close();
            }
            return indicador;
        }

        public List<Recursos> buscarRecursos(string dato)
        {
            try
            {
                cnx = cn.conectar();
                rc = new SqlCommand("prerecursos", cnx);
                rc.Parameters.AddWithValue("@b", 5);
                rc.Parameters.AddWithValue("@idrecursos", "");
                rc.Parameters.AddWithValue("@nombrerecursos", dato);
                rc.Parameters.AddWithValue("@codigo", "");
                rc.Parameters.AddWithValue("@descripcion", "");
                


                rc.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = rc.ExecuteReader();
                listaRecursos = new List<Recursos>();

                while (dr.Read())
                {
                    r.id_recursos = Convert.ToInt32(dr["rcs_Id"].ToString());
                    r.nombre = dr["rcs_Nombre"].ToString();
                    r.codigo = dr["rcs_Codigo"].ToString();
                    r.descripcion = dr["rcs_Descripcion"].ToString();
                    
                    listaRecursos.Add(r);


                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                listaRecursos = null;

            }
            finally
            {
                rc.Connection.Close();

            }

            return listaRecursos;
        }

        
    }
}
