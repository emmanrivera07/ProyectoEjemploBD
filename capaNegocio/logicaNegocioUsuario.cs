using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaDatos;
using capaEntidades;

namespace capaNegocio
{
    public class logicaNegocioUsuario
    {
        accesoDatosUsuario ac = new accesoDatosUsuario();

        public int insertarUsuario(Usuarios u)
        {
            return ac.insertarUsuario(u);
        }

        public int eliminarUsuario(int idrecurso)
        {
            return ac.eliminarUsuario(idrecurso);
        }

        public List<Usuarios> listarUsuarios()
        {
            return ac.listarUsuarios();
        }

        public int editarUsuario(Usuarios u)
        {
            return ac.editarUsuario(u);
        }

        public List<Usuarios> buscarSolicitud(string dato)
        {
            return ac.buscarSolicitud(dato);
        }

    }
}
