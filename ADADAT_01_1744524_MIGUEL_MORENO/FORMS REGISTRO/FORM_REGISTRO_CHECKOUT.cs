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
    public partial class FORM_REGISTRO_CHECKOUT : Form
    {
        public FORM_REGISTRO_CHECKOUT()
        {
            InitializeComponent();
        }

        private void BTN_REGRESAR_Click(object sender, EventArgs e)
        {
            VariablesGlobales.FormMenuOper.Show();
            this.Hide();
        }

        private void BTN_SALIR_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FORM_REGISTRO_CHECKOUT_Load(object sender, EventArgs e)
        {

        }

        private void BTN_GUARDAR_Click(object sender, EventArgs e)
        {
            try
            {
                if (TXT_RESERVACION.Text == "")
                {
                    throw new FormatException("INGRESE ALGUNA RESERVACION!");
                }
                Guid reservacion = Guid.Parse(TXT_RESERVACION.Text);
                List<Reservacion> listaRes = EnlaceCassandra.HacerListaReservaciones();
                if (listaRes.Count > 0)
                {
                    Reservacion res = new();
                    res = listaRes.Find(res => res.id_reservacion == reservacion);
                    if (res != null)
                    {
                        if (!res.reservacion_activa)
                        {
                            throw new FormatException("ESTA RESERVACION ESTA CANCELADA!");
                        }
                        if (!res.checkin)
                        {
                            throw new FormatException("ESTA RESERVACION NO SE LE HA HECHO EL CHECK IN!");
                        }
                        if (res.checkout)
                        {
                            throw new FormatException("ESTA RESERVACION YA SE LE HIZO EL CHECK OUT!");
                        }
                        else
                        {
                            if ((DTP_FECHACHECKOUT.Value.Date < res.fecha_inicial.Date) || (DTP_FECHACHECKOUT.Value.Date > res.fecha_final.Date))
                            {
                                throw new FormatException("LA FECHA INGRESADA NO ESTA DENTRO DE LAS FECHAS DE LA RESERVACION!" + Environment.NewLine + Environment.NewLine + "LAS FECHAS DE LA RESERVACION SON:" + res.fecha_inicial + " - " + res.fecha_final);
                            }
                            else
                            {
                                HabitacionEnHotel habhot = new();
                                List<HabitacionEnHotel> listaHabHot = EnlaceCassandra.HacerListaHabitacionesEnHoteles();
                                habhot = listaHabHot.Find(habhot => habhot.id_habitacion_hotel == res.id_habitacion_hotel);
                                EnlaceCassandra.CheckOut(res.id_reservacion, habhot.id_habitacion_hotel, DTP_FECHACHECKOUT.Value.Date);
                                VariablesGlobales.FormRegistroPagoReservacion.Show();
                                VariablesGlobales.IDReservacionCheckOut = Guid.Parse(TXT_RESERVACION.Text);
                                this.Hide();
                                TXT_RESERVACION.Text = "";
                            }
                        }
                    }
                    else
                    {
                        throw new FormatException("NO HAY NINGUNA RESERVACION ACTIVA CON ESE ID!");
                    }
                }
                else
                {
                    throw new FormatException("NO HAY NINGUNA RESERVACION CREADA!");
                }
            }
            catch (FormatException error)
            {
                MessageBox.Show(error.Message, "ERROR");
            }
        }
    }
}
