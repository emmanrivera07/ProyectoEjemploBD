using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaEntidades;
using capaNegocio;
using capaDatos;

namespace capaNegocio
{
    public class logicaNegocioComentarios
    {

        accesoDatosComentarios ac =new accesoDatosComentarios();

        public int insertarComentarios(Comentarios c)
        {
            return ac.insertarComentarios(c);
        }

        public List<Comentarios> listarComentarios()
        {
            return ac.listarComentarios();
        }

        public int editarComentarios(Comentarios c)
        {
            return ac.editarComentarios(c);
        }

        public List<Comentarios> buscarComentarios(string dato)
        {
            return ac.buscarComentarios(dato);
        }
    }
}
