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
    public partial class FORM_REPORTE_VENTAS : Form
    {
        public FORM_REPORTE_VENTAS()
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

        private void BTN_ACTUALIZAR_Click(object sender, EventArgs e)
        {
            try
            {
                List<Reservacion> ListaReservaciones = EnlaceCassandra.HacerListaReservaciones();
                if (ListaReservaciones.Count == 0)
                {
                    throw new FormatException("PARA VER EL REPORTE DEBE DE HABER POR LO MENOS 1 RESERVACION CREADA Y ACTIVA!");
                }
                List<Hotel> ListaHoteles = EnlaceCassandra.HacerListaHoteles();
                List<HabitacionEnHotel> ListaHabitacionesEnHoteles = EnlaceCassandra.HacerListaHabitacionesEnHoteles();
                LV_VENTAS.Items.Clear();
                for (int c = 0; c < ListaHoteles.Count; c++)
                {
                    decimal IngresosHospedaje = 0;
                    decimal IngresosSerAdic = 0;
                    decimal IngresosTotales = 0;
                    Hotel hotel1 = ListaHoteles[c];
                    foreach (Reservacion reservacion in ListaReservaciones)
                    {
                        if ((reservacion.id_hotel == ListaHoteles[c].id_hotel) && reservacion.checkout)
                        {
                            IngresosHospedaje += ((decimal)(reservacion.total_hospedaje));
                            IngresosSerAdic += ((decimal)(reservacion.total_servicios));
                            IngresosTotales += ((decimal)(reservacion.total_pagar));
                        }
                    }
                    if (IngresosTotales > 0)
                    {
                        string[] datosReporteVentas =
                       {
                            (ListaHoteles[c].pais),
                            ("2023"),
                            (ListaHoteles[c].ciudad),
                            (ListaHoteles[c].nombre),
                            ((ListaHoteles[c].fecha_inicio.ToString()).Substring(3,7)),
                            (IngresosHospedaje.ToString() + " $"),
                            (IngresosSerAdic.ToString() + " $"),
                            (IngresosTotales.ToString() + " $"),
                        };
                        ListViewItem DatosReporte = new(datosReporteVentas);
                        LV_VENTAS.Items.Add(DatosReporte);
                    }
                }
                if (LV_VENTAS.Items.Count==0)
                {
                    throw new FormatException("NINGUNA DE LAS RESERVACIONES SE LE HA HECHO CHECKOUT, NO HAY NADA QUE MOSTRAR!");
                }
            }

            catch (FormatException error)
            {
                MessageBox.Show(error.Message, "ERROR");
            }
        }
    }
}
