using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_ADADAT.CSharp_MainCode
{
    class Cliente
    {
        public Guid id_cliente { set; get; }
        public string nombre { set; get; }
        public string apellido_paterno { set; get; }
        public string apellido_materno { set; get; }
        public string rfc { set; get; }
        public string domicilio { set; get; }
        public string correo_electronico { set; get; }
        public int telefono_casa { set; get; }
        public Int64 telefono_celular { set; get; }
        public string referencia { set; get; }
        public string estado_civil { set; get; }
        public DateTime fecha_nacimiento { set; get; }
        public List<Guid> id_reservacion { set; get; }
    }
}
