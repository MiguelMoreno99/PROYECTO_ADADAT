using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_ADADAT.CSharp_MainCode
{
    class Hotel
    {
        public Guid id_hotel { set; get; }
        public string nombre { set; get; }
        public DateTime fecha_inicio { set; get; }
        public string ciudad { set; get; }
        public string estado { set; get; }
        public string pais { set; get; }
        public string domicilio { set; get; }
        public int numero_pisos { set; get; }
        public string zona_turistica { set; get; }
        public string servicios_adicionales { set; get; }
        public string caracteristicas { set; get; }
        public List<Guid> habitaciones_en_hotel { set; get; }
        public string correo_admin { set; get; }
        public DateTime fecha_registro { set; get; }
    }
}
