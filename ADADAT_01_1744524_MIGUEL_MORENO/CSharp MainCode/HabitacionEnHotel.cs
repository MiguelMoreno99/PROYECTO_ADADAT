using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_ADADAT.CSharp_MainCode
{
    class HabitacionEnHotel
    {
        public Guid id_habitacion_hotel { set; get; }
        public string nombre_habitacion { set; get; }
        public int nivel_habitacion { set; get; }
        public string nombre_nivel_habitacion { set; get; }
        public int numero_camas_habitacion { set; get; }
        public string tipo_cama_habitacion { set; get; }
        public int max_personas_habitacion { set; get; }
        public double precio_noche { set; get; }
        public int numero { set; get; }
        public string caracteristicas { set; get; }
        public string amenidades { set; get; }
        public double ocupada { set; get; }
        public int personas_hospedadas { set; get; }
    }
}
