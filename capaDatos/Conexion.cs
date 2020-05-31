using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace capaDatos
{
    public class Conexion
    {

        public SqlConnection conectar()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=NOHELIA-PC\\SQLEXPRESS;Initial Catalog=programacionBaseDeDatos;Integrated Security=True";
            return cn;
        }
    }
}
