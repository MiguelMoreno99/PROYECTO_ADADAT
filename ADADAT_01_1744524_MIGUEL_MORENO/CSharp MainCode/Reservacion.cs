using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_ADADAT.CSharp_MainCode
{
    class Reservacion
    {
        public Guid id_reservacion { set; get; }
        public bool reservacion_activa { set; get; }
        public Guid id_hotel { set; get; }
        public Guid id_habitacion_hotel { set; get; }
        public Guid id_cliente { set; get; }
        public DateTime fecha_inicial { set; get; }
        public DateTime fecha_final { set; get; }
        public int personas_hospedar { set; get; }
        public double anticipo { set; get; }
        public bool checkin { set; get; }
        public bool checkout { set; get; }
        public DateTime fecha_checkout { set; get; }
        public string servicios_utilizados { set; get; }
        public int numero_servicios { set; get; }
        public int descuento { set; get; }
        public double total_hospedaje { set; get; }
        public double total_servicios { set; get; }
        public double total_pagar { set; get; }
    }
}
