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
    public partial class FORM_REGISTRO_PAGORESERVACION : Form
    {
        public FORM_REGISTRO_PAGORESERVACION()
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

        private void button1_Click(object sender, EventArgs e)
        {
            VariablesGlobales.FormRegistoReservaciones.Show();
            this.Hide();
        }

        private void BTN_GUARDAR_Click(object sender, EventArgs e)
        {
            try
            {
                if (TXT_SERVICIOSADICIONALES.Text != "" && TXT_SERVICIOSUTILIZADOS.Text != "" && CB_NUMEROSERVICIOSUTILIZADOS.Text != "" && CB_DESCUENTO.Text != "")
                {
                    Reservacion res = new();
                    List<Reservacion> listaRes = EnlaceCassandra.HacerListaReservaciones();
                    listaRes = listaRes.FindAll(res => res.id_reservacion == VariablesGlobales.IDReservacionCheckOut);
                    int descuento = Convert.ToInt16(decimal.Parse(TXT_DESCUENTODADO.Text));
                    res.id_reservacion = VariablesGlobales.IDReservacionCheckOut;
                    res.descuento = descuento;
                    res.numero_servicios = int.Parse(CB_NUMEROSERVICIOSUTILIZADOS.Text);
                    res.servicios_utilizados = TXT_SERVICIOSUTILIZADOS.Text;
                    res.total_servicios = double.Parse(TXT_COSTOSERVICIOSADICIONALES.Text);
                    res.total_pagar = double.Parse(TXT_TOTALPAGAR.Text);
                    EnlaceCassandra.CheckOutFactura(res.id_reservacion, res.servicios_utilizados, res.numero_servicios, res.descuento, res.total_servicios, res.total_pagar);
                    BTN_EXTENDERESTANCIA.Enabled = true;
                    TXT_ANTICIPO.Text = "0";
                    TXT_COSTOHOTEL.Text = "0";
                    TXT_COSTOSERVICIOSADICIONALES.Text = "0";
                    TXT_DESCUENTODADO.Text = "0";
                    TXT_SERVICIOSADICIONALES.Text = "";
                    TXT_SERVICIOSUTILIZADOS.Text = "";
                    TXT_TOTALPAGAR.Text = "0";
                }
                else
                {
                    throw new FormatException("PRIMERO INGRESE TODA LA INFORMACION CORRECTAMENTE PARA CREAR HACER EL COBRO!");
                }
            }
            catch (FormatException error)
            {
                MessageBox.Show(error.Message, "ERROR VERIFIQUE LOS DATOS CAPTURADOS");
            }
        }

        private void FORM_REGISTRO_PAGORESERVACION_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                List<Reservacion> listaRes = EnlaceCassandra.HacerListaReservaciones();
                Reservacion Res = new();
                Res = listaRes.Find(Res => Res.id_reservacion == VariablesGlobales.IDReservacionCheckOut);
                HabitacionEnHotel habhot = new();
                List<HabitacionEnHotel> listaHabHot = EnlaceCassandra.HacerListaHabitacionesEnHoteles();
                habhot = listaHabHot.Find(hab => hab.id_habitacion_hotel == Res.id_habitacion_hotel);
                TXT_SERVICIOSADICIONALES.Text = habhot.amenidades;
                TXT_COSTOHOTEL.Text = Res.total_hospedaje.ToString();
                TXT_ANTICIPO.Text = Res.anticipo.ToString();
            }
            catch (FormatException error)
            {
                MessageBox.Show(error.Message, "ERROR");
            }
        }

        private void CB_NUMEROSERVICIOSUTILIZADOS_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                TXT_COSTOSERVICIOSADICIONALES.Text = (350 * int.Parse(CB_NUMEROSERVICIOSUTILIZADOS.Text)).ToString();
            }
            catch (FormatException error)
            {
                MessageBox.Show(error.Message, "ERROR");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                decimal suma = (decimal.Parse(TXT_COSTOHOTEL.Text)) + (decimal.Parse(TXT_COSTOSERVICIOSADICIONALES.Text));
                decimal porciento = int.Parse(CB_DESCUENTO.Text);
                decimal descuento = (porciento / 100);
                decimal totaldescuento = suma* descuento;
                TXT_DESCUENTODADO.Text = totaldescuento.ToString();
            }
            catch (FormatException error)
            {
                MessageBox.Show(error.Message, "ERROR");
            }
        }

        private void TXT_COSTOHOTEL_TextChanged(object sender, EventArgs e)
        {
            TXT_TOTALPAGAR.Text = (double.Parse(TXT_COSTOHOTEL.Text) + double.Parse(TXT_COSTOSERVICIOSADICIONALES.Text) - double.Parse(TXT_ANTICIPO.Text) - double.Parse(TXT_DESCUENTODADO.Text)).ToString();
        }

        private void TXT_COSTOSERVICIOSADICIONALES_TextChanged(object sender, EventArgs e)
        {
            TXT_TOTALPAGAR.Text = (double.Parse(TXT_COSTOHOTEL.Text) + double.Parse(TXT_COSTOSERVICIOSADICIONALES.Text) - double.Parse(TXT_ANTICIPO.Text) - double.Parse(TXT_DESCUENTODADO.Text)).ToString();
        }

        private void TXT_ANTICIPO_TextChanged(object sender, EventArgs e)
        {
            TXT_TOTALPAGAR.Text = (double.Parse(TXT_COSTOHOTEL.Text) + double.Parse(TXT_COSTOSERVICIOSADICIONALES.Text) - double.Parse(TXT_ANTICIPO.Text) - double.Parse(TXT_DESCUENTODADO.Text)).ToString();
        }

        private void TXT_DESCUENTODADO_TextChanged(object sender, EventArgs e)
        {
            TXT_TOTALPAGAR.Text = (double.Parse(TXT_COSTOHOTEL.Text) + double.Parse(TXT_COSTOSERVICIOSADICIONALES.Text) - double.Parse(TXT_ANTICIPO.Text) - double.Parse(TXT_DESCUENTODADO.Text)).ToString();
        }
    }
}
