using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PROYECTO_ADADAT.CSharp_MainCode;


namespace PROYECTO_ADADAT
{
    public partial class FORM_REGISTRO_HABITACIONESenHOTELES : Form
    {
        public FORM_REGISTRO_HABITACIONESenHOTELES()
        {
            InitializeComponent();
        }

        private void BTN_SALIR_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BTN_REGRESAR_Click(object sender, EventArgs e)
        {
            VariablesGlobales.FormRegistoHoteles.Show();
            this.Hide();
        }

        private void BTN_GUARDAR_Click(object sender, EventArgs e)
        {
            try
            {
                HabitacionEnHotel habhot = new();
                Habitacion hab = new();
                Hotel hot = new();
                List<HabitacionEnHotel> listaHabHot = EnlaceCassandra.HacerListaHabitacionesEnHoteles();
                List<Habitacion> listaHab = EnlaceCassandra.HacerListaHabitaciones();
                List<Hotel> listaHot = EnlaceCassandra.HacerListaHoteles();
                hab = listaHab.Find(hab => hab.nombre == LB_HABITACIONES.Text);
                hot = listaHot.Find(hot => hot.nombre == LB_HOTELES.Text);
                habhot.nombre_habitacion = hab.nombre;
                habhot.nivel_habitacion = hab.nivel;
                habhot.nombre_nivel_habitacion = hab.nombre_nivel;
                habhot.numero_camas_habitacion = hab.numero_camas;
                habhot.tipo_cama_habitacion = hab.tipo_cama;
                habhot.max_personas_habitacion = hab.max_personas;
                habhot.precio_noche = double.Parse(TXT_PRECIO.Text);
                string HabitacionHotel = TXT_NUMERO.Text + ((LB_HOTELES.SelectedIndex + 1).ToString());
                habhot.numero = int.Parse(HabitacionHotel) ;
                habhot.caracteristicas = TXT_CARACTERISTICAS.Text;
                habhot.amenidades = TXT_AMENIDADES.Text;
                habhot.id_habitacion_hotel = Guid.NewGuid();
                hot.habitaciones_en_hotel.Add(habhot.id_habitacion_hotel);
                if (listaHabHot.Count > 0)
                {
                    HabitacionEnHotel habhot1 = new();
                    List<HabitacionEnHotel> listaHabHot1 = EnlaceCassandra.HacerListaHabitacionesEnHoteles();
                    habhot1 = listaHabHot1.Find(habhot1 => habhot1.numero == int.Parse(TXT_NUMERO.Text));
                    if (habhot1 != null)
                        throw new FormatException("YA HAY UNA HABITACION REGISTRADA CON ESE NUMERO DE HABITACION!");
                }
                EnlaceCassandra.RegistrarHabitacionEnHotel(habhot.id_habitacion_hotel, habhot.nombre_habitacion, habhot.nivel_habitacion, habhot.nombre_nivel_habitacion, habhot.numero_camas_habitacion, habhot.tipo_cama_habitacion, habhot.max_personas_habitacion, habhot.precio_noche, habhot.numero, habhot.caracteristicas, habhot.amenidades,hot.nombre,hot.habitaciones_en_hotel);
            }
            catch (FormatException error)
            {
                MessageBox.Show(error.Message, "ERROR VERIFIQUE LOS DATOS CAPTURADOS");
            }
        }

        private void BTN_EDITAR_Click(object sender, EventArgs e)
        {

        }

        private void BTN_ELIMINAR_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Habitacion hab = new();
            List<Habitacion> listaHab = EnlaceCassandra.HacerListaHabitaciones();
            hab = listaHab.Find(hab => hab.nombre == LB_HABITACIONES.Text);
            string infoHab = "Nivel Habitacion: " + hab.nombre_nivel + Environment.NewLine +"Numero Camas: " + hab.numero_camas + Environment.NewLine + "Tipo Camas: " + hab.tipo_cama + Environment.NewLine  + "Maximo de Personas: " + hab.max_personas;
            TXT_DATOS.Text = infoHab;
        }

        private void FORM_REGISTRO_HABITACIONESenHOTELES_Load(object sender, EventArgs e)
        {
            List<Habitacion> listaHab = EnlaceCassandra.HacerListaHabitaciones();
            LB_HABITACIONES.DataSource = listaHab;
            List<Hotel> listaHot = EnlaceCassandra.HacerListaHoteles();
            LB_HOTELES.DataSource = listaHot;
        }

        private void BTN_ACTUALIZAR_Click(object sender, EventArgs e)
        {
            List<Habitacion> listaHab = EnlaceCassandra.HacerListaHabitaciones();
            LB_HABITACIONES.DataSource = listaHab;
            List<Hotel> listaHot = EnlaceCassandra.HacerListaHoteles();
            LB_HOTELES.DataSource = listaHot;
        }

        private void LB_HOTELES_SelectedIndexChanged(object sender, EventArgs e)
        {
            Hotel hot = new();
            List<Hotel> listaHot = EnlaceCassandra.HacerListaHoteles();
            hot = listaHot.Find(hot => hot.nombre == LB_HOTELES.Text);
            string infoHot = "Fecha Inicio: " + hot.fecha_inicio + Environment.NewLine + "Ciudad: " + hot.ciudad + Environment.NewLine + "Estado: " + hot.estado + Environment.NewLine + "Pais: " + hot.pais 
             + Environment.NewLine + "Domicilio: " + hot.domicilio + Environment.NewLine + "No. Pisos: " + hot.numero_pisos + Environment.NewLine + "Zona Turistica: " + hot.zona_turistica
             + Environment.NewLine + "Servicios Adicionales: " + hot.servicios_adicionales + Environment.NewLine + "Caracteristicas: " + hot.caracteristicas;
            TXT_DATOS2.Text = infoHot;
        }
    }
}
