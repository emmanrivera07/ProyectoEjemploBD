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
    public class accesoDatosCuentas
    {

        SqlConnection cnx;
        Cuentas c = new Cuentas();
        Conexion cn = new Conexion();
        SqlCommand ct = null;
        int indicador = 0;
        SqlDataReader dr = null;
        List<Cuentas> listaCuentas = null;


        public int insertarCuentas(Cuentas c)
        {

            try
            {

                cnx = cn.conectar();
                ct = new SqlCommand("nueva cuenta", cnx);
                ct.Parameters.AddWithValue("@b", 1);
                ct.Parameters.AddWithValue("@id_cuenta", "");
                ct.Parameters.AddWithValue("@nombreusuarios", c.nombreusuarios);
                ct.Parameters.AddWithValue("@clave", c.clave);
                ct.Parameters.AddWithValue("@rol", c.rol);
                ct.Parameters.AddWithValue("@id_usuario", c.id_usuario);


                ct.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                ct.ExecuteNonQuery();
                indicador = 1;

            }
            catch (Exception e)
            {
                e.Message.ToString();
                indicador = 0;
            }
            finally
            {
                ct.Connection.Close();
            }

            return indicador;
        

        }

        public int eliminarCuentas(int idcuenta)
        {


            try
            {
                cnx = cn.conectar();
                ct = new SqlCommand("cuenta", cnx);
                ct.Parameters.AddWithValue("@b", 2);
                ct.Parameters.AddWithValue("@id_cuenta", idcuenta);
                ct.Parameters.AddWithValue("@nombreusuarios", "");
                ct.Parameters.AddWithValue("@clave", "");
                ct.Parameters.AddWithValue("@rol", "");
                ct.Parameters.AddWithValue("id_usuario", "");


                ct.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                ct.ExecuteNonQuery();
                indicador = 1;

            }
            catch (Exception e)
            {
                e.Message.ToString();
                indicador = 0;
            }

            finally
            {
                ct.Connection.Close();
            }

            return indicador;
        }

        public List<Cuentas> listarCuentas()
        {
            try
            {
                cnx = cn.conectar();
                ct = new SqlCommand("cuentas", cnx);
                ct.Parameters.AddWithValue("@b", 3);
                ct.Parameters.AddWithValue("@id_cuenta", "");
                ct.Parameters.AddWithValue("@nombreusuarios", "");
                ct.Parameters.AddWithValue("@clave", "");
                ct.Parameters.AddWithValue("@rol", "");
                ct.Parameters.AddWithValue("@id_usuario", "");

                ct.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = ct.ExecuteReader();
                listaCuentas = new List<Cuentas>();

                while (dr.Read())
                {

                    c.id_cuentas = Convert.ToInt32(dr["id_cuenta"].ToString());
                    c.nombreusuarios = dr["nombreusuarios"].ToString();
                    c.clave = dr["clave"].ToString();
                    c.rol = dr["rol"].ToString();
                    c.id_usuario = Convert.ToInt32(dr["id_usuarios"].ToString());
                    listaCuentas.Add(c);
                }

            }
            catch (Exception e)
            {
                e.Message.ToString();
                listaCuentas = null;
            }

            finally
            {
                ct.Connection.Close();

            }

            return listaCuentas;
        }

        public int editarCuentas(Cuentas c)
        {
            try
            {

                cnx = cn.conectar();
                ct = new SqlCommand("cuenta", cnx);
                ct.Parameters.AddWithValue("@b", 4);
                ct.Parameters.AddWithValue("@id_cuenta", "");
                ct.Parameters.AddWithValue("@nombreusuarios", c.nombreusuarios);
                ct.Parameters.AddWithValue("@clave", c.clave);
                ct.Parameters.AddWithValue("@rol", c.rol);
                ct.Parameters.AddWithValue("@id_usuario", c.id_usuario);


                ct.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                ct.ExecuteNonQuery();
                indicador = 1;


            }
            catch (Exception e)
            {
                e.Message.ToString();
                indicador = 0;


            }
            finally
            {
                ct.Connection.Close();
            }
            return indicador;
        }

        public List<Cuentas> buscarCuentas(string dato)
        {
            try
            {
                cnx = cn.conectar();
                ct = new SqlCommand("cuenta", cnx);
                ct.Parameters.AddWithValue("@b", 5);
                ct.Parameters.AddWithValue("@id_cuenta", "");
                ct.Parameters.AddWithValue("@nombreusuarios", dato);
                ct.Parameters.AddWithValue("@clave", "");
                ct.Parameters.AddWithValue("@rol", dato);
                ct.Parameters.AddWithValue("@id_cuenta", "");


                ct.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = ct.ExecuteReader();
                listaCuentas = new List<Cuentas>();

                while (dr.Read())
                {
                    c.id_cuentas = Convert.ToInt32(dr["idcuenta"].ToString());
                    c.nombreusuarios = dr["nombreusuarios"].ToString();
                    c.clave = dr["clave"].ToString();
                    c.rol = dr["rol"].ToString();
                    c.id_usuario = Convert.ToInt32(dr["id_usuario"].ToString());
                    listaCuentas.Add(c);


                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                listaCuentas = null;

            }
            finally
            {
                ct.Connection.Close();

            }

            return listaCuentas;
        }

    }
}
