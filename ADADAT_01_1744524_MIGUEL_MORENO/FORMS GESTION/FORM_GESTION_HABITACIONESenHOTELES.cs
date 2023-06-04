using PROYECTO_ADADAT.CSharp_MainCode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_ADADAT
{
    public partial class FORM_GESTION_HABITACIONESenHOTELES : Form
    {
        public FORM_GESTION_HABITACIONESenHOTELES()
        {
            InitializeComponent();
        }

        private void FORM_GESTION_HABITACIONESenHOTELES_Load(object sender, EventArgs e)
        {
            try
            {
                List<Hotel> listaHot = EnlaceCassandra.HacerListaHoteles();
                LB_HOTELES.DataSource = listaHot;
            }
            catch (FormatException error)
            {
                MessageBox.Show(error.Message, "ERROR");
            }
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
                List<Hotel> listaHot = EnlaceCassandra.HacerListaHoteles();
                LB_HOTELES.DataSource = listaHot;
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
                HabitacionEnHotel HabHot = new();
                List<HabitacionEnHotel> listaHabHot = EnlaceCassandra.HacerListaHabitacionesEnHoteles();
                HabHot = listaHabHot.Find(HabHot => HabHot.id_habitacion_hotel == Guid.Parse(LB_HABITACIONES.Text));
                HabHot.caracteristicas = TXT_CARACTERISTICAS.Text;
                HabHot.amenidades = TXT_AMENIDADES.Text;
                HabHot.precio_noche = double.Parse(TXT_PRECIO.Text);
                EnlaceCassandra.EditarHabitacionEnHotel(HabHot.id_habitacion_hotel, HabHot.precio_noche, HabHot.caracteristicas, HabHot.amenidades);
            }
            catch (FormatException error)
            {
                MessageBox.Show(error.Message, "VERIFIQUE LOS DATOS INGRESADOS");
            }
        }

        private void BTN_ELIMINAR_Click(object sender, EventArgs e)
        {
            try
            {
                HabitacionEnHotel HabHot = new();
                List<HabitacionEnHotel> listaHabHot = EnlaceCassandra.HacerListaHabitacionesEnHoteles();
                HabHot = listaHabHot.Find(HabHot => HabHot.id_habitacion_hotel == Guid.Parse(LB_HABITACIONES.Text));
                EnlaceCassandra.EliminarHabitacionEnHotel(HabHot.id_habitacion_hotel);
                List<Hotel> listaHot = EnlaceCassandra.HacerListaHoteles();
                LB_HOTELES.DataSource = listaHot;
            }
            catch (FormatException error)
            {
                MessageBox.Show(error.Message, "ERROR");
            }
        }

        private void LB_HOTELES_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                TXT_CARACTERISTICAS.Text = "";
                TXT_AMENIDADES.Text = "";
                TXT_PRECIO.Text = "";
                Hotel hot = new();
                List<Hotel> listaHot = EnlaceCassandra.HacerListaHoteles();
                hot = listaHot.Find(hot => hot.nombre == LB_HOTELES.Text);

                List<HabitacionEnHotel> listaHabHot = EnlaceCassandra.HacerListaHabitacionesEnHoteles();
                List<Guid> listaHabitacionesdelHotel = new();
                for (int i = 0; i < hot.habitaciones_en_hotel.Count; i++)
                {
                    HabitacionEnHotel HabHot = new();
                    HabHot = listaHabHot.Find(HabHot => HabHot.id_habitacion_hotel == hot.habitaciones_en_hotel[i]);
                    if (HabHot != null)
                    {
                        listaHabitacionesdelHotel.Add(HabHot.id_habitacion_hotel);
                    }
                }
                LB_HABITACIONES.DataSource = listaHabitacionesdelHotel;
            }
            catch (FormatException error)
            {
                MessageBox.Show(error.Message, "ERROR");
            }
        }

        private void LB_HABITACIONES_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                HabitacionEnHotel HabHot = new();
                List<HabitacionEnHotel> listaHabHot = EnlaceCassandra.HacerListaHabitacionesEnHoteles();
                HabHot = listaHabHot.Find(HabHot => HabHot.id_habitacion_hotel == Guid.Parse(LB_HABITACIONES.Text));
                if (HabHot!= null)
                {
                    TXT_CARACTERISTICAS.Text = HabHot.caracteristicas;
                    TXT_AMENIDADES.Text = HabHot.amenidades;
                    TXT_PRECIO.Text = HabHot.precio_noche.ToString();
                }
            }
            catch (FormatException error)
            {
                MessageBox.Show(error.Message, "ERROR");
            }
        }
    }
}
