using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_ADADAT.CSharp_MainCode
{
    class Habitacion
    {
        public string nombre { set; get; }
        public int nivel { set; get; }
        public string nombre_nivel { set; get; }
        public int numero_camas { set; get; }
        public string tipo_cama { set; get; }
        public int max_personas { set; get; }
        public string correo_admin { set; get; }
        public DateTime fecha_registro { set; get; }
    }
}
