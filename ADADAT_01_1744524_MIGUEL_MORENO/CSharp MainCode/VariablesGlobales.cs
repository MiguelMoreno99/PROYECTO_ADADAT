using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_ADADAT
{
    class VariablesGlobales
    {
        //VARIABLES
            public static Form FormLoginOper = new FORM_LOGIN_OPER();
            public static Form FormLoginAdmin = new FORM_LOGIN_ADMIN();
            public static Form FormMain = new FORM_MAIN();
            public static Form FormRegistroOper = new FORM_REGISTRO_OPERADORES();
            public static Form FormMenuOper = new FORM_MENU_OPER();
            public static Form FormMenuAdmin = new FORM_MENU_ADMIN();
            public static Form FormContraRest= new FORM_CONTRA_REST();
            public static Form FormRegistoHoteles = new FORM_REGISTRO_HOTELES();
            public static Form FormRegistoHabitaciones = new FORM_REGISTRO_HABITACIONES();
            public static Form FormRegistoHabitacionesHoteles = new FORM_REGISTRO_HABITACIONESenHOTELES();
            public static Form FormRegistoReservaciones = new FORM_REGISTRO_RESERVACION();
            public static Form FormRegistoClientes = new FORM_REGISTRO_CLIENTES();
            public static Form FormRegistoCancelaciones = new FORM_REGISTRO_CANCELACIONES();
            public static Form FormRegistoCheckIn = new FORM_REGISTRO_CHECKIN();
            public static Form FormRegistoCheckOut = new FORM_REGISTRO_CHECKOUT();
            public static Form FormRegistroPagoReservacion = new FORM_REGISTRO_PAGORESERVACION();
            public static Form FormRegistroHabilitarUsuarios = new FORM_REGISTRO_HABILITARUSUARIOS();
            public static Form FormReporteVentas = new FORM_REPORTE_VENTAS();
            public static Form FormReporteClientes = new FORM_REPORTE_CLIENTE();
            public static Form FormReporteOcupacion = new FORM_REPORTE_OCUPACION();
            public static Form FormGestionClientes = new FORM_GESTION_CLIENTES();
            public static Form FormGestionUsuarios = new FORM_GESTION_USUARIOS();
            public static Form FormGestionHabitaciones = new FORM_GESTION_HABITACIONES();
            public static Form FormGestionHoteles = new FORM_GESTION_HOTELES();
            public static Form FormGestionHabitacionesHoteles = new FORM_GESTION_HABITACIONESenHOTELES();
            public static Form FormGestionReservaciones = new FORM_GESTION_RESERVACIONES();
        public static string CorreoPersonaLogeada;
            public static int IntentosOperador = 0;
            public static string CorreoIntentos;
            public static DateTime FechaCheckInOut;

        //METODOS
        public static Int64 DevolverFechaRegistro()
        {
            Int64 fecha_registro = ((DateTimeOffset.Now).ToUnixTimeMilliseconds()) - 21600000;
            return fecha_registro;
        }

    }
}
