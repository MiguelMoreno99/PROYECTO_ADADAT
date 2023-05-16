using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cassandra;
using Cassandra.Mapping;
using System.Configuration;
using System.Windows.Forms;
using PROYECTO_ADADAT.CSharp_MainCode;

namespace PROYECTO_ADADAT
{
    class EnlaceCassandra
    {
        //VARIABLES
        static private string DbServer { set; get; }
        static private string DbKeySpace { set; get; }
        static private Cluster _cluster;
        static private ISession _session;
        //METODOS
        private static void Conectar()
        {
            DbServer = ConfigurationManager.AppSettings["Cluster"].ToString();
            DbKeySpace = ConfigurationManager.AppSettings["KeySpace"].ToString();

            _cluster = Cluster.Builder()
                .AddContactPoint(DbServer)
                .Build();

            _session = _cluster.Connect(DbKeySpace);
        }

        private static void Desconectar()
        {
            _cluster.Dispose();
        }

        public static void RegistrarOperador(string correo_electronico, string contrasena_actual, string nombre_completo, Int64 numero_nomina, DateTime fecha_nacimiento, string domicilio, int telefono_casa, Int64 telefono_celular)
        {
            try
            {
                Conectar();
                string query = ("INSERT INTO usuariosoperativos(correo_electronico, contrasena_actual, contrasena_anterior, contrasena_anteanterior, nombre_completo, numero_nomina, fecha_nacimiento, domicilio, telefono_casa, telefono_celular, inhabilitado, restablecer_contrasena, correo_admin, fecha_registro) values(?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)");
                var statement = new SimpleStatement(query, correo_electronico, contrasena_actual, contrasena_actual, contrasena_actual, nombre_completo, numero_nomina, fecha_nacimiento, domicilio, telefono_casa, telefono_celular, false, false, VariablesGlobales.CorreoPersonaLogeada, VariablesGlobales.DevolverFechaRegistro());
                _session.Execute(statement);
            }
            catch (FormatException error)
            {
                MessageBox.Show(error.Message, "ERROR CASSANDRA");
            }
            finally
            {
                Desconectar();
                MessageBox.Show("LA INFORMACION SE CAPTURO CORRECTAMENTE", "FELICIDADES!!");
            }
        }

        public static void DeshabiliatarOperador(string correo_electronico)
        {
            try
            {
                Conectar();
                string query = ("UPDATE usuariosoperativos SET inhabilitado = true WHERE correo_electronico = ?;");
                var statement = new SimpleStatement(query, correo_electronico);
                _session.Execute(statement);
            }
            catch (FormatException error)
            {
                MessageBox.Show(error.Message, "ERROR CASSANDRA");
            }
            finally
            {
                Desconectar();
                MessageBox.Show("SU USUARIO QUEDO INHABILITADO", "CONTACTE CON SU ADMINISTRADOR");
            }
        }

        public static void HabiliatarOperador(string correo_electronico, string contrasena_anteanterior, string contrasena_anterior, string contrasena_actual)
        {
            try
            {
                Conectar();
                string query = ("UPDATE usuariosoperativos SET contrasena_anteanterior = ?, contrasena_anterior = ?, contrasena_actual = ?, inhabilitado = false, restablecer_contrasena = true WHERE correo_electronico = ?;");
                var statement = new SimpleStatement(query, contrasena_anterior, contrasena_actual, correo_electronico, correo_electronico);
                _session.Execute(statement);
            }
            catch (FormatException error)
            {
                MessageBox.Show(error.Message, "ERROR CASSANDRA");
            }
            finally
            {
                Desconectar();
                MessageBox.Show("SU USUARIO QUEDO HABILITADO CORRECTAMENTE Y LA CONTRASEÑA ES EL MISMO USUARIO!", "FELICIDADES!");
            }
        }

        public static void CambiarContrasenaOperador(string correo_electronico, string contrasena_actual)
        {
            try
            {
                Conectar();
                string query = ("UPDATE usuariosoperativos SET contrasena_actual = ?, restablecer_contrasena = false WHERE correo_electronico = ?;");
                var statement = new SimpleStatement(query, contrasena_actual, correo_electronico);
                _session.Execute(statement);
            }
            catch (FormatException error)
            {
                MessageBox.Show(error.Message, "ERROR CASSANDRA");
            }
            finally
            {
                Desconectar();
                MessageBox.Show("CAMBIO LA CONTRASEÑA TEMPORAL CORRECTAMENTE!", "FELICIDADES!");
            }
        }

        public static void RegistrarHabitacion(string nombre, int nivel, string nombre_nivel, int numero_camas, string tipo_cama, int max_personas)
        {
            try
            {
                Conectar();
                string query = ("INSERT INTO habitaciones(id_habitacion, nombre, nivel, nombre_nivel, numero_camas, tipo_cama, max_personas, correo_admin, fecha_registro) values(?, ?, ?, ?, ?, ?, ?, ?, ?)");
                var statement = new SimpleStatement(query, 1, nombre, nivel, nombre_nivel, numero_camas, tipo_cama, max_personas, VariablesGlobales.CorreoPersonaLogeada, VariablesGlobales.DevolverFechaRegistro());
                _session.Execute(statement);
            }
            catch (FormatException error)
            {
                MessageBox.Show(error.Message, "ERROR CASSANDRA");
            }
            finally
            {
                Desconectar();
                MessageBox.Show("LA INFORMACION DE LA HABITACION SE CAPTURO CORRECTAMENTE", "FELICIDADES!!");
            }
        }

        public static void RegistrarHotel(string nombre, DateTime fecha_inicio, string ciudad, string estado, string pais, string domicilio, int numero_pisos, string zona_turistica, string servicios_adicionales, string caracteristicas, List<int> habitaciones_en_hotel)
        {
            try
            {
                Conectar();
                string query = ("INSERT INTO hoteles(id_hotel, nombre, fecha_inicio, ciudad, estado, pais, domicilio, numero_pisos, zona_turistica, servicios_adicionales, caracteristicas, habitaciones_en_hotel, correo_admin, fecha_registro) values(?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)");
                var statement = new SimpleStatement(query, 1, nombre, fecha_inicio, ciudad, estado, pais, domicilio, numero_pisos, zona_turistica, servicios_adicionales, caracteristicas, habitaciones_en_hotel, VariablesGlobales.CorreoPersonaLogeada, VariablesGlobales.DevolverFechaRegistro());
                _session.Execute(statement);
            }
            catch (FormatException error)
            {
                MessageBox.Show(error.Message, "ERROR CASSANDRA");
            }
            finally
            {
                Desconectar();
                MessageBox.Show("LA INFORMACION DEL HOTEL SE CAPTURO CORRECTAMENTE", "FELICIDADES!!");
            }
        }

        public static void RegistrarHabitacionEnHotel(string nombre_habitacion, int nivel_habitacion, string nombre_nivel_habitacion, int numero_camas_habitacion, string tipo_cama_habitacion, int max_personas_habitacion, double precio_noche, int numero, string caracteristicas, string amenidades)
        {
            try
            {
                Conectar();
                string query = ("INSERT INTO habitacionesenhoteles(id_habitacion_hotel, id_habitacion, nombre_habitacion, nivel_habitacion, nombre_nivel_habitacion, numero_camas_habitacion, tipo_cama_habitacion, max_personas_habitacion, precio_noche, numero, caracteristicas, amenidades, ocupada, personas_hospedadas) values(?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)");
                var statement = new SimpleStatement(query, 1, 1, nombre_habitacion, nivel_habitacion, nombre_nivel_habitacion, numero_camas_habitacion, tipo_cama_habitacion, max_personas_habitacion, precio_noche, numero, caracteristicas, amenidades, false, 0);
                _session.Execute(statement);
            }
            catch (FormatException error)
            {
                MessageBox.Show(error.Message, "ERROR CASSANDRA");
            }
            finally
            {
                Desconectar();
                MessageBox.Show("LA INFORMACION DE LA HABITACION EN EL HOTEL SE CAPTURO CORRECTAMENTE", "FELICIDADES!!");
            }
        }

        public static void RegistrarCliente(string nombre, string apellido_paterno, string apellido_materno, string rfc, string domicilio, string correo_electronico, int telefono_casa, Int64 telefono_celular, string referencia, string estado_civil, DateTime fecha_nacimiento)
        {
            try
            {
                Conectar();
                string query = ("INSERT INTO clientes(id_cliente, nombre, apellido_paterno, apellido_materno, rfc, domicilio, correo_electronico, telefono_casa, telefono_celular, referencia, estado_civil, fecha_nacimiento,id_reservacion, correo_operativo, fecha_registro) values(?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)");
                var statement = new SimpleStatement(query, 1, nombre, apellido_paterno, apellido_materno, rfc, domicilio, correo_electronico, telefono_casa, telefono_celular, referencia, estado_civil, fecha_nacimiento, null, VariablesGlobales.CorreoPersonaLogeada, VariablesGlobales.DevolverFechaRegistro());
                _session.Execute(statement);
            }
            catch (FormatException error)
            {
                MessageBox.Show(error.Message, "ERROR CASSANDRA");
            }
            finally
            {
                Desconectar();
                MessageBox.Show("LA INFORMACION DEL CLIENTE SE CAPTURO CORRECTAMENTE", "FELICIDADES!!");
            }
        }

        public static void RegistrarReservacion(Guid id_reservacion, DateTime fecha_inicial, DateTime fecha_final, int personas_hospedar, double anticipo, double total_hospedaje)
        {
            try
            {
                Conectar();
                string query = ("INSERT INTO reservaciones(id_reservacion, reservacion_activa, id_hotel, id_habitacion_hotel, id_cliente, fecha_inicial, fecha_final, personas_hospedar, anticipo, checkin, checkout, fecha_checkout, servicios_utilizados, numero_servicios, descuento, total_hospedaje, total_servicios, total_pagar, correo_admin_cancelacion, fecha_cancelacion, correo_operativo, fecha_registro) values(?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)");
                var statement = new SimpleStatement(query, id_reservacion, true, 1, 1, 1, fecha_inicial, fecha_final, personas_hospedar, anticipo, false, false, "", "", "", "", total_hospedaje, "", "", "", "", VariablesGlobales.CorreoPersonaLogeada, VariablesGlobales.DevolverFechaRegistro());
                _session.Execute(statement);
            }
            catch (FormatException error)
            {
                MessageBox.Show(error.Message, "ERROR CASSANDRA");
            }
            finally
            {
                Desconectar();
                MessageBox.Show("LA INFORMACION DE LA RESERVACION SE CAPTURO CORRECTAMENTE, SU RESERVACION ES: " + id_reservacion, "FELICIDADES!!");
            }
        }

        public static List<Operador> HacerListaOperadores()
        {
            string query = "SELECT correo_electronico, contrasena_actual, contrasena_anterior, contrasena_anteanterior, nombre_completo, numero_nomina, fecha_nacimiento, domicilio, telefono_casa, telefono_celular, inhabilitado, restablecer_contrasena, correo_admin, fecha_registro FROM usuariosoperativos;";
            Conectar();
            IMapper mapper = new Mapper(_session);
            IEnumerable<Operador> users = mapper.Fetch<Operador>(query);
            Desconectar();
            return users.ToList();
        }

        public static List<Administrador> HacerListaAdministradores()
        {
            string query = "SELECT correo_electronico, contrasena_actual FROM usuariosadministradores;";
            Conectar();
            IMapper mapper = new Mapper(_session);
            IEnumerable<Administrador> users = mapper.Fetch<Administrador>(query);
            Desconectar();
            return users.ToList();
        }

    }
}