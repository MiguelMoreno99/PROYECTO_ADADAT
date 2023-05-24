using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_ADADAT.CSharp_MainCode
{
    public class HistorialCliente
    {
        public string nombre_cliente { get; set; }
        public string ano_reservacion { get; set; }
        public string nombre_hotel { get; set; }
        public string ciudad_hotel { get; set; }
        public string tipo_habitacion { get; set; }
        public string numero_habitacion { get; set; }
        public string numero_personas_hospedadas { get; set; }
        public string codigo_reservacion { get; set; }
        public string fecha_reservacion { get; set; }
        public string fecha_checkin { get; set; }
        public string fecha_chechout { get; set; }
        public string estatus_reservacion { get; set; }
        public string anticipo { get; set; }
        public string monto_hospedaje { get; set; }
        public string monto_servicios { get; set; }
        public string monto_total { get; set; }

    }
}
