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
    public partial class FORM_GESTION_HABITACIONES : Form
    {
        public FORM_GESTION_HABITACIONES()
        {
            InitializeComponent();
        }

        private void FORM_GESTION_HABITACIONES_Load(object sender, EventArgs e)
        {
            try
            {
                List<Habitacion> listaHab = EnlaceCassandra.HacerListaHabitaciones();
                LB_NOMBRE_HABITACION.DataSource = listaHab;
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

        private void BTN_EDITAR_Click(object sender, EventArgs e)
        {
            try
            {
                Habitacion Hab = new();
                List<Habitacion> listaHab = EnlaceCassandra.HacerListaHabitaciones();
                Hab = listaHab.Find(Hab => Hab.nombre == LB_NOMBRE_HABITACION.Text);
                Hab.nombre_nivel = CB_NIVEL.Text;
                Hab.nivel = CB_NIVEL.SelectedIndex + 1;
                Hab.tipo_cama = TXT_TIPOCAMAS.Text;
                Hab.numero_camas = int.Parse(CB_NUMEROCAMAS.Text);
                Hab.max_personas = int.Parse(CB_PERSONAS.Text);
                EnlaceCassandra.EditarHabitacion(Hab.nombre, Hab.nivel, Hab.nombre_nivel, Hab.numero_camas, Hab.tipo_cama, Hab.max_personas);
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
                EnlaceCassandra.EliminarHabitacion(LB_NOMBRE_HABITACION.Text);
                List<Habitacion> listahab = EnlaceCassandra.HacerListaHabitaciones();
                LB_NOMBRE_HABITACION.DataSource = listahab;
            }
            catch (FormatException error)
            {
                MessageBox.Show(error.Message, "ERROR");
            }
        }

        private void BTN_ACTUALIZAR_Click(object sender, EventArgs e)
        {
            try
            {
                List<Habitacion> listaHab = EnlaceCassandra.HacerListaHabitaciones();
                LB_NOMBRE_HABITACION.DataSource = listaHab;
            }
            catch (FormatException error)
            {
                MessageBox.Show(error.Message, "ERROR");
            }
        }

        private void LB_NOMBRE_HABITACION_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Habitacion Hab= new();
                List<Habitacion> listaHab = EnlaceCassandra.HacerListaHabitaciones();
                Hab = listaHab.Find(Hab => Hab.nombre == LB_NOMBRE_HABITACION.Text);
                CB_NIVEL.Text = Hab.nombre_nivel;
                TXT_TIPOCAMAS.Text = Hab.tipo_cama;
                CB_NUMEROCAMAS.Text = Hab.numero_camas.ToString();
                CB_PERSONAS.Text = Hab.max_personas.ToString();
            }
            catch (FormatException error)
            {
                MessageBox.Show(error.Message, "ERROR");
            }
        }
    }
}
