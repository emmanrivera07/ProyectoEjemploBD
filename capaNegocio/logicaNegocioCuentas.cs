using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaDatos;
using capaEntidades;


namespace capaNegocio
{
    public class logicaNegocioCuentas
    {
        accesoDatosCuentas ac = new accesoDatosCuentas();

        public int insertarCuentas(Cuentas c)
        {
            return ac.insertarCuentas(c);

        }

        public int eliminarCuentas(int idcuenta)
        {
            return ac.eliminarCuentas(idcuenta); 
        }
        public List<Cuentas> listarCuentas()
        {
            return ac.listarCuentas();
        }

        public int editarCuentas(Cuentas c)
        {
            return ac.editarCuentas(c);
        }

        public List<Cuentas> buscarCuentas(string dato)
        {
            return ac.buscarCuentas(dato);
        }


    }
}
