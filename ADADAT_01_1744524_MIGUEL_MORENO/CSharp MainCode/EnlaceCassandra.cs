using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cassandra;
using Cassandra.Mapping;
using System.Configuration;
using System.Windows.Forms;

namespace PROYECTO_ADADAT
{
    class EnlaceCassandra
    {
        static private string DbServer { set; get; }
        static private string DbKeySpace { set; get; }
        static private Cluster _cluster;
        static private ISession _session;

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
                string query = ("INSERT INTO usuariosoperativos(id_operativo, correo_electronico, contrasena_actual, contrasena_anterior, contrasena_anteanterior, nombre_completo, numero_nomina, fecha_nacimiento, domicilio, telefono_casa, telefono_celular, inhabilitado, restablecer_contrasena, correo_admin, fecha_registro) values(?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)");
                var statement = new SimpleStatement(query, 1, correo_electronico, contrasena_actual, contrasena_actual, contrasena_actual, nombre_completo, numero_nomina, fecha_nacimiento, domicilio, telefono_casa, telefono_celular, false, false, "admin@admin.com", VariablesGlobales.DevolverFechaRegistro());
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

        public static void RegistrarHabitacion(string nombre, int nivel, string nombre_nivel, int numero_camas, string tipo_cama, int max_personas)
        {
            try
            {
                Conectar();
                string query = ("INSERT INTO habitaciones(id_habitacion, nombre, nivel, nombre_nivel, numero_camas, tipo_cama, max_personas, correo_admin, fecha_registro) values(?, ?, ?, ?, ?, ?, ?, ?, ?)");
                var statement = new SimpleStatement(query, 1, nombre, nivel, nombre_nivel, numero_camas, tipo_cama, max_personas, "admin@admin.com", VariablesGlobales.DevolverFechaRegistro());
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
                var statement = new SimpleStatement(query, 1, nombre, fecha_inicio, ciudad, estado, pais, domicilio, numero_pisos, zona_turistica, servicios_adicionales, caracteristicas, habitaciones_en_hotel, "admin@admin.com", VariablesGlobales.DevolverFechaRegistro());
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
                var statement = new SimpleStatement(query, 1, 1, nombre_habitacion, nivel_habitacion, nombre_nivel_habitacion, numero_camas_habitacion, tipo_cama_habitacion, max_personas_habitacion, precio_noche, numero, caracteristicas, amenidades, false,0);
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

        //public IEnumerable<UsuariosAdministradores> Get_One(int dato)
        //{
        //    string query = "SELECT campo1, campo2 FROM ejemplo WHERE campo1 = ?;";
        //    conectar();
        //    IMapper mapper = new Mapper(_session);
        //    IEnumerable<UsuariosAdministradores> users = mapper.Fetch<UsuariosAdministradores>(query, dato);

        //    desconectar();
        //    return users.ToList();
        //}

        //public List<UsuariosAdministradores> Get_All()
        //{
        //    string query = "SELECT campo1, campo2 FROM ejemplo;";
        //    conectar();

        //    IMapper mapper = new Mapper(_session);
        //    IEnumerable<UsuariosAdministradores> users = mapper.Fetch<UsuariosAdministradores>(query);

        //    desconectar();
        //    return users.ToList();

        //}

        //// Ejemplo de leer row x row
        //public void GetOne()
        //{
        //    conectar();

        //    string query ="SELECT campo1, campo2 FROM ejemplo;";

        //    // Execute a query on a connection synchronously 
        //    var rs = _session.Execute(query);

        //    // Iterate through the RowSet 
        //    foreach (var row in rs)
        //    {
        //        var value = row.GetValue<int>("campo1");
        //        // Do something with the value 
        //        var texto = row.GetValue<string>("campo2");
        //        // Do something with the value 

        //        MessageBox.Show(texto, value.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        //        /*
        //        RowSet rsUsers = session.Execute(qry);

        //        ////////////////////////////////////////////////
        //        var users = new List<UserModel>();
        //        foreach (var userRow in rsUsers)
        //        {
        //            //users.Add(ReflectionTools.GetSingleEntryDynamicFromReader<UserModel>(userRow));
        //        }

        //        foreach (UserModel user in users)
        //        {
        //            Console.WriteLine("{0} {1} {2} {3} {4}", user.Id, user.FirstName, user.LastName, user.Country, user.IsActive);
        //        }
        //        */

        //    }
        //}

    }
}
