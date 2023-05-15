using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_ADADAT.CSharp_MainCode
{
    public class Operador
    {
        public int id_operativo { set; get; }
        public string correo_electronico { set; get; }
        public string contrasena_actual { set; get; }
        public string contrasena_anterior { set; get; }
        public string contrasena_anteanterior { set; get; }
        public string nombre_completo { set; get; }
        public Int64 numero_nomina { set; get; }
        public DateTime fecha_nacimiento { set; get; }
        public string domicilio { set; get; }
        public Int32 telefono_casa { set; get; }
        public Int64 telefono_celular { set; get; }
        public bool inhabilitado { set; get; }
        public bool restablecer_contrasena { set; get; }
        public string correo_admin { set; get; }
        public DateTime fecha_registro { set; get; }
    }
}
