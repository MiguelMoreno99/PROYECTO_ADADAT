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

        public static void HabiliatarOperador(string correo_electronico, string contrasena_anterior, string contrasena_actual)
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
                string query = ("INSERT INTO habitaciones(nombre, nivel, nombre_nivel, numero_camas, tipo_cama, max_personas, correo_admin, fecha_registro) values(?, ?, ?, ?, ?, ?, ?, ?)");
                var statement = new SimpleStatement(query, nombre, nivel, nombre_nivel, numero_camas, tipo_cama, max_personas, VariablesGlobales.CorreoPersonaLogeada, VariablesGlobales.DevolverFechaRegistro());
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

        public static void RegistrarHotel(string nombre, DateTime fecha_inicio, string ciudad, string estado, string pais, string domicilio, int numero_pisos, string zona_turistica, string servicios_adicionales, string caracteristicas)
        {
            try
            {
                Conectar();
                string query = ("INSERT INTO hoteles(id_hotel, nombre, fecha_inicio, ciudad, estado, pais, domicilio, numero_pisos, zona_turistica, servicios_adicionales, caracteristicas, correo_admin, fecha_registro) values(?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)");
                var statement = new SimpleStatement(query, Guid.NewGuid(), nombre, fecha_inicio, ciudad, estado, pais, domicilio, numero_pisos, zona_turistica, servicios_adicionales, caracteristicas, VariablesGlobales.CorreoPersonaLogeada, VariablesGlobales.DevolverFechaRegistro());
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

        public static void RegistrarHabitacionEnHotel(Guid id_habitacion_hotel, string nombre_habitacion, int nivel_habitacion, string nombre_nivel_habitacion, int numero_camas_habitacion, string tipo_cama_habitacion, int max_personas_habitacion, double precio_noche, int numero, string caracteristicas, string amenidades, string nombre, List<Guid> habitaciones_en_hotel)
        {
            try
            {
                Conectar();
                string query = ("INSERT INTO habitacionesenhoteles(id_habitacion_hotel, nombre_habitacion, nivel_habitacion, nombre_nivel_habitacion, numero_camas_habitacion, tipo_cama_habitacion, max_personas_habitacion, precio_noche, numero, caracteristicas, amenidades, ocupada, personas_hospedadas) values(?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)");
                var statement = new SimpleStatement(query, id_habitacion_hotel, nombre_habitacion, nivel_habitacion, nombre_nivel_habitacion, numero_camas_habitacion, tipo_cama_habitacion, max_personas_habitacion, precio_noche, numero, caracteristicas, amenidades, false, 0);
                _session.Execute(statement);
            }
            catch (FormatException error)
            {
                MessageBox.Show(error.Message, "ERROR CASSANDRA");
            }
            finally
            {
                Desconectar();
                RegistrarGuidHabitacionEnHotel(nombre, habitaciones_en_hotel);
            }
        }

        public static void RegistrarGuidHabitacionEnHotel(string nombre, List<Guid> habitaciones_en_hotel)
        {
            try
            {
                Conectar();
                string query = ("UPDATE hoteles SET habitaciones_en_hotel = ? WHERE nombre = ?;");
                var statement = new SimpleStatement(query, habitaciones_en_hotel, nombre);
                _session.Execute(statement);
            }
            catch (FormatException error)
            {
                MessageBox.Show(error.Message, "ERROR CASSANDRA");
            }
            finally
            {
                Desconectar();
                MessageBox.Show("SE ASIGNO LA HABITACION AL HOTEL CORRECTAMENTE!", "FELICIDADES!");
            }
        }

        public static void RegistrarCliente(string nombre, string apellido_paterno, string apellido_materno, string rfc, string domicilio, string correo_electronico, int telefono_casa, Int64 telefono_celular, string referencia, string estado_civil, DateTime fecha_nacimiento)
        {
            try
            {
                Conectar();
                string query = ("INSERT INTO clientes(id_cliente, nombre, apellido_paterno, apellido_materno, rfc, domicilio, correo_electronico, telefono_casa, telefono_celular, referencia, estado_civil, fecha_nacimiento, correo_operativo, fecha_registro) values(?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)");
                var statement = new SimpleStatement(query, Guid.NewGuid(), nombre, apellido_paterno, apellido_materno, rfc, domicilio, correo_electronico, telefono_casa, telefono_celular, referencia, estado_civil, fecha_nacimiento, VariablesGlobales.CorreoPersonaLogeada, VariablesGlobales.DevolverFechaRegistro());
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

        public static void RegistrarReservacion(Guid id_reservacion,Guid id_hotel, Guid id_habitacion_hotel, Guid id_cliente, List<Guid> id_reservaciones, DateTime fecha_inicial, DateTime fecha_final, int personas_hospedar, double anticipo, double total_hospedaje)
        {
            try
            {
                Conectar();
                string query = ("INSERT INTO reservaciones(id_reservacion, reservacion_activa, id_hotel, id_habitacion_hotel, id_cliente, fecha_inicial, fecha_final, personas_hospedar, anticipo, checkin, checkout, total_hospedaje, correo_operativo, fecha_registro) values(?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)");
                var statement = new SimpleStatement(query, id_reservacion, true, id_hotel, id_habitacion_hotel, id_cliente, fecha_inicial, fecha_final, personas_hospedar, anticipo, false, false, total_hospedaje, VariablesGlobales.CorreoPersonaLogeada, VariablesGlobales.DevolverFechaRegistro());
                _session.Execute(statement);
            }
            catch (FormatException error)
            {
                MessageBox.Show(error.Message, "ERROR CASSANDRA");
            }
            finally
            {
                Desconectar();
                RegistrarGuidReservacionEnCliente(id_cliente, id_reservaciones, id_reservacion);
            }
        }

        public static void RegistrarGuidReservacionEnCliente(Guid id_cliente, List<Guid> id_reservaciones, Guid id_reservacion)
        {
            try
            {
                Conectar();
                string query = ("UPDATE clientes SET id_reservacion = ? WHERE id_cliente = ?;");
                var statement = new SimpleStatement(query, id_reservaciones, id_cliente);
                _session.Execute(statement);
            }
            catch (FormatException error)
            {
                MessageBox.Show(error.Message, "ERROR CASSANDRA");
            }
            finally
            {
                Desconectar();
                MessageBox.Show("SE CREO LA RESERVACION Y SE ASIGNO AL CLIENTE CORRECTAMENTE, SU RESERVACION ES: " + id_reservacion + Environment.NewLine + Environment.NewLine + "El medio de pago para el anticipo puede ser: Tarjeta de crédito o débito, transferencia electrónica bancaria, COBRE 200 $ Pesos del Anticipo", "FELICIDADES!");
            }
        }

        public static void CancelarReservacion(Guid id_reservacion, Guid id_habitacion_hotel)
        {
            try
            {
                Conectar();
                string query = ("UPDATE reservaciones SET reservacion_activa = ?, correo_admin_cancelacion = ?, fecha_cancelacion = ? WHERE id_reservacion = ?;");
                var statement = new SimpleStatement(query, false, VariablesGlobales.CorreoPersonaLogeada, VariablesGlobales.DevolverFechaRegistro(), id_reservacion) ;
                _session.Execute(statement);
            }
            catch (FormatException error)
            {
                MessageBox.Show(error.Message, "ERROR CASSANDRA");
            }
            finally
            {
                Desconectar();
                DesocuparHabitacionEnHotel(id_habitacion_hotel, id_reservacion);
            }
        }

        public static void CancelarReservacionAutomatica(Guid id_reservacion, Guid id_habitacion_hotel)
        {
            try
            {
                Conectar();
                string query = ("UPDATE reservaciones SET reservacion_activa = ?, correo_admin_cancelacion = ?, fecha_cancelacion = ? WHERE id_reservacion = ?;");
                var statement = new SimpleStatement(query, false, "CANCELACION AUTOMATICA", VariablesGlobales.DevolverFechaRegistro(), id_reservacion);
                _session.Execute(statement);
            }
            catch (FormatException error)
            {
                MessageBox.Show(error.Message, "ERROR CASSANDRA");
            }
            finally
            {
                Desconectar();
                DesocuparHabitacionEnHotel(id_habitacion_hotel, id_reservacion);
            }
        }

        public static void DesocuparHabitacionEnHotel(Guid id_habitacion_hotel, Guid id_reservacion)
        {
            try
            {
                Conectar();
                string query = ("UPDATE habitacionesenhoteles SET ocupada = ?, personas_hospedadas = ? WHERE id_habitacion_hotel = ?;");
                var statement = new SimpleStatement(query, false, 0, id_habitacion_hotel);
                _session.Execute(statement);
            }
            catch (FormatException error)
            {
                MessageBox.Show(error.Message, "ERROR CASSANDRA");
            }
            finally
            {
                Desconectar();
                MessageBox.Show("LA RESERVACION: " + id_reservacion + " SE CANCELÓ Y SE DESOCUPÓ LA HABITACION EN EL HOTEL!", "HECHO");
            }
        }

        public static void CheckIn(Guid id_reservacion, Guid id_habitacion_hotel, int personas_hospedadas)
        {
            try
            {
                Conectar();
                string query = ("UPDATE reservaciones SET checkin = ? WHERE id_reservacion = ?;");
                var statement = new SimpleStatement(query, true, id_reservacion);
                _session.Execute(statement);
            }
            catch (FormatException error)
            {
                MessageBox.Show(error.Message, "ERROR CASSANDRA");
            }
            finally
            {
                Desconectar();
                OcuparHabitacion(id_habitacion_hotel, personas_hospedadas);
            }
        }

        public static void OcuparHabitacion(Guid id_habitacion_hotel, int personas_hospedadas)
        {
            try
            {
                Conectar();
                string query = ("UPDATE habitacionesenhoteles SET ocupada = ?, personas_hospedadas = ? WHERE id_habitacion_hotel = ?;");
                var statement = new SimpleStatement(query, true, personas_hospedadas, id_habitacion_hotel);
                _session.Execute(statement);
            }
            catch (FormatException error)
            {
                MessageBox.Show(error.Message, "ERROR CASSANDRA");
            }
            finally
            {
                Desconectar();
                MessageBox.Show("SE OCUPO LA HABITACION Y SE REALIZO EL CHECKIN CORRECTAMENTE!", "HECHO");
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

        public static List<Habitacion> HacerListaHabitaciones()
        {
            string query = "SELECT nombre, nivel, nombre_nivel, numero_camas, tipo_cama, max_personas, correo_admin, fecha_registro FROM habitaciones;";
            Conectar();
            IMapper mapper = new Mapper(_session);
            IEnumerable<Habitacion> users = mapper.Fetch<Habitacion>(query);
            Desconectar();
            return users.ToList();
        }

        public static List<Hotel> HacerListaHoteles()
        {
            string query = "SELECT id_hotel, nombre, fecha_inicio, ciudad, estado, pais, domicilio, numero_pisos, zona_turistica, servicios_adicionales, caracteristicas, habitaciones_en_hotel, correo_admin, fecha_registro FROM hoteles;";
            Conectar();
            IMapper mapper = new Mapper(_session);
            IEnumerable<Hotel> users = mapper.Fetch<Hotel>(query);
            Desconectar();
            return users.ToList();
        }

        public static List<HabitacionEnHotel> HacerListaHabitacionesEnHoteles()
        {
            string query = "SELECT id_habitacion_hotel, nombre_habitacion, nivel_habitacion, nombre_nivel_habitacion, numero_camas_habitacion, tipo_cama_habitacion, max_personas_habitacion, precio_noche, numero, caracteristicas, amenidades, ocupada, personas_hospedadas FROM habitacionesenhoteles;";
            Conectar();
            IMapper mapper = new Mapper(_session);
            IEnumerable<HabitacionEnHotel> users = mapper.Fetch<HabitacionEnHotel>(query);
            Desconectar();
            return users.ToList();
        }

        public static List<Cliente> HacerListaClientes()
        {
            string query = "SELECT id_cliente, nombre, apellido_paterno, apellido_materno, rfc, domicilio, correo_electronico, telefono_casa, telefono_celular, referencia, estado_civil, fecha_nacimiento, id_reservacion FROM clientes;";
            Conectar();
            IMapper mapper = new Mapper(_session);
            IEnumerable<Cliente> users = mapper.Fetch<Cliente>(query);
            Desconectar();
            return users.ToList();
        }

        public static List<Reservacion> HacerListaReservaciones()
        {
            string query = "SELECT id_reservacion, reservacion_activa, id_hotel, id_habitacion_hotel, id_cliente, fecha_inicial, fecha_final, personas_hospedar, anticipo, checkin, checkout, fecha_checkout, servicios_utilizados, numero_servicios, descuento, total_hospedaje, total_servicios, total_pagar FROM reservaciones;";
            Conectar();
            IMapper mapper = new Mapper(_session);
            IEnumerable<Reservacion> users = mapper.Fetch<Reservacion>(query);
            Desconectar();
            return users.ToList();
        }

    }
}