using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaDatos;
using capaEntidades;

namespace capaNegocio
{
    public class logicaNegocioSolicitud
    {
        accesoDatosSolicitud ac = new accesoDatosSolicitud();

        

        public int insertarSolicitud(Solicitud s)
        {
            return ac.insertarSolicitud(s);
        }

        public int eliminarSolicitud(int idsolicitud)
        {
            return ac.eliminarSolicitud(idsolicitud);
        }

        public List<Solicitud> listarSolicitud()
        {
            return ac.listarSolicitud();
        }

        public int editarSolicitud(Solicitud s)
        {
            return ac.editarSolicitud(s);
        }

        public List<Solicitud> buscarSolicitud(int dato)
        {
            return ac.buscarSolicitud(dato);
        }

    }
}
