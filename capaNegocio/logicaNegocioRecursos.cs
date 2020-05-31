using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaDatos;
using capaEntidades;

namespace capaNegocio
{
    public class logicaNegocioRecursos
    {

        accesoDatosRecursos ac = new accesoDatosRecursos();

        public int insertarRecursos(Recursos r)
        {
            return ac.insertarRecursos(r);


        }

        public int eliminarRecursos(int idrecurso)
        {
            return ac.eliminarRecursos(idrecurso);
        }

        public List<Recursos> listarRecursos()
        {
            return ac.listarRecursos();
        }

        public int editarRecursos(Recursos r)
        {
            return ac.editarRecursos(r);
        }

        public List<Recursos> buscarRecursos(string dato)
        {
            return ac.buscarRecursos(dato);
        }

    }
}
