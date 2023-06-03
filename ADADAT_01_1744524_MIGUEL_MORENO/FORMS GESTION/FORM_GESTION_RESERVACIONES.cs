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
    public partial class FORM_GESTION_RESERVACIONES : Form
    {
        public FORM_GESTION_RESERVACIONES()
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
                List<Reservacion> listaRes = EnlaceCassandra.HacerListaReservaciones();
                LB_ID_RESERVACION.DataSource = listaRes;
            }
            catch (FormatException error)
            {
                MessageBox.Show(error.Message, "ERROR");
            }
        }

        private void FORM_GESTION_RESERVACIONES_Load(object sender, EventArgs e)
        {
            try
            {
                List<Reservacion> listaRes = EnlaceCassandra.HacerListaReservaciones();
                LB_ID_RESERVACION.DataSource = listaRes;
            }
            catch (FormatException error)
            {
                MessageBox.Show(error.Message, "ERROR");
            }
        }

        private void BTN_EDITAR_Click(object sender, EventArgs e)
        {
            try
            {
                Reservacion Res = new();
                List<Reservacion> listaRes = EnlaceCassandra.HacerListaReservaciones();
                Res = listaRes.Find(Res => Res.id_reservacion.ToString() == LB_ID_RESERVACION.Text);

                HabitacionEnHotel habhot = new();
                List<HabitacionEnHotel> listaHabHot = EnlaceCassandra.HacerListaHabitacionesEnHoteles();
                habhot = listaHabHot.Find(hab => hab.id_habitacion_hotel == Res.id_habitacion_hotel);

                if (int.Parse(CB_NUMEROPERSONAS.Text) > habhot.max_personas_habitacion)
                {
                    throw new FormatException("EL NUMERO DE PERSONAS A HOSPEDAR ES MAYOR AL MAXIMO DE LA HABITACION DE LA RESERVACION!");
                }

                listaRes = listaRes.FindAll(res => res.id_habitacion_hotel == res.id_habitacion_hotel);
                if (listaRes.Count == 0)
                {
                    Res = new();
                    listaRes = EnlaceCassandra.HacerListaReservaciones();
                    Res = listaRes.Find(Res => Res.id_reservacion.ToString() == LB_ID_RESERVACION.Text);
                    int totalDias = ((Res.fecha_final).Date - (Res.fecha_inicial).Date).Days + 1;
                    double HospedajePorNoche = Res.total_hospedaje / totalDias;
                    Res.fecha_final = DTP_FECHAFINAL.Value.Date;
                    Res.fecha_final = DTP_FECHAFINAL.Value.Date;
                    Res.personas_hospedar = int.Parse(CB_NUMEROPERSONAS.Text);
                    Res.total_hospedaje = HospedajePorNoche * int.Parse(TXT_DIAS.Text);
                    EnlaceCassandra.EditarReservacion(Res.id_reservacion, Res.fecha_inicial, Res.fecha_final, Res.personas_hospedar, Res.total_hospedaje);
                }
                else
                {
                    for (int i = 0; i < listaRes.Count; i++)
                    {
                        if (listaRes[i].id_reservacion != Res.id_reservacion)
                        {
                            if ((listaRes[i].fecha_final.Date < DTP_FECHAINICIAL.Value.Date) || (listaRes[i].fecha_inicial > DTP_FECHAFINAL.Value.Date))
                            {
                            }
                            else
                            {
                                throw new FormatException("LAS FECHAS SOLICITADAS SE EMPALMAN CON LA RESERVACION: " + listaRes[i].id_reservacion + Environment.NewLine + Environment.NewLine + "CON LAS SIGUIENTES FECHAS: " + listaRes[i].fecha_inicial.Date + " - " + listaRes[i].fecha_final.Date);
                            }
                        }
                    }
                    Res = new();
                    listaRes = EnlaceCassandra.HacerListaReservaciones();
                    Res = listaRes.Find(Res => Res.id_reservacion.ToString() == LB_ID_RESERVACION.Text);
                    int totalDias = ((Res.fecha_final).Date - (Res.fecha_inicial).Date).Days + 1;
                    double HospedajePorNoche = Res.total_hospedaje / totalDias;
                    Res.fecha_final = DTP_FECHAFINAL.Value.Date;
                    Res.fecha_final = DTP_FECHAFINAL.Value.Date;
                    Res.personas_hospedar = int.Parse(CB_NUMEROPERSONAS.Text);
                    Res.total_hospedaje = HospedajePorNoche * int.Parse(TXT_DIAS.Text);
                    EnlaceCassandra.EditarReservacion(Res.id_reservacion, Res.fecha_inicial, Res.fecha_final, Res.personas_hospedar, Res.total_hospedaje);
                }
            }
            catch (FormatException error)
            {
                MessageBox.Show(error.Message, "ERROR VERIFIQUE LOS DATOS CAPTURADOS");
            }
        }

        private void DTP_FECHAINICIAL_ValueChanged(object sender, EventArgs e)
        {
            int totalDias = ((DTP_FECHAINICIAL.Value).Date - (DTP_FECHAFINAL.Value).Date).Days + 1;
            TXT_DIAS.Text = totalDias.ToString();
        }

        private void DTP_FECHAFINAL_ValueChanged(object sender, EventArgs e)
        {
            int totalDias = ((DTP_FECHAFINAL.Value).Date - (DTP_FECHAINICIAL.Value).Date).Days + 1;
            TXT_DIAS.Text = totalDias.ToString();
        }

        private void TXT_DIAS_TextChanged(object sender, EventArgs e)
        {
            Reservacion Res = new();
            List<Reservacion> listaRes = EnlaceCassandra.HacerListaReservaciones();
            Res = listaRes.Find(Res => Res.id_reservacion.ToString() == LB_ID_RESERVACION.Text);
            double HospedajeTotal = Res.total_hospedaje;
            int totalDias = ((Res.fecha_final).Date - (Res.fecha_inicial).Date).Days + 1;

            double HospedajePorNoche = HospedajeTotal / totalDias;
            TXT_PRECIONOCHE.Text = (HospedajePorNoche * int.Parse(TXT_DIAS.Text)).ToString();
        }

        private void LB_ID_RESERVACION_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Reservacion Res = new();
                List<Reservacion> listaRes = EnlaceCassandra.HacerListaReservaciones();
                Res = listaRes.Find(Res => Res.id_reservacion.ToString() == LB_ID_RESERVACION.Text);
                int totalDias = ((Res.fecha_final).Date - (Res.fecha_inicial).Date).Days + 1;
                double HospedajePorNoche = Res.total_hospedaje / totalDias;
                DTP_FECHAINICIAL.Value = Res.fecha_inicial.Date;
                DTP_FECHAFINAL.Value = Res.fecha_final.Date;
                CB_NUMEROPERSONAS.Text = Res.personas_hospedar.ToString();
                TXT_PRECIONOCHE.Text = Res.total_hospedaje.ToString();
                Res.total_hospedaje = HospedajePorNoche * int.Parse(TXT_DIAS.Text);
            }
            catch (FormatException error)
            {
                MessageBox.Show(error.Message, "ERROR");
            }
        }
    }
}
