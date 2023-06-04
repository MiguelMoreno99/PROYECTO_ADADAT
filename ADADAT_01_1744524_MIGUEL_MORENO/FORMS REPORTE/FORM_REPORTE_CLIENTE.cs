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
                        Hotel1 = ListaHoteles.Find(Hotel1=> Hotel1.id_hotel == Reservacion1.id_hotel);
                        habitacionEnHotel1 = ListaHabitacionesEnHoteles.Find(habitacionEnHotel1 => habitacionEnHotel1.id_habitacion_hotel == Reservacion1.id_habitacion_hotel);
                        ListViewItem HistoriaCliente = new();
                        HistoriaCliente.SubItems.Add(Cliente1.rfc);
                        HistoriaCliente.SubItems.Add("2023");
                        HistoriaCliente.SubItems.Add(Cliente1.nombre + Cliente1.apellido_paterno + Cliente1.apellido_materno);
                        HistoriaCliente.SubItems.Add(Hotel1.ciudad);
                        HistoriaCliente.SubItems.Add(Hotel1.nombre);
                        HistoriaCliente.SubItems.Add(habitacionEnHotel1.nombre_habitacion);
                        HistoriaCliente.SubItems.Add(Convert.ToString(habitacionEnHotel1.numero));
                        HistoriaCliente.SubItems.Add(Convert.ToString(habitacionEnHotel1.personas_hospedadas));
                        HistoriaCliente.SubItems.Add(Convert.ToString(guid));
                        HistoriaCliente.SubItems.Add(Convert.ToString(Reservacion1.fecha_inicial));
                        HistoriaCliente.SubItems.Add(Convert.ToString(Reservacion1.fecha_inicial));
                        HistoriaCliente.SubItems.Add(Convert.ToString(Reservacion1.fecha_final));
                        HistoriaCliente.SubItems.Add(Convert.ToString(Reservacion1.reservacion_activa));
                        HistoriaCliente.SubItems.Add(Convert.ToString(Reservacion1.anticipo));
                        HistoriaCliente.SubItems.Add(Convert.ToString(Reservacion1.total_hospedaje));
                        HistoriaCliente.SubItems.Add(Convert.ToString(Reservacion1.total_servicios));
                        HistoriaCliente.SubItems.Add(Convert.ToString(Reservacion1.total_pagar));
                        LV_HISTORIALCLIENTE.Items.Add(HistoriaCliente);
                    }
                }
            }
            catch (FormatException error)
            {
                MessageBox.Show(error.Message, "ERROR");
            }
        }
    }
}
