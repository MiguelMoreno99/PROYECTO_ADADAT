using PROYECTO_ADADAT.CSharp_MainCode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_ADADAT
{
    public partial class FORM_REPORTE_CLIENTE : Form
    {
        public FORM_REPORTE_CLIENTE()
        {
            InitializeComponent();
        }

        private void BTN_REGRESAR_Click(object sender, EventArgs e)
        {
            VariablesGlobales.FormMenuAdmin.Show();
            this.Hide();
        }

        private void BTN_SALIR_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FORM_REPORTE_CLIENTE_Load(object sender, EventArgs e)
        {

        }

        private void BTN_ACTUALIZAR_Click(object sender, EventArgs e)
        {
            try
            {
                List<Reservacion> ListaReservaciones = EnlaceCassandra.HacerListaReservaciones();
                if (ListaReservaciones.Count == 0)
                {
                    throw new FormatException("PARA VER EL REPORTE DEBE DE HABER POR LO MENOS 1 RESERVACION CREADA");
                }
                List<Cliente> ListaClientes = EnlaceCassandra.HacerListaClientes();
                List<Hotel> ListaHoteles = EnlaceCassandra.HacerListaHoteles();
                List<HabitacionEnHotel> ListaHabitacionesEnHoteles = EnlaceCassandra.HacerListaHabitacionesEnHoteles();
                LV_HISTORIALCLIENTE.Items.Clear();
                for (int c = 0; c < ListaClientes.Count; c++)
                {
                    for (int r = 0; r < ListaClientes[c].id_reservacion.Count; r++)
                    {
                        Cliente Cliente1 = ListaClientes[c];
                        Reservacion Reservacion1 = new();
                        Hotel Hotel1 = new();
                        HabitacionEnHotel habitacionEnHotel1 = new();
                        Guid guid = Cliente1.id_reservacion[r];
                        Reservacion1 = ListaReservaciones.Find(Reservacion1 => Reservacion1.id_reservacion == guid);
                        if (Reservacion1 == null)
                        {
                            continue;
                        }
                        Hotel1 = ListaHoteles.Find(Hotel1 => Hotel1.id_hotel == Reservacion1.id_hotel);
                        habitacionEnHotel1 = ListaHabitacionesEnHoteles.Find(habitacionEnHotel1 => habitacionEnHotel1.id_habitacion_hotel == Reservacion1.id_habitacion_hotel);
                        string[] datosCliente =
                        {
                            (Cliente1.rfc),
                            ("2023"),
                            (Cliente1.nombre + " " + Cliente1.apellido_paterno + " " + Cliente1.apellido_materno),
                            (Hotel1.ciudad),
                            (Hotel1.nombre),
                            (habitacionEnHotel1.nombre_habitacion),
                            (Convert.ToString(habitacionEnHotel1.numero)),
                            (Convert.ToString(Reservacion1.personas_hospedar)),
                            (Convert.ToString(guid)),
                            (Convert.ToString(Reservacion1.fecha_inicial)),
                            (Convert.ToString(Reservacion1.fecha_inicial)),
                            (Convert.ToString(Reservacion1.fecha_final)),
                            (Convert.ToString(Reservacion1.reservacion_activa)),
                            (Convert.ToString(Reservacion1.anticipo)),
                            (Convert.ToString(Reservacion1.total_hospedaje)),
                            (Convert.ToString(Reservacion1.total_servicios)),
                            (Convert.ToString(Reservacion1.total_pagar)),
                        };
                        ListViewItem HistoriaCliente = new ListViewItem(datosCliente);
                        LV_HISTORIALCLIENTE.Items.Add(HistoriaCliente);
                    }
                }
            }
            catch (FormatException error)
            {
                MessageBox.Show(error.Message, "ERROR");
            }
        }

        private void BTN_FILTRORFC_Click(object sender, EventArgs e)
        {
            try
            {
                if (TXT_FILTRORFC.Text != "")
                {
                    List<Reservacion> ListaReservaciones = EnlaceCassandra.HacerListaReservaciones();
                    if (ListaReservaciones.Count == 0)
                    {
                        throw new FormatException("PARA VER EL REPORTE DEBE DE HABER POR LO MENOS 1 RESERVACION CREADA");
                    }
                    Cliente Cliente1 = new();
                    List<Cliente> ListaClientes = EnlaceCassandra.HacerListaClientes();
                    ListaClientes = ListaClientes.FindAll(Cliente1 => Cliente1.rfc == TXT_FILTRORFC.Text);
                    if (ListaClientes.Count == 0)
                    {
                        throw new FormatException("NO HAY NINGUN CLIENTE CON ESE RFC");
                    }
                    List<Hotel> ListaHoteles = EnlaceCassandra.HacerListaHoteles();
                    List<HabitacionEnHotel> ListaHabitacionesEnHoteles = EnlaceCassandra.HacerListaHabitacionesEnHoteles();
                    LV_HISTORIALCLIENTE.Items.Clear();
                    for (int c = 0; c < ListaClientes.Count; c++)
                    {
                        for (int r = 0; r < ListaClientes[c].id_reservacion.Count; r++)
                        {
                            Cliente1 = ListaClientes[c];
                            Reservacion Reservacion1 = new();
                            Hotel Hotel1 = new();
                            HabitacionEnHotel habitacionEnHotel1 = new();
                            Guid guid = Cliente1.id_reservacion[r];
                            Reservacion1 = ListaReservaciones.Find(Reservacion1 => Reservacion1.id_reservacion == guid);
                            if (Reservacion1 == null)
                            {
                                continue;
                            }
                            Hotel1 = ListaHoteles.Find(Hotel1 => Hotel1.id_hotel == Reservacion1.id_hotel);
                            habitacionEnHotel1 = ListaHabitacionesEnHoteles.Find(habitacionEnHotel1 => habitacionEnHotel1.id_habitacion_hotel == Reservacion1.id_habitacion_hotel);
                            string[] datosCliente =
                            {
                            (Cliente1.rfc),
                            ("2023"),
                            (Cliente1.nombre + " " + Cliente1.apellido_paterno + " " + Cliente1.apellido_materno),
                            (Hotel1.ciudad),
                            (Hotel1.nombre),
                            (habitacionEnHotel1.nombre_habitacion),
                            (Convert.ToString(habitacionEnHotel1.numero)),
                            (Convert.ToString(Reservacion1.personas_hospedar)),
                            (Convert.ToString(guid)),
                            (Convert.ToString(Reservacion1.fecha_inicial)),
                            (Convert.ToString(Reservacion1.fecha_inicial)),
                            (Convert.ToString(Reservacion1.fecha_final)),
                            (Convert.ToString(Reservacion1.reservacion_activa)),
                            (Convert.ToString(Reservacion1.anticipo)),
                            (Convert.ToString(Reservacion1.total_hospedaje)),
                            (Convert.ToString(Reservacion1.total_servicios)),
                            (Convert.ToString(Reservacion1.total_pagar)),
                        };
                            ListViewItem HistoriaCliente = new ListViewItem(datosCliente);
                            LV_HISTORIALCLIENTE.Items.Add(HistoriaCliente);
                        }
                    }
                }
                else
                {
                    throw new FormatException("PRIMERO INGRESE UN RFC!");
                }
            }
            catch (FormatException error)
            {
                MessageBox.Show(error.Message, "ERROR");
            }
        }

        private void BTN_FILTROANO_Click(object sender, EventArgs e)
        {

        }
    }
}
