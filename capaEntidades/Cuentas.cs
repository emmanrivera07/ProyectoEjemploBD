using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidades
{
    public class Cuentas
    {
        public int id_cuentas { get; set; }
        public string nombreusuarios { get; set; }
        public string clave { get; set; }
        public string rol { get; set; }
        public int id_usuario { get; set; }
    }
}
